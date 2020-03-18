﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Harrison314.PassiveMQ.Client.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class ExchangeModel
    {
        /// <summary>
        /// Initializes a new instance of the ExchangeModel class.
        /// </summary>
        public ExchangeModel() { }

        /// <summary>
        /// Initializes a new instance of the ExchangeModel class.
        /// </summary>
        public ExchangeModel(int? nextVisibleInMs = default(int?))
        {
            NextVisibleInMs = nextVisibleInMs;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nextVisibleInMs")]
        public int? NextVisibleInMs { get; set; }

    }
}
