using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA
{
    internal class Player
    {
        public int number;//номер
        public String name;//имя
        public int growth;//рост
        public int position;//позиция
        public String college;//образование
        public String country;//страна

        public float price;
        //Инициализация класса

        public void set(
        int number,
        String name,
        int growth,
        int position,
        String college,
        String country,
            //DateTime dateofbirth
        float price)
        {
         this.number = number;
         this.name = name;
         this.growth = growth;
         this.position = position;
         this.college = college;
         this.country = country;
            // this.dateofbirth = date of birth
         this.price = price;


        }
    }
}
