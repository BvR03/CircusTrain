using NeoCircusTrain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoCircusTrain.Algorithm
{
    public static class SortingAlgorithm
    {
        public static List<Animal> AnimalSorter(List<Animal> animals)
        {
            return animals
                .OrderByDescending(a => a.Carnivore)          // Carnivores first
                .ThenByDescending(a => (int)a.AnimalSize)     // Largest first
                .ToList();
        }
        public static string sortingProgram()
        {
            return ("pass");
            /*
             * Idea 1
             Optimal Combos
            10 space Always start with carnivore
            Large Carnivore == 1 cart
            Medium Carnivore + 1 Large Herbivore
            Small Carnivore + 1 Large & 1 Medium

             Optimal Combos experimental Check for 2, 4, 6 or 8 M/S carnivores
             Only make experimental carts if able to fill in pairs
            2x Medium Carnivore
            1x medium Carnivore 1x small Carnivore
            2x small Carnivore
                

            Sorting process
            Grab all animals ordered by type Carnivore -> Herbivore
            Order all animals based on size Large -> Small
            Foreach Large Carnivore 1 normale cart
            Foreach Medium Carnivore 1 experimental cart (Max4) Dan Normale cart
            Foreach Small Carnivore 1 experimental cart (indien over) anders normale cart
            
            Check cart size != full
            Check Animal inside != Large Carnivore
            Normal cart with Medium Carnivore = Add Large herbivore
            Normal cart with Small carnivore = Add large/medium herbivore
            Put small herbivores together in a singular cart

             
             
             *Idea 2
            For each large carnivore 1 reg cart
            Put Small herbivores in same cart (if left over is 1 maybe into experimental
            Split Medium carnivores into seperate carts (2 per experimental if the cart can be fully filled, else in a reg cart)

             
             */
        }
    }
}
