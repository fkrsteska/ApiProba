using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppWithApi.Models
{
    //[DataContract]
    public class Records
    {
        //[DataMember(Name = "id")]
       // public int id { get; set; }

        [DataMember(Name = "full_name")]
        public string full_name { get; set; }

       /* [DataMember(Name = "short_name")]
        public string short_name { get; set; }

        [DataMember(Name = "vid_ustanova")]
        public string vid_ustanova { get; set; }

        [DataMember(Name = "tip_ustanova")]
        public string tip_ustanova { get; set; }

        [DataMember(Name = "opstina")]
        public string opstina { get; set; }

        [DataMember(Name = "naseleno")]
        public string naseleno { get; set; }

        [DataMember(Name = "fzo_mreza")]
        public bool fzo_mreza { get; set; }

        [DataMember(Name = "address")]
        public string address { get; set; }

        [DataMember(Name = "email")]
        public string email { get; set; }

        [DataMember(Name = "phone_number")]
        public string phone_number { get; set; }

        [DataMember(Name = "is_insulin_pharmacy")]
        public bool is_insulin_pharmacy { get; set; }

        [DataMember(Name = "laboratory_level")]
        public int laboratory_level { get; set; }

        [DataMember(Name = "is_immunization_clinic")]
        public bool is_immunization_clinic { get; set; }

        [DataMember(Name = "is_active")]
        public bool is_active { get; set; }

        [DataMember(Name = "edk")]
        public long edk { get; set; }

        [DataMember(Name = "fzo_code")]
        public long fzo_code { get; set; }

    */

       // public override string ToString() => JsonSerializer.Serialize<UstanovaData>(this);
        
    }
}
