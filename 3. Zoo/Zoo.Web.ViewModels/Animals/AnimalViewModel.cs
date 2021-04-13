namespace Zoo.Web.ViewModels.Animals
{
    public class AnimalViewModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public string HealthPoints { get; set; }
        public int DamageTaken { get; set; }
        public int HealthPointsRecieved { get; set; }
        public bool IsAlive { get; set; }
    }
}
