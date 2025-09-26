using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FQ25L062_DemoCallApi
{
    internal class Dino
    {
        public int Id { get; }
        public string Espece { get; }
        public int Poids { get; set; }
        public int Taille { get; set; }

        public Dino(int id, string espece, int poids, int taille)
        {
            Id = id;
            Espece = espece;
            Poids = poids;
            Taille = taille;
        }
    }
}
