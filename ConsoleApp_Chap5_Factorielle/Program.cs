namespace ConsoleApp_Chap5_Factorielle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez la factorielle à calculer :");
            int fact = int.Parse(Console.ReadLine());
            int resultat = 1;
            Console.WriteLine(" ");
            if (fact == 0)
            {
                resultat = 1;
            }
            else
            {
                while (fact >= 1)
                {
                    resultat = resultat * fact;
                    fact--;
                }
            }
            Console.WriteLine(resultat);
        }
    }
}
