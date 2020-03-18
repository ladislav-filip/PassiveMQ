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

    public partial class QueuCreateReqDto
    {
        /// <summary>
        /// Initializes a new instance of the QueuCreateReqDto class.
        /// </summary>
        public QueuCreateReqDto() { }

        /// <summary>
        /// Initializes a new instance of the QueuCreateReqDto class.
        /// </summary>
        public QueuCreateReqDto(string name, string topicPattern = default(string), string notificationAdress = default(string))
        {
            Name = name;
            TopicPattern = topicPattern;
            NotificationAdress = notificationAdress;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "topicPattern")]
        public string TopicPattern { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "notificationAdress")]
        public string NotificationAdress { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (this.TopicPattern != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(this.TopicPattern, "(/[A-Za-z0-9_]+)+"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "TopicPattern", "(/[A-Za-z0-9_]+)+");
                }
            }
        }
    }
}