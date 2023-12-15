using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Assessment_C_Sharp.Models {
    public class Pokemon {

        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "O Nome do pokemon não pode ficar em branco!")]
        [DisplayName("Nome do Pokemon")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Tipo do pokemon não pode ficar em branco!")]
        [DisplayName("Tipo do Pokemon")]
        public string Tipo { get; set; }


        [Required(ErrorMessage = "A Fraqueza do pokemon não pode ficar em branco!")]

        [DisplayName("Fraqueza do Pokemon")]
        public string Fraqueza { get; set; }


        [DisplayName("Altura do Pokemon")]
        public string Altura { get; set; }
                
        public DateTime dataCriacao { get; set; }

        [Required(ErrorMessage = "O Peso do pokemon não pode ficar em branco!")]
        public string Peso { get; set; }

    }
}
