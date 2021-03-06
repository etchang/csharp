// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// CustomResourceDefinitionVersion describes a version for CRD.
    /// </summary>
    public partial class V1beta1CustomResourceDefinitionVersion
    {
        /// <summary>
        /// Initializes a new instance of the
        /// V1beta1CustomResourceDefinitionVersion class.
        /// </summary>
        public V1beta1CustomResourceDefinitionVersion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// V1beta1CustomResourceDefinitionVersion class.
        /// </summary>
        /// <param name="name">Name is the version name, e.g. “v1”, “v2beta1”,
        /// etc.</param>
        /// <param name="served">Served is a flag enabling/disabling this
        /// version from being served via REST APIs</param>
        /// <param name="storage">Storage flags the version as storage version.
        /// There must be exactly one flagged as storage version.</param>
        /// <param name="additionalPrinterColumns">AdditionalPrinterColumns are
        /// additional columns shown e.g. in kubectl next to the name. Defaults
        /// to a created-at column. Top-level and per-version columns are
        /// mutually exclusive. Per-version columns must not all be set to
        /// identical values (top-level columns should be used instead) This
        /// field is alpha-level and is only honored by servers that enable the
        /// CustomResourceWebhookConversion feature. NOTE: CRDs created prior
        /// to 1.13 populated the top-level additionalPrinterColumns field by
        /// default. To apply an update that changes to per-version
        /// additionalPrinterColumns, the top-level additionalPrinterColumns
        /// field must be explicitly set to null</param>
        /// <param name="schema">Schema describes the schema for CustomResource
        /// used in validation, pruning, and defaulting. Top-level and
        /// per-version schemas are mutually exclusive. Per-version schemas
        /// must not all be set to identical values (top-level validation
        /// schema should be used instead) This field is alpha-level and is
        /// only honored by servers that enable the
        /// CustomResourceWebhookConversion feature.</param>
        /// <param name="subresources">Subresources describes the subresources
        /// for CustomResource Top-level and per-version subresources are
        /// mutually exclusive. Per-version subresources must not all be set to
        /// identical values (top-level subresources should be used instead)
        /// This field is alpha-level and is only honored by servers that
        /// enable the CustomResourceWebhookConversion feature.</param>
        public V1beta1CustomResourceDefinitionVersion(string name, bool served, bool storage, IList<V1beta1CustomResourceColumnDefinition> additionalPrinterColumns = default(IList<V1beta1CustomResourceColumnDefinition>), V1beta1CustomResourceValidation schema = default(V1beta1CustomResourceValidation), V1beta1CustomResourceSubresources subresources = default(V1beta1CustomResourceSubresources))
        {
            AdditionalPrinterColumns = additionalPrinterColumns;
            Name = name;
            Schema = schema;
            Served = served;
            Storage = storage;
            Subresources = subresources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets additionalPrinterColumns are additional columns shown
        /// e.g. in kubectl next to the name. Defaults to a created-at column.
        /// Top-level and per-version columns are mutually exclusive.
        /// Per-version columns must not all be set to identical values
        /// (top-level columns should be used instead) This field is
        /// alpha-level and is only honored by servers that enable the
        /// CustomResourceWebhookConversion feature. NOTE: CRDs created prior
        /// to 1.13 populated the top-level additionalPrinterColumns field by
        /// default. To apply an update that changes to per-version
        /// additionalPrinterColumns, the top-level additionalPrinterColumns
        /// field must be explicitly set to null
        /// </summary>
        [JsonProperty(PropertyName = "additionalPrinterColumns")]
        public IList<V1beta1CustomResourceColumnDefinition> AdditionalPrinterColumns { get; set; }

        /// <summary>
        /// Gets or sets name is the version name, e.g. “v1”, “v2beta1”, etc.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets schema describes the schema for CustomResource used in
        /// validation, pruning, and defaulting. Top-level and per-version
        /// schemas are mutually exclusive. Per-version schemas must not all be
        /// set to identical values (top-level validation schema should be used
        /// instead) This field is alpha-level and is only honored by servers
        /// that enable the CustomResourceWebhookConversion feature.
        /// </summary>
        [JsonProperty(PropertyName = "schema")]
        public V1beta1CustomResourceValidation Schema { get; set; }

        /// <summary>
        /// Gets or sets served is a flag enabling/disabling this version from
        /// being served via REST APIs
        /// </summary>
        [JsonProperty(PropertyName = "served")]
        public bool Served { get; set; }

        /// <summary>
        /// Gets or sets storage flags the version as storage version. There
        /// must be exactly one flagged as storage version.
        /// </summary>
        [JsonProperty(PropertyName = "storage")]
        public bool Storage { get; set; }

        /// <summary>
        /// Gets or sets subresources describes the subresources for
        /// CustomResource Top-level and per-version subresources are mutually
        /// exclusive. Per-version subresources must not all be set to
        /// identical values (top-level subresources should be used instead)
        /// This field is alpha-level and is only honored by servers that
        /// enable the CustomResourceWebhookConversion feature.
        /// </summary>
        [JsonProperty(PropertyName = "subresources")]
        public V1beta1CustomResourceSubresources Subresources { get; set; }

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
            if (AdditionalPrinterColumns != null)
            {
                foreach (var element in AdditionalPrinterColumns)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Subresources != null)
            {
                Subresources.Validate();
            }
        }
    }
}
