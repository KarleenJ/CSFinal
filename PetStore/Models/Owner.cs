using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Models
{
    public class Owner
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName => this.FirstName + " " + this.LastName;
        
        [Required]
        [MaxLength(20)]
        public string Street { get; set; }

        [Required]
        [MaxLength(20)]
        public string City { get; set; }

        [Required]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")]
        public string EmailAddress { get; set; }
        
        [Required]
        [RegularExpression(@"^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]{2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$")]
        public string PhoneNumber { get; set; }
       
        [Required]
        [MaxLength(20)]
        public string Occupation { get; set; }

        public ICollection<Pet> Pets { get; set; }


    }
}
