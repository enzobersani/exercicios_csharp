namespace Ex_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra = string.Empty;
            string consoante = string.Empty;

            Console.WriteLine("SEJA BEM VINDO!");

            Console.Write("Informe uma palara: ");
            palavra= Console.ReadLine();

            for (int i = 0; i < palavra.Length; i++)
            {
                char c = palavra[i];
                if (c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u')
                    consoante += c;
            }

            Console.WriteLine("A palavra, " + palavra + ", possui as consoantes: " + consoante);
        }
    }
}