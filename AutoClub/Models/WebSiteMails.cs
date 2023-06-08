using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.Models
{
    public class WebSiteMails
    {
        public int Id { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email1 { get; set; }
        public string Email1Password { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email2 { get; set; }
        public string Email2Password { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email3 { get; set; }
        public string Email3Password { get; set; }
    }
}
