using System.Data.Entity.Migrations;
using CursoMVCAbril.Infra.Data.Context;

namespace CursoMVCAbril.Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CursoMvcContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CursoMvcContext context)
        {
        }
    }
}