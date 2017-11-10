namespace JTA.JTASystem.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BranchNo = c.Int(nullable: false),
                        AddressLine = c.String(),
                        BarangayCode = c.String(maxLength: 128),
                        CityMunicipalityCode = c.String(maxLength: 128),
                        ProvinceCode = c.String(maxLength: 128),
                        Status = c.Int(nullable: false),
                        Person_Id = c.Int(),
                        Route_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Barangay", t => t.BarangayCode)
                .ForeignKey("dbo.CityMunicipality", t => t.CityMunicipalityCode)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .ForeignKey("dbo.Province", t => t.ProvinceCode)
                .ForeignKey("dbo.Route", t => t.Route_Id)
                .Index(t => t.BarangayCode)
                .Index(t => t.CityMunicipalityCode)
                .Index(t => t.ProvinceCode)
                .Index(t => t.Person_Id)
                .Index(t => t.Route_Id);
            
            CreateTable(
                "dbo.Barangay",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 128),
                        Description = c.String(storeType: "ntext"),
                        RegionCode = c.String(maxLength: 128),
                        ProvinceCode = c.String(maxLength: 128),
                        CityMunicipalityCode = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Code)
                .ForeignKey("dbo.CityMunicipality", t => t.CityMunicipalityCode)
                .ForeignKey("dbo.Province", t => t.ProvinceCode)
                .ForeignKey("dbo.Region", t => t.RegionCode)
                .Index(t => t.RegionCode)
                .Index(t => t.ProvinceCode)
                .Index(t => t.CityMunicipalityCode);
            
            CreateTable(
                "dbo.CityMunicipality",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 128),
                        PSGCCode = c.String(),
                        Description = c.String(storeType: "ntext"),
                        ProvinceCode = c.String(maxLength: 128),
                        RegionCode = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Code)
                .ForeignKey("dbo.Province", t => t.ProvinceCode)
                .ForeignKey("dbo.Region", t => t.RegionCode)
                .Index(t => t.ProvinceCode)
                .Index(t => t.RegionCode);
            
            CreateTable(
                "dbo.Province",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 128),
                        PSGCCode = c.String(),
                        Description = c.String(storeType: "ntext"),
                        RegionCode = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Code)
                .ForeignKey("dbo.Region", t => t.RegionCode)
                .Index(t => t.RegionCode);
            
            CreateTable(
                "dbo.Region",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 128),
                        PSGCCode = c.String(),
                        Description = c.String(storeType: "ntext"),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Type_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PersonType", t => t.Type_Id)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.ContactInformation",
                c => new
                    {
                        ContactValue = c.String(nullable: false, maxLength: 128),
                        BranchNo = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        ContactPerson = c.String(),
                        Status = c.Int(nullable: false),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ContactValue)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.Document",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        DateIssued = c.DateTime(nullable: false),
                        Terms = c.Int(nullable: false),
                        IssuedById = c.Int(),
                        SalesPersonId = c.Int(),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Status = c.Int(nullable: false),
                        PaymentStatus = c.Int(nullable: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(storeType: "ntext"),
                        IsDelivered1 = c.Boolean(),
                        AddedVat = c.Decimal(precision: 18, scale: 2),
                        TotalSales = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.Id, t.Type, t.DateIssued })
                .ForeignKey("dbo.Address", t => t.Id, cascadeDelete: true)
                .ForeignKey("dbo.Employee", t => t.SalesPersonId)
                .ForeignKey("dbo.Employee", t => t.IssuedById)
                .ForeignKey("dbo.People", t => t.Id, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.IssuedById)
                .Index(t => t.SalesPersonId);
            
            CreateTable(
                "dbo.OrderDetail",
                c => new
                    {
                        OrderNum = c.Int(nullable: false),
                        DocumentId = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        DateIssued = c.DateTime(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Unit = c.Int(nullable: false),
                        Discount = c.String(),
                        SubAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderNum, t.DocumentId, t.Type, t.DateIssued })
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Document", t => new { t.DocumentId, t.Type, t.DateIssued }, cascadeDelete: true)
                .Index(t => new { t.DocumentId, t.Type, t.DateIssued })
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Unit = c.Int(nullable: false),
                        IsTracked = c.Boolean(nullable: false),
                        Note = c.String(storeType: "ntext"),
                        ReferencedProductId = c.Int(),
                        ProductCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductCategory", t => t.ProductCategory_Id)
                .ForeignKey("dbo.Product", t => t.ReferencedProductId)
                .Index(t => t.ReferencedProductId)
                .Index(t => t.ProductCategory_Id);
            
            CreateTable(
                "dbo.ProductDiscount",
                c => new
                    {
                        Level = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Discount = c.String(),
                    })
                .PrimaryKey(t => new { t.Level, t.ProductId })
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.ProductCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Color = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductVariant",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Description = c.String(),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BoxQuantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        InitialStocks = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Stocks = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MinimumQuantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.PriceUpdate",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UpdatedPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        ProductVariant_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductVariant", t => t.ProductVariant_Id)
                .Index(t => t.ProductVariant_Id);
            
            CreateTable(
                "dbo.CustomerBlockedProducts",
                c => new
                    {
                        PersonId = c.Int(nullable: false),
                        ProductId = c.String(nullable: false, maxLength: 128),
                        Reason = c.String(storeType: "ntext"),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.PersonId, t.ProductId })
                .ForeignKey("dbo.Product", t => t.Product_Id)
                .ForeignKey("dbo.Customer", t => t.PersonId)
                .Index(t => t.PersonId)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.CustomerBranch",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BranchNo = c.Int(nullable: false),
                        TIN = c.String(maxLength: 15, fixedLength: true, unicode: false),
                        Level = c.Int(nullable: false),
                        CreditScrore = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreditLimit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(storeType: "ntext"),
                        Status = c.Int(nullable: false),
                        CreditRating_Id = c.Int(),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CreditRating", t => t.CreditRating_Id)
                .ForeignKey("dbo.Customer", t => t.Customer_Id)
                .Index(t => t.CreditRating_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.CreditRating",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rating = c.String(),
                        MinimumScore = c.Int(nullable: false),
                        MaximumScore = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PersonType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Route",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        SalesPerson_Id = c.Int(),
                        ParentStoreId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .ForeignKey("dbo.Employee", t => t.SalesPerson_Id)
                .ForeignKey("dbo.Customer", t => t.ParentStoreId)
                .Index(t => t.Id)
                .Index(t => t.SalesPerson_Id)
                .Index(t => t.ParentStoreId);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        DateEmployed = c.DateTime(nullable: false, storeType: "date"),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.PurchaseOrder",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        DateIssued = c.DateTime(nullable: false),
                        SupplierInvoice = c.String(),
                        PurchaseDescription = c.String(storeType: "ntext"),
                        IsPosted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.Id, t.Type, t.DateIssued })
                .ForeignKey("dbo.Document", t => new { t.Id, t.Type, t.DateIssued })
                .Index(t => new { t.Id, t.Type, t.DateIssued });
            
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        TIN = c.String(maxLength: 15, fixedLength: true, unicode: false),
                        Note = c.String(storeType: "ntext"),
                        Terms = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        DisplayName = c.String(),
                        PasswordStored = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.OrderSlip",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        DateIssued = c.DateTime(nullable: false),
                        IsDelivered = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.Id, t.Type, t.DateIssued })
                .ForeignKey("dbo.Document", t => new { t.Id, t.Type, t.DateIssued })
                .Index(t => new { t.Id, t.Type, t.DateIssued });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderSlip", new[] { "Id", "Type", "DateIssued" }, "dbo.Document");
            DropForeignKey("dbo.User", "Id", "dbo.People");
            DropForeignKey("dbo.Supplier", "Id", "dbo.People");
            DropForeignKey("dbo.PurchaseOrder", new[] { "Id", "Type", "DateIssued" }, "dbo.Document");
            DropForeignKey("dbo.Employee", "Id", "dbo.People");
            DropForeignKey("dbo.Customer", "ParentStoreId", "dbo.Customer");
            DropForeignKey("dbo.Customer", "SalesPerson_Id", "dbo.Employee");
            DropForeignKey("dbo.Customer", "Id", "dbo.People");
            DropForeignKey("dbo.Address", "Route_Id", "dbo.Route");
            DropForeignKey("dbo.Address", "ProvinceCode", "dbo.Province");
            DropForeignKey("dbo.People", "Type_Id", "dbo.PersonType");
            DropForeignKey("dbo.Document", "Id", "dbo.People");
            DropForeignKey("dbo.Document", "IssuedById", "dbo.Employee");
            DropForeignKey("dbo.Document", "SalesPersonId", "dbo.Employee");
            DropForeignKey("dbo.CustomerBranch", "Customer_Id", "dbo.Customer");
            DropForeignKey("dbo.CustomerBranch", "CreditRating_Id", "dbo.CreditRating");
            DropForeignKey("dbo.CustomerBlockedProducts", "PersonId", "dbo.Customer");
            DropForeignKey("dbo.CustomerBlockedProducts", "Product_Id", "dbo.Product");
            DropForeignKey("dbo.OrderDetail", new[] { "DocumentId", "Type", "DateIssued" }, "dbo.Document");
            DropForeignKey("dbo.OrderDetail", "ProductId", "dbo.Product");
            DropForeignKey("dbo.ProductVariant", "ProductId", "dbo.Product");
            DropForeignKey("dbo.PriceUpdate", "ProductVariant_Id", "dbo.ProductVariant");
            DropForeignKey("dbo.Product", "ReferencedProductId", "dbo.Product");
            DropForeignKey("dbo.Product", "ProductCategory_Id", "dbo.ProductCategory");
            DropForeignKey("dbo.ProductDiscount", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Document", "Id", "dbo.Address");
            DropForeignKey("dbo.ContactInformation", "Person_Id", "dbo.People");
            DropForeignKey("dbo.Address", "Person_Id", "dbo.People");
            DropForeignKey("dbo.Address", "CityMunicipalityCode", "dbo.CityMunicipality");
            DropForeignKey("dbo.Address", "BarangayCode", "dbo.Barangay");
            DropForeignKey("dbo.Barangay", "RegionCode", "dbo.Region");
            DropForeignKey("dbo.Barangay", "ProvinceCode", "dbo.Province");
            DropForeignKey("dbo.Barangay", "CityMunicipalityCode", "dbo.CityMunicipality");
            DropForeignKey("dbo.CityMunicipality", "RegionCode", "dbo.Region");
            DropForeignKey("dbo.CityMunicipality", "ProvinceCode", "dbo.Province");
            DropForeignKey("dbo.Province", "RegionCode", "dbo.Region");
            DropIndex("dbo.OrderSlip", new[] { "Id", "Type", "DateIssued" });
            DropIndex("dbo.User", new[] { "Id" });
            DropIndex("dbo.Supplier", new[] { "Id" });
            DropIndex("dbo.PurchaseOrder", new[] { "Id", "Type", "DateIssued" });
            DropIndex("dbo.Employee", new[] { "Id" });
            DropIndex("dbo.Customer", new[] { "ParentStoreId" });
            DropIndex("dbo.Customer", new[] { "SalesPerson_Id" });
            DropIndex("dbo.Customer", new[] { "Id" });
            DropIndex("dbo.CustomerBranch", new[] { "Customer_Id" });
            DropIndex("dbo.CustomerBranch", new[] { "CreditRating_Id" });
            DropIndex("dbo.CustomerBlockedProducts", new[] { "Product_Id" });
            DropIndex("dbo.CustomerBlockedProducts", new[] { "PersonId" });
            DropIndex("dbo.PriceUpdate", new[] { "ProductVariant_Id" });
            DropIndex("dbo.ProductVariant", new[] { "ProductId" });
            DropIndex("dbo.ProductDiscount", new[] { "ProductId" });
            DropIndex("dbo.Product", new[] { "ProductCategory_Id" });
            DropIndex("dbo.Product", new[] { "ReferencedProductId" });
            DropIndex("dbo.OrderDetail", new[] { "ProductId" });
            DropIndex("dbo.OrderDetail", new[] { "DocumentId", "Type", "DateIssued" });
            DropIndex("dbo.Document", new[] { "SalesPersonId" });
            DropIndex("dbo.Document", new[] { "IssuedById" });
            DropIndex("dbo.Document", new[] { "Id" });
            DropIndex("dbo.ContactInformation", new[] { "Person_Id" });
            DropIndex("dbo.People", new[] { "Type_Id" });
            DropIndex("dbo.Province", new[] { "RegionCode" });
            DropIndex("dbo.CityMunicipality", new[] { "RegionCode" });
            DropIndex("dbo.CityMunicipality", new[] { "ProvinceCode" });
            DropIndex("dbo.Barangay", new[] { "CityMunicipalityCode" });
            DropIndex("dbo.Barangay", new[] { "ProvinceCode" });
            DropIndex("dbo.Barangay", new[] { "RegionCode" });
            DropIndex("dbo.Address", new[] { "Route_Id" });
            DropIndex("dbo.Address", new[] { "Person_Id" });
            DropIndex("dbo.Address", new[] { "ProvinceCode" });
            DropIndex("dbo.Address", new[] { "CityMunicipalityCode" });
            DropIndex("dbo.Address", new[] { "BarangayCode" });
            DropTable("dbo.OrderSlip");
            DropTable("dbo.User");
            DropTable("dbo.Supplier");
            DropTable("dbo.PurchaseOrder");
            DropTable("dbo.Employee");
            DropTable("dbo.Customer");
            DropTable("dbo.Route");
            DropTable("dbo.PersonType");
            DropTable("dbo.CreditRating");
            DropTable("dbo.CustomerBranch");
            DropTable("dbo.CustomerBlockedProducts");
            DropTable("dbo.PriceUpdate");
            DropTable("dbo.ProductVariant");
            DropTable("dbo.ProductCategory");
            DropTable("dbo.ProductDiscount");
            DropTable("dbo.Product");
            DropTable("dbo.OrderDetail");
            DropTable("dbo.Document");
            DropTable("dbo.ContactInformation");
            DropTable("dbo.People");
            DropTable("dbo.Region");
            DropTable("dbo.Province");
            DropTable("dbo.CityMunicipality");
            DropTable("dbo.Barangay");
            DropTable("dbo.Address");
        }
    }
}
