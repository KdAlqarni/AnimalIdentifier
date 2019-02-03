using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    class Printing
    { 
        public String print(String dog, String cat , String bird )
        {
            return "XXPicutre contains " + dog + ", " + cat + ", and " + bird + ".";
        }
         
        public String print(String oneAnimal)
        {
            return "Picutre contains " + oneAnimal + ".";
        }
         
        public String print(String oneAnimal, String twoAnimal)
        {
            return "Picutre contains " + oneAnimal + " and " + twoAnimal +".";
        }

        public String print(Boolean None)
        {
            return "Picutre does not contain a dog, a cat, nor a bird.";
        }

    }
}
