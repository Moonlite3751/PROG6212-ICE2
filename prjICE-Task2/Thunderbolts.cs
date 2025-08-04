using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjICE_Task2
{
    public class Thunderbolts
    {
        int age;
        string name, power, heroName, personality;

        public Thunderbolts(int age, string name, string power, string heroName, string personality)
        {
            this.age = age;
            this.name = name;
            this.power = power;
            this.heroName = heroName;
            this.personality = personality;
        }

        public object this[int index]
        {
            get
            {
                if(index == 0)
                    return age;

                else if(index == 1)
                    return name;

                else if(index == 2)
                    return power;

                else if(index == 3)
                    return heroName;

                else if(index == 4)
                    return personality;

                else
                    return null;
            }

            set
            {
                if(index == 0)
                    age = (int)value;

                else if(index == 1)
                    name = (string)value;

                else if(index == 2)
                    power = (string)value;

                else if(index == 3)
                    heroName = (string)value;

                else if(index == 4)
                    personality = (string)value;
               
            }
        }

        public object this[string attName]
        {
            get 
            {
                if(attName == "age")
                    return age;

                else if(attName == "name")
                    return name;

                else if(attName == "power")
                    return power;

                else if(attName == "heroName")
                    return heroName;



                else
                    return null;
            }

            set
            {
                if (attName.ToLower().Equals("age"))
                this.age = (int)value;
                
                else if (attName.ToLower().Equals("name"))
                    this.name = (string)value;

                else if (attName.ToLower().Equals("power"))
                    this.power = (string)value;

                else if (attName.ToLower().Equals("heroName"))
                    this.heroName = (string)value;

                else if (attName.ToLower().Equals("personality"))
                    this.personality = (string)value;

            }
        }
    }
}
