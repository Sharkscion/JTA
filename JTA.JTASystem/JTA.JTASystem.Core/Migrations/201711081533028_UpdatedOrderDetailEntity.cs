namespace JTA.JTASystem.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedOrderDetailEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderDetail", "ProductVariantId", c => c.Int(nullable: false));
            CreateIndex("dbo.OrderDetail", "ProductVariantId");
            AddForeignKey("dbo.OrderDetail", "ProductVariantId", "dbo.ProductVariant", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetail", "ProductVariantId", "dbo.ProductVariant");
            DropIndex("dbo.OrderDetail", new[] { "ProductVariantId" });
            DropColumn("dbo.OrderDetail", "ProductVariantId");
        }
    }
}
