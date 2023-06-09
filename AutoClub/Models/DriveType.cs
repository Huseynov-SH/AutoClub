﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.Models
{
    public class DriveType
    {
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string Name { get; set; }
    }
}
