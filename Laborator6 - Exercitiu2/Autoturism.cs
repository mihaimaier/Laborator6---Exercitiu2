using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator6___Exercitiu2
{
    /// <summary>
    /// Clasa Autoturism va compila si va arata marca, numarul de imatriculare si capacitatea cilindrica.
    /// </summary>
    class Autoturism 
    {
        private Marca marca;
        private NumarDeMatriculare numarDeMatriculare;
        private CapacitateCilindrica capacitateCilindrica;

        public Autoturism(Marca marca, NumarDeMatriculare numarDeMatriculare, CapacitateCilindrica capacitateCilindrica)
        {
            this.marca = marca;
            this.numarDeMatriculare = numarDeMatriculare;
            this.capacitateCilindrica = capacitateCilindrica;
        }

        public void Tipareste()
        {
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Numar De Imatriculare: {numarDeMatriculare}");
            Console.WriteLine($"Capacitate Cilindrica: {capacitateCilindrica}");
        }
    }
}
