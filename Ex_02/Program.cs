namespace Ex_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra = string.Empty;
            int qtVogais = 0;

            Console.WriteLine("SEJA BEM-VINDO");
            Console.Write("INFORME UMA PALAVRA: ");
            palavra = Console.ReadLine();

            for (int i = 0; i < palavra.Length; i++)
            {
                char c = palavra[i];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    qtVogais++;
            }
            Console.WriteLine("O número de vogais de " + palavra + " é de " + qtVogais);
        }
    }
}