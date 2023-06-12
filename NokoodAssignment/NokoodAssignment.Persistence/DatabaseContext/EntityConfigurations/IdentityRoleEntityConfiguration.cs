using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NokoodAssignment.Persistence.DatabaseContext.EntityConfigurations
{
    public class IdentityRoleEntityConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(new IdentityRole[]
            {
                new IdentityRole("Admins")
                {
                    NormalizedName="admins".ToUpper()
                },
                new IdentityRole("AppUser")
                {
                    NormalizedName="appuser".ToUpper()
                }
            });
        }
    }
}
