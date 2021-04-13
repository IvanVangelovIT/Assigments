using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Lion
    {
        public int healthPoints;
        private bool animalIsDead = false;
        private readonly Random random = new Random();
        public Lion()
        {
            this.healthPoints = 100;
            this.showHealthPoints();
        }
        public bool AnimalIsHungry()
        {
            var helthPoinrsAreDecreasing = random.Next(0, 20);
            this.healthPoints -= helthPoinrsAreDecreasing;
            return true;
            showHealthPoints();
        }

        public bool AnimalIsEating()
        {
            if (this.animalIsDead)
            {

            }
            var helthPoinrsAreDecreasing = random.Next(0, 20);
            this.healthPoints -= helthPoinrsAreDecreasing;
            showHealthPoints();
            return true;
        }

        private void showHealthPoints()
        {
            Console.WriteLine(new string('.', this.healthPoints));
        }
    }
}
