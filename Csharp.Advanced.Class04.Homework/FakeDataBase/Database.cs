using Models;
using Models.Generic;

namespace FakeDataBase
{
    public class Database
    {
        public PetStore<Dog> dogStore = new PetStore<Dog>()
        {
            PetsList = new List<Dog>()
            {
                new Dog{Name = "Rex",Type = "German Shepard",Age = 4, FavouriteFood = "Beef",GoodBoi = true},
                new Dog{Name = "Sparky", Type = "Pitbull", Age = 3, FavouriteFood = "Chicken", GoodBoi = false}
            }
        };
        public PetStore<Cat> catStore = new PetStore<Cat>()
        {
            PetsList = new List<Cat>()
            {
                new Cat{Name = "Garfield", Type = "House cat", Age = 3, Lazy = false, LivesLeft = 9},
                new Cat{Name = "Meow", Type = "Persian", Age = 2, Lazy = true, LivesLeft = 8},
            }
        };
        public PetStore<Fish> fishStore = new PetStore<Fish>()
        {
            PetsList = new List<Fish>()
            {
                new Fish{Name = "Nemo", Type = "Goldfish", Age = 2, Color ="Gold",Size = 10},
                new Fish{Name = "Bruce", Type = "Shark", Age = 7, Color = "Blue", Size = 250}
            }
        };
    }
}