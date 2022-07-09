using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_light
{
    class Class1
    {
        delegate void SayWalkLight(string name);
        SayWalkLight sayWalkLight;

        void SayRedWalk(string name)
        {
            Console.WriteLine($"{name} - Stop");
        }

        void SayGreenWalk(string name)
        {
            Console.WriteLine($"{name} -Go");
        }

        public Class1(string light = "green")
        {
            if (light.ToLower().Equals("red")|| light.ToLower().Equals("yellow"))
                this.sayWalkLight += SayRedWalk;
            else
                this.sayWalkLight += SayGreenWalk;
        }


        public void Run(string name)
        {
            //this.sayWalkLight(name);
            this.sayWalkLight?.Invoke(name);
        }
    }
}

