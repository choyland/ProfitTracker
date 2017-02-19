using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfitTracker.Models.Entities.Interfaces;

namespace ProfitTracker.Models.Entities
{
    public class LayBet : IEntity
    { 
        public double LayStake { get; set; }
        public double LayOdds { get; set; }
        public Exchange Exchange { get; set; }
        public int ExchangeId { get; set; }
        public int Id { get; set; }
    }
}
