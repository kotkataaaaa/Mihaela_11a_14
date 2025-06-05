﻿namespace Mihaela_11a_14.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Int(nullable: false),
                        DishTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DishTypes", t => t.DishTypeId, cascadeDelete: true)
                .Index(t => t.DishTypeId);
            
            CreateTable(
                "dbo.DishTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dishes", "DishTypeId", "dbo.DishTypes");
            DropIndex("dbo.Dishes", new[] { "DishTypeId" });
            DropTable("dbo.DishTypes");
            DropTable("dbo.Dishes");
        }
    }
}
