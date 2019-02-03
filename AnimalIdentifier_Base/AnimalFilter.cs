using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    // this is the class to filiter if the animal was a dog or a cat
    class AnimalFilter 
    {
        // two counters to keep track of number of dog and cat
        private int dogCounter;
        private int catCounter;
        private int birdCounter;
        
        //  check if a dog or a cat or noun of them 
        public void checkAnimal (string name){

            if (name == "dog")
            {
                dogCounter++;
            }
            else if (name == "cat")
            {
                catCounter++;
            }
            else if(name == "bird")
            {
                birdCounter++;
            }
        }


        // to get the final result and return them as string
        public string AnimalResult
        {
            get
            {
                Printing printer = new Printing();
 
                int dog = dogCounter;
                int cat = catCounter;
                int bird = birdCounter;
                 
                 
                 
                if (dog > 0 && cat > 0 && bird > 0)
                {
                    return printer.print("dog", "cat", "bird");
                    //return "Picutre contains a dog, a cat, and a bird.";
                }
                
                else if (dog > 0 && cat > 0)
                {
                    return printer.print("dog", "cat");
                }
                else if (dog > 0 && bird > 0)
                {
                    return printer.print("dog", "bird");
                }
                else if ( bird > 0 && cat > 0)
                {
                    return printer.print( "cat", "bird");
                }
                else if (dog > 0)
                {
                    return printer.print("dog");
                    //return "Picutre contains a dog.";
                }


                else if (cat > 0)
                {
                    return printer.print("cat");
                    //return "Picutre contains a cat.";
                }

                else if (bird > 0)
                {
                    return printer.print("brid");
                    //return "Picutre contains a bird.";
                }

                // if not one of them, will return None
                else
                    return printer.print(true);
                    
                    //return "Picutre does not contain a dog, a cat, nor a bird.";
            }
        }
    }
    
}
