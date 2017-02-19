using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitTracker.Models.ViewModels
{
    public class LayBetViewModel
    {
        public int Id { get; set; }
        public IEnumerable<ExchangeViewModel> Exchanges { get; set; }
        public int ExchangeId { get; set; }
        public double LayStake { get; set; }
        public double LayOdds { get; set; }
    }
}
