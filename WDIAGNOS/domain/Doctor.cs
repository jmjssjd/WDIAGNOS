using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDIAGNOS.domain
{
    public enum tipoDr { Prescriptor = 0x01, Realizador = 0x02, Anestesista = 0x03 }

    public enum tipoTitulo{Dr = 0x01, Dra = 0x02, Dres = 0x03}

    class Doctor
    {
        public int Id { get; set; }                         // pk autonumérica resumen: paciente + episodio + fecha (incl. hora)

        public tipoDr Tipo { get; set; }                    // anestesista, prescriptor (menos datos), realizador, ...

        public string Licencia { get; set; }                // número de colegiado

        public string Nombre { get; set; }                  // nombre 

        public string Apellidos { get; set; }               // apellidos

        public tipoTitulo Titulo { get; set; }              // Dr., Dra, etc. (ojo: idiomas)

    }
    
}
