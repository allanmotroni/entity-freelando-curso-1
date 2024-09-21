using Freelando.Dados;
using Microsoft.EntityFrameworkCore;

namespace Freelando.Api.Endpoints;

public static class ProfissionalExtension
{
    public static void AddEndPointProfissional(this WebApplication app)
    {
      app.MapGet("/profissional", async (FreelandoContext context) =>
      {
         return Results.Ok(await context.Profissionais.ToListAsync());
      });
    }
}
