using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Match : IEntity
    {
        [Key]
        public int MatchId { get; set; }
        public int? HomeTeamId { get; set; }
        public int? GuestTeamId { get; set; }
        public string MatchDate { get; set; }
        public string Stadium { get; set; }
        public Team GuestTeam { get; set; }
        public Team HomeTeam { get; set; }
    }
}
