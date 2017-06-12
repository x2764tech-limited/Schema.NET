namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Aquarium.
    /// </summary>
    [DataContract]
    public class Aquarium : CivicStructure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Aquarium";
    }
}