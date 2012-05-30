namespace CartolaFC.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CriadoTecnico : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Tecnicoes",
                c => new
                    {
                        TecnicoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.TecnicoId);
            
        }
        
        public override void Down()
        {
            DropTable("Tecnicoes");
        }
    }
}
