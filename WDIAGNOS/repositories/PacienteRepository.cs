using NHibernate;
using WDIAGNOS.domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDIAGNOS.repositories
{
    public class PacienteRepository: IPacienteRepository
    {
        public void Add(Paciente paciente)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(paciente);
                transaction.Commit();
            }
        }
        public void Update(Paciente paciente)
        {
            throw new NotImplementedException();
        }
        public void Remove(Paciente paciente)
        {
            throw new NotImplementedException();
        }
        public Paciente GetById(int pacienteId)
        {
            return new Paciente();
        }


    }
}
