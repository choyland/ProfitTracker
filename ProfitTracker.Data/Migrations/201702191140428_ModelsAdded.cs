namespace ProfitTracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelsAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BackBets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Stake = c.Double(nullable: false),
                        Odds = c.Double(nullable: false),
                        BookmakerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bookmakers", t => t.BookmakerId)
                .Index(t => t.BookmakerId);
            
            CreateTable(
                "dbo.Bookmakers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationUserId = c.Int(nullable: false),
                        BetType = c.Int(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        Description = c.String(),
                        Sport = c.Int(nullable: false),
                        EventTime = c.DateTime(nullable: false),
                        BetResultId = c.Int(nullable: false),
                        BackBetId = c.Int(nullable: false),
                        LayBetId = c.Int(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.BackBets", t => t.BackBetId, cascadeDelete: true)
                .ForeignKey("dbo.BetResults", t => t.BetResultId, cascadeDelete: true)
                .ForeignKey("dbo.LayBets", t => t.LayBetId, cascadeDelete: true)
                .Index(t => t.BetResultId)
                .Index(t => t.BackBetId)
                .Index(t => t.LayBetId)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.BetResults",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BackBetId = c.Int(nullable: false),
                        LayBetId = c.Int(nullable: false),
                        Winnings = c.Double(nullable: false),
                        Outcome = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BackBets", t => t.BackBetId)
                .ForeignKey("dbo.LayBets", t => t.LayBetId)
                .Index(t => t.BackBetId)
                .Index(t => t.LayBetId);
            
            CreateTable(
                "dbo.LayBets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BackBetId = c.Int(nullable: false),
                        LayOdds = c.Double(nullable: false),
                        Exchange_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BackBets", t => t.BackBetId)
                .ForeignKey("dbo.Exchanges", t => t.Exchange_Id)
                .Index(t => t.BackBetId)
                .Index(t => t.Exchange_Id);
            
            CreateTable(
                "dbo.Exchanges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Commission = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bets", "LayBetId", "dbo.LayBets");
            DropForeignKey("dbo.Bets", "BetResultId", "dbo.BetResults");
            DropForeignKey("dbo.BetResults", "LayBetId", "dbo.LayBets");
            DropForeignKey("dbo.LayBets", "Exchange_Id", "dbo.Exchanges");
            DropForeignKey("dbo.LayBets", "BackBetId", "dbo.BackBets");
            DropForeignKey("dbo.BetResults", "BackBetId", "dbo.BackBets");
            DropForeignKey("dbo.Bets", "BackBetId", "dbo.BackBets");
            DropForeignKey("dbo.Bets", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.BackBets", "BookmakerId", "dbo.Bookmakers");
            DropIndex("dbo.LayBets", new[] { "Exchange_Id" });
            DropIndex("dbo.LayBets", new[] { "BackBetId" });
            DropIndex("dbo.BetResults", new[] { "LayBetId" });
            DropIndex("dbo.BetResults", new[] { "BackBetId" });
            DropIndex("dbo.Bets", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Bets", new[] { "LayBetId" });
            DropIndex("dbo.Bets", new[] { "BackBetId" });
            DropIndex("dbo.Bets", new[] { "BetResultId" });
            DropIndex("dbo.BackBets", new[] { "BookmakerId" });
            DropTable("dbo.Exchanges");
            DropTable("dbo.LayBets");
            DropTable("dbo.BetResults");
            DropTable("dbo.Bets");
            DropTable("dbo.Bookmakers");
            DropTable("dbo.BackBets");
        }
    }
}
