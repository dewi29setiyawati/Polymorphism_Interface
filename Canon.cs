using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Interface
{
  class Canon : IPrinterWindows
  {
    public void Show()
    {
      Console.WriteLine("\nCanon display dimention : 9.5*12");
    }

    public void Print()
    {
      Console.WriteLine("\nCanon printer printing.......");
    }
  }
}
