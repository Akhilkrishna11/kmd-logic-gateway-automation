// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.Gateway.Automation.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PolicyModel
    {
        /// <summary>
        /// Initializes a new instance of the PolicyModel class.
        /// </summary>
        public PolicyModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PolicyModel class.
        /// </summary>
        /// <param name="entityType">Possible values include: 'Product',
        /// 'Api'</param>
        /// <param name="channel">Possible values include: 'Inbound',
        /// 'Backend', 'Outbound', 'Onerror'</param>
        /// <param name="synchronization">Possible values include: 'Pending',
        /// 'Active', 'Faulted'</param>
        /// <param name="policyType">Possible values include: 'RateLimit',
        /// 'SetHeader', 'Custom'</param>
        public PolicyModel(System.Guid? id = default(System.Guid?), System.Guid? entityId = default(System.Guid?), string entityType = default(string), string channel = default(string), string name = default(string), string description = default(string), string synchronization = default(string), string policyType = default(string))
        {
            Id = id;
            EntityId = entityId;
            EntityType = entityType;
            Channel = channel;
            Name = name;
            Description = description;
            Synchronization = synchronization;
            PolicyType = policyType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityId")]
        public System.Guid? EntityId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Product', 'Api'
        /// </summary>
        [JsonProperty(PropertyName = "entityType")]
        public string EntityType { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Inbound', 'Backend',
        /// 'Outbound', 'Onerror'
        /// </summary>
        [JsonProperty(PropertyName = "channel")]
        public string Channel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Pending', 'Active',
        /// 'Faulted'
        /// </summary>
        [JsonProperty(PropertyName = "synchronization")]
        public string Synchronization { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'RateLimit', 'SetHeader',
        /// 'Custom'
        /// </summary>
        [JsonProperty(PropertyName = "policyType")]
        public string PolicyType { get; set; }

    }
}
