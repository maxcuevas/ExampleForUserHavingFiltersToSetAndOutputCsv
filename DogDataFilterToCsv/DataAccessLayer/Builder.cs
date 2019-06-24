using DogDataFilterToCsv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDataFilterToCsv.DataAccessLayer
{
    class Builder
    {

        public Builder()
        {

        }

        public IQueryable<csvWithData> addAgeLessThanFilter(IQueryable<csvWithData> csvTableData,
            string ageTobeLessThanAsString, string ageToBeGreaterThanAsString)
        {
            int ageToBelessThan;
            int ageToBeGreaterThan;
            if (!Int32.TryParse(ageTobeLessThanAsString, out ageToBelessThan) && !Int32.TryParse(ageToBeGreaterThanAsString, out ageToBeGreaterThan))
            {
                return csvTableData;
            }

            if (!String.IsNullOrWhiteSpace(ageToBeGreaterThanAsString) && String.IsNullOrWhiteSpace(ageTobeLessThanAsString))
            {
                ageToBeGreaterThan = Convert.ToInt32(ageToBeGreaterThanAsString);
                return csvTableData.Where(x => x.age > ageToBeGreaterThan);
            }

            if (String.IsNullOrWhiteSpace(ageToBeGreaterThanAsString) && !String.IsNullOrWhiteSpace(ageTobeLessThanAsString))
            {
                ageToBelessThan = Convert.ToInt32(ageTobeLessThanAsString);
                return csvTableData.Where(x => x.age < ageToBelessThan);
            }

                ageToBeGreaterThan = Convert.ToInt32(ageToBeGreaterThanAsString);
                ageToBelessThan = Convert.ToInt32(ageTobeLessThanAsString);
               return csvTableData.Where(x => x.age < ageToBelessThan && x.age > ageToBeGreaterThan);

        }

        public IQueryable<csvWithData> addNameFilter(IQueryable<csvWithData> csvTableData, string containsThisString)
        {
            int notAString;
            if (String.IsNullOrWhiteSpace(containsThisString) || Int32.TryParse(containsThisString, out notAString))
            {
                return csvTableData;
            }
            return csvTableData.Where(x => x.name.Contains(containsThisString));
        }
    }
}
