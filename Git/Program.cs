using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git
{
    class Program
    {
        public static List<Adicionar> Add = new List<Adicionar>();
        public static List<Multiplicar> Mult = new List<Multiplicar>();
        public static List<Diminuir> Dimi = new List<Diminuir>();
        public static List<Dividir> Divi = new List<Dividir>();


        static void Main(string[] args)
        {


            int opcao = 0;
            

            while ( opcao != 6)
            {
                Console.Clear();
                Tela.opcoes();
                opcao = int.Parse(Console.ReadLine());
                
                if(opcao == 1)
                {
                    Console.Write("Digite um numero: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Digite um numero: ");
                    int b = int.Parse(Console.ReadLine());
                    Adicionar A = new Adicionar(a, b);
                    Console.Write("Resultado: ");
                    Console.WriteLine(A.calculo().ToString("F2"));
                    Add.Add(A);

                } else if(opcao == 2)
                {
                    Console.Write("Digite um numero: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Digite um numero: ");
                    int b = int.Parse(Console.ReadLine());
                    Diminuir D = new Diminuir(a, b);
                    Console.WriteLine(D.calculo().ToString("F2"));
                    Dimi.Add(D);

                } else if (opcao == 3)
                {
                    Console.Write("Digite um numero: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Digite um numero: ");
                    int b = int.Parse(Console.ReadLine());
                    Multiplicar M = new Multiplicar(a, b);
                    Console.WriteLine(M.calculo().ToString("F2"));
                    Mult.Add(M);

                } else if (opcao == 4){

                    Console.Write("Digite um numero: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Digite um numero: ");
                    int b = int.Parse(Console.ReadLine());
                    Dividir D = new Dividir(a, b);
                    Console.WriteLine(D.calculo().ToString("F2"));
                    Divi.Add(D);

                }else if (opcao == 5)
                {
                    if (Add != null)
                    {
                        for (int i = 0; i < Add.Count; i++) {
                            Console.WriteLine(Add[i]);
                         }
                     }
                    if (Dimi != null)
                    {
                        for (int i = 0; i < Dimi.Count; i++)
                        {
                            Console.WriteLine(Dimi[i]);
                        }
                    }
                    if (Mult != null)
                    {
                        for (int i = 0; i < Mult.Count; i++)
                        {
                            Console.WriteLine(Mult[i]);
                        }
                    }
                    if (Divi != null)
                    {
                        for (int i = 0; i < Divi.Count; i++)
                        {
                            Console.WriteLine(Divi[i]);
                        }
                    }
                } else if (opcao == 6)
                {
                    Console.WriteLine("FIM");
                }



                Console.ReadLine();

            }


            //Console.ReadLine();
            
            

        }
    }
}
