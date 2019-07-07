using System;
using System.Collections.Generic;
using System.Text;

namespace DogDataFilterApi.Models
{
    public class Ear
    {
        public LessThanAndGreaterThanStrings highData { get; }
        public LessThanAndGreaterThanStrings lowData { get; }

        public Ear(string highLessThan, string highGreaterThan, string lowLessThan, string lowGreaterThan)
        {
            highData = new LessThanAndGreaterThanStrings(highLessThan, highGreaterThan);
            lowData = new LessThanAndGreaterThanStrings(lowLessThan, lowGreaterThan);
        }
    }
}
