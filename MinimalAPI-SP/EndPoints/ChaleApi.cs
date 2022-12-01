namespace MinimalAPI_SP.EndPoints;

public static class ChaleApi
{
    public static void ConfigureChaleApi(this WebApplication app)
    {
        app.MapGet("v1/Chales", GetAll);
        app.MapGet("v1/Chales/{id}", Get);
        app.MapPost("v1/Chales", InsertChale);
        app.MapPut("v1/Chales", UpdateChale);
        app.MapDelete("v1/Chales", DeleteChale);
    }

    private static async Task<IResult> GetAll(IChaleData data)
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

    private static async Task<IResult> Get(int id, IChaleData data)
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

    private static async Task<IResult> InsertChale(Chale chale, IChaleData data)
    {
        try
        {
            await data.InsertChale(chale);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateChale(Chale chale, IChaleData data)
    {
        try
        {
            await data.UpdateChale(chale);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteChale(int id, IChaleData data)
    {
        try
        {
            await data.DeleteChale(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}

    



