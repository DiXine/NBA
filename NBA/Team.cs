using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA
{
    public partial class Team
    {
        public int teamID;
        public string TeamName;
        public string DivisionID;
        string Abbr;
        string Logo;
        string Coach;
        string Stadium;

        public void set(
            int teamID, 
            string TeamName,
            string DivisionID,
            string Coach,
            string Abbr,
            string Stadium,
            string Logo)
            
        {
            this.teamID = teamID;
            this.TeamName = TeamName;
            this.Stadium = Stadium;
            this.Abbr = Abbr;
            this.Logo = Logo;
            this.DivisionID = DivisionID;
            this.Coach = Coach;
        }
    }
}
