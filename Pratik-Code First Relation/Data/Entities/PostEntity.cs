using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pratik_Code_First_Relation.Data.Entities
{
    public class PostEntity
    {
        [Key] // Id'yi birincil anahtar olarak belirliyoruz
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Otomatik artan olarak ayarlıyoruz
        public int Id { get; set; }

        [Required] // Boş olamaz
        [StringLength(50)] // en fazla 50 karakter
        public string Title { get; set; }

        [Required] //boş olamaz
        [StringLength(200)] //en fazla 200 karakter
        public string Content { get; set; }

        //her post yalnızca bir kullanıcı tarafından atılmıştır.
        public int UserId { get; set; }


        public UserEntity User { get; set; }
    }
}
