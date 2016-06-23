namespace MyMigrations
{
    using FluentMigrator;

    [Migration(1)]
    public class CreateFooTable : Migration
    {
        public override void Up()
        {
            Create.Table("Foos")
            .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
            .WithColumn("Name").AsString(255).Nullable();
        }

        public override void Down()
        {
            Delete.Table("Foos");
        }
    }
}
