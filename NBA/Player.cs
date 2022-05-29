using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA
{
    public partial class Player
    {
        public int playerID;
        public int number;
        public String name;
        public int growth;
        public int position;
        public String college;
        public String country;
        public int teamID;
        public String TeamName;
        public float price;
        //Инициализация класса

        public void set(
        int playerID,
        int number,
        String name,
        int growth,
        int position,
        String college,
        String country,
        int teamID,
        String TeamName,   
        float price)
        {
         this.playerID = playerID;
         this.number = number;
         this.name = name;
         this.growth = growth;
         this.position = position;
         this.college = college;
         this.country = country;
         this.teamID = teamID;
         this.TeamName = TeamName;           
         this.price = price;


        }
    }
}
