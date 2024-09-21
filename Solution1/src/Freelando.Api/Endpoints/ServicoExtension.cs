using Freelando.Dados;
using Microsoft.EntityFrameworkCore;

namespace Freelando.Api.Endpoints;

public static class ServicoExtensions
{
    public static void AddEndPointServico(this WebApplication app)
    {
      app.MapGet("/servico", async (FreelandoContext context) =>
      {
         return Results.Ok(await context.Servicos.ToListAsync());
      });
    }
}
