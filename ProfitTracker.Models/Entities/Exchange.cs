using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfitTracker.Models.Entities.Interfaces;

namespace ProfitTracker.Models.Entities
{
    public class Exchange : IEntity
    {
        public string Name { get; set; }
        public double Commission { get; set; }
        public int Id { get; set; }
    }
}
