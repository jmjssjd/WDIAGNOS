using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDIAGNOS.domain
{
    public class Paciente
    {
        public virtual int Id { get; set; }
        public virtual string Apellidos { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Telefono { get; set; }
        public virtual DateTime FechaNacimiento { get; set; }
        
    }
}
