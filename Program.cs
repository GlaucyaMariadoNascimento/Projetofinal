using System;

namespace Projetofinal
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("================================="); 
            Console.WriteLine("¦ \t \t \t \t¦ ");    
            Console.WriteLine("==== CALCULADORA ARITMÉDICA =====");
            Console.WriteLine("¦ \t \t \t \t¦ "); 
            Console.WriteLine("=================================");                    

            double num1, num2 ;
           
            int resul = 0;


            Console.WriteLine("\nDigite o 1º numero: ");

            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º numero: ");

            num2 = double.Parse(Console.ReadLine());

            Console.Clear();

        
            while (resul != 7)

            {

                Console.WriteLine("== Digite 1 para soma: ");

                Console.WriteLine("== Digite 2 para subtração: ");

                Console.WriteLine("== Digite 3 para divisão: ");

                Console.WriteLine("== Digite 4 para multiplicação: ");

                Console.WriteLine("== Digite 5 para exponenciação: ");

                Console.WriteLine("== Digite 6 para radiciação:");

                Console.WriteLine("== Para sair digite 7: ");

                resul = int.Parse(Console.ReadLine());

                 if (resul == 1)
            

                {

                    Console.WriteLine("\nSoma = {0}", num1+num2);
                }

                else if (resul == 2)
                {

                    Console.WriteLine("\nSubtração = {0}", num1 - num2);
                }

                else if (resul == 3)
                {

                    Console.WriteLine("\nDivisão = {0}", num1 / num2);

                }

                else if (resul == 4)

                {

                    Console.WriteLine("\nMultiplicação = {0}", num1 * num2);

                }

                else if (resul == 5)
                {

                    Console.WriteLine("\nExponenciação = {0}", Math.Pow(num1, num2));
                
                }
                 
                else if (resul == 6)
                {
                double resultado = Math.Sqrt(num1);
                double resultado2 = Math.Sqrt(num2);
                Console.WriteLine($"\nA Radiciação do primeiro número é = {resultado}");
                Console.WriteLine($"\nA Radiciação do segundo número é = {resultado2}");

                }


                Console.Write("\nCréditos: Glaucya Nascimento, 28 anos, estudante de ADS na UNIP, informatica nova matriz na ETEC e full stack developer Java na Generation:");
                Console.Write("\nhttps://github.com/GlaucyaMariadoNascimento");

                Console.ReadLine();
                
                Console.Clear();
            }
        }
    }
}

