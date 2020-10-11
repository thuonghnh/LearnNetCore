﻿using LearnNetCore.Data.Enums;
using LearnNetCore.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LearnNetCore.Data.Entities
{
    [Table("ContactDetails")]
    public class Contact:DomainEntity<string>
    {
        [StringLength(250)]
        [Required]
        public string Name { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(250)]
        public string Email { get; set; }
        [StringLength(250)]
        public string Website { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        public string Other { get; set; }
        public double? Lat { get; set; }//giup hien thi ban do toa do: lat lng
        public double? Lng { get; set; }
        public Status Status { get; set; }

    }
}
