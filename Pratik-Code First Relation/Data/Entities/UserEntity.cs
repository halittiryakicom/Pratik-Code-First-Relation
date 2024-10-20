using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pratik_Code_First_Relation.Data.Entities
{
    public class UserEntity
    {
        [Key] // Id'yi birincil anahtar olarak belirliyoruz
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Otomatik artan olarak ayarlıyoruz
        public int Id { get; set; }

        [Required] //boş geçilemez
        [StringLength(25)] // en fazla 25 karakter
        public string UserName { get; set; }

        [Required] //boş geçilemez
        [StringLength(50)] //en fazla 50 karakter
        public string Email { get; set; }

        //her kullanıcının birden fazla postu olabilir
        public List<PostEntity> Posts { get; set; }
    }
}
