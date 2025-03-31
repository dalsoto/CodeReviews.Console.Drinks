using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DrinkInfoPractice.Models
{
    internal class DrinkCategory
    {
        [JsonPropertyName("strCategory")]
        public string StrCategory { get; set; }
    }
}
