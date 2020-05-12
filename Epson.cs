using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Interface
{
  class Epson : IPrinterWindows
  {
    public void Show()
    {
      Console.WriteLine("\nEpson display dimention : 10*11");
    }

    public void Print()
    {
      Console.WriteLine("\nEpson printer printing.......");
    }
  }
}
