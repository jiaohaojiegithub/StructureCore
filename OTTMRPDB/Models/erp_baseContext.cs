using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OTTMRPDB.Models
{
    public partial class erp_baseContext : DbContext
    {
        public erp_baseContext()
        {
        }

        public erp_baseContext(DbContextOptions<erp_baseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HmBaseApiLog> HmBaseApiLog { get; set; }
        public virtual DbSet<HmBaseColor> HmBaseColor { get; set; }
        public virtual DbSet<HmBaseDepotid> HmBaseDepotid { get; set; }
        public virtual DbSet<HmBaseFabric> HmBaseFabric { get; set; }
        public virtual DbSet<HmBaseInStore> HmBaseInStore { get; set; }
        public virtual DbSet<HmBaseInStoresub> HmBaseInStoresub { get; set; }
        public virtual DbSet<HmBaseManager> HmBaseManager { get; set; }
        public virtual DbSet<HmBaseMenu> HmBaseMenu { get; set; }
        public virtual DbSet<HmBaseOutStore> HmBaseOutStore { get; set; }
        public virtual DbSet<HmBaseOutStoresub> HmBaseOutStoresub { get; set; }
        public virtual DbSet<HmBasePurchaseOrder> HmBasePurchaseOrder { get; set; }
        public virtual DbSet<HmBasePurchaseOrdersub> HmBasePurchaseOrdersub { get; set; }
        public virtual DbSet<HmBaseQuarterBudget> HmBaseQuarterBudget { get; set; }
        public virtual DbSet<HmBaseQuarterBudgetDetail> HmBaseQuarterBudgetDetail { get; set; }
        public virtual DbSet<HmBaseReceive> HmBaseReceive { get; set; }
        public virtual DbSet<HmBaseReceivesub> HmBaseReceivesub { get; set; }
        public virtual DbSet<HmBaseRequest> HmBaseRequest { get; set; }
        public virtual DbSet<HmBaseRole> HmBaseRole { get; set; }
        public virtual DbSet<HmBaseRoleMenu> HmBaseRoleMenu { get; set; }
        public virtual DbSet<HmBaseStock> HmBaseStock { get; set; }
        public virtual DbSet<HmBaseStocksub> HmBaseStocksub { get; set; }
        public virtual DbSet<HmBaseStocksubs> HmBaseStocksubs { get; set; }
        public virtual DbSet<HmBaseStore> HmBaseStore { get; set; }
        public virtual DbSet<HmBaseStoresub> HmBaseStoresub { get; set; }
        public virtual DbSet<HmBaseStyle> HmBaseStyle { get; set; }
        public virtual DbSet<HmBaseSumRequest> HmBaseSumRequest { get; set; }
        public virtual DbSet<HmBaseSumRequestsub> HmBaseSumRequestsub { get; set; }
        public virtual DbSet<HmBaseSupplier> HmBaseSupplier { get; set; }
        public virtual DbSet<HmBaseSupplierSure> HmBaseSupplierSure { get; set; }
        public virtual DbSet<HmBaseSupplierSuresub> HmBaseSupplierSuresub { get; set; }
        public virtual DbSet<HmBaseTechnician> HmBaseTechnician { get; set; }
        public virtual DbSet<HmBaseToken> HmBaseToken { get; set; }
        public virtual DbSet<HmBaseUser> HmBaseUser { get; set; }
        public virtual DbSet<HmBaseUserRole> HmBaseUserRole { get; set; }
        public virtual DbSet<HmMaterielStock> HmMaterielStock { get; set; }
        public virtual DbSet<LrAppFnScheme> LrAppFnScheme { get; set; }
        public virtual DbSet<LrAppFunction> LrAppFunction { get; set; }
        public virtual DbSet<LrBaseArea> LrBaseArea { get; set; }
        public virtual DbSet<LrBaseAuthorize> LrBaseAuthorize { get; set; }
        public virtual DbSet<LrBaseCodeRule> LrBaseCodeRule { get; set; }
        public virtual DbSet<LrBaseCodeRuleSeed> LrBaseCodeRuleSeed { get; set; }
        public virtual DbSet<LrBaseCompany> LrBaseCompany { get; set; }
        public virtual DbSet<LrBaseCustmerQuery> LrBaseCustmerQuery { get; set; }
        public virtual DbSet<LrBaseDataCondition> LrBaseDataCondition { get; set; }
        public virtual DbSet<LrBaseDataItem> LrBaseDataItem { get; set; }
        public virtual DbSet<LrBaseDataItemDetail> LrBaseDataItemDetail { get; set; }
        public virtual DbSet<LrBaseDataRelation> LrBaseDataRelation { get; set; }
        public virtual DbSet<LrBaseDatabaseLink> LrBaseDatabaseLink { get; set; }
        public virtual DbSet<LrBaseDbDraft> LrBaseDbDraft { get; set; }
        public virtual DbSet<LrBaseDbField> LrBaseDbField { get; set; }
        public virtual DbSet<LrBaseDepartment> LrBaseDepartment { get; set; }
        public virtual DbSet<LrBaseFilterIp> LrBaseFilterIp { get; set; }
        public virtual DbSet<LrBaseFilterTime> LrBaseFilterTime { get; set; }
        public virtual DbSet<LrBaseInterface> LrBaseInterface { get; set; }
        public virtual DbSet<LrBaseLog> LrBaseLog { get; set; }
        public virtual DbSet<LrBaseModule> LrBaseModule { get; set; }
        public virtual DbSet<LrBaseModuleButton> LrBaseModuleButton { get; set; }
        public virtual DbSet<LrBaseModuleColumn> LrBaseModuleColumn { get; set; }
        public virtual DbSet<LrBasePost> LrBasePost { get; set; }
        public virtual DbSet<LrBaseRole> LrBaseRole { get; set; }
        public virtual DbSet<LrBaseUser> LrBaseUser { get; set; }
        public virtual DbSet<LrBaseUserRelation> LrBaseUserRelation { get; set; }
        public virtual DbSet<LrCrmCashBalance> LrCrmCashBalance { get; set; }
        public virtual DbSet<LrCrmChance> LrCrmChance { get; set; }
        public virtual DbSet<LrCrmCustomer> LrCrmCustomer { get; set; }
        public virtual DbSet<LrCrmCustomerContact> LrCrmCustomerContact { get; set; }
        public virtual DbSet<LrCrmExpenses> LrCrmExpenses { get; set; }
        public virtual DbSet<LrCrmInvoice> LrCrmInvoice { get; set; }
        public virtual DbSet<LrCrmOrder> LrCrmOrder { get; set; }
        public virtual DbSet<LrCrmOrderProduct> LrCrmOrderProduct { get; set; }
        public virtual DbSet<LrCrmReceivable> LrCrmReceivable { get; set; }
        public virtual DbSet<LrCrmTrailRecord> LrCrmTrailRecord { get; set; }
        public virtual DbSet<LrDemoBorrow> LrDemoBorrow { get; set; }
        public virtual DbSet<LrDemoChenji> LrDemoChenji { get; set; }
        public virtual DbSet<LrDemoFormLeave> LrDemoFormLeave { get; set; }
        public virtual DbSet<LrDemoOrderList> LrDemoOrderList { get; set; }
        public virtual DbSet<LrDemoSingle> LrDemoSingle { get; set; }
        public virtual DbSet<LrDemoStudent> LrDemoStudent { get; set; }
        public virtual DbSet<LrDemoUser> LrDemoUser { get; set; }
        public virtual DbSet<LrDemoUserDes> LrDemoUserDes { get; set; }
        public virtual DbSet<LrExcelExport> LrExcelExport { get; set; }
        public virtual DbSet<LrExcelImport> LrExcelImport { get; set; }
        public virtual DbSet<LrExcelImportFileds> LrExcelImportFileds { get; set; }
        public virtual DbSet<LrFormRelation> LrFormRelation { get; set; }
        public virtual DbSet<LrFormScheme> LrFormScheme { get; set; }
        public virtual DbSet<LrFormSchemeInfo> LrFormSchemeInfo { get; set; }
        public virtual DbSet<LrImContent> LrImContent { get; set; }
        public virtual DbSet<LrImGroup> LrImGroup { get; set; }
        public virtual DbSet<LrImRead> LrImRead { get; set; }
        public virtual DbSet<LrImUserGroup> LrImUserGroup { get; set; }
        public virtual DbSet<LrOaEmailAddressee> LrOaEmailAddressee { get; set; }
        public virtual DbSet<LrOaEmailCategory> LrOaEmailCategory { get; set; }
        public virtual DbSet<LrOaEmailContent> LrOaEmailContent { get; set; }
        public virtual DbSet<LrOaFileFolder> LrOaFileFolder { get; set; }
        public virtual DbSet<LrOaFileInfo> LrOaFileInfo { get; set; }
        public virtual DbSet<LrOaNews> LrOaNews { get; set; }
        public virtual DbSet<LrOaSchedule> LrOaSchedule { get; set; }
        public virtual DbSet<LrReportTemp> LrReportTemp { get; set; }
        public virtual DbSet<LrWeChatDeptRelation> LrWeChatDeptRelation { get; set; }
        public virtual DbSet<LrWeChatUserRelation> LrWeChatUserRelation { get; set; }
        public virtual DbSet<LrWfConfluence> LrWfConfluence { get; set; }
        public virtual DbSet<LrWfDelegateRecord> LrWfDelegateRecord { get; set; }
        public virtual DbSet<LrWfDelegateRule> LrWfDelegateRule { get; set; }
        public virtual DbSet<LrWfDelegateRuleRelation> LrWfDelegateRuleRelation { get; set; }
        public virtual DbSet<LrWfProcessInstance> LrWfProcessInstance { get; set; }
        public virtual DbSet<LrWfScheme> LrWfScheme { get; set; }
        public virtual DbSet<LrWfSchemeAuthorize> LrWfSchemeAuthorize { get; set; }
        public virtual DbSet<LrWfSchemeInfo> LrWfSchemeInfo { get; set; }
        public virtual DbSet<LrWfTask> LrWfTask { get; set; }
        public virtual DbSet<LrWfTaskHistory> LrWfTaskHistory { get; set; }
        public virtual DbSet<NetAdminauthorization> NetAdminauthorization { get; set; }
        public virtual DbSet<NetAdmindb> NetAdmindb { get; set; }

        // Unable to generate entity type for table 'dbo.LR_Base_DataSource'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LR_Base_AnnexesFile'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.net_adminacount'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LR_Demo_TestCustmerFormp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LR_Demo_TestCustmerFormc'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LR_Demo_PreloadGird'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("data source=192.168.0.101;initial catalog=erp_base;persist security info=True;user id=sa;password=#*#8160l;MultipleActiveResultSets=True;");
                optionsBuilder.UseSqlServer("Server=.;Database=erp_base;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<HmBaseApiLog>(entity =>
            {
                entity.ToTable("HM_Base_ApiLog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActionParams)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ControllerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Exception)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ExecuteEndTime).HasColumnType("datetime");

                entity.Property(e => e.ExecuteStartTime).HasColumnType("datetime");

                entity.Property(e => e.HttpMethod)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HttpRequestHeaders)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Response)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBaseColor>(entity =>
            {
                entity.ToTable("HM_Base_Color");

                entity.HasIndex(e => e.ColorId)
                    .HasName("unique_colorId")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ColorId)
                    .HasColumnName("colorId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColorName)
                    .HasColumnName("colorName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<HmBaseDepotid>(entity =>
            {
                entity.ToTable("HM_Base_depotid");

                entity.HasIndex(e => e.DepotId)
                    .HasName("unique_depotId")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepotId)
                    .HasColumnName("depotId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepotName)
                    .HasColumnName("depotName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<HmBaseFabric>(entity =>
            {
                entity.ToTable("HM_Base_Fabric");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AfterfinishDays).HasColumnName("afterfinishDays");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ColoringDays).HasColumnName("coloringDays");

                entity.Property(e => e.Component)
                    .HasColumnName("component")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FabricClass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FabricCode)
                    .HasColumnName("fabric_code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FabricName)
                    .HasColumnName("fabric_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsDays).HasColumnName("goodsDays");

                entity.Property(e => e.GoodsPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GramWeight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Pnremark)
                    .HasColumnName("PNRemark")
                    .HasColumnType("text");

                entity.Property(e => e.PrintingDays).HasColumnName("printingDays");

                entity.Property(e => e.Remark)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.SamplePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Shrinkage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartQuantity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplier_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SureDays).HasColumnName("sureDays");

                entity.Property(e => e.UseWidth).HasColumnName("use_width");

                entity.Property(e => e.UseWidthUnit)
                    .HasColumnName("use_width_unit")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValidWidth)
                    .HasColumnName("valid_width")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValidWidthUnit)
                    .HasColumnName("valid_width_unit")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBaseInStore>(entity =>
            {
                entity.ToTable("HM_Base_InStore");

                entity.HasIndex(e => e.InStoreId)
                    .HasName("unique_inStoreId")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).HasMaxLength(200);

                entity.Property(e => e.ConfirmDate)
                    .HasColumnName("confirmDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FabricCode)
                    .HasColumnName("fabric_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InStoreDate)
                    .HasColumnName("inStoreDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.InStoreId)
                    .HasColumnName("inStoreId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InStoreUser)
                    .HasColumnName("inStoreUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceiveId)
                    .HasColumnName("receiveId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SamplePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Shnum).HasColumnName("shnum");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Step).HasColumnName("step");

                entity.Property(e => e.StyleId)
                    .HasColumnName("styleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplier_code")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBaseInStoresub>(entity =>
            {
                entity.ToTable("HM_Base_InStoresub");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ColorId)
                    .HasColumnName("colorId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FabricCode)
                    .HasColumnName("fabric_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InStoreId)
                    .HasColumnName("inStoreId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceivesubId).HasColumnName("receivesubId");

                entity.Property(e => e.RequestId)
                    .HasColumnName("requestId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SamplePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Shnum).HasColumnName("shnum");

                entity.Property(e => e.Specification)
                    .HasColumnName("specification")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StyleId)
                    .HasColumnName("styleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupplierColor)
                    .HasColumnName("supplierColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBaseManager>(entity =>
            {
                entity.ToTable("HM_Base_Manager");

                entity.HasIndex(e => e.UserId)
                    .HasName("unique_userId")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.PassWord)
                    .HasColumnName("passWord")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.Property(e => e.RoleIds)
                    .HasColumnName("roleIds")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplier_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBaseMenu>(entity =>
            {
                entity.ToTable("HM_Base_Menu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImgUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MenuName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("parentId");

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<HmBaseOutStore>(entity =>
            {
                entity.ToTable("HM_Base_OutStore");

                entity.HasIndex(e => e.OutStoreId)
                    .HasName("unique_outStoreId")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).HasMaxLength(200);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Designer)
                    .HasColumnName("designer")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FabricCode)
                    .HasColumnName("fabric_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InStoreId)
                    .HasColumnName("inStoreId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Master)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OutStoreDate)
                    .HasColumnName("outStoreDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OutStoreId)
                    .HasColumnName("outStoreId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutStoreUser)
                    .HasColumnName("outStoreUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestId)
                    .HasColumnName("requestId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SamplePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Step).HasColumnName("step");

                entity.Property(e => e.StyleId)
                    .HasColumnName("styleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupplierColor)
                    .HasColumnName("supplierColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TechnicianId).HasColumnName("technicianID");

                entity.Property(e => e.UseName)
                    .HasColumnName("useName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBaseOutStoresub>(entity =>
            {
                entity.ToTable("HM_Base_OutStoresub");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ColorId)
                    .HasColumnName("colorId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FabricCode)
                    .HasColumnName("fabric_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InStoresubId).HasColumnName("inStoresubId");

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OutStoreId)
                    .HasColumnName("outStoreId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SamplePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Specification)
                    .HasColumnName("specification")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StyleId)
                    .HasColumnName("styleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupplierColor)
                    .HasColumnName("supplierColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBasePurchaseOrder>(entity =>
            {
                entity.ToTable("HM_Base_PurchaseOrder");

                entity.HasIndex(e => e.PurchaseOrderId)
                    .HasName("unique_purchaseOrderId")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AfterfinishDays).HasColumnName("afterfinishDays");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CheckDate)
                    .HasColumnName("checkDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CheckUser)
                    .HasColumnName("checkUser")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ColoringDays).HasColumnName("coloringDays");

                entity.Property(e => e.Comment).HasMaxLength(200);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FabricCode)
                    .HasColumnName("fabric_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsDays).HasColumnName("goodsDays");

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrintingDays).HasColumnName("printingDays");

                entity.Property(e => e.PurchaseOrderId)
                    .HasColumnName("purchaseOrderId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReComment)
                    .HasColumnName("reComment")
                    .HasMaxLength(200);

                entity.Property(e => e.SamplePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ScheduleDate)
                    .HasColumnName("scheduleDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Step).HasColumnName("step");

                entity.Property(e => e.StyleId)
                    .HasColumnName("styleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitDate)
                    .HasColumnName("submitDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubmitUser)
                    .HasColumnName("submitUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SumRequestId)
                    .HasColumnName("sumRequestId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplier_code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SureDays).HasColumnName("sureDays");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasDefaultValueSql("((2))");
            });

            modelBuilder.Entity<HmBasePurchaseOrdersub>(entity =>
            {
                entity.ToTable("HM_Base_PurchaseOrdersub");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ColorId)
                    .HasColumnName("colorId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FabricCode)
                    .HasColumnName("fabric_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PurchaseOrderId)
                    .HasColumnName("purchaseOrderId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SamplePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Specification)
                    .HasColumnName("specification")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StyleId)
                    .HasColumnName("styleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupplierColor)
                    .HasColumnName("supplierColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBaseQuarterBudget>(entity =>
            {
                entity.ToTable("HM_Base_QuarterBudget");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuarterBudget).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.QuarterCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuarterName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<HmBaseQuarterBudgetDetail>(entity =>
            {
                entity.ToTable("HM_Base_QuarterBudgetDetail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.QuarterCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuarterName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RelateId).HasColumnName("relateId");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<HmBaseReceive>(entity =>
            {
                entity.ToTable("HM_Base_Receive");

                entity.HasIndex(e => e.ReceiveId)
                    .HasName("unique_receiveId")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArriveDate)
                    .HasColumnName("arriveDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).HasMaxLength(200);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FabricCode)
                    .HasColumnName("fabric_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Fhnum).HasColumnName("fhnum");

                entity.Property(e => e.GetDate)
                    .HasColumnName("getDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.GetUser)
                    .HasColumnName("getUser")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IsPay).HasColumnName("isPay");

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReComment)
                    .HasColumnName("reComment")
                    .HasMaxLength(200);

                entity.Property(e => e.RealSendDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveId)
                    .HasColumnName("receiveId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SamplePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Step).HasColumnName("step");

                entity.Property(e => e.StyleId)
                    .HasColumnName("styleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplier_code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierSureId)
                    .HasColumnName("supplierSureId")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBaseReceivesub>(entity =>
            {
                entity.ToTable("HM_Base_Receivesub");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ColorId)
                    .HasColumnName("colorId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColorIsRight).HasColumnName("colorIsRight");

                entity.Property(e => e.FabricCode)
                    .HasColumnName("fabric_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FeelIsRight).HasColumnName("feelIsRight");

                entity.Property(e => e.Fhnum).HasColumnName("fhnum");

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceiveId)
                    .HasColumnName("receiveId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SamplePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Specification)
                    .HasColumnName("specification")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StyleId)
                    .HasColumnName("styleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupplierColor)
                    .HasColumnName("supplierColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierSuresubId).HasColumnName("supplierSuresubId");
            });

            modelBuilder.Entity<HmBaseRequest>(entity =>
            {
                entity.ToTable("HM_Base_Request");

                entity.HasIndex(e => e.RequestId)
                    .HasName("unique_requestId")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CheckDate)
                    .HasColumnName("checkDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CheckUser)
                    .HasColumnName("checkUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColorId)
                    .HasColumnName("colorId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).HasMaxLength(200);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FabricAttribute)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FabricCode)
                    .HasColumnName("fabric_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FabricPart)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("imageUrl")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReComment)
                    .HasColumnName("reComment")
                    .HasMaxLength(200);

                entity.Property(e => e.RequestId)
                    .HasColumnName("requestId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SamplePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SampleSeason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Specification)
                    .HasColumnName("specification")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Step)
                    .HasColumnName("step")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StyleId)
                    .HasColumnName("styleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitDate)
                    .HasColumnName("submitDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubmitUser)
                    .HasColumnName("submitUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupplierColor)
                    .HasColumnName("supplierColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBaseRole>(entity =>
            {
                entity.ToTable("HM_Base_Role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.RoleName)
                    .HasColumnName("roleName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<HmBaseRoleMenu>(entity =>
            {
                entity.ToTable("HM_Base_RoleMenu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<HmBaseStock>(entity =>
            {
                entity.ToTable("HM_Base_Stock");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DepotId)
                    .HasColumnName("depotId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FabricCode)
                    .HasColumnName("fabric_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Kpkcnum)
                    .HasColumnName("kpkcnum")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sjkcnum)
                    .HasColumnName("sjkcnum")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SupplierColor)
                    .HasColumnName("supplierColor")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBaseStocksub>(entity =>
            {
                entity.ToTable("HM_Base_Stocksub");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cknum)
                    .HasColumnName("cknum")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepotId)
                    .HasColumnName("depotId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FabricCode)
                    .HasColumnName("fabric_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Innum)
                    .HasColumnName("innum")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Outnum)
                    .HasColumnName("outnum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RelateId)
                    .HasColumnName("relateId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestId)
                    .HasColumnName("requestId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rknum)
                    .HasColumnName("rknum")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sfnum)
                    .HasColumnName("sfnum")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StyleId)
                    .HasColumnName("styleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierColor)
                    .HasColumnName("supplierColor")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBaseStocksubs>(entity =>
            {
                entity.ToTable("HM_Base_Stocksubs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FabricCode)
                    .HasColumnName("fabric_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewrequestId)
                    .HasColumnName("newrequestId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewstyleId)
                    .HasColumnName("newstyleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RequestId)
                    .HasColumnName("requestId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StyleId)
                    .HasColumnName("styleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierColor)
                    .HasColumnName("supplierColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBaseStore>(entity =>
            {
                entity.ToTable("HM_Base_Store");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cknum)
                    .HasColumnName("cknum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ColorId)
                    .HasColumnName("colorId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepotId)
                    .HasColumnName("depotId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FabricCode)
                    .HasColumnName("fabric_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Rknum)
                    .HasColumnName("rknum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Specification)
                    .HasColumnName("specification")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StyleId)
                    .HasColumnName("styleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupplierColor)
                    .HasColumnName("supplierColor")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBaseStoresub>(entity =>
            {
                entity.ToTable("HM_Base_Storesub");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cknum)
                    .HasColumnName("cknum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ColorId)
                    .HasColumnName("colorId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).HasMaxLength(200);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.FabricCode)
                    .HasColumnName("fabric_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RequestId)
                    .HasColumnName("requestId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rknum)
                    .HasColumnName("rknum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Specification)
                    .HasColumnName("specification")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreId).HasColumnName("storeId");

                entity.Property(e => e.StyleId)
                    .HasColumnName("styleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupplierColor)
                    .HasColumnName("supplierColor")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UseStatus).HasColumnName("useStatus");
            });

            modelBuilder.Entity<HmBaseStyle>(entity =>
            {
                entity.ToTable("HM_Base_Style");

                entity.HasIndex(e => e.StyleId)
                    .HasName("unique_styleId")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Band)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Designer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImgUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Master)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Season)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StyleId)
                    .HasColumnName("styleId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StyleName)
                    .HasColumnName("styleName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Year)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBaseSumRequest>(entity =>
            {
                entity.ToTable("HM_Base_SumRequest");

                entity.HasIndex(e => e.SumRequestId)
                    .HasName("unique_sumRequestId")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CheckDate)
                    .HasColumnName("checkDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CheckUser)
                    .HasColumnName("checkUser")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).HasMaxLength(200);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FabricCode)
                    .HasColumnName("fabric_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReComment)
                    .HasColumnName("reComment")
                    .HasMaxLength(200);

                entity.Property(e => e.SamplePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SampleSeason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Specification)
                    .HasColumnName("specification")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Step).HasColumnName("step");

                entity.Property(e => e.StyleId)
                    .HasColumnName("styleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitDate)
                    .HasColumnName("submitDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubmitUser)
                    .HasColumnName("submitUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SumRequestId)
                    .HasColumnName("sumRequestId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierComment)
                    .HasColumnName("supplierComment")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HmBaseSumRequestsub>(entity =>
            {
                entity.ToTable("HM_Base_SumRequestsub");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ColorId)
                    .HasColumnName("colorId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FabricCode)
                    .HasColumnName("fabric_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RequestDate)
                    .HasColumnName("requestDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestId).HasColumnName("requestId");

                entity.Property(e => e.RequestUser)
                    .HasColumnName("requestUser")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SamplePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Specification)
                    .HasColumnName("specification")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StyleId)
                    .HasColumnName("styleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SumRequestId)
                    .HasColumnName("sumRequestId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierColor)
                    .HasColumnName("supplierColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBaseSupplier>(entity =>
            {
                entity.ToTable("HM_Base_Supplier");

                entity.HasIndex(e => e.SupplierCode)
                    .HasName("unique_supplier_code")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Linkman)
                    .HasColumnName("linkman")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplier_code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierName)
                    .HasColumnName("supplier_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBaseSupplierSure>(entity =>
            {
                entity.ToTable("HM_Base_SupplierSure");

                entity.HasIndex(e => e.SupplierSureId)
                    .HasName("unique_supplierSureId")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CheckDate)
                    .HasColumnName("checkDate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckUser)
                    .HasColumnName("checkUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).HasMaxLength(200);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressName)
                    .HasColumnName("expressName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressNum)
                    .HasColumnName("expressNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FabricCode)
                    .HasColumnName("fabric_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PurchaseOrderId)
                    .HasColumnName("purchaseOrderId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReComment)
                    .HasColumnName("reComment")
                    .HasMaxLength(200);

                entity.Property(e => e.RealSendDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SamplePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SendDate)
                    .HasColumnName("sendDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SendUser)
                    .HasColumnName("sendUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Step).HasColumnName("step");

                entity.Property(e => e.StyleId)
                    .HasColumnName("styleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplier_code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierSureId)
                    .HasColumnName("supplierSureId")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBaseSupplierSuresub>(entity =>
            {
                entity.ToTable("HM_Base_SupplierSuresub");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ColorId)
                    .HasColumnName("colorId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColorIsRight).HasColumnName("colorIsRight");

                entity.Property(e => e.FabricCode)
                    .HasColumnName("fabric_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FeelIsRight).HasColumnName("feelIsRight");

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PurchaseOrdersubId).HasColumnName("purchaseOrdersubId");

                entity.Property(e => e.SamplePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Specification)
                    .HasColumnName("specification")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StyleId)
                    .HasColumnName("styleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupplierColor)
                    .HasColumnName("supplierColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierSureId)
                    .HasColumnName("supplierSureId")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBaseTechnician>(entity =>
            {
                entity.HasKey(e => e.TechnicianId);

                entity.ToTable("HM_Base_Technician");

                entity.Property(e => e.TechnicianId).HasColumnName("TechnicianID");

                entity.Property(e => e.Technicianname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBaseToken>(entity =>
            {
                entity.ToTable("HM_Base_Token");

                entity.HasIndex(e => e.Uid)
                    .HasName("unique_uid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBaseUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("HM_Base__id")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("HM_Base_User");

                entity.HasIndex(e => e.Uid)
                    .HasName("unique_uid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AvatarUrl)
                    .HasColumnName("avatarUrl")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.IsSure)
                    .HasColumnName("isSure")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OpenId)
                    .HasColumnName("openId")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Realname)
                    .HasColumnName("realname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplier_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("uid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UnionId)
                    .HasColumnName("unionId")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmBaseUserRole>(entity =>
            {
                entity.ToTable("HM_Base_UserRole");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsSure)
                    .HasColumnName("isSure")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HmMaterielStock>(entity =>
            {
                entity.ToTable("HM_Materiel_Stock");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("brandId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyColorId)
                    .HasColumnName("companyColorId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepotId)
                    .HasColumnName("depotId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KNum).HasColumnName("k_num");

                entity.Property(e => e.MaterialCode)
                    .HasColumnName("materialCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PNum).HasColumnName("p_num");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StyleId)
                    .HasColumnName("styleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierColorId)
                    .HasColumnName("supplierColorId")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrAppFnScheme>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_LR_App_FunctionScheme");

                entity.ToTable("LR_App_FnScheme");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FScheme)
                    .HasColumnName("F_Scheme")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<LrAppFunction>(entity =>
            {
                entity.HasKey(e => e.FId);

                entity.ToTable("LR_App_Function");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCodeId)
                    .HasColumnName("F_CodeId")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FFormId)
                    .HasColumnName("F_FormId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FIcon)
                    .HasColumnName("F_Icon")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("F_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FSchemeId)
                    .HasColumnName("F_SchemeId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");

                entity.Property(e => e.FType)
                    .HasColumnName("F_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrBaseArea>(entity =>
            {
                entity.HasKey(e => e.FAreaId)
                    .HasName("PK_BASE_AREA")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_Base_Area");

                entity.HasIndex(e => e.FCreateDate)
                    .HasName("PK_BASE_AREA_CreateDate");

                entity.Property(e => e.FAreaId)
                    .HasColumnName("F_AreaId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FAreaCode)
                    .HasColumnName("F_AreaCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FAreaName)
                    .HasColumnName("F_AreaName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FLayer).HasColumnName("F_Layer");

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FParentId)
                    .HasColumnName("F_ParentId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FQuickQuery)
                    .HasColumnName("F_QuickQuery")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FSimpleSpelling)
                    .HasColumnName("F_SimpleSpelling")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");
            });

            modelBuilder.Entity<LrBaseAuthorize>(entity =>
            {
                entity.HasKey(e => e.FAuthorizeId)
                    .HasName("PK_BASE_AUTHORIZE")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_Base_Authorize");

                entity.Property(e => e.FAuthorizeId)
                    .HasColumnName("F_AuthorizeId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FItemId)
                    .HasColumnName("F_ItemId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FItemType).HasColumnName("F_ItemType");

                entity.Property(e => e.FObjectId)
                    .HasColumnName("F_ObjectId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FObjectType).HasColumnName("F_ObjectType");
            });

            modelBuilder.Entity<LrBaseCodeRule>(entity =>
            {
                entity.HasKey(e => e.FRuleId)
                    .HasName("PK_CODE_RULE")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_Base_CodeRule");

                entity.Property(e => e.FRuleId)
                    .HasColumnName("F_RuleId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCurrentNumber)
                    .HasColumnName("F_CurrentNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnCode)
                    .HasColumnName("F_EnCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FFullName)
                    .HasColumnName("F_FullName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FRuleFormatJson)
                    .HasColumnName("F_RuleFormatJson")
                    .HasColumnType("text");

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");
            });

            modelBuilder.Entity<LrBaseCodeRuleSeed>(entity =>
            {
                entity.HasKey(e => e.FRuleSeedId)
                    .HasName("PK_CODE_RULESEED")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_Base_CodeRuleSeed");

                entity.Property(e => e.FRuleSeedId)
                    .HasColumnName("F_RuleSeedId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FRuleId)
                    .HasColumnName("F_RuleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSeedValue).HasColumnName("F_SeedValue");

                entity.Property(e => e.FUserId)
                    .HasColumnName("F_UserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrBaseCompany>(entity =>
            {
                entity.HasKey(e => e.FCompanyId)
                    .HasName("PK_BASE_ORGANIZE")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_Base_Company");

                entity.Property(e => e.FCompanyId)
                    .HasColumnName("F_CompanyId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FAddress)
                    .HasColumnName("F_Address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FBusinessScope)
                    .HasColumnName("F_BusinessScope")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FCategory).HasColumnName("F_Category");

                entity.Property(e => e.FCityId)
                    .HasColumnName("F_CityId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCountyId)
                    .HasColumnName("F_CountyId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEmail)
                    .HasColumnName("F_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FEnCode)
                    .HasColumnName("F_EnCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FFax)
                    .HasColumnName("F_Fax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FFoundedTime)
                    .HasColumnName("F_FoundedTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FFullName)
                    .HasColumnName("F_FullName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FInnerPhone)
                    .HasColumnName("F_InnerPhone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FManager)
                    .HasColumnName("F_Manager")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FNature)
                    .HasColumnName("F_Nature")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FOuterPhone)
                    .HasColumnName("F_OuterPhone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FParentId)
                    .HasColumnName("F_ParentId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FPostalcode)
                    .HasColumnName("F_Postalcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FProvinceId)
                    .HasColumnName("F_ProvinceId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FShortName)
                    .HasColumnName("F_ShortName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");

                entity.Property(e => e.FWebAddress)
                    .HasColumnName("F_WebAddress")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrBaseCustmerQuery>(entity =>
            {
                entity.HasKey(e => e.FCustmerQueryId)
                    .HasName("PK_LR_CustmerQuery_Main");

                entity.ToTable("LR_Base_CustmerQuery");

                entity.Property(e => e.FCustmerQueryId)
                    .HasColumnName("F_CustmerQueryId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FFormula)
                    .HasColumnName("F_Formula")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FModuleId)
                    .HasColumnName("F_ModuleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModuleUrl)
                    .IsRequired()
                    .HasColumnName("F_ModuleUrl")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .IsRequired()
                    .HasColumnName("F_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FQueryJson)
                    .HasColumnName("F_QueryJson")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.FUserId)
                    .HasColumnName("F_UserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrBaseDataCondition>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_LR_Base_DataAuthorizeCondition");

                entity.ToTable("LR_Base_DataCondition");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FDataAuthorizeRelationId)
                    .HasColumnName("F_DataAuthorizeRelationId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FFieldId)
                    .HasColumnName("F_FieldId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FFieldName)
                    .HasColumnName("F_FieldName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FFieldType).HasColumnName("F_FieldType");

                entity.Property(e => e.FFiledValue)
                    .HasColumnName("F_FiledValue")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FFiledValueType).HasColumnName("F_FiledValueType");

                entity.Property(e => e.FSort).HasColumnName("F_Sort");

                entity.Property(e => e.FSymbol).HasColumnName("F_Symbol");

                entity.Property(e => e.FSymbolName)
                    .HasColumnName("F_SymbolName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrBaseDataItem>(entity =>
            {
                entity.HasKey(e => e.FItemId)
                    .HasName("PK_BASE_DATAITEM")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_Base_DataItem");

                entity.Property(e => e.FItemId)
                    .HasColumnName("F_ItemId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FIsNav).HasColumnName("F_IsNav");

                entity.Property(e => e.FIsTree).HasColumnName("F_IsTree");

                entity.Property(e => e.FItemCode)
                    .HasColumnName("F_ItemCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FItemName)
                    .HasColumnName("F_ItemName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FParentId)
                    .HasColumnName("F_ParentId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");
            });

            modelBuilder.Entity<LrBaseDataItemDetail>(entity =>
            {
                entity.HasKey(e => e.FItemDetailId)
                    .HasName("PK_BASE_DATAITEMDETAIL")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_Base_DataItemDetail");

                entity.Property(e => e.FItemDetailId)
                    .HasColumnName("F_ItemDetailId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FIsDefault).HasColumnName("F_IsDefault");

                entity.Property(e => e.FItemCode)
                    .HasColumnName("F_ItemCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FItemId)
                    .HasColumnName("F_ItemId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FItemName)
                    .HasColumnName("F_ItemName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FItemValue)
                    .HasColumnName("F_ItemValue")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FParentId)
                    .HasColumnName("F_ParentId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FQuickQuery)
                    .HasColumnName("F_QuickQuery")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FSimpleSpelling)
                    .HasColumnName("F_SimpleSpelling")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");
            });

            modelBuilder.Entity<LrBaseDataRelation>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_LR_Base_AuthorizeData");

                entity.ToTable("LR_Base_DataRelation");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FFormula)
                    .HasColumnName("F_Formula")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FInterfaceId)
                    .HasColumnName("F_InterfaceId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("F_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FObjectId)
                    .HasColumnName("F_ObjectId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FObjectType).HasColumnName("F_ObjectType");
            });

            modelBuilder.Entity<LrBaseDatabaseLink>(entity =>
            {
                entity.HasKey(e => e.FDatabaseLinkId)
                    .HasName("PK_BASE_DATABASELINK")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_Base_DatabaseLink");

                entity.Property(e => e.FDatabaseLinkId)
                    .HasColumnName("F_DatabaseLinkId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDbConnection)
                    .HasColumnName("F_DbConnection")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FDbType)
                    .HasColumnName("F_DbType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDbalias)
                    .HasColumnName("F_DBAlias")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDbname)
                    .HasColumnName("F_DBName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FDesencrypt).HasColumnName("F_DESEncrypt");

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FServerAddress)
                    .HasColumnName("F_ServerAddress")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");

                entity.Property(e => e.FVersion)
                    .HasColumnName("F_Version")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrBaseDbDraft>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK__DraftMan__2C6EC723662B2B3B");

                entity.ToTable("LR_Base_DbDraft");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FContent)
                    .HasColumnName("F_Content")
                    .HasColumnType("text");

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .IsRequired()
                    .HasColumnName("F_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FRemark)
                    .HasColumnName("F_Remark")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrBaseDbField>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK__CommonFi__2C6EC723625A9A57");

                entity.ToTable("LR_Base_DbField");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDataType)
                    .IsRequired()
                    .HasColumnName("F_DataType")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FLength).HasColumnName("F_Length");

                entity.Property(e => e.FName)
                    .IsRequired()
                    .HasColumnName("F_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FRemark)
                    .HasColumnName("F_Remark")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrBaseDepartment>(entity =>
            {
                entity.HasKey(e => e.FDepartmentId)
                    .HasName("PK_BASE_DEPARTMENT")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_Base_Department");

                entity.Property(e => e.FDepartmentId)
                    .HasColumnName("F_DepartmentId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCompanyId)
                    .HasColumnName("F_CompanyId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEmail)
                    .HasColumnName("F_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FEnCode)
                    .HasColumnName("F_EnCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FFax)
                    .HasColumnName("F_Fax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FFullName)
                    .HasColumnName("F_FullName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FInnerPhone)
                    .HasColumnName("F_InnerPhone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FManager)
                    .HasColumnName("F_Manager")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FNature)
                    .HasColumnName("F_Nature")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FOuterPhone)
                    .HasColumnName("F_OuterPhone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FParentId)
                    .HasColumnName("F_ParentId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FShortName)
                    .HasColumnName("F_ShortName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");
            });

            modelBuilder.Entity<LrBaseFilterIp>(entity =>
            {
                entity.HasKey(e => e.FFilterIpid)
                    .HasName("PK_BASE_FILTERIP")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_Base_FilterIP");

                entity.Property(e => e.FFilterIpid)
                    .HasColumnName("F_FilterIPId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FIplimit)
                    .HasColumnName("F_IPLimit")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FObjectId)
                    .HasColumnName("F_ObjectId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FObjectType)
                    .HasColumnName("F_ObjectType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");

                entity.Property(e => e.FType).HasColumnName("F_Type");

                entity.Property(e => e.FVisitType).HasColumnName("F_VisitType");
            });

            modelBuilder.Entity<LrBaseFilterTime>(entity =>
            {
                entity.HasKey(e => e.FFilterTimeId)
                    .HasName("PK_BASE_FILTERTIME")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_Base_FilterTime");

                entity.Property(e => e.FFilterTimeId)
                    .HasColumnName("F_FilterTimeId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FObjectType)
                    .HasColumnName("F_ObjectType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");

                entity.Property(e => e.FVisitType).HasColumnName("F_VisitType");

                entity.Property(e => e.FWeekDay1)
                    .HasColumnName("F_WeekDay1")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FWeekDay2)
                    .HasColumnName("F_WeekDay2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FWeekDay3)
                    .HasColumnName("F_WeekDay3")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FWeekDay4)
                    .HasColumnName("F_WeekDay4")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FWeekDay5)
                    .HasColumnName("F_WeekDay5")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FWeekDay6)
                    .HasColumnName("F_WeekDay6")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FWeekDay7)
                    .HasColumnName("F_WeekDay7")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrBaseInterface>(entity =>
            {
                entity.HasKey(e => e.FId);

                entity.ToTable("LR_Base_Interface");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FAddress)
                    .HasColumnName("F_Address")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FFieldsJson)
                    .HasColumnName("F_FieldsJson")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("F_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrBaseLog>(entity =>
            {
                entity.HasKey(e => e.FLogId)
                    .HasName("PK_BASE_LOG")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_Base_Log");

                entity.Property(e => e.FLogId)
                    .HasColumnName("F_LogId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FBrowser)
                    .HasColumnName("F_Browser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCategoryId).HasColumnName("F_CategoryId");

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FExecuteResult).HasColumnName("F_ExecuteResult");

                entity.Property(e => e.FExecuteResultJson)
                    .HasColumnName("F_ExecuteResultJson")
                    .HasColumnType("text");

                entity.Property(e => e.FHost)
                    .HasColumnName("F_Host")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FIpaddress)
                    .HasColumnName("F_IPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FIpaddressName)
                    .HasColumnName("F_IPAddressName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FModule)
                    .HasColumnName("F_Module")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FOperateAccount)
                    .HasColumnName("F_OperateAccount")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FOperateTime)
                    .HasColumnName("F_OperateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FOperateType)
                    .HasColumnName("F_OperateType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FOperateTypeId)
                    .HasColumnName("F_OperateTypeId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FOperateUserId)
                    .HasColumnName("F_OperateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSourceContentJson)
                    .HasColumnName("F_SourceContentJson")
                    .HasColumnType("text");

                entity.Property(e => e.FSourceObjectId)
                    .HasColumnName("F_SourceObjectId")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrBaseModule>(entity =>
            {
                entity.HasKey(e => e.FModuleId)
                    .HasName("PK_BASE_MODULE")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_Base_Module");

                entity.Property(e => e.FModuleId)
                    .HasColumnName("F_ModuleId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FAllowDelete).HasColumnName("F_AllowDelete");

                entity.Property(e => e.FAllowEdit).HasColumnName("F_AllowEdit");

                entity.Property(e => e.FAllowExpand).HasColumnName("F_AllowExpand");

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnCode)
                    .HasColumnName("F_EnCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FFullName)
                    .HasColumnName("F_FullName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FIcon)
                    .HasColumnName("F_Icon")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FIsMenu).HasColumnName("F_IsMenu");

                entity.Property(e => e.FIsPublic).HasColumnName("F_IsPublic");

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FParentId)
                    .IsRequired()
                    .HasColumnName("F_ParentId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");

                entity.Property(e => e.FTarget)
                    .HasColumnName("F_Target")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FUrlAddress)
                    .HasColumnName("F_UrlAddress")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrBaseModuleButton>(entity =>
            {
                entity.HasKey(e => e.FModuleButtonId)
                    .HasName("PK_BASE_MODULEBUTTON")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_Base_ModuleButton");

                entity.HasIndex(e => e.FModuleId)
                    .HasName("SY_F_ModuleId");

                entity.Property(e => e.FModuleButtonId)
                    .HasColumnName("F_ModuleButtonId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FActionAddress)
                    .HasColumnName("F_ActionAddress")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnCode)
                    .HasColumnName("F_EnCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FFullName)
                    .HasColumnName("F_FullName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FIcon)
                    .HasColumnName("F_Icon")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModuleId)
                    .HasColumnName("F_ModuleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FParentId)
                    .HasColumnName("F_ParentId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");
            });

            modelBuilder.Entity<LrBaseModuleColumn>(entity =>
            {
                entity.HasKey(e => e.FModuleColumnId)
                    .HasName("PK_BASE_MODULECOLUMN")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_Base_ModuleColumn");

                entity.HasIndex(e => e.FModuleId)
                    .HasName("SY_F_ModuleId");

                entity.Property(e => e.FModuleColumnId)
                    .HasColumnName("F_ModuleColumnId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnCode)
                    .HasColumnName("F_EnCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FFullName)
                    .HasColumnName("F_FullName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModuleId)
                    .HasColumnName("F_ModuleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FParentId)
                    .HasColumnName("F_ParentId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");
            });

            modelBuilder.Entity<LrBasePost>(entity =>
            {
                entity.HasKey(e => e.FPostId);

                entity.ToTable("LR_Base_Post");

                entity.Property(e => e.FPostId)
                    .HasColumnName("F_PostId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCompanyId)
                    .IsRequired()
                    .HasColumnName("F_CompanyId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDepartmentId)
                    .HasColumnName("F_DepartmentId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnCode)
                    .IsRequired()
                    .HasColumnName("F_EnCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .IsRequired()
                    .HasColumnName("F_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FParentId)
                    .IsRequired()
                    .HasColumnName("F_ParentId")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrBaseRole>(entity =>
            {
                entity.HasKey(e => e.FRoleId)
                    .HasName("PK_BASE_ROLE")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_Base_Role");

                entity.Property(e => e.FRoleId)
                    .HasColumnName("F_RoleId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCategory)
                    .HasColumnName("F_Category")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnCode)
                    .HasColumnName("F_EnCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FFullName)
                    .HasColumnName("F_FullName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");
            });

            modelBuilder.Entity<LrBaseUser>(entity =>
            {
                entity.HasKey(e => e.FUserId)
                    .HasName("PK_BASE_USER")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_Base_User");

                entity.Property(e => e.FUserId)
                    .HasColumnName("F_UserId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FAccount)
                    .HasColumnName("F_Account")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FAllowEndTime)
                    .HasColumnName("F_AllowEndTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FAllowStartTime)
                    .HasColumnName("F_AllowStartTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FAnswerQuestion)
                    .HasColumnName("F_AnswerQuestion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FBirthday)
                    .HasColumnName("F_Birthday")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCheckOnLine).HasColumnName("F_CheckOnLine");

                entity.Property(e => e.FCompanyId)
                    .HasColumnName("F_CompanyId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDepartmentId)
                    .HasColumnName("F_DepartmentId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEmail)
                    .HasColumnName("F_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FEnCode)
                    .HasColumnName("F_EnCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FGender).HasColumnName("F_Gender");

                entity.Property(e => e.FHeadIcon)
                    .HasColumnName("F_HeadIcon")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FLockEndDate)
                    .HasColumnName("F_LockEndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FLockStartDate)
                    .HasColumnName("F_LockStartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FMobile)
                    .HasColumnName("F_Mobile")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FMsn)
                    .HasColumnName("F_MSN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FNickName)
                    .HasColumnName("F_NickName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FOicq)
                    .HasColumnName("F_OICQ")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FOpenId).HasColumnName("F_OpenId");

                entity.Property(e => e.FPassword)
                    .HasColumnName("F_Password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FQuestion)
                    .HasColumnName("F_Question")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FQuickQuery)
                    .HasColumnName("F_QuickQuery")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FRealName)
                    .HasColumnName("F_RealName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSecretkey)
                    .HasColumnName("F_Secretkey")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSecurityLevel).HasColumnName("F_SecurityLevel");

                entity.Property(e => e.FSimpleSpelling)
                    .HasColumnName("F_SimpleSpelling")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");

                entity.Property(e => e.FTelephone)
                    .HasColumnName("F_Telephone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FWeChat)
                    .HasColumnName("F_WeChat")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrBaseUserRelation>(entity =>
            {
                entity.HasKey(e => e.FUserRelationId)
                    .HasName("PK_BASE_USERRELATION")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_Base_UserRelation");

                entity.Property(e => e.FUserRelationId)
                    .HasColumnName("F_UserRelationId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCategory).HasColumnName("F_Category");

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FObjectId)
                    .HasColumnName("F_ObjectId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FUserId)
                    .HasColumnName("F_UserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrCrmCashBalance>(entity =>
            {
                entity.HasKey(e => e.FCashBalanceId)
                    .HasName("PK_Client_CashBalance");

                entity.ToTable("LR_CRM_CashBalance");

                entity.Property(e => e.FCashBalanceId)
                    .HasColumnName("F_CashBalanceId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FAbstract)
                    .HasColumnName("F_Abstract")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FBalance)
                    .HasColumnName("F_Balance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FCashAccount)
                    .HasColumnName("F_CashAccount")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FExecutionDate)
                    .HasColumnName("F_ExecutionDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FExpenses)
                    .HasColumnName("F_Expenses")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FObjectId)
                    .HasColumnName("F_ObjectId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FReceivable)
                    .HasColumnName("F_Receivable")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");
            });

            modelBuilder.Entity<LrCrmChance>(entity =>
            {
                entity.HasKey(e => e.FChanceId)
                    .HasName("PK_CLIENT_CHANCE")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_CRM_Chance");

                entity.Property(e => e.FChanceId)
                    .HasColumnName("F_ChanceId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FAlertDateTime)
                    .HasColumnName("F_AlertDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FAlertState).HasColumnName("F_AlertState");

                entity.Property(e => e.FAmount)
                    .HasColumnName("F_Amount")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FChanceState).HasColumnName("F_ChanceState");

                entity.Property(e => e.FChanceTypeId)
                    .HasColumnName("F_ChanceTypeId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCity)
                    .HasColumnName("F_City")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCompanyAddress)
                    .HasColumnName("F_CompanyAddress")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FCompanyDesc)
                    .HasColumnName("F_CompanyDesc")
                    .IsUnicode(false);

                entity.Property(e => e.FCompanyName)
                    .HasColumnName("F_CompanyName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FCompanyNatureId)
                    .HasColumnName("F_CompanyNatureId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCompanySite)
                    .HasColumnName("F_CompanySite")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FContacts)
                    .HasColumnName("F_Contacts")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDealDate)
                    .HasColumnName("F_DealDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEmail)
                    .HasColumnName("F_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FEnCode)
                    .HasColumnName("F_EnCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FFax)
                    .HasColumnName("F_Fax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FFullName)
                    .HasColumnName("F_FullName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FHobby)
                    .HasColumnName("F_Hobby")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FIsToCustom).HasColumnName("F_IsToCustom");

                entity.Property(e => e.FMobile)
                    .HasColumnName("F_Mobile")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FProfit)
                    .HasColumnName("F_Profit")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FProvince)
                    .HasColumnName("F_Province")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FQq)
                    .HasColumnName("F_QQ")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSaleCost)
                    .HasColumnName("F_SaleCost")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");

                entity.Property(e => e.FSourceId)
                    .HasColumnName("F_SourceId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FStageId)
                    .HasColumnName("F_StageId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSuccessRate)
                    .HasColumnName("F_SuccessRate")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FTel)
                    .HasColumnName("F_Tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FTraceUserId)
                    .HasColumnName("F_TraceUserId")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FTraceUserName)
                    .HasColumnName("F_TraceUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FWechat)
                    .HasColumnName("F_Wechat")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrCrmCustomer>(entity =>
            {
                entity.HasKey(e => e.FCustomerId)
                    .HasName("PK_CLIENT_CUSTOMER")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_CRM_Customer");

                entity.Property(e => e.FCustomerId)
                    .HasColumnName("F_CustomerId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FAlertDateTime)
                    .HasColumnName("F_AlertDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FAlertState).HasColumnName("F_AlertState");

                entity.Property(e => e.FCity)
                    .HasColumnName("F_City")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCompanyAddress)
                    .HasColumnName("F_CompanyAddress")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FCompanyDesc)
                    .HasColumnName("F_CompanyDesc")
                    .IsUnicode(false);

                entity.Property(e => e.FCompanySite)
                    .HasColumnName("F_CompanySite")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FContact)
                    .HasColumnName("F_Contact")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCustDegreeId)
                    .HasColumnName("F_CustDegreeId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCustIndustryId)
                    .HasColumnName("F_CustIndustryId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCustLevelId)
                    .HasColumnName("F_CustLevelId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCustTypeId)
                    .HasColumnName("F_CustTypeId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEmail)
                    .HasColumnName("F_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FEnCode)
                    .HasColumnName("F_EnCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FFax)
                    .HasColumnName("F_Fax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FFullName)
                    .HasColumnName("F_FullName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FHobby)
                    .HasColumnName("F_Hobby")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FLegalPerson)
                    .HasColumnName("F_LegalPerson")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FMobile)
                    .HasColumnName("F_Mobile")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FProvince)
                    .HasColumnName("F_Province")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FQq)
                    .HasColumnName("F_QQ")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FShortName)
                    .HasColumnName("F_ShortName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");

                entity.Property(e => e.FTel)
                    .HasColumnName("F_Tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FTraceUserId)
                    .HasColumnName("F_TraceUserId")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FTraceUserName)
                    .HasColumnName("F_TraceUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FWechat)
                    .HasColumnName("F_Wechat")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrCrmCustomerContact>(entity =>
            {
                entity.HasKey(e => e.FCustomerContactId)
                    .HasName("PK_CLIENT_CUSTOMERCONTACT")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_CRM_CustomerContact");

                entity.HasIndex(e => e.FCustomerId)
                    .HasName("Relationship_28_FK");

                entity.Property(e => e.FCustomerContactId)
                    .HasColumnName("F_CustomerContactId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FContact)
                    .HasColumnName("F_Contact")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCustomerId)
                    .HasColumnName("F_CustomerId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEmail)
                    .HasColumnName("F_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FFax)
                    .HasColumnName("F_Fax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FGender).HasColumnName("F_Gender");

                entity.Property(e => e.FHobby)
                    .HasColumnName("F_Hobby")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FMobile)
                    .HasColumnName("F_Mobile")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FPostId)
                    .HasColumnName("F_PostId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FQq)
                    .HasColumnName("F_QQ")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");

                entity.Property(e => e.FTel)
                    .HasColumnName("F_Tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FWechat)
                    .HasColumnName("F_Wechat")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrCrmExpenses>(entity =>
            {
                entity.HasKey(e => e.FExpensesId)
                    .HasName("PK_Client_Expenses");

                entity.ToTable("LR_CRM_Expenses");

                entity.Property(e => e.FExpensesId)
                    .HasColumnName("F_ExpensesId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FExpensesAbstract)
                    .HasColumnName("F_ExpensesAbstract")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FExpensesAccount)
                    .HasColumnName("F_ExpensesAccount")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FExpensesDate)
                    .HasColumnName("F_ExpensesDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FExpensesObject).HasColumnName("F_ExpensesObject");

                entity.Property(e => e.FExpensesPrice)
                    .HasColumnName("F_ExpensesPrice")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FExpensesType)
                    .HasColumnName("F_ExpensesType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FManagers)
                    .HasColumnName("F_Managers")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");
            });

            modelBuilder.Entity<LrCrmInvoice>(entity =>
            {
                entity.HasKey(e => e.FInvoiceId)
                    .HasName("PK_CLIENT_INVOICE")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_CRM_Invoice");

                entity.HasIndex(e => e.FCustomerId)
                    .HasName("Relationship_33_FK");

                entity.Property(e => e.FInvoiceId)
                    .HasColumnName("F_InvoiceId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCustomerCode)
                    .HasColumnName("F_CustomerCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCustomerId)
                    .HasColumnName("F_CustomerId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCustomerName)
                    .HasColumnName("F_CustomerName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FInvoiceContent)
                    .HasColumnName("F_InvoiceContent")
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");
            });

            modelBuilder.Entity<LrCrmOrder>(entity =>
            {
                entity.HasKey(e => e.FOrderId)
                    .HasName("PK_CLIENT_ORDER")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_CRM_Order");

                entity.Property(e => e.FOrderId)
                    .HasColumnName("F_OrderId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FAbstractInfo)
                    .HasColumnName("F_AbstractInfo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FAccounts)
                    .HasColumnName("F_Accounts")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.FContractCode)
                    .HasColumnName("F_ContractCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FContractFile)
                    .HasColumnName("F_ContractFile")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCustomerId)
                    .HasColumnName("F_CustomerId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FDiscountSum)
                    .HasColumnName("F_DiscountSum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FOrderCode)
                    .HasColumnName("F_OrderCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FOrderDate)
                    .HasColumnName("F_OrderDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FPaymentDate)
                    .HasColumnName("F_PaymentDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FPaymentMode)
                    .HasColumnName("F_PaymentMode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FPaymentState).HasColumnName("F_PaymentState");

                entity.Property(e => e.FReceivedAmount)
                    .HasColumnName("F_ReceivedAmount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.FSaleCost)
                    .HasColumnName("F_SaleCost")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FSellerId)
                    .HasColumnName("F_SellerId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");
            });

            modelBuilder.Entity<LrCrmOrderProduct>(entity =>
            {
                entity.HasKey(e => e.FOrderEntryId)
                    .HasName("PK_CLIENT_ORDERENTRY")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_CRM_OrderProduct");

                entity.Property(e => e.FOrderEntryId)
                    .HasColumnName("F_OrderEntryId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FAmount)
                    .HasColumnName("F_Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FOrderId)
                    .HasColumnName("F_OrderId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FPrice)
                    .HasColumnName("F_Price")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FProductCode)
                    .HasColumnName("F_ProductCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FProductId)
                    .HasColumnName("F_ProductId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FProductName)
                    .HasColumnName("F_ProductName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FQty)
                    .HasColumnName("F_Qty")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");

                entity.Property(e => e.FTax)
                    .HasColumnName("F_Tax")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FTaxAmount)
                    .HasColumnName("F_TaxAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FTaxRate)
                    .HasColumnName("F_TaxRate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FTaxprice)
                    .HasColumnName("F_Taxprice")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FUnitId)
                    .HasColumnName("F_UnitId")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrCrmReceivable>(entity =>
            {
                entity.HasKey(e => e.FReceivableId)
                    .HasName("PK_CLIENT_RECEIVABLE")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_CRM_Receivable");

                entity.HasIndex(e => e.FOrderId)
                    .HasName("Relationship_34_FK");

                entity.Property(e => e.FReceivableId)
                    .HasColumnName("F_ReceivableId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FOrderId)
                    .HasColumnName("F_OrderId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FPaymentAccount)
                    .HasColumnName("F_PaymentAccount")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FPaymentMode)
                    .HasColumnName("F_PaymentMode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FPaymentPrice)
                    .HasColumnName("F_PaymentPrice")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FPaymentTime)
                    .HasColumnName("F_PaymentTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");
            });

            modelBuilder.Entity<LrCrmTrailRecord>(entity =>
            {
                entity.HasKey(e => e.FTrailId)
                    .HasName("PK_CLIENT_CHANCETRAIL")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_CRM_TrailRecord");

                entity.Property(e => e.FTrailId)
                    .HasColumnName("F_TrailId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FObjectId)
                    .HasColumnName("F_ObjectId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FObjectSort).HasColumnName("F_ObjectSort");

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");

                entity.Property(e => e.FTrackContent)
                    .HasColumnName("F_TrackContent")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FTrackTypeId)
                    .HasColumnName("F_TrackTypeId")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrDemoBorrow>(entity =>
            {
                entity.ToTable("LR_Demo_Borrow");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FdataItem)
                    .HasColumnName("FDataItem")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlowId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Money).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrDemoChenji>(entity =>
            {
                entity.ToTable("LR_Demo_Chenji");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Sid)
                    .HasColumnName("SID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Xueke)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrDemoFormLeave>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK__LR_Demo___2C6EC7234336F4B9");

                entity.ToTable("LR_Demo_FormLeave");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FBegin)
                    .HasColumnName("F_Begin")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FEnd)
                    .HasColumnName("F_End")
                    .HasColumnType("datetime");

                entity.Property(e => e.FFileId)
                    .HasColumnName("F_FileId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FNum).HasColumnName("F_Num");

                entity.Property(e => e.FReason)
                    .HasColumnName("F_Reason")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FType).HasColumnName("F_Type");

                entity.Property(e => e.FdataItem)
                    .HasColumnName("FDataItem")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrDemoOrderList>(entity =>
            {
                entity.ToTable("LR_Demo_OrderList");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MeterialId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeterialName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UId)
                    .HasColumnName("U_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrDemoSingle>(entity =>
            {
                entity.HasKey(e => e.FId);

                entity.ToTable("LR_Demo_Single");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDes)
                    .HasColumnName("F_Des")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("F_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FType)
                    .HasColumnName("F_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrDemoStudent>(entity =>
            {
                entity.ToTable("LR_Demo_Student");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Fdepartment)
                    .HasColumnName("FDepartment")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ffile)
                    .HasColumnName("FFile")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fsex)
                    .HasColumnName("FSex")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrDemoUser>(entity =>
            {
                entity.ToTable("LR_Demo_User");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Age)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrDemoUserDes>(entity =>
            {
                entity.ToTable("LR_Demo_UserDes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Post)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UId)
                    .HasColumnName("U_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrExcelExport>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_System_SetExcelExport");

                entity.ToTable("LR_Excel_Export");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FBtnName)
                    .HasColumnName("F_BtnName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FGridId)
                    .HasColumnName("F_GridId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModuleBtnId)
                    .HasColumnName("F_ModuleBtnId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModuleId)
                    .HasColumnName("F_ModuleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("F_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrExcelImport>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_System_SetExcelImprot");

                entity.ToTable("LR_Excel_Import");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FBtnName)
                    .HasColumnName("F_BtnName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDbId)
                    .HasColumnName("F_DbId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDbTable)
                    .HasColumnName("F_DbTable")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FErrorType).HasColumnName("F_ErrorType");

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModuleBtnId)
                    .HasColumnName("F_ModuleBtnId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModuleId)
                    .HasColumnName("F_ModuleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("F_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrExcelImportFileds>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_System_SetExcelImportFiled");

                entity.ToTable("LR_Excel_ImportFileds");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FColName)
                    .HasColumnName("F_ColName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FDataItemCode)
                    .HasColumnName("F_DataItemCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDataSourceId)
                    .HasColumnName("F_DataSourceId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FImportId)
                    .HasColumnName("F_ImportId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("F_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FOnlyOne).HasColumnName("F_OnlyOne");

                entity.Property(e => e.FRelationType).HasColumnName("F_RelationType");

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");

                entity.Property(e => e.FValue)
                    .HasColumnName("F_Value")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrFormRelation>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_Form_ModuleRelation");

                entity.ToTable("LR_Form_Relation");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FFormId)
                    .IsRequired()
                    .HasColumnName("F_FormId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModuleId)
                    .IsRequired()
                    .HasColumnName("F_ModuleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSettingJson)
                    .HasColumnName("F_SettingJson")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<LrFormScheme>(entity =>
            {
                entity.HasKey(e => e.FId);

                entity.ToTable("LR_Form_Scheme");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FScheme)
                    .HasColumnName("F_Scheme")
                    .HasColumnType("text");

                entity.Property(e => e.FSchemeInfoId)
                    .IsRequired()
                    .HasColumnName("F_SchemeInfoId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FType).HasColumnName("F_Type");
            });

            modelBuilder.Entity<LrFormSchemeInfo>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_Form_Module");

                entity.ToTable("LR_Form_SchemeInfo");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCategory)
                    .HasColumnName("F_Category")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("F_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FSchemeId)
                    .HasColumnName("F_SchemeId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FType).HasColumnName("F_Type");

                entity.Property(e => e.FUrlAddress)
                    .HasColumnName("F_UrlAddress")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrImContent>(entity =>
            {
                entity.HasKey(e => e.FContentId)
                    .HasName("PK_MSG_CONTENT")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_IM_Content");

                entity.Property(e => e.FContentId)
                    .HasColumnName("F_ContentId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FIsGroup).HasColumnName("F_IsGroup");

                entity.Property(e => e.FMsgContent)
                    .HasColumnName("F_MsgContent")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FSendId)
                    .HasColumnName("F_SendId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FToId)
                    .HasColumnName("F_ToId")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrImGroup>(entity =>
            {
                entity.HasKey(e => e.FGroupId)
                    .HasName("PK_MSG_GROUP")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_IM_Group");

                entity.Property(e => e.FGroupId)
                    .HasColumnName("F_GroupId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FFullName)
                    .HasColumnName("F_FullName")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrImRead>(entity =>
            {
                entity.HasKey(e => e.FReadId)
                    .HasName("PK_MSG_UNREAD")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_IM_Read");

                entity.Property(e => e.FReadId)
                    .HasColumnName("F_ReadId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FContentId)
                    .HasColumnName("F_ContentId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FReadStatus).HasColumnName("F_ReadStatus");

                entity.Property(e => e.FSendId)
                    .HasColumnName("F_SendId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FUserId)
                    .HasColumnName("F_UserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrImUserGroup>(entity =>
            {
                entity.HasKey(e => e.FUserGroupId)
                    .HasName("PK_MSG_USERGROUP")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_IM_UserGroup");

                entity.Property(e => e.FUserGroupId)
                    .HasColumnName("F_UserGroupId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FGroupId)
                    .HasColumnName("F_GroupId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FUserId)
                    .HasColumnName("F_UserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrOaEmailAddressee>(entity =>
            {
                entity.HasKey(e => e.FAddresseeId)
                    .HasName("PK_EMAIL_ADDRESSEE")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_OA_EmailAddressee");

                entity.Property(e => e.FAddresseeId)
                    .HasColumnName("F_AddresseeId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FBacklog).HasColumnName("F_Backlog");

                entity.Property(e => e.FCategoryId)
                    .HasColumnName("F_CategoryId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FContentId)
                    .HasColumnName("F_ContentId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FIsHighlight).HasColumnName("F_IsHighlight");

                entity.Property(e => e.FIsRead).HasColumnName("F_IsRead");

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FReadCount).HasColumnName("F_ReadCount");

                entity.Property(e => e.FReadDate)
                    .HasColumnName("F_ReadDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FRecipientId)
                    .HasColumnName("F_RecipientId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FRecipientName)
                    .HasColumnName("F_RecipientName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FRecipientState).HasColumnName("F_RecipientState");
            });

            modelBuilder.Entity<LrOaEmailCategory>(entity =>
            {
                entity.HasKey(e => e.FCategoryId)
                    .HasName("PK_EMAIL_CATEGORY")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_OA_EmailCategory");

                entity.Property(e => e.FCategoryId)
                    .HasColumnName("F_CategoryId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FFullName)
                    .HasColumnName("F_FullName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");
            });

            modelBuilder.Entity<LrOaEmailContent>(entity =>
            {
                entity.HasKey(e => e.FContentId)
                    .HasName("PK_EMAIL_CONTENT")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_OA_EmailContent");

                entity.Property(e => e.FContentId)
                    .HasColumnName("F_ContentId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FAddresssHtml)
                    .HasColumnName("F_AddresssHtml")
                    .HasColumnType("text");

                entity.Property(e => e.FBccsendHtml)
                    .HasColumnName("F_BccsendHtml")
                    .HasColumnType("text");

                entity.Property(e => e.FCategoryId)
                    .HasColumnName("F_CategoryId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCopysendHtml)
                    .HasColumnName("F_CopysendHtml")
                    .HasColumnType("text");

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEmailContent)
                    .HasColumnName("F_EmailContent")
                    .HasColumnType("text");

                entity.Property(e => e.FEmailType).HasColumnName("F_EmailType");

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FFiles)
                    .HasColumnName("F_Files")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FIsHighlight).HasColumnName("F_IsHighlight");

                entity.Property(e => e.FIsReceipt).HasColumnName("F_IsReceipt");

                entity.Property(e => e.FIsSmsReminder).HasColumnName("F_IsSmsReminder");

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FParentId)
                    .HasColumnName("F_ParentId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSendPriority)
                    .HasColumnName("F_SendPriority")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSendState).HasColumnName("F_SendState");

                entity.Property(e => e.FSenderId)
                    .HasColumnName("F_SenderId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSenderName)
                    .HasColumnName("F_SenderName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSenderTime)
                    .HasColumnName("F_SenderTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FTheme)
                    .HasColumnName("F_Theme")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FThemeColor)
                    .HasColumnName("F_ThemeColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrOaFileFolder>(entity =>
            {
                entity.HasKey(e => e.FFolderId)
                    .HasName("PK_FILE_FOLDER")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_OA_FileFolder");

                entity.Property(e => e.FFolderId)
                    .HasColumnName("F_FolderId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FFolderName)
                    .HasColumnName("F_FolderName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FFolderType)
                    .HasColumnName("F_FolderType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FIsShare).HasColumnName("F_IsShare");

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FParentId)
                    .HasColumnName("F_ParentId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FShareCode).HasColumnName("F_ShareCode");

                entity.Property(e => e.FShareLink)
                    .HasColumnName("F_ShareLink")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FShareTime)
                    .HasColumnName("F_ShareTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");
            });

            modelBuilder.Entity<LrOaFileInfo>(entity =>
            {
                entity.HasKey(e => e.FFileId)
                    .HasName("PK_FILE_DOCUMENT")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_OA_FileInfo");

                entity.Property(e => e.FFileId)
                    .HasColumnName("F_FileId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FDownloadCount).HasColumnName("F_DownloadCount");

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FFileExtensions)
                    .HasColumnName("F_FileExtensions")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FFileName)
                    .HasColumnName("F_FileName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FFilePath)
                    .HasColumnName("F_FilePath")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FFileSize)
                    .HasColumnName("F_FileSize")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FFileType)
                    .HasColumnName("F_FileType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FFolderId)
                    .HasColumnName("F_FolderId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FIsShare).HasColumnName("F_IsShare");

                entity.Property(e => e.FIsTop).HasColumnName("F_IsTop");

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FShareCode).HasColumnName("F_ShareCode");

                entity.Property(e => e.FShareLink)
                    .HasColumnName("F_ShareLink")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FShareTime)
                    .HasColumnName("F_ShareTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");
            });

            modelBuilder.Entity<LrOaNews>(entity =>
            {
                entity.HasKey(e => e.FNewsId)
                    .HasName("PK_BASE_NEWS")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_OA_News");

                entity.Property(e => e.FNewsId)
                    .HasColumnName("F_NewsId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FAuthorName)
                    .HasColumnName("F_AuthorName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FBriefHead)
                    .HasColumnName("F_BriefHead")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCategory)
                    .HasColumnName("F_Category")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCategoryId)
                    .HasColumnName("F_CategoryId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCompileName)
                    .HasColumnName("F_CompileName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FFullHead)
                    .HasColumnName("F_FullHead")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FFullHeadColor)
                    .HasColumnName("F_FullHeadColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FKeyword)
                    .HasColumnName("F_Keyword")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FNewsContent)
                    .HasColumnName("F_NewsContent")
                    .HasColumnType("text");

                entity.Property(e => e.FPv).HasColumnName("F_PV");

                entity.Property(e => e.FReleaseTime)
                    .HasColumnName("F_ReleaseTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");

                entity.Property(e => e.FSourceAddress)
                    .HasColumnName("F_SourceAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSourceName)
                    .HasColumnName("F_SourceName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FTagWord)
                    .HasColumnName("F_TagWord")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FTypeId).HasColumnName("F_TypeId");
            });

            modelBuilder.Entity<LrOaSchedule>(entity =>
            {
                entity.HasKey(e => e.FScheduleId)
                    .HasName("PK_BASE_SCHEDULE")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_OA_Schedule");

                entity.Property(e => e.FScheduleId)
                    .HasColumnName("F_ScheduleId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCategory)
                    .HasColumnName("F_Category")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEarly).HasColumnName("F_Early");

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FEndDate)
                    .HasColumnName("F_EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FEndTime)
                    .HasColumnName("F_EndTime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FIsMailAlert).HasColumnName("F_IsMailAlert");

                entity.Property(e => e.FIsMobileAlert).HasColumnName("F_IsMobileAlert");

                entity.Property(e => e.FIsWeChatAlert).HasColumnName("F_IsWeChatAlert");

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FScheduleContent)
                    .HasColumnName("F_ScheduleContent")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FScheduleName)
                    .HasColumnName("F_ScheduleName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FScheduleState).HasColumnName("F_ScheduleState");

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");

                entity.Property(e => e.FStartDate)
                    .HasColumnName("F_StartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FStartTime)
                    .HasColumnName("F_StartTime")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrReportTemp>(entity =>
            {
                entity.HasKey(e => e.FTempId)
                    .HasName("PK_RPT_TEMP")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_ReportTemp");

                entity.Property(e => e.FTempId)
                    .HasColumnName("F_TempId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnCode)
                    .HasColumnName("F_EnCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FFullName)
                    .HasColumnName("F_FullName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FParamJson)
                    .HasColumnName("F_ParamJson")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.FSortCode).HasColumnName("F_SortCode");

                entity.Property(e => e.FTempCategory)
                    .HasColumnName("F_TempCategory")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FTempStyle)
                    .HasColumnName("F_TempStyle")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FTempType)
                    .HasColumnName("F_TempType")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrWeChatDeptRelation>(entity =>
            {
                entity.HasKey(e => e.FDeptRelationId)
                    .HasName("PK_WECHAT_DEPTRELATION")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_WeChat_DeptRelation");

                entity.Property(e => e.FDeptRelationId)
                    .HasColumnName("F_DeptRelationId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeptId)
                    .HasColumnName("F_DeptId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeptName)
                    .HasColumnName("F_DeptName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FWeChatDeptId).HasColumnName("F_WeChatDeptId");
            });

            modelBuilder.Entity<LrWeChatUserRelation>(entity =>
            {
                entity.HasKey(e => e.FUserRelationId)
                    .HasName("PK_WeChat_UserRelation");

                entity.ToTable("LR_WeChat_UserRelation");

                entity.Property(e => e.FUserRelationId)
                    .HasColumnName("F_UserRelationId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeptId)
                    .HasColumnName("F_DeptId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeptName)
                    .HasColumnName("F_DeptName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSyncLog)
                    .HasColumnName("F_SyncLog")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FSyncState)
                    .HasColumnName("F_SyncState")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FUserId)
                    .HasColumnName("F_UserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FWeChatDeptId).HasColumnName("F_WeChatDeptId");
            });

            modelBuilder.Entity<LrWfConfluence>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_LR_Workflow_Confluence");

                entity.ToTable("LR_WF_Confluence");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FFormNodeId)
                    .HasColumnName("F_FormNodeId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FIsOk).HasColumnName("F_IsOk");

                entity.Property(e => e.FNodeId)
                    .HasColumnName("F_NodeId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FProcessId)
                    .HasColumnName("F_ProcessId")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrWfDelegateRecord>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_WF_DelegateRecord");

                entity.ToTable("LR_WF_DelegateRecord");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FFromUserId)
                    .HasColumnName("F_FromUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FFromUserName)
                    .HasColumnName("F_FromUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FProcessCode)
                    .HasColumnName("F_ProcessCode")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FProcessId)
                    .HasColumnName("F_ProcessId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FProcessName)
                    .HasColumnName("F_ProcessName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FToUserId)
                    .HasColumnName("F_ToUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FToUserName)
                    .HasColumnName("F_ToUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FWfdelegateRuleId)
                    .IsRequired()
                    .HasColumnName("F_WFDelegateRuleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrWfDelegateRule>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_WF_DelegateRule");

                entity.ToTable("LR_WF_DelegateRule");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FBeginDate)
                    .HasColumnName("F_BeginDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FEndDate)
                    .HasColumnName("F_EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FToUserId)
                    .HasColumnName("F_ToUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FToUserName)
                    .HasColumnName("F_ToUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrWfDelegateRuleRelation>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_LR_Workflow_DelegateRuleSchemeInfo");

                entity.ToTable("LR_WF_DelegateRuleRelation");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FDelegateRuleId)
                    .HasColumnName("F_DelegateRuleId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSchemeInfoId)
                    .HasColumnName("F_SchemeInfoId")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrWfProcessInstance>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK__WF_ProcessInstan__3B40CD36");

                entity.ToTable("LR_WF_ProcessInstance");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCompanyId)
                    .HasColumnName("F_CompanyId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .IsRequired()
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .IsRequired()
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDepartmentId)
                    .HasColumnName("F_DepartmentId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FIsAgain).HasColumnName("F_IsAgain");

                entity.Property(e => e.FIsChildFlow).HasColumnName("F_IsChildFlow");

                entity.Property(e => e.FIsFinished).HasColumnName("F_IsFinished");

                entity.Property(e => e.FProcessLevel).HasColumnName("F_ProcessLevel");

                entity.Property(e => e.FProcessName)
                    .HasColumnName("F_ProcessName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FProcessParentId)
                    .HasColumnName("F_ProcessParentId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSchemeCode)
                    .HasColumnName("F_SchemeCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSchemeId)
                    .HasColumnName("F_SchemeId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FSchemeName)
                    .HasColumnName("F_SchemeName")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrWfScheme>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_LR_Workflow_Scheme");

                entity.ToTable("LR_WF_Scheme");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FScheme)
                    .HasColumnName("F_Scheme")
                    .HasColumnType("text");

                entity.Property(e => e.FSchemeInfoId)
                    .HasColumnName("F_SchemeInfoId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FType).HasColumnName("F_Type");
            });

            modelBuilder.Entity<LrWfSchemeAuthorize>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_LR_Workflow_SchemeAuthorize");

                entity.ToTable("LR_WF_SchemeAuthorize");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FObjectId)
                    .HasColumnName("F_ObjectId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FObjectName)
                    .HasColumnName("F_ObjectName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FObjectType).HasColumnName("F_ObjectType");

                entity.Property(e => e.FSchemeInfoId)
                    .HasColumnName("F_SchemeInfoId")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrWfSchemeInfo>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK__LR_Workf__2C6EC72261BB7BD9")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LR_WF_SchemeInfo");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCategory)
                    .HasColumnName("F_Category")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCode)
                    .HasColumnName("F_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDeleteMark).HasColumnName("F_DeleteMark");

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FEnabledMark).HasColumnName("F_EnabledMark");

                entity.Property(e => e.FIsApp).HasColumnName("F_IsApp");

                entity.Property(e => e.FKind).HasColumnName("F_Kind");

                entity.Property(e => e.FName)
                    .HasColumnName("F_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FSchemeId)
                    .HasColumnName("F_SchemeId")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LrWfTask>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_LR_Workflow_Task");

                entity.ToTable("LR_WF_Task");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FAuditorId)
                    .HasColumnName("F_AuditorId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FAuditorName)
                    .HasColumnName("F_AuditorName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCompanyId)
                    .HasColumnName("F_CompanyId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDepartmentId)
                    .HasColumnName("F_DepartmentId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FIsFinished).HasColumnName("F_IsFinished");

                entity.Property(e => e.FModifyDate)
                    .HasColumnName("F_ModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FModifyUserId)
                    .HasColumnName("F_ModifyUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FModifyUserName)
                    .HasColumnName("F_ModifyUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FNodeId)
                    .HasColumnName("F_NodeId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FNodeName)
                    .HasColumnName("F_NodeName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FPreviousId)
                    .HasColumnName("F_PreviousId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FPreviousName)
                    .HasColumnName("F_PreviousName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FProcessId)
                    .HasColumnName("F_ProcessId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FTaskType).HasColumnName("F_TaskType");

                entity.Property(e => e.FTimeoutAction).HasColumnName("F_TimeoutAction");

                entity.Property(e => e.FTimeoutNotice).HasColumnName("F_TimeoutNotice");
            });

            modelBuilder.Entity<LrWfTaskHistory>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_LR_Workflow_TaskHistory");

                entity.ToTable("LR_WF_TaskHistory");

                entity.Property(e => e.FId)
                    .HasColumnName("F_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FCreateDate)
                    .HasColumnName("F_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FCreateUserId)
                    .HasColumnName("F_CreateUserId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCreateUserName)
                    .HasColumnName("F_CreateUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FDescription)
                    .HasColumnName("F_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FNodeId)
                    .HasColumnName("F_NodeId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FNodeName)
                    .HasColumnName("F_NodeName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FPreviousId)
                    .HasColumnName("F_PreviousId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FPreviousName)
                    .HasColumnName("F_PreviousName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FProcessId)
                    .HasColumnName("F_ProcessId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FResult).HasColumnName("F_Result");

                entity.Property(e => e.FTaskType).HasColumnName("F_TaskType");
            });

            modelBuilder.Entity<NetAdminauthorization>(entity =>
            {
                entity.ToTable("net_adminauthorization");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyUser)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MoidfyDate).HasColumnType("datetime");

                entity.Property(e => e.NetId)
                    .HasColumnName("netId")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NetAdmindb>(entity =>
            {
                entity.ToTable("net_admindb");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DbIpaddress)
                    .HasColumnName("DB_IPAddress")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DbPort)
                    .HasColumnName("DB_Port")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DbRemark)
                    .HasColumnName("DB_Remark")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DbUserName)
                    .HasColumnName("DB_UserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DbUserPassword)
                    .HasColumnName("DB_UserPassword")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pid)
                    .HasColumnName("PID")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
