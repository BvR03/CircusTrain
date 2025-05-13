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
        public int AnimalSize { get; private set; }
        public bool Carnivore { get; private set; }
        public Animal(int size, bool Carnivore)
        {
            this.AnimalSize = size;
            this.Carnivore = Carnivore; 
        }
    }
}
