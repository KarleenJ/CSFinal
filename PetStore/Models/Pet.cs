using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Models
{
    public class Pet
    {
        
        public int ID { get; set; }

        [Required]
        [MaxLength(10)]
        public string Name { get; set; }
        
        [Required]
        public DateTime DOB { get; set; }
       
        public enum Breed { Dog, Cat, Fish, Hamster, GuineaPig }
        
        [Required]
        public int OwnderId { get; set; }

        public Owner Owner { get; set; }


    }
}
