using System;

namespace DogDataFilterToCsv.Models
{
    public interface IVersionAgnostic
    {
        int ear_high { get; set; }
        int ear_low { get; set; }
        int id { get; set; }
        string name { get; set; }
        int nose_high { get; set; }
        int nose_low { get; set; }
        int tail_high { get; set; }
        int tail_low { get; set; }
        DateTime time_stamp { get; set; }
    }
}