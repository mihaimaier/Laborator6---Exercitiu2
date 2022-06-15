using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator6___Exercitiu2
{
    /// <summary>
    /// Clasa NumarDeMatriculare arata numarul de imatriculare al autoturismului. Clasa este una privata.
    /// </summary>
    class NumarDeMatriculare
    {
        private string numarImatriculare;

        public string GetNumarImatriculare()
        {
            return this.numarImatriculare;
        }

        public void SetNumarImatriculare(string numarImatricularenou)
        {
            this.numarImatriculare = numarImatricularenou;
        }
    }
}
