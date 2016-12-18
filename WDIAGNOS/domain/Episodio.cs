using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDIAGNOS.domain
{
    class Episodio
    {
        public int Id { get; set; }                         // pk autonumérica resumen: paciente + episodio + fecha (incl. hora)

        public int ExploracionId { get; set; }              // foránea descripción exploracion (gastro, colono, etc)

        public string ReferenciaHistoria { get; set; }      // foránea id de historial del paciente
        
        public DateTime ExploracionMomento { get; set; }    // alta registro en fecha
        
        public int GestorAsumeId { get; set; }              // id. pk entidad que asume (facturación)

        public List<Doctor> DoctoresRealizan { get; set; }  // lista de dres. que realizan (incluye anestesista)

        public List<Doctor> DoctoresPrescriben { get; set; }// lista de dres. que prescriben 

    }
}
