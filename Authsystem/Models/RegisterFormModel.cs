using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Authsystem.Models
{
    public class RegisterFormModel
    {
        [Key]
        public string SteamId { get; set; }

        public string School{ get; set; }
        public string TeachersEmail { get; set; }

    public string Team { get; set; }
    public string Rank { get; set; }

     

        
    }

}

