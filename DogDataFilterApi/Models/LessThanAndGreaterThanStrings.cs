using System;
using System.Collections.Generic;
using System.Text;

namespace DogDataFilterApi.Models
{
    public class LessThanAndGreaterThanStrings
    {
        public string lessThan { get; }
        public string greaterThan { get; }

        public LessThanAndGreaterThanStrings(string lessThan, string greaterThan)
        {
            this.lessThan = lessThan;
            this.greaterThan = greaterThan;
        }

    }
}
