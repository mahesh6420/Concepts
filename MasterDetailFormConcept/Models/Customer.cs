using System.ComponentModel.DataAnnotations;

namespace MasterDetailFormConcept.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public CustomerAddress CustomerAddress { get; set; }
    }
}