using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitTracker.Models.Entities
{
    public class LayBet
    {
        public int Id { get; set; }
        public BackBet BackBet { get; set; }
        public int BackBetId { get; set; }
        public double LayOdds { get; set; }
        public Exchange Exchange { get; set; }
    }
}
