using System.Collections.Generic;
using System.Linq;

namespace NeoCircusTrain.Classes
{
    public class Wagon
    {
        public List<Animal> Animals { get; private set; } = new List<Animal>();
        public const int MaxPoints = 10;

        public bool TryAddAnimal(Animal animal)
        {
            int currentPoints = Animals.Sum(a => (int)a.AnimalSize);
            if (currentPoints + (int)animal.AnimalSize > MaxPoints)
                return false;

            foreach (var a in Animals)
            {
                if ((a.Carnivore && (int)a.AnimalSize >= (int)animal.AnimalSize) ||
                    (animal.Carnivore && (int)animal.AnimalSize >= (int)a.AnimalSize))
                    return false;
            }

            Animals.Add(animal);
            return true;
        }
    }

    public class ExperimentalWagon
    {
        public List<Animal> Animals { get; private set; } = new List<Animal>();

        public bool TryAddExperimental(Animal animal)
        {
            if (Animals.Count >= 2 || animal.AnimalSize == Animal.animalSize.large)
                return false;

            if (Animals.Count == 1)
            {
                var existing = Animals[0];
                // Only allow:
                // - 2 herbivores
                // - 2 carnivores
                // - 1 carnivore + 1 herbivore if carnivore is smaller
                if (!existing.Carnivore && !animal.Carnivore)
                {
                    Animals.Add(animal);
                    return true;
                }
                else if (existing.Carnivore && animal.Carnivore)
                {
                    Animals.Add(animal);
                    return true;
                }
                else if (existing.Carnivore && !animal.Carnivore && (int)existing.AnimalSize < (int)animal.AnimalSize)
                {
                    Animals.Add(animal);
                    return true;
                }
                else if (!existing.Carnivore && animal.Carnivore && (int)animal.AnimalSize < (int)existing.AnimalSize)
                {
                    Animals.Add(animal);
                    return true;
                }
                return false;
            }
            else
            {
                Animals.Add(animal);
                return true;
            }
        }
    }
}
