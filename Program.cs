using Calculadora;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcula calculadora = new Calcula();

            Console.WriteLine("Qual operação deseja fazer:");
            Console.WriteLine("1-Soma:");
            Console.WriteLine("2-Subtração:");
            Console.WriteLine("3-Divisão:");
            Console.WriteLine("4-Multiplicação:");
            Console.Write("Escolha a operação:");
            int op = int.Parse(Console.ReadLine());

            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            
            if(op == 1){
                int res = calculadora.soma(num1, num2);

                Console.WriteLine("Resultado: " + res);
            }
             if(op == 2){
                int res = calculadora.Subtracao(num1, num2);

                Console.WriteLine("Resultado: " + res);
            }

             if(op == 3){
                int res = calculadora.Divisao(num1, num2);

                Console.WriteLine("Resultado: " + res);
            }

             if(op == 4){
                int res = calculadora.Multiplicacao(num1, num2);

                Console.WriteLine("Resultado: " + res);
            }



        }
    }
}