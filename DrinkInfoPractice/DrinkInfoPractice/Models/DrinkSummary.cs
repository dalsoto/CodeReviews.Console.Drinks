﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DrinkInfoPractice.Models
{
    internal class DrinkSummary
    {
        [JsonPropertyName("idDrink")]
        public string IdDrink { get; set; }

        [JsonPropertyName("strDrink")]
        public string StrDrink { get; set; }

        [JsonPropertyName("strDrinkThumb")]
        public string StrDrinkThumb { get; set; }
    }
}
