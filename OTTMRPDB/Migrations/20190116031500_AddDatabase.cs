using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OTTMRPDB.Migrations
{
    public partial class AddDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HM_Base_ApiLog",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IP = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ControllerName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ActionName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    HttpMethod = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Token = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HttpRequestHeaders = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    ActionParams = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    ExecuteStartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ExecuteEndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsException = table.Column<int>(nullable: true),
                    Exception = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    Response = table.Column<string>(unicode: false, maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_ApiLog", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_Color",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    colorId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    colorName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    picture = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_Color", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_depotid",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    depotId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    depotName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_depotid", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_Fabric",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    fabric_code = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    fabric_name = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    supplier_code = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    mobile = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    valid_width = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    valid_width_unit = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    use_width = table.Column<double>(nullable: true),
                    use_width_unit = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    component = table.Column<string>(unicode: false, maxLength: 3000, nullable: true),
                    GramWeight = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    SamplePrice = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    GoodsPrice = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    StartQuantity = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ArrivalDays = table.Column<double>(nullable: true),
                    Shrinkage = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PNRemark = table.Column<string>(type: "text", nullable: true),
                    picture = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    Remark = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    sureDays = table.Column<double>(nullable: true),
                    coloringDays = table.Column<double>(nullable: true),
                    afterfinishDays = table.Column<double>(nullable: true),
                    goodsDays = table.Column<double>(nullable: true),
                    printingDays = table.Column<double>(nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    status = table.Column<int>(nullable: true),
                    FabricClass = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_Fabric", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_InStore",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    inStoreId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    receiveId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    fabric_code = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    styleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    shnum = table.Column<int>(nullable: true),
                    num = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SamplePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    sum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    supplier_code = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    CreateUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    inStoreUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    inStoreDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    confirmDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Comment = table.Column<string>(maxLength: 200, nullable: true),
                    step = table.Column<int>(nullable: true),
                    status = table.Column<int>(nullable: true),
                    BudgetDetailId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_InStore", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_InStoresub",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    inStoreId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    requestId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    receivesubId = table.Column<int>(nullable: true),
                    fabric_code = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    colorId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    supplierColor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    specification = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    styleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    shnum = table.Column<int>(nullable: true),
                    num = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SamplePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    sum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_InStoresub", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_Manager",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    uid = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    userId = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    userName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    passWord = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    roleId = table.Column<int>(nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    status = table.Column<int>(nullable: true),
                    roleIds = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    supplier_code = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_Manager", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_Menu",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    type = table.Column<int>(nullable: true),
                    MenuName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ImgUrl = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    parentId = table.Column<int>(nullable: true),
                    CreateUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    sort = table.Column<int>(nullable: true),
                    status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_Menu", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_OutStore",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    outStoreId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    inStoreId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    fabric_code = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    styleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    num = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SamplePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    sum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    useName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    supplierColor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Comment = table.Column<string>(maxLength: 200, nullable: true),
                    CreateUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    outStoreUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    outStoreDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    step = table.Column<int>(nullable: true),
                    status = table.Column<int>(nullable: true),
                    technicianID = table.Column<int>(nullable: true),
                    requestId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Master = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    designer = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_OutStore", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_OutStoresub",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    outStoreId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    inStoresubId = table.Column<int>(nullable: true),
                    fabric_code = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    colorId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    supplierColor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    specification = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    styleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    num = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SamplePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    sum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_OutStoresub", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_PurchaseOrder",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    purchaseOrderId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    sumRequestId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    fabric_code = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    styleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    num = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SamplePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    sum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CreateUser = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    supplier_code = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    sureDays = table.Column<double>(nullable: true),
                    coloringDays = table.Column<double>(nullable: true),
                    afterfinishDays = table.Column<double>(nullable: true),
                    goodsDays = table.Column<double>(nullable: true),
                    printingDays = table.Column<double>(nullable: true),
                    scheduleDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    step = table.Column<int>(nullable: true),
                    submitUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    submitDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ExpectDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Comment = table.Column<string>(maxLength: 200, nullable: true),
                    checkUser = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    checkDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    reComment = table.Column<string>(maxLength: 200, nullable: true),
                    status = table.Column<int>(nullable: true),
                    type = table.Column<int>(nullable: true, defaultValueSql: "((2))"),
                    BudgetDetailId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_PurchaseOrder", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_PurchaseOrdersub",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    purchaseOrderId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    SumRequestsubId = table.Column<int>(nullable: true),
                    fabric_code = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    colorId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    supplierColor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    specification = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    styleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    num = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SamplePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    sum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_PurchaseOrdersub", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_QuarterBudget",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    QuarterCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    QuarterName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    QuarterBudget = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_QuarterBudget", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_QuarterBudgetDetail",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuarterCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    QuarterName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    relateId = table.Column<int>(nullable: true),
                    sum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_QuarterBudgetDetail", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_Receive",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    receiveId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    supplierSureId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    fabric_code = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    styleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    fhnum = table.Column<int>(nullable: true),
                    num = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SamplePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    sum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    supplier_code = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    CreateUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    getUser = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    getDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    arriveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RealSendDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Comment = table.Column<string>(maxLength: 200, nullable: true),
                    reComment = table.Column<string>(maxLength: 200, nullable: true),
                    isPay = table.Column<int>(nullable: true),
                    step = table.Column<int>(nullable: true),
                    status = table.Column<int>(nullable: true),
                    BudgetDetailId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_Receive", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_Receivesub",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    receiveId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    supplierSuresubId = table.Column<int>(nullable: true),
                    fabric_code = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    colorId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    supplierColor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    specification = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    styleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    fhnum = table.Column<int>(nullable: true),
                    num = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SamplePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    sum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    feelIsRight = table.Column<int>(nullable: true),
                    colorIsRight = table.Column<int>(nullable: true),
                    status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_Receivesub", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_Request",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    requestId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    fabric_code = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    colorId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    supplierColor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    specification = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    styleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    imageUrl = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    num = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SamplePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SampleSeason = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ExpectDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    sum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Comment = table.Column<string>(maxLength: 200, nullable: true),
                    CreateUser = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    submitUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    submitDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    checkUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    checkDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    reComment = table.Column<string>(maxLength: 200, nullable: true),
                    step = table.Column<int>(nullable: true, defaultValueSql: "((1))"),
                    status = table.Column<int>(nullable: true),
                    FabricAttribute = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    FabricPart = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_Request", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_Role",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    roleName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    type = table.Column<int>(nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_Role", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_RoleMenu",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    RoleId = table.Column<int>(nullable: true),
                    MenuId = table.Column<int>(nullable: true),
                    type = table.Column<int>(nullable: true),
                    CreateUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_RoleMenu", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_Stock",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    depotId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    fabric_code = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    supplierColor = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    sjkcnum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, defaultValueSql: "((0))"),
                    kpkcnum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, defaultValueSql: "((0))"),
                    status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_Stock", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_Stocksub",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    depotId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    requestId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    styleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    fabric_code = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    supplierColor = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    rknum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, defaultValueSql: "((0))"),
                    cknum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, defaultValueSql: "((0))"),
                    sfnum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, defaultValueSql: "((0))"),
                    innum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, defaultValueSql: "((0))"),
                    outnum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    relateId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_Stocksub", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_Stocksubs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fabric_code = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    supplierColor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    type = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    styleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    newstyleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    requestId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    newrequestId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    num = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    uid = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_Stocksubs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_Store",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    depotId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    fabric_code = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    supplierColor = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    colorId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    specification = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    styleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    rknum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    cknum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    sum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_Store", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_Storesub",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    storeId = table.Column<int>(nullable: true),
                    fabric_code = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    supplierColor = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    colorId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    specification = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    styleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    rknum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    cknum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    sum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Comment = table.Column<string>(maxLength: 200, nullable: true),
                    CreateUser = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    requestId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    useStatus = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_Storesub", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_Style",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    styleId = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    styleName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Year = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Season = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Band = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ImgUrl = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Designer = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Master = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreateUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_Style", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_SumRequest",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    sumRequestId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    fabric_code = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    SamplePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SampleSeason = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    specification = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    styleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    num = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    sum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ExpectDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreateUser = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    submitUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    submitDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Comment = table.Column<string>(maxLength: 200, nullable: true),
                    type = table.Column<int>(nullable: true, defaultValueSql: "((1))"),
                    step = table.Column<int>(nullable: true),
                    checkUser = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    checkDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    reComment = table.Column<string>(maxLength: 200, nullable: true),
                    supplierComment = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_SumRequest", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_SumRequestsub",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    sumRequestId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    requestId = table.Column<int>(nullable: true),
                    fabric_code = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    colorId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    supplierColor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    specification = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    styleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    num = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SamplePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    sum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    requestUser = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    requestDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    comment = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_SumRequestsub", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_Supplier",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    supplier_code = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    supplier_name = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    linkman = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    mobile = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    tel = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_Supplier", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_SupplierSure",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    supplierSureId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    purchaseOrderId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    fabric_code = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    styleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    num = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SamplePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    sum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    supplier_code = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    CreateUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    expressName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    expressNum = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Comment = table.Column<string>(maxLength: 200, nullable: true),
                    sendUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    sendDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    checkUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    checkDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    reComment = table.Column<string>(maxLength: 200, nullable: true),
                    step = table.Column<int>(nullable: true),
                    status = table.Column<int>(nullable: true),
                    BudgetDetailId = table.Column<int>(nullable: true),
                    ExpectDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    RealSendDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_SupplierSure", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_SupplierSuresub",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    supplierSureId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    purchaseOrdersubId = table.Column<int>(nullable: true),
                    fabric_code = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    colorId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    supplierColor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    specification = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    styleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    num = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SamplePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    sum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    feelIsRight = table.Column<int>(nullable: true),
                    colorIsRight = table.Column<int>(nullable: true),
                    status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_SupplierSuresub", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_Technician",
                columns: table => new
                {
                    TechnicianID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Technicianname = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_Technician", x => x.TechnicianID);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_Token",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    uid = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    token = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_Token", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_User",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    uid = table.Column<string>(unicode: false, maxLength: 32, nullable: false),
                    userId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    openId = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    unionId = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    mobile = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    userName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    realname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    avatarUrl = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    gender = table.Column<int>(nullable: true),
                    supplier_code = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    city = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    isSure = table.Column<int>(nullable: true, defaultValueSql: "((1))"),
                    status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("HM_Base__id", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "HM_Base_UserRole",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    uid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    RoleId = table.Column<int>(nullable: true),
                    type = table.Column<int>(nullable: true),
                    CreateUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    isSure = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Base_UserRole", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HM_Materiel_Stock",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brandId = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    depotId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    materialCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    styleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    companyColorId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    supplierColorId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    size = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    k_num = table.Column<double>(nullable: true),
                    p_num = table.Column<double>(nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HM_Materiel_Stock", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LR_App_FnScheme",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_Scheme = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LR_App_FunctionScheme", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_App_Function",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_Type = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_FormId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CodeId = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Icon = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    F_Name = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    F_SchemeId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_SortCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LR_App_Function", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_Area",
                columns: table => new
                {
                    F_AreaId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ParentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_AreaCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_AreaName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_QuickQuery = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_SimpleSpelling = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_Layer = table.Column<int>(nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_AREA", x => x.F_AreaId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_Authorize",
                columns: table => new
                {
                    F_AuthorizeId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ObjectType = table.Column<int>(nullable: true),
                    F_ObjectId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ItemType = table.Column<int>(nullable: true),
                    F_ItemId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_AUTHORIZE", x => x.F_AuthorizeId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_CodeRule",
                columns: table => new
                {
                    F_RuleId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_EnCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_FullName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CurrentNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_RuleFormatJson = table.Column<string>(type: "text", nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CODE_RULE", x => x.F_RuleId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_CodeRuleSeed",
                columns: table => new
                {
                    F_RuleSeedId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_RuleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_UserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SeedValue = table.Column<int>(nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CODE_RULESEED", x => x.F_RuleSeedId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_Company",
                columns: table => new
                {
                    F_CompanyId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_Category = table.Column<int>(nullable: true),
                    F_ParentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_EnCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ShortName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_FullName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Nature = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_OuterPhone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_InnerPhone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Fax = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Postalcode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Manager = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ProvinceId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CityId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CountyId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Address = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_WebAddress = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_FoundedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_BusinessScope = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_ORGANIZE", x => x.F_CompanyId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_CustmerQuery",
                columns: table => new
                {
                    F_CustmerQueryId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_Name = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    F_UserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModuleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModuleUrl = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    F_Formula = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_QueryJson = table.Column<string>(unicode: false, maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LR_CustmerQuery_Main", x => x.F_CustmerQueryId);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_DatabaseLink",
                columns: table => new
                {
                    F_DatabaseLinkId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ServerAddress = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    F_DBName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_DBAlias = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_DbType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Version = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_DbConnection = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    F_DESEncrypt = table.Column<int>(nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_DATABASELINK", x => x.F_DatabaseLinkId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_DataCondition",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_DataAuthorizeRelationId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_FieldId = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    F_FieldName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    F_FieldType = table.Column<int>(nullable: true),
                    F_Symbol = table.Column<int>(nullable: true),
                    F_SymbolName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_FiledValueType = table.Column<int>(nullable: true),
                    F_FiledValue = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_Sort = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LR_Base_DataAuthorizeCondition", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_DataItem",
                columns: table => new
                {
                    F_ItemId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ParentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ItemCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ItemName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_IsTree = table.Column<int>(nullable: true),
                    F_IsNav = table.Column<int>(nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_DATAITEM", x => x.F_ItemId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_DataItemDetail",
                columns: table => new
                {
                    F_ItemDetailId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ItemId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ParentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ItemCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ItemName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ItemValue = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_QuickQuery = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_SimpleSpelling = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_IsDefault = table.Column<int>(nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_DATAITEMDETAIL", x => x.F_ItemDetailId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_DataRelation",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_Name = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_InterfaceId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ObjectId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ObjectType = table.Column<int>(nullable: true),
                    F_Formula = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LR_Base_AuthorizeData", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_DbDraft",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_Content = table.Column<string>(type: "text", nullable: true),
                    F_Remark = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DraftMan__2C6EC723662B2B3B", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_DbField",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_DataType = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    F_Remark = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Length = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CommonFi__2C6EC723625A9A57", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_Department",
                columns: table => new
                {
                    F_DepartmentId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_CompanyId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ParentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_EnCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_FullName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ShortName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Nature = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Manager = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_OuterPhone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_InnerPhone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Fax = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_DEPARTMENT", x => x.F_DepartmentId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_FilterIP",
                columns: table => new
                {
                    F_FilterIPId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ObjectType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ObjectId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_VisitType = table.Column<int>(nullable: true),
                    F_Type = table.Column<int>(nullable: true),
                    F_IPLimit = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_FILTERIP", x => x.F_FilterIPId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_FilterTime",
                columns: table => new
                {
                    F_FilterTimeId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ObjectType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_VisitType = table.Column<int>(nullable: true),
                    F_WeekDay1 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_WeekDay2 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_WeekDay3 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_WeekDay4 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_WeekDay5 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_WeekDay6 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_WeekDay7 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_FILTERTIME", x => x.F_FilterTimeId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_Interface",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_Name = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    F_Address = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    F_FieldsJson = table.Column<string>(unicode: false, maxLength: 4000, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LR_Base_Interface", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_Log",
                columns: table => new
                {
                    F_LogId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_CategoryId = table.Column<int>(nullable: true),
                    F_SourceObjectId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SourceContentJson = table.Column<string>(type: "text", nullable: true),
                    F_OperateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_OperateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_OperateAccount = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_OperateTypeId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_OperateType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Module = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_IPAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_IPAddressName = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_Host = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_Browser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ExecuteResult = table.Column<int>(nullable: true),
                    F_ExecuteResultJson = table.Column<string>(type: "text", nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_LOG", x => x.F_LogId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_Module",
                columns: table => new
                {
                    F_ModuleId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ParentId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_EnCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_FullName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Icon = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_UrlAddress = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_Target = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F_IsMenu = table.Column<int>(nullable: false),
                    F_AllowExpand = table.Column<int>(nullable: true),
                    F_IsPublic = table.Column<int>(nullable: true),
                    F_AllowEdit = table.Column<int>(nullable: true),
                    F_AllowDelete = table.Column<int>(nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: false),
                    F_EnabledMark = table.Column<int>(nullable: false),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_MODULE", x => x.F_ModuleId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_ModuleButton",
                columns: table => new
                {
                    F_ModuleButtonId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ModuleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ParentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Icon = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_EnCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_FullName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ActionAddress = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_SortCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_MODULEBUTTON", x => x.F_ModuleButtonId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_ModuleColumn",
                columns: table => new
                {
                    F_ModuleColumnId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ModuleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ParentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_EnCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_FullName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_MODULECOLUMN", x => x.F_ModuleColumnId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_Post",
                columns: table => new
                {
                    F_PostId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ParentId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_EnCode = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_CompanyId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_DepartmentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LR_Base_Post", x => x.F_PostId);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_Role",
                columns: table => new
                {
                    F_RoleId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_Category = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_EnCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_FullName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_ROLE", x => x.F_RoleId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_User",
                columns: table => new
                {
                    F_UserId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_EnCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Account = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Password = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Secretkey = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_RealName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_NickName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_HeadIcon = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_QuickQuery = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_SimpleSpelling = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_Gender = table.Column<int>(nullable: true),
                    F_Birthday = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_Mobile = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Telephone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_OICQ = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_WeChat = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_MSN = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CompanyId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_DepartmentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SecurityLevel = table.Column<int>(nullable: true),
                    F_OpenId = table.Column<int>(nullable: true),
                    F_Question = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_AnswerQuestion = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CheckOnLine = table.Column<int>(nullable: true),
                    F_AllowStartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_AllowEndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_LockStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_LockEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_USER", x => x.F_UserId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_Base_UserRelation",
                columns: table => new
                {
                    F_UserRelationId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_UserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Category = table.Column<int>(nullable: true),
                    F_ObjectId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_USERRELATION", x => x.F_UserRelationId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_CRM_CashBalance",
                columns: table => new
                {
                    F_CashBalanceId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ObjectId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ExecutionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CashAccount = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Receivable = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    F_Expenses = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    F_Balance = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    F_Abstract = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_CashBalance", x => x.F_CashBalanceId);
                });

            migrationBuilder.CreateTable(
                name: "LR_CRM_Chance",
                columns: table => new
                {
                    F_ChanceId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_EnCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_FullName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SourceId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_StageId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SuccessRate = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    F_Amount = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    F_Profit = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    F_ChanceTypeId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SaleCost = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    F_DealDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_IsToCustom = table.Column<int>(nullable: true),
                    F_CompanyName = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CompanyNatureId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CompanyAddress = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CompanySite = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CompanyDesc = table.Column<string>(unicode: false, nullable: true),
                    F_Province = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_City = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Contacts = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Mobile = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Tel = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Fax = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_QQ = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Wechat = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Hobby = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_TraceUserId = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    F_TraceUserName = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    F_ChanceState = table.Column<int>(nullable: true),
                    F_AlertDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_AlertState = table.Column<int>(nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENT_CHANCE", x => x.F_ChanceId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_CRM_Customer",
                columns: table => new
                {
                    F_CustomerId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_EnCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_FullName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ShortName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CustIndustryId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CustTypeId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CustLevelId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CustDegreeId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Province = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_City = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Contact = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Mobile = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Tel = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Fax = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_QQ = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Wechat = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Hobby = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_LegalPerson = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CompanyAddress = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CompanySite = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CompanyDesc = table.Column<string>(unicode: false, nullable: true),
                    F_TraceUserId = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    F_TraceUserName = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    F_AlertDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_AlertState = table.Column<int>(nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENT_CUSTOMER", x => x.F_CustomerId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_CRM_CustomerContact",
                columns: table => new
                {
                    F_CustomerContactId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_CustomerId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Contact = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Gender = table.Column<int>(nullable: true),
                    F_Mobile = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Tel = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Fax = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_QQ = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Wechat = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_PostId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Hobby = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENT_CUSTOMERCONTACT", x => x.F_CustomerContactId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_CRM_Expenses",
                columns: table => new
                {
                    F_ExpensesId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ExpensesDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ExpensesPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    F_ExpensesAccount = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ExpensesType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ExpensesAbstract = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ExpensesObject = table.Column<int>(nullable: true),
                    F_Managers = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Expenses", x => x.F_ExpensesId);
                });

            migrationBuilder.CreateTable(
                name: "LR_CRM_Invoice",
                columns: table => new
                {
                    F_InvoiceId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_CustomerId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CustomerCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CustomerName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_InvoiceContent = table.Column<string>(unicode: false, nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENT_INVOICE", x => x.F_InvoiceId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_CRM_Order",
                columns: table => new
                {
                    F_OrderId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_CustomerId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SellerId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_OrderDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_OrderCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_DiscountSum = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    F_Accounts = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, defaultValueSql: "((0.00))"),
                    F_ReceivedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, defaultValueSql: "((0.00))"),
                    F_PaymentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_PaymentMode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_PaymentState = table.Column<int>(nullable: true),
                    F_SaleCost = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    F_AbstractInfo = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_ContractCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ContractFile = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENT_ORDER", x => x.F_OrderId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_CRM_OrderProduct",
                columns: table => new
                {
                    F_OrderEntryId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_OrderId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ProductId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ProductCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ProductName = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_UnitId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Qty = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    F_Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    F_Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    F_Taxprice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    F_TaxRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    F_Tax = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    F_TaxAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENT_ORDERENTRY", x => x.F_OrderEntryId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_CRM_Receivable",
                columns: table => new
                {
                    F_ReceivableId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_OrderId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_PaymentTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_PaymentPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    F_PaymentMode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_PaymentAccount = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENT_RECEIVABLE", x => x.F_ReceivableId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_CRM_TrailRecord",
                columns: table => new
                {
                    F_TrailId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ObjectSort = table.Column<int>(nullable: true),
                    F_ObjectId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_TrackContent = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_TrackTypeId = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENT_CHANCETRAIL", x => x.F_TrailId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_Demo_Borrow",
                columns: table => new
                {
                    Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    UserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Money = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    RequestDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    FlowId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    FDataItem = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LR_Demo_Borrow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_Demo_Chenji",
                columns: table => new
                {
                    ID = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Xueke = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Chenji = table.Column<int>(nullable: true),
                    SID = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LR_Demo_Chenji", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LR_Demo_FormLeave",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_Type = table.Column<int>(nullable: true),
                    F_Num = table.Column<int>(nullable: true),
                    F_Reason = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    F_Begin = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_End = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_FileId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    FDataItem = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LR_Demo___2C6EC7234336F4B9", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_Demo_OrderList",
                columns: table => new
                {
                    ID = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    U_ID = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    MeterialId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    MeterialName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Qty = table.Column<int>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LR_Demo_OrderList", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LR_Demo_Single",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_type = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Des = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LR_Demo_Single", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_Demo_Student",
                columns: table => new
                {
                    ID = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    FName = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    FSex = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    FDepartment = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    FFile = table.Column<string>(unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LR_Demo_Student", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LR_Demo_User",
                columns: table => new
                {
                    ID = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Sex = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Age = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LR_Demo_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LR_Demo_UserDes",
                columns: table => new
                {
                    ID = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Post = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    U_ID = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LR_Demo_UserDes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LR_Excel_Export",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_GridId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModuleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModuleBtnId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_BtnName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_SetExcelExport", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_Excel_Import",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModuleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModuleBtnId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_BtnName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_DbId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_DbTable = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ErrorType = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_SetExcelImprot", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_Excel_ImportFileds",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ImportId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Name = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_ColName = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_OnlyOne = table.Column<int>(nullable: true),
                    F_RelationType = table.Column<int>(nullable: true),
                    F_DataItemCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Value = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_DataSourceId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SortCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_SetExcelImportFiled", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_Form_Relation",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_FormId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ModuleId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SettingJson = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_ModuleRelation", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_Form_Scheme",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_SchemeInfoId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_Type = table.Column<int>(nullable: true),
                    F_Scheme = table.Column<string>(type: "text", nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LR_Form_Scheme", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_Form_SchemeInfo",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_Name = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_Type = table.Column<int>(nullable: true),
                    F_Category = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SchemeId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_UrlAddress = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_Module", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_IM_Content",
                columns: table => new
                {
                    F_ContentId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_IsGroup = table.Column<int>(nullable: true),
                    F_SendId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ToId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_MsgContent = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSG_CONTENT", x => x.F_ContentId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_IM_Group",
                columns: table => new
                {
                    F_GroupId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_FullName = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSG_GROUP", x => x.F_GroupId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_IM_Read",
                columns: table => new
                {
                    F_ReadId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ContentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_UserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SendId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ReadStatus = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSG_UNREAD", x => x.F_ReadId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_IM_UserGroup",
                columns: table => new
                {
                    F_UserGroupId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_GroupId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_UserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSG_USERGROUP", x => x.F_UserGroupId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_OA_EmailAddressee",
                columns: table => new
                {
                    F_AddresseeId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ContentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CategoryId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_RecipientId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_RecipientName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_RecipientState = table.Column<int>(nullable: true),
                    F_IsRead = table.Column<int>(nullable: true),
                    F_ReadCount = table.Column<int>(nullable: true),
                    F_ReadDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_IsHighlight = table.Column<int>(nullable: true),
                    F_Backlog = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMAIL_ADDRESSEE", x => x.F_AddresseeId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_OA_EmailCategory",
                columns: table => new
                {
                    F_CategoryId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_FullName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMAIL_CATEGORY", x => x.F_CategoryId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_OA_EmailContent",
                columns: table => new
                {
                    F_ContentId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_CategoryId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ParentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Theme = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_ThemeColor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_EmailContent = table.Column<string>(type: "text", nullable: true),
                    F_Files = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    F_EmailType = table.Column<int>(nullable: true),
                    F_SenderId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SenderName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SenderTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_IsHighlight = table.Column<int>(nullable: true),
                    F_SendPriority = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_IsSmsReminder = table.Column<int>(nullable: true),
                    F_IsReceipt = table.Column<int>(nullable: true),
                    F_AddresssHtml = table.Column<string>(type: "text", nullable: true),
                    F_CopysendHtml = table.Column<string>(type: "text", nullable: true),
                    F_BccsendHtml = table.Column<string>(type: "text", nullable: true),
                    F_SendState = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMAIL_CONTENT", x => x.F_ContentId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_OA_FileFolder",
                columns: table => new
                {
                    F_FolderId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ParentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_FolderType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_FolderName = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_IsShare = table.Column<int>(nullable: true),
                    F_ShareLink = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_ShareCode = table.Column<int>(nullable: true),
                    F_ShareTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FILE_FOLDER", x => x.F_FolderId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_OA_FileInfo",
                columns: table => new
                {
                    F_FileId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_FolderId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_FileName = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_FilePath = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_FileSize = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_FileExtensions = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_FileType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_IsShare = table.Column<int>(nullable: true),
                    F_ShareLink = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_ShareCode = table.Column<int>(nullable: true),
                    F_ShareTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_DownloadCount = table.Column<int>(nullable: true),
                    F_IsTop = table.Column<int>(nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FILE_DOCUMENT", x => x.F_FileId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_OA_News",
                columns: table => new
                {
                    F_NewsId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_TypeId = table.Column<int>(nullable: true),
                    F_CategoryId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Category = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_FullHead = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_FullHeadColor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_BriefHead = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_AuthorName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CompileName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_TagWord = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_Keyword = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_SourceName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SourceAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_NewsContent = table.Column<string>(type: "text", nullable: true),
                    F_PV = table.Column<int>(nullable: true),
                    F_ReleaseTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_NEWS", x => x.F_NewsId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_OA_Schedule",
                columns: table => new
                {
                    F_ScheduleId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ScheduleName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ScheduleContent = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_Category = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_StartTime = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_EndTime = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Early = table.Column<int>(nullable: true),
                    F_IsMailAlert = table.Column<int>(nullable: true),
                    F_IsMobileAlert = table.Column<int>(nullable: true),
                    F_IsWeChatAlert = table.Column<int>(nullable: true),
                    F_ScheduleState = table.Column<int>(nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_SCHEDULE", x => x.F_ScheduleId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_ReportTemp",
                columns: table => new
                {
                    F_TempId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_FullName = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_EnCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_TempCategory = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_TempStyle = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_TempType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_ParamJson = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RPT_TEMP", x => x.F_TempId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_WeChat_DeptRelation",
                columns: table => new
                {
                    F_DeptRelationId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_DeptId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_DeptName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_WeChatDeptId = table.Column<int>(nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WECHAT_DEPTRELATION", x => x.F_DeptRelationId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_WeChat_UserRelation",
                columns: table => new
                {
                    F_UserRelationId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_DeptId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_DeptName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_WeChatDeptId = table.Column<int>(nullable: true),
                    F_UserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SyncState = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SyncLog = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChat_UserRelation", x => x.F_UserRelationId);
                });

            migrationBuilder.CreateTable(
                name: "LR_WF_Confluence",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ProcessId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_NodeId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_FormNodeId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_IsOk = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LR_Workflow_Confluence", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_WF_DelegateRecord",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_WFDelegateRuleId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_FromUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_FromUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ToUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ToUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ProcessId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ProcessCode = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_ProcessName = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WF_DelegateRecord", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_WF_DelegateRule",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ToUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ToUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_BeginDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WF_DelegateRule", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_WF_DelegateRuleRelation",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_DelegateRuleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SchemeInfoId = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LR_Workflow_DelegateRuleSchemeInfo", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_WF_ProcessInstance",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_SchemeId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SchemeCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_SchemeName = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_ProcessName = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_ProcessLevel = table.Column<int>(nullable: true),
                    F_EnabledMark = table.Column<int>(nullable: false),
                    F_IsFinished = table.Column<int>(nullable: true),
                    F_IsAgain = table.Column<int>(nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_CompanyId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_DepartmentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_IsChildFlow = table.Column<int>(nullable: true),
                    F_ProcessParentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__WF_ProcessInstan__3B40CD36", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_WF_Scheme",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_SchemeInfoId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Type = table.Column<int>(nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    F_Scheme = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LR_Workflow_Scheme", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_WF_SchemeAuthorize",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_SchemeInfoId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ObjectName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    F_ObjectId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ObjectType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LR_Workflow_SchemeAuthorize", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_WF_SchemeInfo",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_Code = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Name = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_Category = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Kind = table.Column<int>(nullable: true),
                    F_SchemeId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_DeleteMark = table.Column<int>(nullable: false),
                    F_EnabledMark = table.Column<int>(nullable: false),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F_IsApp = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LR_Workf__2C6EC72261BB7BD9", x => x.F_Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "LR_WF_Task",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ProcessId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_NodeId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_NodeName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    F_TaskType = table.Column<int>(nullable: true),
                    F_IsFinished = table.Column<int>(nullable: true),
                    F_AuditorId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_AuditorName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CompanyId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_DepartmentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_TimeoutAction = table.Column<int>(nullable: true),
                    F_TimeoutNotice = table.Column<int>(nullable: true),
                    F_PreviousId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_PreviousName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_ModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_ModifyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LR_Workflow_Task", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "LR_WF_TaskHistory",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    F_ProcessId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_NodeId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_NodeName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_TaskType = table.Column<int>(nullable: true),
                    F_Result = table.Column<int>(nullable: true),
                    F_PreviousId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_PreviousName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    F_CreateUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_CreateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F_Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LR_Workflow_TaskHistory", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "net_adminauthorization",
                columns: table => new
                {
                    ID = table.Column<string>(unicode: false, maxLength: 150, nullable: false),
                    IP = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    netId = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    RoleId = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    UserId = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateUser = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    MoidfyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyUser = table.Column<string>(unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_net_adminauthorization", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "net_admindb",
                columns: table => new
                {
                    ID = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    PID = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    DB_IPAddress = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    DB_Port = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    DB_UserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DB_UserPassword = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DB_Remark = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_net_admindb", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "unique_colorId",
                table: "HM_Base_Color",
                column: "colorId",
                unique: true,
                filter: "[colorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "unique_depotId",
                table: "HM_Base_depotid",
                column: "depotId",
                unique: true,
                filter: "[depotId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "unique_inStoreId",
                table: "HM_Base_InStore",
                column: "inStoreId",
                unique: true,
                filter: "[inStoreId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "unique_userId",
                table: "HM_Base_Manager",
                column: "userId",
                unique: true,
                filter: "[userId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "unique_outStoreId",
                table: "HM_Base_OutStore",
                column: "outStoreId",
                unique: true,
                filter: "[outStoreId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "unique_purchaseOrderId",
                table: "HM_Base_PurchaseOrder",
                column: "purchaseOrderId",
                unique: true,
                filter: "[purchaseOrderId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "unique_receiveId",
                table: "HM_Base_Receive",
                column: "receiveId",
                unique: true,
                filter: "[receiveId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "unique_requestId",
                table: "HM_Base_Request",
                column: "requestId",
                unique: true,
                filter: "[requestId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "unique_styleId",
                table: "HM_Base_Style",
                column: "styleId",
                unique: true,
                filter: "[styleId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "unique_sumRequestId",
                table: "HM_Base_SumRequest",
                column: "sumRequestId",
                unique: true,
                filter: "[sumRequestId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "unique_supplier_code",
                table: "HM_Base_Supplier",
                column: "supplier_code",
                unique: true,
                filter: "[supplier_code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "unique_supplierSureId",
                table: "HM_Base_SupplierSure",
                column: "supplierSureId",
                unique: true,
                filter: "[supplierSureId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "unique_uid",
                table: "HM_Base_Token",
                column: "uid",
                unique: true,
                filter: "[uid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "unique_uid",
                table: "HM_Base_User",
                column: "uid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "PK_BASE_AREA_CreateDate",
                table: "LR_Base_Area",
                column: "F_CreateDate");

            migrationBuilder.CreateIndex(
                name: "SY_F_ModuleId",
                table: "LR_Base_ModuleButton",
                column: "F_ModuleId");

            migrationBuilder.CreateIndex(
                name: "SY_F_ModuleId",
                table: "LR_Base_ModuleColumn",
                column: "F_ModuleId");

            migrationBuilder.CreateIndex(
                name: "Relationship_28_FK",
                table: "LR_CRM_CustomerContact",
                column: "F_CustomerId");

            migrationBuilder.CreateIndex(
                name: "Relationship_33_FK",
                table: "LR_CRM_Invoice",
                column: "F_CustomerId");

            migrationBuilder.CreateIndex(
                name: "Relationship_34_FK",
                table: "LR_CRM_Receivable",
                column: "F_OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HM_Base_ApiLog");

            migrationBuilder.DropTable(
                name: "HM_Base_Color");

            migrationBuilder.DropTable(
                name: "HM_Base_depotid");

            migrationBuilder.DropTable(
                name: "HM_Base_Fabric");

            migrationBuilder.DropTable(
                name: "HM_Base_InStore");

            migrationBuilder.DropTable(
                name: "HM_Base_InStoresub");

            migrationBuilder.DropTable(
                name: "HM_Base_Manager");

            migrationBuilder.DropTable(
                name: "HM_Base_Menu");

            migrationBuilder.DropTable(
                name: "HM_Base_OutStore");

            migrationBuilder.DropTable(
                name: "HM_Base_OutStoresub");

            migrationBuilder.DropTable(
                name: "HM_Base_PurchaseOrder");

            migrationBuilder.DropTable(
                name: "HM_Base_PurchaseOrdersub");

            migrationBuilder.DropTable(
                name: "HM_Base_QuarterBudget");

            migrationBuilder.DropTable(
                name: "HM_Base_QuarterBudgetDetail");

            migrationBuilder.DropTable(
                name: "HM_Base_Receive");

            migrationBuilder.DropTable(
                name: "HM_Base_Receivesub");

            migrationBuilder.DropTable(
                name: "HM_Base_Request");

            migrationBuilder.DropTable(
                name: "HM_Base_Role");

            migrationBuilder.DropTable(
                name: "HM_Base_RoleMenu");

            migrationBuilder.DropTable(
                name: "HM_Base_Stock");

            migrationBuilder.DropTable(
                name: "HM_Base_Stocksub");

            migrationBuilder.DropTable(
                name: "HM_Base_Stocksubs");

            migrationBuilder.DropTable(
                name: "HM_Base_Store");

            migrationBuilder.DropTable(
                name: "HM_Base_Storesub");

            migrationBuilder.DropTable(
                name: "HM_Base_Style");

            migrationBuilder.DropTable(
                name: "HM_Base_SumRequest");

            migrationBuilder.DropTable(
                name: "HM_Base_SumRequestsub");

            migrationBuilder.DropTable(
                name: "HM_Base_Supplier");

            migrationBuilder.DropTable(
                name: "HM_Base_SupplierSure");

            migrationBuilder.DropTable(
                name: "HM_Base_SupplierSuresub");

            migrationBuilder.DropTable(
                name: "HM_Base_Technician");

            migrationBuilder.DropTable(
                name: "HM_Base_Token");

            migrationBuilder.DropTable(
                name: "HM_Base_User");

            migrationBuilder.DropTable(
                name: "HM_Base_UserRole");

            migrationBuilder.DropTable(
                name: "HM_Materiel_Stock");

            migrationBuilder.DropTable(
                name: "LR_App_FnScheme");

            migrationBuilder.DropTable(
                name: "LR_App_Function");

            migrationBuilder.DropTable(
                name: "LR_Base_Area");

            migrationBuilder.DropTable(
                name: "LR_Base_Authorize");

            migrationBuilder.DropTable(
                name: "LR_Base_CodeRule");

            migrationBuilder.DropTable(
                name: "LR_Base_CodeRuleSeed");

            migrationBuilder.DropTable(
                name: "LR_Base_Company");

            migrationBuilder.DropTable(
                name: "LR_Base_CustmerQuery");

            migrationBuilder.DropTable(
                name: "LR_Base_DatabaseLink");

            migrationBuilder.DropTable(
                name: "LR_Base_DataCondition");

            migrationBuilder.DropTable(
                name: "LR_Base_DataItem");

            migrationBuilder.DropTable(
                name: "LR_Base_DataItemDetail");

            migrationBuilder.DropTable(
                name: "LR_Base_DataRelation");

            migrationBuilder.DropTable(
                name: "LR_Base_DbDraft");

            migrationBuilder.DropTable(
                name: "LR_Base_DbField");

            migrationBuilder.DropTable(
                name: "LR_Base_Department");

            migrationBuilder.DropTable(
                name: "LR_Base_FilterIP");

            migrationBuilder.DropTable(
                name: "LR_Base_FilterTime");

            migrationBuilder.DropTable(
                name: "LR_Base_Interface");

            migrationBuilder.DropTable(
                name: "LR_Base_Log");

            migrationBuilder.DropTable(
                name: "LR_Base_Module");

            migrationBuilder.DropTable(
                name: "LR_Base_ModuleButton");

            migrationBuilder.DropTable(
                name: "LR_Base_ModuleColumn");

            migrationBuilder.DropTable(
                name: "LR_Base_Post");

            migrationBuilder.DropTable(
                name: "LR_Base_Role");

            migrationBuilder.DropTable(
                name: "LR_Base_User");

            migrationBuilder.DropTable(
                name: "LR_Base_UserRelation");

            migrationBuilder.DropTable(
                name: "LR_CRM_CashBalance");

            migrationBuilder.DropTable(
                name: "LR_CRM_Chance");

            migrationBuilder.DropTable(
                name: "LR_CRM_Customer");

            migrationBuilder.DropTable(
                name: "LR_CRM_CustomerContact");

            migrationBuilder.DropTable(
                name: "LR_CRM_Expenses");

            migrationBuilder.DropTable(
                name: "LR_CRM_Invoice");

            migrationBuilder.DropTable(
                name: "LR_CRM_Order");

            migrationBuilder.DropTable(
                name: "LR_CRM_OrderProduct");

            migrationBuilder.DropTable(
                name: "LR_CRM_Receivable");

            migrationBuilder.DropTable(
                name: "LR_CRM_TrailRecord");

            migrationBuilder.DropTable(
                name: "LR_Demo_Borrow");

            migrationBuilder.DropTable(
                name: "LR_Demo_Chenji");

            migrationBuilder.DropTable(
                name: "LR_Demo_FormLeave");

            migrationBuilder.DropTable(
                name: "LR_Demo_OrderList");

            migrationBuilder.DropTable(
                name: "LR_Demo_Single");

            migrationBuilder.DropTable(
                name: "LR_Demo_Student");

            migrationBuilder.DropTable(
                name: "LR_Demo_User");

            migrationBuilder.DropTable(
                name: "LR_Demo_UserDes");

            migrationBuilder.DropTable(
                name: "LR_Excel_Export");

            migrationBuilder.DropTable(
                name: "LR_Excel_Import");

            migrationBuilder.DropTable(
                name: "LR_Excel_ImportFileds");

            migrationBuilder.DropTable(
                name: "LR_Form_Relation");

            migrationBuilder.DropTable(
                name: "LR_Form_Scheme");

            migrationBuilder.DropTable(
                name: "LR_Form_SchemeInfo");

            migrationBuilder.DropTable(
                name: "LR_IM_Content");

            migrationBuilder.DropTable(
                name: "LR_IM_Group");

            migrationBuilder.DropTable(
                name: "LR_IM_Read");

            migrationBuilder.DropTable(
                name: "LR_IM_UserGroup");

            migrationBuilder.DropTable(
                name: "LR_OA_EmailAddressee");

            migrationBuilder.DropTable(
                name: "LR_OA_EmailCategory");

            migrationBuilder.DropTable(
                name: "LR_OA_EmailContent");

            migrationBuilder.DropTable(
                name: "LR_OA_FileFolder");

            migrationBuilder.DropTable(
                name: "LR_OA_FileInfo");

            migrationBuilder.DropTable(
                name: "LR_OA_News");

            migrationBuilder.DropTable(
                name: "LR_OA_Schedule");

            migrationBuilder.DropTable(
                name: "LR_ReportTemp");

            migrationBuilder.DropTable(
                name: "LR_WeChat_DeptRelation");

            migrationBuilder.DropTable(
                name: "LR_WeChat_UserRelation");

            migrationBuilder.DropTable(
                name: "LR_WF_Confluence");

            migrationBuilder.DropTable(
                name: "LR_WF_DelegateRecord");

            migrationBuilder.DropTable(
                name: "LR_WF_DelegateRule");

            migrationBuilder.DropTable(
                name: "LR_WF_DelegateRuleRelation");

            migrationBuilder.DropTable(
                name: "LR_WF_ProcessInstance");

            migrationBuilder.DropTable(
                name: "LR_WF_Scheme");

            migrationBuilder.DropTable(
                name: "LR_WF_SchemeAuthorize");

            migrationBuilder.DropTable(
                name: "LR_WF_SchemeInfo");

            migrationBuilder.DropTable(
                name: "LR_WF_Task");

            migrationBuilder.DropTable(
                name: "LR_WF_TaskHistory");

            migrationBuilder.DropTable(
                name: "net_adminauthorization");

            migrationBuilder.DropTable(
                name: "net_admindb");
        }
    }
}
