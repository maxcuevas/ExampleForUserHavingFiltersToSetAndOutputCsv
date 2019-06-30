using DogDataFilterApi.Models;
using DogDataFilterToCsv.Models;
using System;
using System.Linq;

namespace DogDataFilterApi
{
    class Builder
    {

        public Builder()
        {

        }

        public IQueryable<IVersionAgnostic> tailHighFilter(IQueryable<IVersionAgnostic> csvTableData, LessThanAndGreaterThanStrings lessThanAndGreaterThanStrings)
        {
            if (isValidData(lessThanAndGreaterThanStrings.lessThan, lessThanAndGreaterThanStrings.greaterThan))
            {
                return csvTableData;
            }

            int tailHighToBeGreaterThan;
            int tailHighToBelessThan;

            if (onlyDataForGreaterThan(lessThanAndGreaterThanStrings.lessThan, lessThanAndGreaterThanStrings.greaterThan))
            {
                tailHighToBeGreaterThan = Convert.ToInt32(lessThanAndGreaterThanStrings.greaterThan);
                return csvTableData.Where(x => x.tail_high > tailHighToBeGreaterThan);
            } 

            if (onlyDataForLessThan(lessThanAndGreaterThanStrings.lessThan, lessThanAndGreaterThanStrings.greaterThan))
            {
                tailHighToBelessThan = Convert.ToInt32(lessThanAndGreaterThanStrings.lessThan);
                return csvTableData.Where(x => x.tail_high < tailHighToBelessThan);
            }
            tailHighToBeGreaterThan = Convert.ToInt32(lessThanAndGreaterThanStrings.greaterThan);
            tailHighToBelessThan = Convert.ToInt32(lessThanAndGreaterThanStrings.lessThan);
            return csvTableData.Where(x => x.tail_high < tailHighToBelessThan && x.tail_high > tailHighToBeGreaterThan);
        }

        private bool onlyDataForLessThan(string lessThanString, string greaterThanString)
        {
            return String.IsNullOrWhiteSpace(greaterThanString) && !String.IsNullOrWhiteSpace(lessThanString);
        }

        private bool onlyDataForGreaterThan(string lessThanString, string greaterThanString)
        {
            return !String.IsNullOrWhiteSpace(greaterThanString) && String.IsNullOrWhiteSpace(lessThanString);
        }

        public IQueryable<IVersionAgnostic> tailLowFilter(IQueryable<IVersionAgnostic> csvTableData, LessThanAndGreaterThanStrings lessThanAndGreaterThanStrings)
        {
            if (isValidData(lessThanAndGreaterThanStrings.lessThan, lessThanAndGreaterThanStrings.greaterThan))
            {
                return csvTableData;
            }

            int TailLowToBeGreaterThan;
            int tailLowToBelessThan;

            if (onlyDataForGreaterThan(lessThanAndGreaterThanStrings.lessThan, lessThanAndGreaterThanStrings.greaterThan))
            {
                TailLowToBeGreaterThan = Convert.ToInt32(lessThanAndGreaterThanStrings.greaterThan);
                return csvTableData.Where(x => x.tail_low > TailLowToBeGreaterThan);
            }

            if (onlyDataForLessThan(lessThanAndGreaterThanStrings.lessThan, lessThanAndGreaterThanStrings.greaterThan))
            {
                tailLowToBelessThan = Convert.ToInt32(lessThanAndGreaterThanStrings.lessThan);
                return csvTableData.Where(x => x.tail_low < tailLowToBelessThan);
            }

            TailLowToBeGreaterThan = Convert.ToInt32(lessThanAndGreaterThanStrings.greaterThan);
            tailLowToBelessThan = Convert.ToInt32(lessThanAndGreaterThanStrings.lessThan);
            return csvTableData.Where(x => x.tail_low < tailLowToBelessThan && x.tail_low > TailLowToBeGreaterThan);
        }

        public IQueryable<IVersionAgnostic> earHighFilter(IQueryable<IVersionAgnostic> csvTableData
            , LessThanAndGreaterThanStrings lessThanAndGreaterThanStrings)
        {

            if (isValidData(lessThanAndGreaterThanStrings.lessThan, lessThanAndGreaterThanStrings.greaterThan))
            {
                return csvTableData;
            }

            int earHighToBeGreaterThan;
            int earHighToBelessThan;

            if (onlyDataForGreaterThan(lessThanAndGreaterThanStrings.lessThan, lessThanAndGreaterThanStrings.greaterThan))
            {
                earHighToBeGreaterThan = Convert.ToInt32(lessThanAndGreaterThanStrings.greaterThan);
                return csvTableData.Where(x => x.ear_high > earHighToBeGreaterThan);
            }

            if (onlyDataForLessThan(lessThanAndGreaterThanStrings.lessThan, lessThanAndGreaterThanStrings.greaterThan))
            {
                earHighToBelessThan = Convert.ToInt32(lessThanAndGreaterThanStrings.lessThan);
                return csvTableData.Where(x => x.ear_high < earHighToBelessThan);
            }

            earHighToBeGreaterThan = Convert.ToInt32(lessThanAndGreaterThanStrings.greaterThan);
            earHighToBelessThan = Convert.ToInt32(lessThanAndGreaterThanStrings.lessThan);
            return csvTableData.Where(x => x.ear_high < earHighToBelessThan && x.ear_high > earHighToBeGreaterThan);
        }

