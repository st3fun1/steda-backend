using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Steda_backend.Models {

    // model = set of classes that represent the data the app
    // manages
    [Table("Photos")]
    public class Photo {

        [Column("PhotoID")]
        [Key]
        [Required]
        public int PhotoID {get; set;}

        [Column("Name")]
        [Required]
        [StringLength(100)]
        public string Name { get; set;}

        [Column("Description")]
        [StringLength(255)]
        public string Description {get; set;}

        [Column("Url")]
        [StringLength(500)]
        [Required]
        public string Url {get; set;}
    }
}