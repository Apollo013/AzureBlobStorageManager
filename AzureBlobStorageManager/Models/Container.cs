using System.ComponentModel.DataAnnotations;

namespace AzureBlobStorageManager.Models
{
    public class Container
    {
        [Required]
        public string Name { get; set; }
    }
}
