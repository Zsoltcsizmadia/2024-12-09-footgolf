namespace _2024_12_09_footgolf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyző> versenyzok = new();
            foreach (var sor in File.ReadAllLines("fob2016.txt"))
            {
                versenyzok.Add(new Versenyző(sor));
            }
            Console.WriteLine($"3. feladat: Versenyzők száma: {versenyzok.Count}");

            var nok = 0;
            
            foreach (var no in versenyzok)
            {
                if (no.Nem == "Noi")
                {
                    nok++;
                }
            }
            double arany = (versenyzok.Count / nok);
            Console.WriteLine($"A nők száma: {nok}");
            Console.WriteLine($"A női versenyzők aránya: {Math.Round(arany,2)}");
        }
    }
}
