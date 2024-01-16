﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WIS_PrototypeAPI.Data;

#nullable disable

namespace WIS_PrototypeAPI.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WIS_PrototypeAPI.Data.Models.Bin", b =>
                {
                    b.Property<int>("BinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BinId"));

                    b.Property<string>("BinName")
                        .HasColumnType("nvarchar(50");

                    b.Property<int?>("CommodityTypeIdLink")
                        .HasColumnType("int");

                    b.Property<long?>("CommodityVerietyIdLink")
                        .HasColumnType("bigint");

                    b.Property<int?>("NetIntake")
                        .HasColumnType("int");

                    b.Property<int?>("WarehouseIdLink")
                        .HasColumnType("int");

                    b.HasKey("BinId");

                    b.HasIndex("CommodityTypeIdLink");

                    b.HasIndex("CommodityVerietyIdLink");

                    b.HasIndex("WarehouseIdLink");

                    b.ToTable("Bins");
                });

            modelBuilder.Entity("WIS_PrototypeAPI.Data.Models.CommodityType", b =>
                {
                    b.Property<int>("CommodityTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommodityTypeId"));

                    b.Property<string>("CommodityTypeName")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CommodityTypeId");

                    b.ToTable("CommodityTypes");
                });

            modelBuilder.Entity("WIS_PrototypeAPI.Data.Models.CommodityVeriety", b =>
                {
                    b.Property<long>("CommodityVerietyeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CommodityVerietyeId"));

                    b.Property<int?>("CommodityTypeIdLink")
                        .HasColumnType("int");

                    b.Property<string>("CommodityVerietyName")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CommodityVerietyeId");

                    b.HasIndex("CommodityTypeIdLink");

                    b.ToTable("CommodityVerieties");
                });

            modelBuilder.Entity("WIS_PrototypeAPI.Data.Models.District", b =>
                {
                    b.Property<int>("DistrictId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DistrictId"));

                    b.Property<string>("DistrictName")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("DistrictId");

                    b.ToTable("District");
                });

            modelBuilder.Entity("WIS_PrototypeAPI.Data.Models.Load", b =>
                {
                    b.Property<long>("LoadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("LoadId"));

                    b.Property<string>("BillOfLading")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("GrossWeight")
                        .HasColumnType("int");

                    b.Property<double?>("MoistureLevel")
                        .HasColumnType("float");

                    b.Property<int?>("NetWeight")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(200)");

                    b.Property<double?>("ProtienLevel")
                        .HasColumnType("float");

                    b.Property<int?>("TareWeight")
                        .HasColumnType("int");

                    b.Property<double?>("TestWeight")
                        .HasColumnType("float");

                    b.Property<DateTime?>("TimeIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("TimeOut")
                        .HasColumnType("datetime2");

                    b.Property<string>("TruckId")
                        .HasColumnType("nvarchar(20)");

                    b.Property<long?>("WeightSheetId")
                        .HasColumnType("bigint");

                    b.HasKey("LoadId");

                    b.HasIndex("WeightSheetId");

                    b.ToTable("Load");
                });

            modelBuilder.Entity("WIS_PrototypeAPI.Data.Models.Lot", b =>
                {
                    b.Property<long>("LotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("LotId"));

                    b.Property<int?>("CommodityTypeIdLink")
                        .HasColumnType("int");

                    b.Property<long?>("CommodityVerietyIdLink")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FarmNumber")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Landlord")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("ProducerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StateId")
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("LotId");

                    b.HasIndex("CommodityTypeIdLink");

                    b.HasIndex("CommodityVerietyIdLink");

                    b.HasIndex("ProducerId");

                    b.ToTable("Lot");
                });

            modelBuilder.Entity("WIS_PrototypeAPI.Data.Models.Producer", b =>
                {
                    b.Property<int>("ProducerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProducerId"));

                    b.Property<string>("ProducerName")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ProducerId");

                    b.ToTable("Producer");
                });

            modelBuilder.Entity("WIS_PrototypeAPI.Data.Models.Warehouse", b =>
                {
                    b.Property<int>("WarehouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WarehouseId"));

                    b.Property<int?>("DistrictIdLink")
                        .HasColumnType("int");

                    b.Property<string>("WarehouseName")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("WarehouseId");

                    b.HasIndex("DistrictIdLink");

                    b.ToTable("Warehouse");
                });

            modelBuilder.Entity("WIS_PrototypeAPI.Data.Models.Weightsheet", b =>
                {
                    b.Property<long>("WeightSheetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("WeightSheetId"));

                    b.Property<string>("BillOfLading")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("CommodityTypeIdLink")
                        .HasColumnType("int");

                    b.Property<long?>("CommodityVerietyIdLink")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateClosed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOpened")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hauler")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Miles")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("ProducerIdLink")
                        .HasColumnType("int");

                    b.Property<int?>("SourceIdLink")
                        .HasColumnType("int");

                    b.Property<string>("Weigher")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("WeightSheetId");

                    b.HasIndex("CommodityTypeIdLink");

                    b.HasIndex("CommodityVerietyIdLink");

                    b.HasIndex("ProducerIdLink");

                    b.HasIndex("SourceIdLink");

                    b.ToTable("Weightsheet");
                });

            modelBuilder.Entity("WIS_PrototypeAPI.Data.Models.Bin", b =>
                {
                    b.HasOne("WIS_PrototypeAPI.Data.Models.CommodityType", "CommodityType")
                        .WithMany()
                        .HasForeignKey("CommodityTypeIdLink");

                    b.HasOne("WIS_PrototypeAPI.Data.Models.CommodityVeriety", "CommodityVeriety")
                        .WithMany()
                        .HasForeignKey("CommodityVerietyIdLink");

                    b.HasOne("WIS_PrototypeAPI.Data.Models.Warehouse", "Warehouse")
                        .WithMany("Bins")
                        .HasForeignKey("WarehouseIdLink");

                    b.Navigation("CommodityType");

                    b.Navigation("CommodityVeriety");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("WIS_PrototypeAPI.Data.Models.CommodityVeriety", b =>
                {
                    b.HasOne("WIS_PrototypeAPI.Data.Models.CommodityType", "CommodityType")
                        .WithMany("CommodityVerieties")
                        .HasForeignKey("CommodityTypeIdLink");

                    b.Navigation("CommodityType");
                });

            modelBuilder.Entity("WIS_PrototypeAPI.Data.Models.Load", b =>
                {
                    b.HasOne("WIS_PrototypeAPI.Data.Models.Weightsheet", null)
                        .WithMany("Loads")
                        .HasForeignKey("WeightSheetId");
                });

            modelBuilder.Entity("WIS_PrototypeAPI.Data.Models.Lot", b =>
                {
                    b.HasOne("WIS_PrototypeAPI.Data.Models.CommodityType", "CommodityType")
                        .WithMany()
                        .HasForeignKey("CommodityTypeIdLink");

                    b.HasOne("WIS_PrototypeAPI.Data.Models.CommodityVeriety", "CommodityVeriety")
                        .WithMany()
                        .HasForeignKey("CommodityVerietyIdLink");

                    b.HasOne("WIS_PrototypeAPI.Data.Models.Producer", null)
                        .WithMany("Lots")
                        .HasForeignKey("ProducerId");

                    b.Navigation("CommodityType");

                    b.Navigation("CommodityVeriety");
                });

            modelBuilder.Entity("WIS_PrototypeAPI.Data.Models.Warehouse", b =>
                {
                    b.HasOne("WIS_PrototypeAPI.Data.Models.District", "District")
                        .WithMany("Warehouses")
                        .HasForeignKey("DistrictIdLink");

                    b.Navigation("District");
                });

            modelBuilder.Entity("WIS_PrototypeAPI.Data.Models.Weightsheet", b =>
                {
                    b.HasOne("WIS_PrototypeAPI.Data.Models.CommodityType", "CommodityType")
                        .WithMany()
                        .HasForeignKey("CommodityTypeIdLink");

                    b.HasOne("WIS_PrototypeAPI.Data.Models.CommodityVeriety", "CommodityVeriety")
                        .WithMany()
                        .HasForeignKey("CommodityVerietyIdLink");

                    b.HasOne("WIS_PrototypeAPI.Data.Models.Producer", "Producer")
                        .WithMany()
                        .HasForeignKey("ProducerIdLink");

                    b.HasOne("WIS_PrototypeAPI.Data.Models.Warehouse", "Warehouse")
                        .WithMany("Weightsheets")
                        .HasForeignKey("SourceIdLink");

                    b.Navigation("CommodityType");

                    b.Navigation("CommodityVeriety");

                    b.Navigation("Producer");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("WIS_PrototypeAPI.Data.Models.CommodityType", b =>
                {
                    b.Navigation("CommodityVerieties");
                });

            modelBuilder.Entity("WIS_PrototypeAPI.Data.Models.District", b =>
                {
                    b.Navigation("Warehouses");
                });

            modelBuilder.Entity("WIS_PrototypeAPI.Data.Models.Producer", b =>
                {
                    b.Navigation("Lots");
                });

            modelBuilder.Entity("WIS_PrototypeAPI.Data.Models.Warehouse", b =>
                {
                    b.Navigation("Bins");

                    b.Navigation("Weightsheets");
                });

            modelBuilder.Entity("WIS_PrototypeAPI.Data.Models.Weightsheet", b =>
                {
                    b.Navigation("Loads");
                });
#pragma warning restore 612, 618
        }
    }
}
