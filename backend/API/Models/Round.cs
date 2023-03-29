using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Round
    {
        [Key]
        public int RoundId { get; set; }
        public int RoundNumber { get; set; }
        public GameSession GameSession { get; set; }
        public int GameSessionId { get; set; }
        public ICollection<Bet> Bets { get; set; }
        public ICollection<UserRound> UserRounds { get; set; }
    }
}
