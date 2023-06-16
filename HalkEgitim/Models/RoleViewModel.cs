using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HalkEgitim.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="Role Adı Giriniz")]
        public string name { get; set; }
    }
}
