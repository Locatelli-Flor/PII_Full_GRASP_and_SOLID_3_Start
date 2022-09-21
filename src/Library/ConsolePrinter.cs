using System;
namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter : IPrinter
    {
        public void Imprimir(Recipe receta)
        {
            Console.WriteLine(receta.GetTextToPrint());
        }
    }
}