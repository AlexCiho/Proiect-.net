//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System.Runtime.Serialization;

    [DataContract(IsReference = true)]
    public partial class Properties
    {

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Property_name { get; set; }

        [DataMember]
        public string Property_desc { get; set; }

        [DataMember]
        public int PhotosId { get; set; }

        [DataMember]
        public virtual Photos Photo { get; set; }
    }
}
