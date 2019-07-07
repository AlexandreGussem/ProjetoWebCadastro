namespace ProjetoWebCadastro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class model06 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.cadastrofornecedors", "CNPJ", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.cadastrofornecedors", "Telefone", c => c.String(maxLength: 30));
            AlterColumn("dbo.cadastrofornecedors", "Agencia", c => c.String(maxLength: 20));
            AlterColumn("dbo.cadastrofornecedors", "ContaCorrente", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.cadastrofornecedors", "ContaCorrente", c => c.String(maxLength: 8));
            AlterColumn("dbo.cadastrofornecedors", "Agencia", c => c.String(maxLength: 6));
            AlterColumn("dbo.cadastrofornecedors", "Telefone", c => c.String(maxLength: 11));
            AlterColumn("dbo.cadastrofornecedors", "CNPJ", c => c.String(nullable: false, maxLength: 14));
        }
    }
}
