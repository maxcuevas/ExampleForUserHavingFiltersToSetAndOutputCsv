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

        public IQueryable<csvWithData> tailHighFilter(IQueryable<csvWithData> csvTableData,
            string tailHighTobeLessThanAsString, string tailHighToBeGreaterThanAsString)
        {
            if (isValidData(tailHighTobeLessThanAsString, tailHighToBeGreaterThanAsString))
            {
                return csvTableData;
            }

            int TailHighToBeGreaterThan;
            int tailHighToBelessThan;
            if (onlyDataForGreaterThan(tailHighTobeLessThanAsString, tailHighToBeGreaterThanAsString))
            {
                TailHighToBeGreaterThan = Convert.ToInt32(tailHighToBeGreaterThanAsString);
                return csvTableData.Where(x => x.tail_high > TailHighToBeGreaterThan);
            }

            if (onlyDataForLessThan(tailHighTobeLessThanAsString, tailHighToBeGreaterThanAsString))
            {
                tailHighToBelessThan = Convert.ToInt32(tailHighTobeLessThanAsString);
                return csvTableData.Where(x => x.tail_high < tailHighToBelessThan);
            }

            TailHighToBeGreaterThan = Convert.ToInt32(tailHighToBeGreaterThanAsString);
            tailHighToBelessThan = Convert.ToInt32(tailHighTobeLessThanAsString);
            return csvTableData.Where(x => x.tail_high < tailHighToBelessThan && x.tail_high > TailHighToBeGreaterThan);
        }

        private bool onlyDataForLessThan(string lessThanString, string greaterThanString)
        {
            return String.IsNullOrWhiteSpace(greaterThanString) && !String.IsNullOrWhiteSpace(lessThanString);
        }

        private bool onlyDataForGreaterThan(string lessThanString, string greaterThanString)
        {
            return !String.IsNullOrWhiteSpace(greaterThanString) && String.IsNullOrWhiteSpace(lessThanString);
        }

        public IQueryable<csvWithData> tailLowFilter(IQueryable<csvWithData> csvTableData,
            string tailLowTobeLessThanAsString, string tailLowToBeGreaterThanAsString)
        {

            if (isValidData(tailLowTobeLessThanAsString, tailLowToBeGreaterThanAsString))
            {
                return csvTableData;
            }

            int TailLowToBeGreaterThan;
            int tailLowToBelessThan;

            if (onlyDataForGreaterThan(tailLowTobeLessThanAsString, tailLowToBeGreaterThanAsString))
            {
                TailLowToBeGreaterThan = Convert.ToInt32(tailLowToBeGreaterThanAsString);
                return csvTableData.Where(x => x.tail_low > TailLowToBeGreaterThan);
            }

            if (onlyDataForLessThan(tailLowTobeLessThanAsString, tailLowToBeGreaterThanAsString))
            {
                tailLowToBelessThan = Convert.ToInt32(tailLowTobeLessThanAsString);
                return csvTableData.Where(x => x.tail_low < tailLowToBelessThan);
            }

            TailLowToBeGreaterThan = Convert.ToInt32(tailLowToBeGreaterThanAsString);
            tailLowToBelessThan = Convert.ToInt32(tailLowTobeLessThanAsString);
            return csvTableData.Where(x => x.tail_low < tailLowToBelessThan && x.tail_low > TailLowToBeGreaterThan);
        }

        public IQueryable<csvWithData> earHighFilter(IQueryable<csvWithData> csvTableData,
            string earHighTobeLessThanAsString, string earHighToBeGreaterThanAsString)
        {

            if (isValidData(earHighTobeLessThanAsString, earHighToBeGreaterThanAsString))
            {
                return csvTableData;
            }

            int earHighToBeGreaterThan;
            int earHighToBelessThan;

            if (onlyDataForGreaterThan(earHighTobeLessThanAsString, earHighToBeGreaterThanAsString))
            {
                earHighToBeGreaterThan = Convert.ToInt32(earHighToBeGreaterThanAsString);
                return csvTableData.Where(x => x.ear_high > earHighToBeGreaterThan);
            }

            if (onlyDataForLessThan(earHighTobeLessThanAsString, earHighToBeGreaterThanAsString))
            {
                earHighToBelessThan = Convert.ToInt32(earHighTobeLessThanAsString);
                return csvTableData.Where(x => x.ear_high < earHighToBelessThan);
            }

            earHighToBeGreaterThan = Convert.ToInt32(earHighToBeGreaterThanAsString);
            earHighToBelessThan = Convert.ToInt32(earHighTobeLessThanAsString);
            return csvTableData.Where(x => x.ear_high < earHighToBelessThan && x.ear_high > earHighToBeGreaterThan);
        }

        public IQueryable<csvWithData> earLowFilter(IQueryable<csvWithData> csvTableData,
            string earLowTobeLessThanAsString, string earLowToBeGreaterThanAsString)
        {
            if (isValidData(earLowTobeLessThanAsString, earLowToBeGreaterThanAsString))
            {
                return csvTableData;
            }

            int earLowToBeGreaterThan;
            int earLowToBelessThan;

            if (onlyDataForGreaterThan(earLowTobeLessThanAsString, earLowToBeGreaterThanAsString))
            {
                earLowToBeGreaterThan = Convert.ToInt32(earLowToBeGreaterThanAsString);
                return csvTableData.Where(x => x.ear_low > earLowToBeGreaterThan);
            }

            if (onlyDataForLessThan(earLowTobeLessThanAsString, earLowToBeGreaterThanAsString))
            {
                earLowToBelessThan = Convert.ToInt32(earLowTobeLessThanAsString);
                return csvTableData.Where(x => x.ear_low < earLowToBelessThan);
            }

            earLowToBeGreaterThan = Convert.ToInt32(earLowToBeGreaterThanAsString);
            earLowToBelessThan = Convert.ToInt32(earLowTobeLessThanAsString);
            return csvTableData.Where(x => x.ear_low < earLowToBelessThan && x.ear_low > earLowToBeGreaterThan);
        }

        public IQueryable<csvWithData> noseHighFilter(IQueryable<csvWithData> csvTableData,
            string noseHighTobeLessThanAsString, string noseHighToBeGreaterThanAsString)
        {
            if (isValidData(noseHighTobeLessThanAsString, noseHighToBeGreaterThanAsString))
            {
                return csvTableData;
            }

            int noseHighToBeGreaterThan;
            int noseHighToBelessThan;

            if (onlyDataForGreaterThan(noseHighTobeLessThanAsString, noseHighToBeGreaterThanAsString))
            {
                noseHighToBeGreaterThan = Convert.ToInt32(noseHighToBeGreaterThanAsString);
                return csvTableData.Where(x => x.nose_high > noseHighToBeGreaterThan);
            }

            if (onlyDataForLessThan(noseHighTobeLessThanAsString, noseHighToBeGreaterThanAsString))
            {
                noseHighToBelessThan = Convert.ToInt32(noseHighTobeLessThanAsString);
                return csvTableData.Where(x => x.nose_high < noseHighToBelessThan);
            }

            noseHighToBeGreaterThan = Convert.ToInt32(noseHighToBeGreaterThanAsString);
            noseHighToBelessThan = Convert.ToInt32(noseHighTobeLessThanAsString);
            return csvTableData.Where(x => x.nose_high < noseHighToBelessThan && x.nose_high > noseHighToBeGreaterThan);
        }

        public IQueryable<csvWithData> noseLowFilter(IQueryable<csvWithData> csvTableData,
            string noseLowTobeLessThanAsString, string noseLowToBeGreaterThanAsString)
        {
            if (isValidData(noseLowTobeLessThanAsString, noseLowToBeGreaterThanAsString))
            {
                return csvTableData;
            }

            int noseLowToBeGreaterThan;
            int noseLowToBelessThan;

            if (onlyDataForGreaterThan(noseLowTobeLessThanAsString, noseLowToBeGreaterThanAsString))
            {
                noseLowToBeGreaterThan = Convert.ToInt32(noseLowToBeGreaterThanAsString);
                return csvTableData.Where(x => x.nose_low > noseLowToBeGreaterThan);
            }

            if (onlyDataForLessThan(noseLowTobeLessThanAsString, noseLowToBeGreaterThanAsString))
            {
                noseLowToBelessThan = Convert.ToInt32(noseLowTobeLessThanAsString);
                return csvTableData.Where(x => x.nose_low < noseLowToBelessThan);
            }

            noseLowToBeGreaterThan = Convert.ToInt32(noseLowToBeGreaterThanAsString);
            noseLowToBelessThan = Convert.ToInt32(noseLowTobeLessThanAsString);
            return csvTableData.Where(x => x.nose_low < noseLowToBelessThan && x.nose_low > noseLowToBeGreaterThan);
        }

        private bool isValidData(string lessThanString, string greaterThanString)
        {
            int intToBelessThan;
            int intToBeGreaterThan;
            return !Int32.TryParse(lessThanString, out intToBelessThan) && !Int32.TryParse(greaterThanString, out intToBeGreaterThan);
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
