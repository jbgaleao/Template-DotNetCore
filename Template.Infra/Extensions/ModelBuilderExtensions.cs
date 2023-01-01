using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

using Template.Domain.Entities;

namespace Template.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(new User
                    {
                        Id = Guid.Parse("c0d05997-e91f-4c57-a205-565e2d95c869"),
                        Name = "User Default",
                        Email = "userdefault@template.com"
                    });
            return builder;
        }
    }
}
