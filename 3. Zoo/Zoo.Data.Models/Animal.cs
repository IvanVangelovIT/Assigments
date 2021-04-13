namespace Zoo.Data.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public string HealthPoints { get; set; }
        public int HealthPointsRecieved { get; set; }
        public int DamageTaken { get; set; }
        public int MinimumHealth { get; set; }
        public bool IsAlive { get; set; }
        public bool IsItAbleToWalk { get; set; }
    }
}
