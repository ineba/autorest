// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AdditionalProperties.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class Feature
    {
        /// <summary>
        /// Initializes a new instance of the Feature class.
        /// </summary>
        public Feature() { }

        /// <summary>
        /// Initializes a new instance of the Feature class.
        /// </summary>
        public Feature(string foo = default(string), int? bar = default(int?))
        {
            Foo = foo;
            Bar = bar;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "foo")]
        public string Foo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bar")]
        public int? Bar { get; set; }

    }
}