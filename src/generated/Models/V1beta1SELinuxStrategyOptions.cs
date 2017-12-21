// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SELinux  Strategy Options defines the strategy type and any options
    /// used to create the strategy.
    /// </summary>
    public partial class V1beta1SELinuxStrategyOptions
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1SELinuxStrategyOptions
        /// class.
        /// </summary>
        public V1beta1SELinuxStrategyOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1SELinuxStrategyOptions
        /// class.
        /// </summary>
        /// <param name="rule">type is the strategy that will dictate the
        /// allowable labels that may be set.</param>
        /// <param name="seLinuxOptions">seLinuxOptions required to run as;
        /// required for MustRunAs More info:
        /// https://git.k8s.io/community/contributors/design-proposals/security_context.md</param>
        public V1beta1SELinuxStrategyOptions(string rule, V1SELinuxOptions seLinuxOptions = default(V1SELinuxOptions))
        {
            Rule = rule;
            SeLinuxOptions = seLinuxOptions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type is the strategy that will dictate the allowable
        /// labels that may be set.
        /// </summary>
        [JsonProperty(PropertyName = "rule")]
        public string Rule { get; set; }

        /// <summary>
        /// Gets or sets seLinuxOptions required to run as; required for
        /// MustRunAs More info:
        /// https://git.k8s.io/community/contributors/design-proposals/security_context.md
        /// </summary>
        [JsonProperty(PropertyName = "seLinuxOptions")]
        public V1SELinuxOptions SeLinuxOptions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Rule == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Rule");
            }
        }
    }
}