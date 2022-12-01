namespace MinimalAPI_SP.EndPoints;

public static class ClienteApi
{
    public static void ConfigureClienteApi(this WebApplication app)
    {
        app.MapGet("v1/Clientes", GetAll);
        app.MapGet("v1/Clientes/{id}", Get);
        app.MapPost("v1/Clientes", InsertCliente);
        app.MapPut("v1/Clientes", UpdateCliente);
        app.MapDelete("v1/Clientes", DeleteCliente);
    }

    private static async Task<IResult> GetAll(IClienteData data)
    {
        try
        {
            var clientes = await data.GetAll();
            return Results.Ok(clientes);
            //lista de anonimos para selecionar e exibir apenas alguns campos
            //return Results.Ok(clientes.Select(x => new
            //{
            //    x.Id,
            //    x.Nome
            //}));
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> Get(int id, IClienteData data)
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

    private static async Task<IResult> InsertCliente(Cliente cliente, IClienteData data)
    {
        try
        {
            await data.InsertCliente(cliente);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateCliente(Cliente cliente, IClienteData data)
    {
        try
        {
            await data.UpdateCliente(cliente);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteCliente(int id, IClienteData data)
    {
        try
        {
            await data.DeleteCliente(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}


