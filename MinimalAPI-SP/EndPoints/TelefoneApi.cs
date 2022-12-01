namespace MinimalAPI_SP.EndPoints;

public static class TelefoneApi
{

    public static void ConfigureTelefoneApi(this WebApplication app)
    {
        app.MapGet("v1/Telefone", GetAll);
        app.MapGet("v1/Telefone/{id}", Get);
        app.MapPost("v1/Telefone", InsertTelefone);
        app.MapPut("v1/Telefone", UpdateTelefone);
        app.MapDelete("v1/Telefone", DeleteTelefone);
    }

    private static async Task<IResult> GetAll(ITelefoneData data)
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

    private static async Task<IResult> Get(int id, ITelefoneData data)
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

    private static async Task<IResult> InsertTelefone(Telefone telefone, ITelefoneData data)
    {
        try
        {
            await data.InsertTelefone(telefone);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateTelefone(Telefone telefone, ITelefoneData data)
    {
        try
        {
            await data.UpdateTelefone(telefone);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteTelefone(int numero, ITelefoneData data)
    {
        try
        {
            await data.DeleteTelefone(numero);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

}


    






