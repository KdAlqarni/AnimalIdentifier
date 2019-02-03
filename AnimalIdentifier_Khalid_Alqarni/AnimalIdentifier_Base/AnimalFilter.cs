using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    // this is the class to filiter if the animal was a dog or a cat
    public class AnimalFilter 
    {
        // two counters to keep track of number of dog and cat
        private int dogCounter;
        private int catCounter;
        private int birdCounter;
        
        //  check if a dog or a cat or noun of them 
        public void checkAnimal (string name, double conf){
            var confd = new ConfidenceCheck();

            if (confd.result(conf) == true)
            {
                if (name == "dog")
                {
                    dogCounter++;
                }
                else if (name == "cat")
                {
                    catCounter++;
                }
                else if (name == "bird")
                {
                    birdCounter++;
                }
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
                }
                else if (dog > 0 && cat > 0)
                {
                    return printer.print("dog", "cat");
                }
                else if (dog > 0 && bird > 0)
                {
                    return printer.print("dog", "bird");
                }
                else if (bird > 0 && cat > 0)
                {
                    return printer.print("cat", "bird");
                }
                else if (dog > 0)
                {
                    return printer.print("dog");                  
                }
                else if (cat > 0)
                {
                    return printer.print("cat");                    
                }

                else if (bird > 0)
                {
                    return printer.print("brid");
                    
                }

                // if not one of them, will return None
                else
                    return printer.print(true);
                

            }
        }
    }
    
}
