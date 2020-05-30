using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetStore.Models;

namespace PetStore.Models
{
    public class PetStoreContext : DbContext
    {
        public PetStoreContext (DbContextOptions<PetStoreContext> options)
            : base(options)
        {
        }

        public DbSet<PetStore.Models.Owner> Owner { get; set; }

        public DbSet<PetStore.Models.Pet> Pet { get; set; }
    }
}
