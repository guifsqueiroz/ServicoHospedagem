namespace MinimalAPI_SP.EndPoints;

public static class HospedagemAPi
{
    public static void ConfigureHospedagemApi(this WebApplication app)
    {
        app.MapGet("v1/Hospedagem", GetAll);
        app.MapPost("v1/Hospedagem", InsertHospedagem);
        app.MapPut("v1/Hospedagem", UpdateHospedagem);
        app.MapDelete("v1/Hospedagem", DeleteHospedagem);
    }

    private static async Task<IResult> GetAll(IHospedagemData data)
    {
        try
        {
            var hospedagem = await data.GetAll();
            return Results.Ok(hospedagem);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertHospedagem(Hospedagem hospedagem, IHospedagemData data)
    {
        try
        {
            await data.InsertHospedagem(hospedagem);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateHospedagem(Hospedagem hospedagem, IHospedagemData data)
    {
        try
        {
            await data.UpdateHospedagem(hospedagem);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteHospedagem(int id, bool estado, IHospedagemData data)
    {
        try
        {
            await data.DeleteHospedagem(id, estado);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}

