// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.Gateway.Automation.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ApiKeyListModel
    {
        /// <summary>
        /// Initializes a new instance of the ApiKeyListModel class.
        /// </summary>
        public ApiKeyListModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiKeyListModel class.
        /// </summary>
        /// <param name="state">Possible values include: 'Suspended', 'Active',
        /// 'Expired', 'Submitted', 'Rejected', 'Cancelled'</param>
        /// <param name="synchronization">Possible values include: 'Pending',
        /// 'Active', 'Faulted'</param>
        public ApiKeyListModel(System.Guid? id = default(System.Guid?), System.Guid? subscriptionId = default(System.Guid?), System.Guid? productId = default(System.Guid?), string name = default(string), string primaryKey = default(string), string secondaryKey = default(string), string state = default(string), string stateComment = default(string), string requesterName = default(string), string requesterPhoneNumber = default(string), string requesterEmail = default(string), string requesterIntent = default(string), string synchronization = default(string), System.Guid? clientCredentialId = default(System.Guid?), System.DateTime? requestDate = default(System.DateTime?), bool? allowTracing = default(bool?))
        {
            Id = id;
            SubscriptionId = subscriptionId;
            ProductId = productId;
            Name = name;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            State = state;
            StateComment = stateComment;
            RequesterName = requesterName;
            RequesterPhoneNumber = requesterPhoneNumber;
            RequesterEmail = requesterEmail;
            RequesterIntent = requesterIntent;
            Synchronization = synchronization;
            ClientCredentialId = clientCredentialId;
            RequestDate = requestDate;
            AllowTracing = allowTracing;
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
        [JsonProperty(PropertyName = "subscriptionId")]
        public System.Guid? SubscriptionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productId")]
        public System.Guid? ProductId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryKey")]
        public string PrimaryKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "secondaryKey")]
        public string SecondaryKey { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Suspended', 'Active',
        /// 'Expired', 'Submitted', 'Rejected', 'Cancelled'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stateComment")]
        public string StateComment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requesterName")]
        public string RequesterName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requesterPhoneNumber")]
        public string RequesterPhoneNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requesterEmail")]
        public string RequesterEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requesterIntent")]
        public string RequesterIntent { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Pending', 'Active',
        /// 'Faulted'
        /// </summary>
        [JsonProperty(PropertyName = "synchronization")]
        public string Synchronization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clientCredentialId")]
        public System.Guid? ClientCredentialId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requestDate")]
        public System.DateTime? RequestDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allowTracing")]
        public bool? AllowTracing { get; set; }

    }
}
