using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestArchitectureReviewOne.Database.Mappings
{
    public interface IMapping
    {
        void OnModelCreating(ModelBuilder modelBuilder);

    }
}