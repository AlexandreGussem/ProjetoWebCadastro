namespace ProjetoWebCadastro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class model04 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.cadastrofornecedors", name: "Categoria_Id", newName: "CategoriaId");
            RenameIndex(table: "dbo.cadastrofornecedors", name: "IX_Categoria_Id", newName: "IX_CategoriaId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.cadastrofornecedors", name: "IX_CategoriaId", newName: "IX_Categoria_Id");
            RenameColumn(table: "dbo.cadastrofornecedors", name: "CategoriaId", newName: "Categoria_Id");
        }
    }
}
