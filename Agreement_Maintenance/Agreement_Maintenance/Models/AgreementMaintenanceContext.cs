using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Agreement_Maintenance.Models;

public partial class AgreementMaintenanceContext : DbContext
{
    public AgreementMaintenanceContext()
    {
    }

    public AgreementMaintenanceContext(DbContextOptions<AgreementMaintenanceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AgreementDetail> AgreementDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=localhost;Port=5433;User Id=postgres;Password=Siva@123;Database=Agreement_Maintenance;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AgreementDetail>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("Agreement_Details_pkey");

            entity.ToTable("Agreement_Details");

            entity.Property(e => e.Sno).ValueGeneratedNever();
            entity.Property(e => e.AgreementStatus).HasColumnName("Agreement_Status");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.CreatedOn).HasColumnName("Created_On");
            entity.Property(e => e.EndDateOfAgreement).HasColumnName("End_Date_Of_Agreement");
            entity.Property(e => e.NameOfTheParty).HasColumnName("Name_Of_The_Party");
            entity.Property(e => e.NatureOfAgreement).HasColumnName("Nature_Of_Agreement");
            entity.Property(e => e.NotificationTriggeredCount).HasColumnName("Notification_Triggered_Count");
            entity.Property(e => e.StartDateOfAgreement).HasColumnName("Start_Date_Of_Agreement");
            entity.Property(e => e.VendorCode).HasColumnName("Vendor_Code");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
