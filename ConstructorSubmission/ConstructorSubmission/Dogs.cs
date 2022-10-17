using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    // Creating a "Dogs" class and giving it two properties;
    // creating constructor w/ 2 parameters and chaining two together.
    public class Dogs
    {
        public string Breed { get; set; }
        public string Weight { get; set; }
        
        public Dogs(string breed, string weight)
        {
            Breed = breed;
            Weight = weight;
        }

        public Dogs(string breed) : this(breed, "large")
        {

        }
    }
}
