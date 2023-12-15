using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Assessment_C_Sharp.Models {
    public class Lendarios {

        [Key]
        public int ID { get; set; }


        [Required(ErrorMessage = "O Nome do pokemon não pode ficar em branco!")]
        [DisplayName("Nome do Lendário")]
        [MaxLength(20)]
        public string Nome { get; set; }



        [Required(ErrorMessage = "O Tipo do pokemon não pode ficar em branco!")]
        [MaxLength(15)]
        public string Tipo { get; set; }



    }
}
