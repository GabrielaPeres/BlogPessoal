﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Blog_pessoal.src.modelos
{
    [Table("tb_usuarios")]
    public class UsuarioModelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)] 
        public string Nome { get; set; }
       
        [Required]
        [StringLength(30)]
        public string Email { get; set; }
        
        [Required]
        [StringLength(30)]
        public string Senha { get; set; }
  
        public string Foto { get; set; }

        [JsonIgnore]
        public List<PostagemModelo>Postagens { get; set; }
     
    }


}
