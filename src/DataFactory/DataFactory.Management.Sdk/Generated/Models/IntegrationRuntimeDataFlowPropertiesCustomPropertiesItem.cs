// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    public partial class IntegrationRuntimeDataFlowPropertiesCustomPropertiesItem
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationRuntimeDataFlowPropertiesCustomPropertiesItem class.
        /// </summary>
        public IntegrationRuntimeDataFlowPropertiesCustomPropertiesItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntegrationRuntimeDataFlowPropertiesCustomPropertiesItem class.
        /// </summary>

        /// <param name="name">Name of custom property.
        /// </param>

        /// <param name="value">Value of custom property.
        /// </param>
        public IntegrationRuntimeDataFlowPropertiesCustomPropertiesItem(string name = default(string), string value = default(string))

        {
            this.Name = name;
            this.Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets name of custom property.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets or sets value of custom property.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public string Value {get; set; }
    }
}