using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace splitIsmetles
{
  class Program
  {
    static void Main(string[] args)
    {
      // fájl sorai: "Törpapa;120"
      // ; elválasztva az adatok
      // fájlban max 100 sor
      String[] torpok = new String[100];
      int[] evek = new int[100];
      int db = 0; // tényleges darabszámnak

      StreamReader file = new StreamReader("adatok.txt");

      while (!file.EndOfStream)
      {
        String sor = file.ReadLine();
        // sor "Törpapa;120"
        String[] adatok = sor.Split(';');
        // adatok[0] "Törpapa"
        // adatok[1] "120"
        torpok[db] = adatok[0];
        evek[db] = Convert.ToInt32(adatok[1]);
        db++;
      }

      file.Close();

      Console.WriteLine("Adatok száma: {0}",db);
      for (int i = 0; i < db; i++)
      {
        Console.WriteLine("{0} -- {1}",torpok[i].PadRight(15),
          evek[i].ToString().PadLeft(3));
      }


      Console.ReadKey();
    }
  }
}
