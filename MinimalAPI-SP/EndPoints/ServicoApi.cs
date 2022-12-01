namespace MinimalAPI_SP.EndPoints;

public static class ServicoApi
{

    public static void ConfigureServicoApi(this WebApplication app)
    {
        app.MapGet("v1/Servicos", GetAll);
        app.MapGet("v1/Servicos/{id}", Get);
        app.MapPost("v1/Servicos", InsertServico);
        app.MapPut("v1/Servicos", UpdateServico);
        app.MapDelete("v1/Servicos", DeleteServico);
    }

    private static async Task<IResult> GetAll(IServicoData data)
    {
        try
        {
            return Results.Ok(await data.GetAll());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> Get(int id, IServicoData data)
    {
        try
        {
            var results = await data.Get(id);
            if (results == null) return Results.NotFound();
            return Results.Ok(results);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertServico(Servico servico, IServicoData data)
    {
        try
        {
            await data.InsertServico(servico);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateServico(Servico servico, IServicoData data)
    {
        try
        {
            await data.UpdateServico(servico);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteServico(int id, IServicoData data)
    {
        try
        {
            await data.DeleteServico(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

}
