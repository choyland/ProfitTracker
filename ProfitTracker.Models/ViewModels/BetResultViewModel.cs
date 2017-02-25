using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfitTracker.Models.enums;

namespace ProfitTracker.Models.ViewModels
{
    public class BetResultViewModel
    {
        public int Id { get; set; }
        public double Winnings { get; set; }
        public BetOutcome Outcome { get; set; }
    }
}
