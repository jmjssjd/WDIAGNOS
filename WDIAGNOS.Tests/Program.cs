using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDIAGNOS.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateSchema_Fixture prueba = new GenerateSchema_Fixture();
            prueba.Can_generate_schema();
        }
    }
}
