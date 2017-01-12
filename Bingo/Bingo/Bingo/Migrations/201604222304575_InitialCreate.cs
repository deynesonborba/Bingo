namespace Bingo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Apostador",
                c => new
                    {
                        IdApostador = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100),
                        Telefone = c.String(maxLength: 20),
                        Cpf = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.IdApostador);
            
            CreateTable(
                "dbo.Brinde",
                c => new
                    {
                        IdBrindes = c.Int(nullable: false, identity: true),
                        NomeBrinde = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.IdBrindes);
            
            CreateTable(
                "dbo.Cartela",
                c => new
                    {
                        IdCartela = c.Int(nullable: false, identity: true),
                        NumerosCartela = c.String(maxLength: 200),
                        IdApostador = c.Int(nullable: false),
                        IdRodadas = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdCartela)
                .ForeignKey("dbo.Rodada", t => t.IdRodadas)
                .Index(t => t.IdRodadas);
            
            CreateTable(
                "dbo.Rodada",
                c => new
                    {
                        IdRodadas = c.Int(nullable: false, identity: true),
                        IdCartela = c.Int(nullable: false),
                        NumerosSorteados = c.String(maxLength: 200),
                        IdBrindes = c.Int(nullable: false),
                        DataRodada = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdRodadas)
                .ForeignKey("dbo.Brinde", t => t.IdBrindes)
                .Index(t => t.IdBrindes);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cartela", "IdRodadas", "dbo.Rodada");
            DropForeignKey("dbo.Rodada", "IdBrindes", "dbo.Brinde");
            DropIndex("dbo.Rodada", new[] { "IdBrindes" });
            DropIndex("dbo.Cartela", new[] { "IdRodadas" });
            DropTable("dbo.Rodada");
            DropTable("dbo.Cartela");
            DropTable("dbo.Brinde");
            DropTable("dbo.Apostador");
        }
    }
}
