using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    public class Tag
    {
        public string name { get; set; }
        public double confidence { get; set; }
        public string hint { get; set; }
    }

    public class TagData
    {
        public List<Tag> tags { get; set; }
        public string requestId { get; set; }

    }
}
