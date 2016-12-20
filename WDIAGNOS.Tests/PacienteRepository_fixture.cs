using WDIAGNOS.domain;
using WDIAGNOS.repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;
using NHibernate;

namespace WDIAGNOS.Tests
{
    class PacienteRepository_fixture
    {
        private ISessionFactory _sessionFactory;
        private Configuration _configuration;

        [OneTimeSetUpAttribute]
        public void TestFixtureSetUp()
        {
            _configuration = new Configuration();
            _configuration.Configure();
            _configuration.AddAssembly(typeof(Paciente).Assembly);
            _sessionFactory = _configuration.BuildSessionFactory();
        }

        [Test]
        public void Can_add_new_Paciente()
        {
            var paciente = new Paciente { Nombre = "Juan Miguel", Telefono = "555454545", Apellidos = "Jiménez Salvador" };
            IPacienteRepository repository = new PacienteRepository();
            repository.Add(paciente);
        }

    }
}
