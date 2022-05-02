using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_pessoal.src.modelos
    {
    public class PostagemModelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(100)]
        public string Descricao { get; set; }

        public string Foto { get; set; }

        [ForeignKey("fk_usuario")]
        public UsuarioModelo  Criador { get; set; }

        [ForeignKey("fk_tema")]
        public TemaModelo Tema { get; set; }
    }
}


