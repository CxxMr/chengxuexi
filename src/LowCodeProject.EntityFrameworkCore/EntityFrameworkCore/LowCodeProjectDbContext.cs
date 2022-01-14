using LowCodeProject.Model;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace LowCodeProject.EntityFrameworkCore
{
    [ReplaceDbContext(typeof(IIdentityDbContext))]
    [ReplaceDbContext(typeof(ITenantManagementDbContext))]
    [ConnectionStringName("Default")]
    public class LowCodeProjectDbContext : 
        AbpDbContext<LowCodeProjectDbContext>,
        IIdentityDbContext,
        ITenantManagementDbContext
    {
        /* Add DbSet properties for your Aggregate Roots / Entities here. */
        
        #region Entities from the modules
        
        /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
         * and replaced them for this DbContext. This allows you to perform JOIN
         * queries for the entities of these modules over the repositories easily. You
         * typically don't need that for other modules. But, if you need, you can
         * implement the DbContext interface of the needed module and use ReplaceDbContext
         * attribute just like IIdentityDbContext and ITenantManagementDbContext.
         *
         * More info: Replacing a DbContext of a module ensures that the related module
         * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
         */
        
        //Identity
        public DbSet<IdentityUser> Users { get; set; }
        public DbSet<IdentityRole> Roles { get; set; }
        public DbSet<IdentityClaimType> ClaimTypes { get; set; }
        public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
        public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
        public DbSet<IdentityLinkUser> LinkUsers { get; set; }
        
        // Tenant Management
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

        #endregion
        /// <summary>
        ///  低代码平台表
        /// </summary>
        #region
        public DbSet<MyUserModel> UserModel { get; set; }
        public DbSet<MyRoleModel> RoleModel { get; set; }
        public DbSet<MyPowerModel> PowerModel { get; set; }
        public DbSet<MyUserRoleModel> UserRoleModel { get; set; }
        public DbSet<MyRolePowerModel> RolePowerModel { get; set; }
        public DbSet<ApplyTypeModel> ApplyTypeModel { get; set; }
        public DbSet<FormatModel> FormatModel { get; set; }
        public DbSet<MemberModel> MemberModel { get; set; }
        public DbSet<JournalModel> JournalModel { get; set; }
        public DbSet<TreeModel> TreeModel { get; set; }
        public DbSet<MyOrederForm> MyOrederForm { get; set; }
        public DbSet<SchemeModel> SchemeModel { get; set; }
        public DbSet<MyMessage> MyMessage { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<UploadPicture> UploadPicture { get; set; }
        public DbSet<WarehouseModel> WarehouseModel { get; set; }


        #endregion

        public LowCodeProjectDbContext(DbContextOptions<LowCodeProjectDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */
            
            builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureBackgroundJobs();
            builder.ConfigureAuditLogging();
            builder.ConfigureIdentity();
            builder.ConfigureIdentityServer();
            builder.ConfigureFeatureManagement();
            builder.ConfigureTenantManagement();

            /* Configure your own tables/entities inside here */

            builder.Entity<MyUserModel>(x => x.ToTable("tb_UserModel"));
            builder.Entity<MyRoleModel>(x => x.ToTable("tb_RoleModel"));
            builder.Entity<MyPowerModel>(x => x.ToTable("tb_PowerModel"));
            builder.Entity<MyUserRoleModel>(x => x.ToTable("tb_UserRoleModel"));
            builder.Entity<MyRolePowerModel>(x => x.ToTable("tb_RolePowerModel"));
            builder.Entity<ApplyTypeModel>(x => x.ToTable("tb_ApplyTypeModel"));
            builder.Entity<MemberModel>(x => x.ToTable("tb_MemberModel"));
            builder.Entity<JournalModel>(x => x.ToTable("tb_JournalModel"));
            builder.Entity<TreeModel>(x => x.ToTable("tb_TreeModel"));
            builder.Entity<MyOrederForm>(x => x.ToTable("tb_MyOrederForm"));
            builder.Entity<SchemeModel>(x => x.ToTable("tb_SchemeModel"));
            builder.Entity<MyMessage>(x => x.ToTable("tb_MyMessage"));
            builder.Entity<Department>(x => x.ToTable("tb_Department"));
            builder.Entity<UploadPicture>(x => x.ToTable("tb_UploadPicture"));
            builder.Entity<WarehouseModel>(x => x.ToTable("tb_WarehouseModel"));
            builder.Entity<FormatModel>(x => x.ToTable("tb_FormatModel"));
            
            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(LowCodeProjectConsts.DbTablePrefix + "YourEntities", LowCodeProjectConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}
