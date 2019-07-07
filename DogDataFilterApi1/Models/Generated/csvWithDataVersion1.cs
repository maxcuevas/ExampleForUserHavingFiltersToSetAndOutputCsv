namespace DogDataFilterApi.Models.Generated
{
    using DogDataFilterToCsv.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class csvWithDataVersion1 : IVersionAgnostic
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public int tail_high { get; set; }

        public int tail_low { get; set; }

        public int ear_high { get; set; }

        public int ear_low { get; set; }

        public int nose_high { get; set; }

        public int nose_low { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime time_stamp { get; set; }

        public double latitude { get; set; }

        public double longitude { get; set; }

        public int only_in_version_1 { get; set; }
    }
}