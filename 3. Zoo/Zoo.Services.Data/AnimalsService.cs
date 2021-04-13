namespace Zoo.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Zoo.Data;
    using Zoo.Data.Models;
    using Zoo.Web.ViewModels.Animals;

    public class AnimalsService : IAnimalsService
    {
        private readonly ApplicationDbContext _context;

        private const string _Lion = "Lion";
        private const string _Monkey = "Monkey";
        private const string _Elephant = "Elephant";
        public AnimalsService(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IList<AnimalViewModel> GetAll()
        {
            var animals = this._context.Animals.ToList();

            var animalsViewModels = new AnimalsViewModel();
            animalsViewModels.Animals = new List<AnimalViewModel>();

            foreach (var animal in animals)
            {
                animalsViewModels.Animals.Add(new AnimalViewModel()
                {
                    Id = animal.Id,
                    Name = animal.Name,
                    Health = animal.Health,
                    HealthPoints = animal.HealthPoints,
                    HealthPointsRecieved = animal.HealthPointsRecieved,
                    DamageTaken = animal.DamageTaken,
                    IsAlive = animal.IsAlive,
                });
            }

            return animalsViewModels.Animals;
        }

        public async Task<bool> StarveAnimals()
        {
            var animals = this._context.Animals.ToList();

            foreach (var animal in animals)
            {
                if (animal.IsAlive == false)
                {
                    continue;
                }

                int rnd = this.GenerateRandomNumber(false);
                this.UpdateAnimalPropertiesByDamageTaken(animal, rnd);
            }

            this._context.UpdateRange(animals);
            await this._context.SaveChangesAsync();
            return true;
        }

        private void UpdateAnimalPropertiesByDamageTaken(Animal animal, int rnd)
        {
            if (animal.Type == _Lion)
            {
                int health = animal.Health - rnd;
                if (animal.MinimumHealth > health)
                {
                    animal.Health = health;
                    animal.IsAlive = false;
                    animal.DamageTaken = 0;
                    animal.HealthPointsRecieved = 0;
                    animal.HealthPoints = new string('.', health);
                    return;
                }
                else
                {
                    animal.Health = health;
                    animal.DamageTaken = rnd;
                    animal.HealthPointsRecieved = 0;
                    animal.HealthPoints = new string('.', health);
                    return;
                }
            }
            else if (animal.Type == _Monkey)
            {
                int health = animal.Health - rnd;
                if (animal.MinimumHealth > health)
                {
                    animal.Health = health;
                    animal.IsAlive = false;
                    animal.DamageTaken = 0;
                    animal.HealthPointsRecieved = 0;
                    animal.HealthPoints = new string('.', health);
                    return;
                }
                else
                {
                    animal.Health = health;
                    animal.DamageTaken = rnd;
                    animal.HealthPointsRecieved = 0;
                    animal.HealthPoints = new string('.', health);
                    return;
                }
            }
            else
            {
                int health = animal.Health - rnd;
                if (animal.IsItAbleToWalk == false)
                {
                    animal.Health = health;
                    animal.IsAlive = false;
                    animal.DamageTaken = 0;
                    animal.HealthPointsRecieved = 0;
                    animal.HealthPoints = new string('.', health);
                    return;
                }
                else if (animal.MinimumHealth > health)
                {
                    animal.Health = health;
                    animal.IsItAbleToWalk = false;
                    animal.DamageTaken = 0;
                    animal.HealthPointsRecieved = 0;
                    animal.HealthPoints = new string('.', health);
                    return;
                }
                else
                {
                    animal.Health = health;
                    animal.DamageTaken = rnd;
                    animal.HealthPointsRecieved = 0;
                    animal.HealthPoints = new string('.', health);
                    return;
                }
            }
        }

        private int GenerateRandomNumber(bool isAnimalEating)
        {
            if (isAnimalEating)
            {
                Random random = new Random();
                var rnd = random.Next(5, 26);
                return rnd;
            }
            else
            {
                Random random = new Random();
                var rnd = random.Next(0, 21);
                return rnd;
            }
        }

        public async Task<bool> Reset()
        {
            var animals = this._context.Animals.ToList();

            foreach (var animal in animals)
            {
                animal.HealthPoints = new string('.', 100);
                animal.IsAlive = true;
                animal.Health = 100;
                animal.DamageTaken = 0;
                animal.HealthPointsRecieved = 0;
                animal.IsItAbleToWalk = true;
            }

            this._context.UpdateRange(animals);
            await this._context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> FeedAnimals()
        {
            var animals = this._context.Animals.ToList();

            foreach (var animal in animals)
            {
                if (animal.IsAlive == false)
                {
                    continue;
                }

                if (animal.Health == 100)
                {
                    animal.HealthPointsRecieved = 0;
                    continue;
                }

                int rnd = this.GenerateRandomNumber(true);
                this.UpdateAnimalPropertiesByPointsRecieved(animal, rnd);
            }

            this._context.UpdateRange(animals);
            await this._context.SaveChangesAsync();
            return true;
        }

        private void UpdateAnimalPropertiesByPointsRecieved(Animal animal, int rnd)
        {
            int health = animal.Health + rnd;

            if (health > 100) { health = 100; }

            if (animal.Type == _Elephant)
            {
                if (animal.MinimumHealth > health)
                {
                    animal.Health = health;
                    animal.HealthPointsRecieved = rnd;
                    animal.DamageTaken = 0;
                    animal.HealthPoints = new string('.', health);
                    return;
                }
                else
                {
                    animal.Health = health;
                    animal.HealthPointsRecieved = rnd;
                    animal.DamageTaken = 0;
                    animal.HealthPoints = new string('.', health);
                    animal.IsItAbleToWalk = true;
                    return;
                }
            }

            animal.Health = health;
            animal.HealthPointsRecieved = rnd;
            animal.DamageTaken = 0;
            animal.HealthPoints = new string('.', health);

        }

        public IList<AnimalViewModel> GetAllSurvivors()
        {
            var animals = this._context
                .Animals
                .Where(x => x.IsAlive == true)
                .ToList();

            var animalsViewModels = new AnimalsViewModel();
            animalsViewModels.Animals = new List<AnimalViewModel>();

            foreach (var animal in animals)
            {
                animalsViewModels.Animals.Add(new AnimalViewModel()
                {
                    Id = animal.Id,
                    Name = animal.Name,
                    Health = animal.Health,
                    HealthPoints = animal.HealthPoints,
                    HealthPointsRecieved = animal.HealthPointsRecieved,
                    DamageTaken = animal.DamageTaken,
                    IsAlive = animal.IsAlive,
                });
            }

            return animalsViewModels.Animals;
        }
    }
}
