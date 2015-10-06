namespace ProfsCursoMtoM_WithPayload.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        ProfessorId = c.Int(nullable: false, identity: true),
                        Sobrenome = c.String(),
                        Nome = c.String(),
                        DataContratacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProfessorId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Professors");
        }
    }
}
