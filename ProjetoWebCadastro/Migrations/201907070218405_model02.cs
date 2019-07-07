namespace ProjetoWebCadastro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class model02 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.categoriafornecedors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.cadastrofornecedors", "Categoria", c => c.Boolean(nullable: false));
            AlterColumn("dbo.cadastrofornecedors", "DataDeCadastro", c => c.DateTime());
            DropColumn("dbo.cadastrofornecedors", "Categoriaa");
        }
        
        public override void Down()
        {
            AddColumn("dbo.cadastrofornecedors", "Categoriaa", c => c.String());
            AlterColumn("dbo.cadastrofornecedors", "DataDeCadastro", c => c.String());
            DropColumn("dbo.cadastrofornecedors", "Categoria");
            DropTable("dbo.categoriafornecedors");
        }
    }
}
