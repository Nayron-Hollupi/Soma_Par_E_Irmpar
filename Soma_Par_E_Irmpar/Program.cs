using System;

namespace Soma_Par_E_Irmpar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 0,numero, par = 0 , impar = 0;

            while (i != 1)
            {
                Console.Write("\n\tDigite um numero inteiro sendo que numeros acima de 1000 apresenta o resultado:");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero <= 1000 )
                {
                    if(numero % 2 == 0)
                    {
                        par = numero + par;
                    }
                    else
                    {
                        impar = numero + impar;
                    }
                }
                else
                {
                    i++;
                }

            }
            Console.WriteLine("\n\n\tA soma dos numeros pares eh {0} e a dos impares  eh {1}", par, impar);
        
        }
    }
}
