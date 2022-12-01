namespace MinimalAPI_SP.EndPoints;

public static class ChaleItemApi
{
    public static void ConfigureChaleItemApi(this WebApplication app)
    {
        app.MapGet("v1/ChaleItem", GetAll);
        app.MapPost("v1/ChaleItem", InsertChaleItem);
        app.MapPut("v1/ChaleItem", UpdateChaleItem);
       // app.MapDelete("v1/ChaleItem", DeleteChaleItem);
    }

    private static async Task<IResult> GetAll(int id, IChaleItemData data)
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

    private static async Task<IResult> InsertChaleItem(ChaleItem chaleItem, IChaleItemData data)
    {
        try
        {
            await data.InsertChaleItem(chaleItem);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateChaleItem(int chaleId, int itemId, int newItemId, IChaleItemData data)
    {
        try
        {
            await data.UpdateChaleItem(chaleId, itemId, newItemId);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteChaleItem(ChaleItem chaleItem, IChaleItemData data)
    {
        try
        {
            await data.DeleteChaleItem(chaleItem);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }


}


