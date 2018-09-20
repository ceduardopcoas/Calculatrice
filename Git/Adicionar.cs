using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git
{
    class Adicionar
    {
        public int a { get; set; }
        public int b { get; set; }
        public Adicionar(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int calculo()
        {
            int resultado;
            return resultado = a + b;
        }

        public override string ToString()
        {
            return "Resultado: " + a + " + " + b + " = " + calculo();
        }

    }
}
