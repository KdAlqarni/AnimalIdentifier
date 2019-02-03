using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    class Printing
    { 
        public String print(String animal1, String animal2, String animal3)
        {
            return "Picutre contains " + animal1 + ", " + animal2 + ", and " + animal3 + ".";
        }

        public String print(String animal)
        {
            return "Picutre contains " + animal + ".";
        }

        public String print(String animal1, String animal2)
        {
            return "Picutre contains " + animal1 + " and " + animal2 + ".";
        }
         
        public String print(Boolean None)
        {
            return "Picutre does not contain a dog, a cat, nor a bird.";
        }

    }
}
