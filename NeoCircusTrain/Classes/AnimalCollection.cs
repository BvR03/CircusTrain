using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoCircusTrain.Classes
{
    class AnimalCollection
    {
        public static List<Animal> animals = new List<Animal>();

        public static List<Animal> FetchAnimals()
        {
            List<Animal> animals = new List<Animal>();
            animals.AddRange(AnimalCollection.animals);
            return animals; 
        }
        public void AnimalCreation()
        {

        }
    }
}
