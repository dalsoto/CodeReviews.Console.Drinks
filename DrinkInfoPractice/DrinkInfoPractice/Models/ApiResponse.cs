using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DrinkInfoPractice.Models
{
    internal class ApiResponse<T>
    {
        [JsonPropertyName("drinks")]
        public List<T> Drinks { get; set; }
    }
}
