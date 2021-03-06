using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Interface
{
  class Program
  {
    static void Main(string[] args)
    {
      IPrinterWindows printer;

      Console.WriteLine("Pilih Printer");
      Console.WriteLine("1. Epson");
      Console.WriteLine("2. Canon");
      Console.WriteLine("3. Laser Jet");

      Console.Write("\nNomor Printer [1..3] : ");
      int nomorprinter = Convert.ToInt32(Console.ReadLine());

      if (nomorprinter == 1)
          printer = new Epson();
      else if (nomorprinter == 2)
          printer = new Canon();
      else
          printer = new LaserJet();

      printer.Show();
      printer.Print();


      Console.ReadKey();
    }
  }
}
