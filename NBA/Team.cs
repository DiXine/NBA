using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA
{
    internal class Team
    {
        String teamID;
        String teamName;
        String teamAbbr;
        String teamLogo;

        public void set(
            string teamID, 
            string teamName,
            string teamAbbr,
            string teamLogo)
            
        {
            this.teamID = teamID;
            this.teamName = teamName;
            this.teamAbbr = teamAbbr;
            this.teamLogo = teamLogo;
        }
    }
}
