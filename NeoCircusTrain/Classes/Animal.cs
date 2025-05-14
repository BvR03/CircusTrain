using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace NeoCircusTrain.Classes
{
    class Animal
    {
        public animalSize AnimalSize { get; private set; }
        public bool Carnivore { get; private set; }
        public Animal(animalSize size, bool Carnivore)
        {
            this.AnimalSize = size;
            this.Carnivore = Carnivore; 
        }
        public enum animalSize
        {
            small = 1,
            medium = 3,
            large = 5
        }
    }
}
