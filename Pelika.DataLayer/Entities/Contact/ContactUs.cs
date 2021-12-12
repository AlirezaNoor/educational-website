using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pelika.DataLayer.Entities.Contact
{
    [Keyless]
    public class ContactUs
    {
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        public string Email { get; set; }

        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        public string Name { get; set; }
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        public string Massage { get; set; }
    }
}
