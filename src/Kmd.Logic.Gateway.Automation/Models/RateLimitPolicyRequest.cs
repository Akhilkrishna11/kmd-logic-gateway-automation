// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.Gateway.Automation.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RateLimitPolicyRequest
    {
        /// <summary>
        /// Initializes a new instance of the RateLimitPolicyRequest class.
        /// </summary>
        public RateLimitPolicyRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RateLimitPolicyRequest class.
        /// </summary>
        /// <param name="entityType">Possible values include: 'Product',
        /// 'Api'</param>
        public RateLimitPolicyRequest(string name, System.Guid? entityId = default(System.Guid?), string entityType = default(string), string description = default(string), int? calls = default(int?), int? renewalPeriod = default(int?))
        {
            EntityId = entityId;
            EntityType = entityType;
            Name = name;
            Description = description;
            Calls = calls;
            RenewalPeriod = renewalPeriod;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

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
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calls")]
        public int? Calls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "renewalPeriod")]
        public int? RenewalPeriod { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Calls != null)
            {
                if (Calls > 2147483647)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "Calls", 2147483647);
                }
                if (Calls < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "Calls", 1);
                }
            }
            if (RenewalPeriod != null)
            {
                if (RenewalPeriod > 300)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "RenewalPeriod", 300);
                }
                if (RenewalPeriod < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "RenewalPeriod", 1);
                }
            }
        }
    }
}
