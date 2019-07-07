namespace ProjetoWebCadastro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class model03 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.cadastrofornecedors", "Categoria_Id", c => c.Int());
            AlterColumn("dbo.cadastrofornecedors", "Status", c => c.Boolean(nullable: false));
            CreateIndex("dbo.cadastrofornecedors", "Categoria_Id");
            AddForeignKey("dbo.cadastrofornecedors", "Categoria_Id", "dbo.categoriafornecedors", "Id");
            DropColumn("dbo.cadastrofornecedors", "Categoria");
        }
        
        public override void Down()
        {
            AddColumn("dbo.cadastrofornecedors", "Categoria", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.cadastrofornecedors", "Categoria_Id", "dbo.categoriafornecedors");
            DropIndex("dbo.cadastrofornecedors", new[] { "Categoria_Id" });
            AlterColumn("dbo.cadastrofornecedors", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.cadastrofornecedors", "Categoria_Id");
        }
    }
}
