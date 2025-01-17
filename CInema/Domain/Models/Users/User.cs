﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Domain.Models.Users
{
    [Table("USERS")]
    public class User
    {
        [Column("KOD_USER")]
        [Key]
        public long Kod { get; set; }
        [Column("LOGIN")]
        public string Login { get; set; }
        [Column("PASSWORD")]
        public string Password { get; set; }
        [Column("KOD_ROLEUSERS")]
        public long RoleId{ get; set; }
    }
}
