namespace Zoo.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Zoo.Data.Models;
    using Zoo.Web.ViewModels.Animals;

    public interface IAnimalsService
    {
        IList<AnimalViewModel> GetAll();
        IList<AnimalViewModel> GetAllSurvivors();
        Task<bool> StarveAnimals();
        Task<bool> FeedAnimals();
        Task<bool> Reset();
    }
}
