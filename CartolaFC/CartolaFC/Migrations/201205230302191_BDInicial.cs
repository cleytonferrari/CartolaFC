namespace CartolaFC.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class BDInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Times",
                c => new
                    {
                        TimeId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        AnoDeFundacao = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.TimeId);
            
        }
        
        public override void Down()
        {
            DropTable("Times");
        }
    }
}
