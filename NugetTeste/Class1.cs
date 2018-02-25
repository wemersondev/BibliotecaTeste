using System;

namespace NugetTeste
{
    public class Teste
    {
        private string _texto;

        public Teste(string texto)
        {
            _texto = texto;
        }

        public override string ToString()
        {
            return _texto;
        }
    }
}
