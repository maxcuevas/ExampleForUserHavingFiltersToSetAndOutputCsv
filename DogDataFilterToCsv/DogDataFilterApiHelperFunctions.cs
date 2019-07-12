using DogDataFilterApi;
using DogDataFilterApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace DogDataFilterToCsv
{
    class DogDataFilterApiHelperFunctions
    {

        public DateAndTime getDateAndTimeData(DateTime DateLessThanThisDatePicker, DateTime DateGreaterThanThisDatePicker)
        {
            return new DateAndTime(DateLessThanThisDatePicker, DateGreaterThanThisDatePicker);
        }

        public Ear getEarData(string EarHighLessThanThisTextBox, string EarHighGreaterThanThisTextBox, string EarLowLessThanThisTextBox, string EarLowGreaterThanThisTextBox )
        {
            return new Ear(EarHighLessThanThisTextBox, EarHighGreaterThanThisTextBox,
                             EarLowLessThanThisTextBox, EarLowGreaterThanThisTextBox);
        }

        public Tail getTailData(string TailHighLessThanThisTextBox, string TailHighGreaterThanThisTextBox, string TailLowLessThanThisTextBox, string TailLowGreaterThanThisTextBox)
        {
            return new Tail(TailHighLessThanThisTextBox, TailHighGreaterThanThisTextBox,
                             TailLowLessThanThisTextBox, TailLowGreaterThanThisTextBox);
        }

        public Nose getNoseData(string NoseHighLessThanThisTextBox, string NoseHighGreaterThanThisTextBox, string NoseLowLessThanThisTextBox, string NoseLowGreaterThanThisTextBox)
        {
            return new Nose(NoseHighLessThanThisTextBox, NoseHighGreaterThanThisTextBox,
                             NoseLowLessThanThisTextBox, NoseLowGreaterThanThisTextBox);
        }

        public GeoLocationData getLongitudeData(string longitudeTextBox, string distanceFromLongitudeTextBox)
        {
            return new GeoLocationData(longitudeTextBox, distanceFromLongitudeTextBox);
        }

        public GeoLocationData getLatitudeData(string latitudeTextBox, string distanceFromLatitudeTextBox)
        {
            return new GeoLocationData(latitudeTextBox, distanceFromLatitudeTextBox);
        }

        public TableVersion.Value getTableVersionSelected(bool isChecked)
        {
            return isChecked ? TableVersion.Value.Version1 : TableVersion.Value.Version2;
        }
    }
}
