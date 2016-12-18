using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDIAGNOS.domain
{
    class Quirofano
    {
        public int Id { get; set; }                 // id auto teknon

        public string Descripcion { get; set; }     // quirofano 1 de teknon, 3 de Tres Torres, etc. (pensar en cloud)

    }
}
