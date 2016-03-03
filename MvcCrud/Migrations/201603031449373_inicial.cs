namespace MvcCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pessoas", "EnderecoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Pessoas", "EnderecoId");
            AddForeignKey("dbo.Pessoas", "EnderecoId", "dbo.Enderecoes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pessoas", "EnderecoId", "dbo.Enderecoes");
            DropIndex("dbo.Pessoas", new[] { "EnderecoId" });
            DropColumn("dbo.Pessoas", "EnderecoId");
        }
    }
}
