using System;

namespace Laborator6___Exercitiu2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Laborator 6 - Exercitiu 2

            //Scrieti un program care va modela un autoturism. Un autoturism va avea o marca(string), un numar de inmatriculare(string), precum si o capacitate cilindrica(int).
            //Autoturismul va avea:
            // - Campurile corespunzatoare caracteristicilor autoturismului.
            // - Un constructor care va initializa campurile acestuia
            // - O metoda “Tiparire” care va afisa pe consola descrierea acestuia sub forma: “marca, numarDeInmatriculare, capacitateCilindrica”.
            // - Realiazti diagrama UML a clasei.
            // - Folositi: clase, campuri, metode, modificatorii de acces adecvati, comentarii xml pentru metodele publice.
            // - Creeati doua obiecte de tipul autoturism in functia “Main” si apelati-le metodele "Tipareste".

            Marca marca = new Marca("Mazda");
            NumarDeMatriculare numarDeMatriculare = new NumarDeMatriculare("CJ25MSM");
            CapacitateCilindrica capacitateCilindrica = new CapacitateCilindrica(2000);
            Autoturism autoturism1 = new Autoturism(marca, numarDeMatriculare,capacitateCilindrica);
            autoturism1.Tipareste();

            Console.WriteLine();

            Marca marca2 = new Marca("Audi");
            NumarDeMatriculare numarDeMatriculare2 = new NumarDeMatriculare("B03LEL");
            CapacitateCilindrica capacitateCilindrica2 = new CapacitateCilindrica(2500);
            Autoturism autoturism2 = new Autoturism(marca2, numarDeMatriculare2, capacitateCilindrica2);
            autoturism2.Tipareste();


        }
    }
}
