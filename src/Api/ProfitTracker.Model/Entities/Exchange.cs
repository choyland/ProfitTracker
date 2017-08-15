using ProfitTracker.Models.Entities.Interfaces;

namespace ProfitTracker.Model.Entities
{
    public class Exchange : IEntity
    {
        public string Name { get; set; }
        public double Commission { get; set; }
        public int Id { get; set; }
    }
}
