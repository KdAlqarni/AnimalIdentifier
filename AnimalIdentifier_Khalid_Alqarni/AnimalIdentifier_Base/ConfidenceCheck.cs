using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace AnimalIdentifier_Base
{
    public class ConfidenceCheck
    {

        public bool result (double confNum)
        {
            if (confNum >= 0.80)
            {
                return true;
            }
            else
                return false;
            
        }
    }
}
