namespace Ex_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra = string.Empty;
            string vogais =string.Empty;

            Console.WriteLine("SEJA BEM-VINDO");
            Console.Write("INFORME UMA PALAVRA: ");
            palavra = Console.ReadLine();

            for (int i = 0; i < palavra.Length; i++)
            {
                char c = palavra[i];
                if (c == 'a' || c == 'e' || c == 'i' ||
                    c == 'o' || c == 'u')
                {
                    vogais += c + " ";
                }
            }
            Console.WriteLine("Vogais de " + palavra + ":" + " " + vogais);
        }
    }
}