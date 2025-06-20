using System.Collections.Generic;
using NeoCircusTrain.Algorithm;

namespace NeoCircusTrain.Classes
{
    public class Train
    {
        public List<Wagon> Wagons { get; private set; } = new List<Wagon>();
        public List<ExperimentalWagon> ExperimentalWagons { get; private set; } = new List<ExperimentalWagon>();

        public void DistributeAnimals(List<Animal> animals)
        {
            var sorted = SortingAlgorithm.AnimalSorter(animals);

            foreach (var animal in sorted)
            {
                bool placed = false;

                // Try normal wagons
                foreach (var wagon in Wagons)
                {
                    if (wagon.TryAddAnimal(animal))
                    {
                        placed = true;
                        break;
                    }
                }

                // Try experimental wagons if applicable
                if (!placed && ExperimentalWagons.Count < 4 && (int)animal.AnimalSize < 5)
                {
                    foreach (var ew in ExperimentalWagons)
                    {
                        if (ew.TryAddExperimental(animal))
                        {
                            placed = true;
                            break;
                        }
                    }

                    if (!placed && ExperimentalWagons.Count < 4)
                    {
                        var newEw = new ExperimentalWagon();
                        newEw.TryAddExperimental(animal);
                        ExperimentalWagons.Add(newEw);
                        placed = true;
                    }
                }

                // Fallback: create new wagon
                if (!placed)
                {
                    var newWagon = new Wagon();
                    newWagon.TryAddAnimal(animal);
                    Wagons.Add(newWagon);
                }
            }
        }
    }
}
