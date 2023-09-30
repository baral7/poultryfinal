using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PoultryVersion.Models
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblPoultryFarms = new HashSet<TblPoultryFarm>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression("^([0-9]{10})", ErrorMessage = "Invalid Phone Number.")]
        public string? Phone { get; set; }
        public int? RoleId { get; set; }
        public string? Password { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<TblPoultryFarm> TblPoultryFarms { get; set; }
    }
}
