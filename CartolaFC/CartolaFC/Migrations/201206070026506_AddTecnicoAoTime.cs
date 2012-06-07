namespace CartolaFC.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddTecnicoAoTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("Times", "Tecnico_TecnicoId", c => c.Int());
            AddForeignKey("Times", "Tecnico_TecnicoId", "Tecnicoes", "TecnicoId");
            CreateIndex("Times", "Tecnico_TecnicoId");
        }
        
        public override void Down()
        {
            DropIndex("Times", new[] { "Tecnico_TecnicoId" });
            DropForeignKey("Times", "Tecnico_TecnicoId", "Tecnicoes");
            DropColumn("Times", "Tecnico_TecnicoId");
        }
    }
}
