using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    public static class FacaComoEuFiz
    {
        private static List<int> list = new List<int>();

        public static void ExibirOsNumeros()
        {
            ExibirNumeroParesFor();
            ExibirNumeroParesForeach();
        }

        private static void GerarNumeroAleatorios()
        {
            Random rand = new Random();
            for (int i = 0; i <= 100; i++)
            {
                list.Add(rand.Next(1,1000));
            }
        }

        private static void ExibirNumeroParesFor()
        {
            Console.WriteLine("Numero Pares For");
            list.Clear();
            GerarNumeroAleatorios();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0) Console.WriteLine(list[i]);
            }
        }

        private static void ExibirNumeroParesForeach()
        {
            Console.WriteLine("Numero Pares Foreach");
            list.Clear();
            GerarNumeroAleatorios();
            foreach (int i in list)
            {
                if (i % 2 == 0) Console.WriteLine(i);
            }
        }
    }
}
