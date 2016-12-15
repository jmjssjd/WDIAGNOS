using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDIAGNOS.domain
{
    public interface IPacienteRepository
    {
        void Add(Paciente paciente);
        void Update(Paciente paciente);
        void Remove(Paciente paciente);
        void GetById(int pacienteId);
    }
}
