using NugetTeste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestandoPacote
{
    public class HelloWord
    {
        public HelloWord()
        {
            var a = new Teste("Olá");
            Console.Write(a.ToString());
        }
    }
}
