using ProfitTracker.Models.Entities.Interfaces;

namespace ProfitTracker.Model.Entities
{
    public class Bookmaker : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
