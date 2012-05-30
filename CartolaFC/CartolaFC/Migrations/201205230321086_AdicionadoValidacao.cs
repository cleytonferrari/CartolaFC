namespace CartolaFC.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AdicionadoValidacao : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Times", "Nome", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("Times", "AnoDeFundacao", c => c.String(nullable: false, maxLength: 4));
        }
        
        public override void Down()
        {
            AlterColumn("Times", "AnoDeFundacao", c => c.String());
            AlterColumn("Times", "Nome", c => c.String());
        }
    }
}
