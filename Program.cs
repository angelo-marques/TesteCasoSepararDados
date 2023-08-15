using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCasoSepararDados
{
    internal class Program
    {
        public static IEnumerable<string> AllPrefixes(int prexixLength, IEnumerable<string> words)
        {
            var prefixes = new List<string>();
            var cont = 0;
            foreach (var item in words)
            {
                if(item.Length >= prexixLength)
                {
                    cont++;
                }
            }

            if(cont == 0)
            {
                return prefixes;
            }

            foreach (var word in words.Where(x => x.Length >= prexixLength)) {
                var novo = word.Substring(0, prexixLength);
                if (!prefixes.Contains(novo))
                {
                    prefixes.Add(novo);
                }
            }
            return prefixes;
        }
        static void Main(string[] args)
        {
            foreach (var p in AllPrefixes(3, new string[] { "flow", "flowers", "flew", "flag", "fm" }))
            {
                Console.WriteLine(p.ToString());               
            }
            foreach (var p in AllPrefixes(3, new string[] { "fl", "fl", "fl", "fl", "fm" }))
            {
                Console.WriteLine(p.ToString());
            }
            foreach (var p in AllPrefixes(7, new string[] { "flow", "flowers", "flew", "flag", "fm" }))
            {
                Console.WriteLine(p.ToString());
            }
            foreach (var p in AllPrefixes(2, new string[] { "flow", "flowers", "flew", "flag", "fm" }))
            {
                Console.WriteLine(p.ToString());
            }
            Console.ReadLine();
           
        }
    }
}
