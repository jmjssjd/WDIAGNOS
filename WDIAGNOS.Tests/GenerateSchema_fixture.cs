using WDIAGNOS.domain;

using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;

namespace WDIAGNOS.Tests
{
    [TestFixture]
    public class GenerateSchema_Fixture
    {
        [Test]
        public void Can_generate_schema()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Paciente).Assembly);

            //podría llegar a crearse la tabla en la base de datos...
            //new SchemaExport(cfg).Execute(true, true, false);
        }
    }
}