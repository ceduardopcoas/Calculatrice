﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git
{
    class Multiplicar
    {
        
        public int a { get; set; }
        public int b { get; set; }

        public Multiplicar(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int calculo()
        {

            int resultado;
            return resultado = a * b;
        }
        public override string ToString()
        {
            return "Resultado: " + a + " x " + b + " = " + calculo();
        }




    }


}
