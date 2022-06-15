using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator6___Exercitiu2
{
    /// <summary>
    /// Marca va arata brandul autoturismului. Clasa Marca este publica.
    /// </summary>
    class Marca
    {
        public string marca;

        public string GetMarca()
        {
            return this.marca;
        }
        
        public void SetMarca(string marcaNou)
        {
            this.marca = marcaNou;
        }


    }
}
