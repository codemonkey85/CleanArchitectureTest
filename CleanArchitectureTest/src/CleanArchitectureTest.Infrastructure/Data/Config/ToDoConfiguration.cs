using CleanArchitectureTest.Core.ToDoAggregate;

namespace CleanArchitectureTest.Infrastructure.Data.Config;

public class ToDoConfiguration : IEntityTypeConfiguration<ToDo>
{
  public void Configure(EntityTypeBuilder<ToDo> builder)
  {
    builder.Property(p => p.Title)
    .HasMaxLength(DataSchemaConstants.DEFAULT_NAME_LENGTH)
    .IsRequired();

  }
}
