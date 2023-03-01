namespace Ex_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (1 == 1)
            {
                double num1, num2, resultado = 0, sobra;
                string operador;

                Console.WriteLine("Bem-vindo a Calculadora");
                Console.Write("Informe o primeiro número: ");
                num1 = double.Parse(Console.ReadLine());

                Console.Write("Informe o segundo número: ");
                num2 = double.Parse(Console.ReadLine());

                Console.Write("Informe o tipo da operação\n");
                Console.WriteLine("(1) - Somar");
                Console.WriteLine("(2) - Subtrair");
                Console.WriteLine("(3) - Multiplicar");
                Console.WriteLine("(4) - Divisão");
                Console.WriteLine("(5) - Sair");
                operador = Console.ReadLine();

                if (operador == "1") resultado = num1 + num2;
                else if (operador == "2") resultado = num1 - num2;
                else if (operador == "3") resultado = num1 * num2;
                else if (operador == "4")
                {
                    resultado = num1 / num2;
                }
                else if (operador == "5") return;
                else
                {
                    Console.WriteLine("Selecione apenas um dos informados!");
                    return;
                }

                Console.WriteLine("Resultado: " + resultado);
                if (operador == "4") Console.WriteLine("Sobra: " + (sobra = num1 % num2));
                Console.ReadKey();
            }
        }
    }
}