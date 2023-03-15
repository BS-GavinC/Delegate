using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Models
{

    public class CarWash
    {
        delegate void CarWashDelegate(Voiture voiture);

        CarWashDelegate carWashDelegate = null;

        public void Preparer()
        {
            carWashDelegate += delegate (Voiture voiture)
            {
                Console.WriteLine($"Je prepare la voiture : {voiture.Plaque}");
            };
        }

        public void Laver()
        {
            carWashDelegate += delegate (Voiture voiture)
            {
                Console.WriteLine($"Je lave la voiture : {voiture.Plaque}");
            };
        }

        public void Secher()
        {
            carWashDelegate += delegate (Voiture voiture)
            {
                Console.WriteLine($"Je seche la voiture : {voiture.Plaque}");
            };
        }

        public void Finaliser()
        {
            carWashDelegate += delegate (Voiture voiture)
            {
                Console.WriteLine($"Je finalise la voiture : {voiture.Plaque}");
            };
        }

        public void Traiter(Voiture voiture)
        {
            carWashDelegate(voiture);
            carWashDelegate = null;
        }

    }
}
