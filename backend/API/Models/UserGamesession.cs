using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class UserGameSession
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public GameSession GameSession { get; set; }
        public int GameSessionId { get; set; }
    }
}
