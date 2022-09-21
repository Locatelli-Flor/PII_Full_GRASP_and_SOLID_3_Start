using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter
    {
        public void Imprimir(Recipe receta)
        {
            File.WriteAllText("Recipe.txt", receta.GetTextToPrint());
        }
    }
}