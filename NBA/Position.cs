using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA
{
    internal class Position
    {
        string PositionID;
        string PositionName;
        public void set (string PositionID, string PositionName)
        {
            this.PositionID = PositionID;
            this.PositionName = PositionName;
        }
    }
}
