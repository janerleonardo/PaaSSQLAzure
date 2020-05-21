using System.ComponentModel.DataAnnotations;
namespace WebApiSQLAzure.Models
{
    public class Contacts
    {
       [Required]
        public string Id { get; set; }
        public string Nombre { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [StringLength(10)]
        public string telefono { get; set; }

    }
}