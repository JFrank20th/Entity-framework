using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.Entidades.Configuraciones
{
    public class ActorConfig : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.Property(a => a.Nombre).HasMaxLength(150); // Establecer maximo de caracteres
            builder.Property(a => a.FechaNacimiento).HasColumnType("date"); // Establecer como date en sql
            builder.Property(a => a.Fortuna).HasPrecision(18, 2); // Establecer 18 digitos y 2 que sean decimales 
        }
    }
}
