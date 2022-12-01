namespace MinimalAPI_SP.EndPoints
{
    public static class HospedagemServicoApi
    {
        public static void ConfigureHospedagemServicoApi(this WebApplication app)
        {
            app.MapGet("v1/HospedagemServico", GetAll);
            app.MapPost("v1/HospedagemServico", InsertHospedagemServico);
            app.MapPut("v1/HospedagemServico", UpdateHospedagemServico);
            //app.MapDelete("v1/HospedagemServico", DeleteHospedagemServico);
        }

        private static async Task<IResult> GetAll(int id, IHospedagemServicoData data)
        {
            try
            {
                var hospedagem = await data.GetAll(id);
                return Results.Ok(hospedagem);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> InsertHospedagemServico(HospedagemServico hospedagemServico, IHospedagemServicoData data)
        {
            try
            {
                await data.InsertHospedagemServico(hospedagemServico);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> UpdateHospedagemServico(HospedagemServico hospedagemServico, IHospedagemServicoData data)
        {
            try
            {
                await data.UpdateHospedagemServico(hospedagemServico);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> DeleteHospedagemServico(HospedagemServico hospedagemServico, IHospedagemServicoData data)
        {
            try
            {
                await data.DeleteHospedagemServico(hospedagemServico);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

    }
}
