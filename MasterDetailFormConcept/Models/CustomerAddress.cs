using System.ComponentModel.DataAnnotations;

namespace MasterDetailFormConcept.Models
{
    public class CustomerAddress
    {
        [Key]
        public int? Id { get; set; }
        public int? CustomerId { get; set; }
        public string PermanentToleName { get; set; }
        public int? PermanentWardNo { get; set; }
        public string TemporaryToleName { get; set; }
        public int? TemporaryWardNo { get; set; }
    }
}