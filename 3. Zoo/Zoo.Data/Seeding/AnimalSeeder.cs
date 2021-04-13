namespace Zoo.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Zoo.Data.Models;

    internal class AnimalSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Animals.Any())
            {
                return;
            }

            var animals = new Animal[]
            {
                new Animal
                {
                    Type = "Lion",
                    Name = "Lion1",
                    Health = 100,
                    HealthPoints = new string('.', 100),
                    DamageTaken = 0,
                    MinimumHealth = 50,
                    IsAlive = true,
                },
                new Animal
                {
                    Type = "Lion",
                    Name = "Lion2",
                    Health = 100,
                    HealthPoints = new string('.', 100),
                    DamageTaken = 0,
                    MinimumHealth = 50,
                    IsAlive = true,
                },
                new Animal
                {
                    Type = "Lion",
                    Name = "Lion3",
                    Health = 100,
                    HealthPoints = new string('.', 100),
                    DamageTaken = 0,
                    MinimumHealth = 50,
                    IsAlive = true,
                },
                new Animal
                {
                    Type = "Lion",
                    Name = "Lion4",
                    Health = 100,
                    HealthPoints = new string('.', 100),
                    DamageTaken = 0,
                    MinimumHealth = 50,
                    IsAlive = true,
                },
                new Animal
                {
                    Type = "Lion",
                    Name = "Lion5",
                    Health = 100,
                    HealthPoints = new string('.', 100),
                    DamageTaken = 0,
                    MinimumHealth = 50,
                    IsAlive = true,
                },
                new Animal
                {
                    Type = "Monkey",
                    Name = "Monkey1",
                    Health = 100,
                    HealthPoints = new string('.', 100),
                    DamageTaken = 0,
                    MinimumHealth = 40,
                    IsAlive = true,
                },
                new Animal
                {
                    Type = "Monkey",
                    Name = "Monkey2",
                    Health = 100,
                    HealthPoints = new string('.', 100),
                    DamageTaken = 0,
                    MinimumHealth = 40,
                    IsAlive = true,
                },
                new Animal
                {
                    Type = "Monkey",
                    Name = "Monkey3",
                    Health = 100,
                    HealthPoints = new string('.', 100),
                    DamageTaken = 0,
                    MinimumHealth = 40,
                    IsAlive = true,
                },
                new Animal
                {
                    Type = "Monkey",
                    Name = "Monkey4",
                    Health = 100,
                    HealthPoints = new string('.', 100),
                    DamageTaken = 0,
                    MinimumHealth = 40,
                    IsAlive = true,
                },
                new Animal
                {
                    Type = "Monkey",
                    Name = "Monkey5",
                    Health = 100,
                    HealthPoints = new string('.', 100),
                    DamageTaken = 0,
                    MinimumHealth = 40,
                    IsAlive = true,
                },
                new Animal
                {
                    Type = "Elephant",
                    Name = "Elephant1",
                    Health = 100,
                    HealthPoints = new string('.', 100),
                    DamageTaken = 0,
                    MinimumHealth = 70,
                    IsAlive = true,
                    IsItAbleToWalk = true,
                },
                new Animal
                {
                    Type = "Elephant",
                    Name = "Elephant2",
                    Health = 100,
                    HealthPoints = new string('.', 100),
                    DamageTaken = 0,
                    MinimumHealth = 70,
                    IsAlive = true,
                    IsItAbleToWalk = true,
                },
                new Animal
                {
                    Type = "Elephant",
                    Name = "Elephant3",
                    Health = 100,
                    HealthPoints = new string('.', 100),
                    DamageTaken = 0,
                    MinimumHealth = 70,
                    IsAlive = true,
                    IsItAbleToWalk = true,
                },
                new Animal
                {
                    Type = "Elephant",
                    Name = "Elephant4",
                    Health = 100,
                    HealthPoints = new string('.', 100),
                    DamageTaken = 0,
                    MinimumHealth = 70,
                    IsAlive = true,
                    IsItAbleToWalk = true,
                },
                new Animal
                {
                    Type = "Elephant",
                    Name = "Elephant5",
                    Health = 100,
                    HealthPoints = new string('.', 100),
                    DamageTaken = 0,
                    MinimumHealth = 70,
                    IsAlive = true,
                    IsItAbleToWalk = true,
                },
            };
            foreach (Animal animal in animals)
            {
                await dbContext.Animals.AddAsync(animal);
            }
        }
    }
}