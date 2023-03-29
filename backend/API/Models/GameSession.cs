using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class GameSession
    {
        [Key]
        public int GameSessionId {get; set;}
        public string Type { get; set; }
        public ICollection<Round> Rounds { get; set; }
        public ICollection<UserGameSession> UserGameSessions { get; set; }
    }
}
