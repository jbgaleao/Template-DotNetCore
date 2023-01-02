using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

using System;
using System.Collections.Generic;
using System.Text;

using Template.Domain.Entities;
using Template.Domain.Models;

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
                    Email = "userdefault@template.com",
                    DateCreated = new DateTime(2022, 05, 14),
                    DateUpdated = null,
                    IsDeleted = false
                });
            return builder;
        }

        public static ModelBuilder ApplyGlobalConfigurations(this ModelBuilder builder)
        {
            foreach (IMutableEntityType entityType in builder.Model.GetEntityTypes())
            {
                foreach (IMutableProperty property in entityType.GetProperties())
                {
                    switch (property.Name)
                    {
                        case nameof(Entity.Id):
                            property.IsKey();
                            break;

                        case nameof(Entity.DateUpdated):
                            property.IsNullable = true;
                            break;

                        case nameof(Entity.DateCreated):
                            property.IsNullable = false;
                            property.SetDefaultValue(DateTime.Now);
                            break;

                        case nameof(Entity.IsDeleted):
                            property.IsNullable = false;
                            property.SetDefaultValue(null);
                            break;

                        default:
                            break;
                    }
                }
            }

            return builder;
        }
    }
}
