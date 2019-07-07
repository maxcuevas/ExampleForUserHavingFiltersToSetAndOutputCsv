using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDataFilterApi.Models
{
    public class GeoLocationData
    {
        public string pointInSpace { get; }
        public string radiusFromPointInSpace { get; }

        public GeoLocationData(string pointInSpace, string radiusFromPointInSpace)
        {
            this.pointInSpace = pointInSpace;
            this.radiusFromPointInSpace = radiusFromPointInSpace;
        }


    }
}
