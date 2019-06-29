using System;
using System.Collections.Generic;
using System.Text;

namespace DogDataFilterApi.Models
{
    public class DateAndTime
    {
        public DateTime lessThanThis { get; }
        public DateTime greaterThanThis { get; }

        public DateAndTime(DateTime dateLessThanThis, DateTime dateGreaterThanThis)
        {
            this.lessThanThis = dateLessThanThis;
            this.greaterThanThis = dateGreaterThanThis;
        }

    }
}
