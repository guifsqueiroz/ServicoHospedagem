namespace MinimalAPI_SP.EndPoints;

public static class ItemApi
{

    public static void ConfigureItemApi(this WebApplication app)
    {
        app.MapGet("v1/Items", GetAll);
        app.MapGet("v1/Items/{id}", Get);
        app.MapPost("v1/Items", InsertItem);
        app.MapPut("v1/Items", UpdateItem);
        app.MapDelete("v1/Items", DeleteItem);
    }

    private static async Task<IResult> GetAll(IItemData data)
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

    private static async Task<IResult> Get(int id, IItemData data)
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

    private static async Task<IResult> InsertItem(Item item, IItemData data)
    {
        try
        {
            await data.InsertItem(item);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateItem(Item item, IItemData data)
    {
        try
        {
            await data.UpdateItem(item);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteItem(int id,IItemData data)
    {
        try
        {
            await data.DeleteItem(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

}
