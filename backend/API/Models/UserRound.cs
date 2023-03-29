using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class UserRound
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Round Round { get; set; }
        public int RoundId { get; set; }
        public ICollection<Bet> Bets { get; set; }
    }
}
