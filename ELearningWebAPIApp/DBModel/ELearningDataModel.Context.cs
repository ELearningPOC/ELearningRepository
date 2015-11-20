﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ELearning.WebAPI.DBModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ELearningDbEntities : DbContext
    {
        public ELearningDbEntities()
            : base("name=ELearningDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public DbSet<CategoryMaster> CategoryMasters { get; set; }
        public DbSet<ChapterContent> ChapterContents { get; set; }
        public DbSet<ChapterDetail> ChapterDetails { get; set; }
        public DbSet<CountryMaster> CountryMasters { get; set; }
        public DbSet<CourseBookmark> CourseBookmarks { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }
        public DbSet<CourseStatusMaster> CourseStatusMasters { get; set; }
        public DbSet<FileTypeMaster> FileTypeMasters { get; set; }
        public DbSet<GenderMaster> GenderMasters { get; set; }
        public DbSet<ImageMaster> ImageMasters { get; set; }
        public DbSet<NotificationTypeMaster> NotificationTypeMasters { get; set; }
        public DbSet<RoleMaster> RoleMasters { get; set; }
        public DbSet<TenantMaster> TenantMasters { get; set; }
        public DbSet<ThirdpartyProvider> ThirdpartyProviders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserInterest> UserInterests { get; set; }
        public DbSet<UserLoginAuditTrail> UserLoginAuditTrails { get; set; }
        public DbSet<UserNotification> UserNotifications { get; set; }
        public DbSet<UserStatusMaster> UserStatusMasters { get; set; }
    }
}