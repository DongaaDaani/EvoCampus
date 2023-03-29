using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Cash { get; set; }
        public ICollection<Bet> Bets { get; set; }
        public ICollection<UserRound> UserRounds { get; set; }
        public ICollection<UserGameSession> UserGameSessions { get; set; }
    }
}