        public IQueryable<IVersionAgnostic> earLowFilter(IQueryable<IVersionAgnostic> csvTableData, LessThanAndGreaterThanStrings lessThanAndGreaterThanStrings)
        {
            if (isValidData(lessThanAndGreaterThanStrings.lessThan, lessThanAndGreaterThanStrings.greaterThan))
            {
                return csvTableData;
            }

            int earLowToBeGreaterThan;
            int earLowToBelessThan;

            if (onlyDataForGreaterThan(lessThanAndGreaterThanStrings.lessThan, lessThanAndGreaterThanStrings.greaterThan))
            {
                earLowToBeGreaterThan = Convert.ToInt32(lessThanAndGreaterThanStrings.greaterThan);
                return csvTableData.Where(x => x.ear_low > earLowToBeGreaterThan);
            }

            if (onlyDataForLessThan(lessThanAndGreaterThanStrings.lessThan, lessThanAndGreaterThanStrings.greaterThan))
            {
                earLowToBelessThan = Convert.ToInt32(lessThanAndGreaterThanStrings.lessThan);
                return csvTableData.Where(x => x.ear_low < earLowToBelessThan);
            }

            earLowToBeGreaterThan = Convert.ToInt32(lessThanAndGreaterThanStrings.greaterThan);
            earLowToBelessThan = Convert.ToInt32(lessThanAndGreaterThanStrings.lessThan);
            return csvTableData.Where(x => x.ear_low < earLowToBelessThan && x.ear_low > earLowToBeGreaterThan);
        }

        public IQueryable<IVersionAgnostic> noseHighFilter(IQueryable<IVersionAgnostic> csvTableData, LessThanAndGreaterThanStrings lessThanAndGreaterThanStrings)
        {
            if (isValidData(lessThanAndGreaterThanStrings.lessThan, lessThanAndGreaterThanStrings.greaterThan))
            {
                return csvTableData;
            }

            int noseHighToBeGreaterThan;
            int noseHighToBelessThan;

            if (onlyDataForGreaterThan(lessThanAndGreaterThanStrings.lessThan, lessThanAndGreaterThanStrings.greaterThan))
            {
                noseHighToBeGreaterThan = Convert.ToInt32(lessThanAndGreaterThanStrings.greaterThan);
                return csvTableData.Where(x => x.nose_high > noseHighToBeGreaterThan);
            }

            if (onlyDataForLessThan(lessThanAndGreaterThanStrings.lessThan, lessThanAndGreaterThanStrings.greaterThan))
            {
                noseHighToBelessThan = Convert.ToInt32(lessThanAndGreaterThanStrings.lessThan);
                return csvTableData.Where(x => x.nose_high < noseHighToBelessThan);
            }

            noseHighToBeGreaterThan = Convert.ToInt32(lessThanAndGreaterThanStrings.greaterThan);
            noseHighToBelessThan = Convert.ToInt32(lessThanAndGreaterThanStrings.lessThan);
            return csvTableData.Where(x => x.nose_high < noseHighToBelessThan && x.nose_high > noseHighToBeGreaterThan);
        }

        public IQueryable<IVersionAgnostic> noseLowFilter(IQueryable<IVersionAgnostic> csvTableData, LessThanAndGreaterThanStrings lessThanAndGreaterThanStrings)
        {
            if (isValidData(lessThanAndGreaterThanStrings.lessThan, lessThanAndGreaterThanStrings.greaterThan))
            {
                return csvTableData;
            }

            int noseLowToBeGreaterThan;
            int noseLowToBelessThan;

            if (onlyDataForGreaterThan(lessThanAndGreaterThanStrings.lessThan, lessThanAndGreaterThanStrings.greaterThan))
            {
                noseLowToBeGreaterThan = Convert.ToInt32(lessThanAndGreaterThanStrings.greaterThan);
                return csvTableData.Where(x => x.nose_low > noseLowToBeGreaterThan);
            }

            if (onlyDataForLessThan(lessThanAndGreaterThanStrings.lessThan, lessThanAndGreaterThanStrings.greaterThan))
            {
                noseLowToBelessThan = Convert.ToInt32(lessThanAndGreaterThanStrings.lessThan);
                return csvTableData.Where(x => x.nose_low < noseLowToBelessThan);
            }

            noseLowToBeGreaterThan = Convert.ToInt32(lessThanAndGreaterThanStrings.greaterThan);
            noseLowToBelessThan = Convert.ToInt32(lessThanAndGreaterThanStrings.lessThan);
            return csvTableData.Where(x => x.nose_low < noseLowToBelessThan && x.nose_low > noseLowToBeGreaterThan);
        }

        public IQueryable<IVersionAgnostic> DateFilter(IQueryable<IVersionAgnostic> csvTableData,
           DateAndTime dateAndTime)
        {
            if (dateAndTime.lessThanThis == null && dateAndTime.greaterThanThis == null)
            {
                return csvTableData;
            }

            if (dateAndTime.lessThanThis == null && dateAndTime.greaterThanThis != null)
            {
                return csvTableData.Where(x => x.time_stamp > dateAndTime.greaterThanThis);
            }

            if (dateAndTime.lessThanThis != null && dateAndTime.greaterThanThis == null)
            {
                return csvTableData.Where(x => x.time_stamp < dateAndTime.lessThanThis);
            }

            return csvTableData.Where(x => x.time_stamp < dateAndTime.lessThanThis && x.time_stamp > dateAndTime.greaterThanThis);
        }

        private bool isValidData(string lessThanString, string greaterThanString)
        {
            return !Int32.TryParse(lessThanString, out int intToBelessThan) && !Int32.TryParse(greaterThanString, out int intToBeGreaterThan);
        }

        public IQueryable<IVersionAgnostic> addNameFilter(IQueryable<IVersionAgnostic> csvTableData, string containsThisString)
        {
            if (String.IsNullOrWhiteSpace(containsThisString))
            {
                return csvTableData;
            }
            return csvTableData.Where(x => x.name.Contains(containsThisString));
        }
    }
}
