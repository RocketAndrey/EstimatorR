﻿// <auto-generated />
using System;
using Estimator.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Estimator.Migrations
{
    [DbContext(typeof(EstimatorContext))]
    [Migration("20240122104919_QualityLevel")]
    partial class QualityLevel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Estimator.Models.AsuViews.DefectedType", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"), 1L, 1);

                    b.Property<long>("DefectCount")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ElementImportID")
                        .HasColumnType("int");

                    b.Property<bool>("NormTY")
                        .HasColumnType("bit");

                    b.Property<string>("ProtokolNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RFA")
                        .HasColumnType("bit");

                    b.Property<string>("TY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeNominal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Unrecommend")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("ElementImportID");

                    b.ToTable("DefectedType");
                });

            modelBuilder.Entity("Estimator.Models.CalcFactor", b =>
                {
                    b.Property<int>("CalcFactorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CalcFactorID"), 1L, 1);

                    b.Property<int>("CompanyHistoryID")
                        .HasColumnType("int");

                    b.Property<string>("FactorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("FactorValue")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("CalcFactorID");

                    b.HasIndex("CompanyHistoryID");

                    b.ToTable("CalcFactor", (string)null);
                });

            modelBuilder.Entity("Estimator.Models.ClassECB", b =>
                {
                    b.Property<int>("ClassECBID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassECBID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ClassECBID");

                    b.ToTable("ClassECB", (string)null);
                });

            modelBuilder.Entity("Estimator.Models.CompanyHistory", b =>
                {
                    b.Property<int>("CompanyHistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyHistoryID"), 1L, 1);

                    b.Property<decimal>("AdditionalSalary")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Margin")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("OverHead")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("PensionTax")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("YearOfNorms")
                        .HasColumnType("int");

                    b.HasKey("CompanyHistoryID");

                    b.ToTable("CompanyHistory", (string)null);
                });

            modelBuilder.Entity("Estimator.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"), 1L, 1);

                    b.Property<string>("INN")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("Estimator.Models.CustomerRequest", b =>
                {
                    b.Property<int>("CustomerRequestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerRequestID"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreateUserID")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsProceed")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModificateUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModificateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ParentCustomerRequestID")
                        .HasColumnType("int");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,4)");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RequestNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TestProgramID")
                        .HasColumnType("int");

                    b.Property<bool>("UseImport")
                        .HasColumnType("bit");

                    b.HasKey("CustomerRequestID");

                    b.HasIndex("CreateUserID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("LastModificateUserID");

                    b.HasIndex("ParentCustomerRequestID")
                        .IsUnique()
                        .HasFilter("[ParentCustomerRequestID] IS NOT NULL");

                    b.HasIndex("TestProgramID");

                    b.ToTable("CustomerRequests", (string)null);
                });

            modelBuilder.Entity("Estimator.Models.ElementImport", b =>
                {
                    b.Property<int>("ElementImportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ElementImportID"), 1L, 1);

                    b.Property<int>("CustomerRequestID")
                        .HasColumnType("int");

                    b.Property<int>("DatasheetColumn")
                        .HasColumnType("int");

                    b.Property<int>("DeliveryTimeColumn")
                        .HasColumnType("int");

                    b.Property<int>("DownloadPriceColumn")
                        .HasColumnType("int");

                    b.Property<int>("ElementContractorPriceColumn")
                        .HasColumnType("int");

                    b.Property<int>("ElementCountColumn")
                        .HasColumnType("int");

                    b.Property<int>("ElementKitPriceColumn")
                        .HasColumnType("int");

                    b.Property<int>("ElementNameColumn")
                        .HasColumnType("int");

                    b.Property<int>("ElementPriceColumn")
                        .HasColumnType("int");

                    b.Property<int>("ElementTypeKeyColumn")
                        .HasColumnType("int");

                    b.Property<bool>("FileUploaded")
                        .HasColumnType("bit");

                    b.Property<bool>("FirstRowIsHeader")
                        .HasColumnType("bit");

                    b.Property<int>("FirstRowNumber")
                        .HasColumnType("int");

                    b.Property<bool>("GroupSameTypes")
                        .HasColumnType("bit");

                    b.Property<bool>("ImportDatasheet")
                        .HasColumnType("bit");

                    b.Property<bool>("ImportDeliveryTime")
                        .HasColumnType("bit");

                    b.Property<bool>("ImportElementContractorPrice")
                        .HasColumnType("bit");

                    b.Property<bool>("ImportElementPrice")
                        .HasColumnType("bit");

                    b.Property<bool>("ImportElementКitPrice")
                        .HasColumnType("bit");

                    b.Property<bool>("ImportQualityLevel")
                        .HasColumnType("bit");

                    b.Property<int>("LastRowNumber")
                        .HasColumnType("int");

                    b.Property<int>("QualityLevelColumn")
                        .HasColumnType("int");

                    b.Property<bool>("UseElementPrice")
                        .HasColumnType("bit");

                    b.Property<bool>("UseLastCalculation")
                        .HasColumnType("bit");

                    b.Property<bool>("UseLastRowNumber")
                        .HasColumnType("bit");

                    b.HasKey("ElementImportID");

                    b.HasIndex("CustomerRequestID");

                    b.ToTable("ElementImports");
                });

            modelBuilder.Entity("Estimator.Models.ElementKey", b =>
                {
                    b.Property<int>("ElementKeyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ElementKeyID"), 1L, 1);

                    b.Property<int>("ElementTypeID")
                        .HasColumnType("int");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ElementKeyID");

                    b.HasIndex("ElementTypeID");

                    b.ToTable("ElementKey");
                });

            modelBuilder.Entity("Estimator.Models.ElementType", b =>
                {
                    b.Property<int>("ElementTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ElementTypeID"), 1L, 1);

                    b.Property<bool>("CheckInAsu")
                        .HasColumnType("bit");

                    b.Property<int?>("ChildElementTypeID")
                        .HasColumnType("int");

                    b.Property<int>("ClassECBID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("ProgramID")
                        .HasColumnType("int");

                    b.HasKey("ElementTypeID");

                    b.HasIndex("ClassECBID");

                    b.HasIndex("ProgramID");

                    b.ToTable("ElementType", (string)null);
                });

            modelBuilder.Entity("Estimator.Models.Operation", b =>
                {
                    b.Property<int>("OperationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OperationID"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<bool>("DPO")
                        .HasColumnType("bit");

                    b.Property<bool>("IsExecuteDefault")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("OperationGroupID")
                        .HasColumnType("int");

                    b.Property<int>("SampleCount")
                        .HasColumnType("int");

                    b.HasKey("OperationID");

                    b.HasIndex("OperationGroupID");

                    b.ToTable("Operation", (string)null);
                });

            modelBuilder.Entity("Estimator.Models.OperationGroup", b =>
                {
                    b.Property<int>("OperationGroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OperationGroupID"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("OperationGroupID");

                    b.ToTable("OperationGroup", (string)null);
                });

            modelBuilder.Entity("Estimator.Models.Qualification", b =>
                {
                    b.Property<int>("QualificationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QualificationID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("QualificationID");

                    b.ToTable("Qualification", (string)null);
                });

            modelBuilder.Entity("Estimator.Models.RequestElementType", b =>
                {
                    b.Property<int>("RequestElementTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequestElementTypeID"), 1L, 1);

                    b.Property<int>("BatchCount")
                        .HasColumnType("int");

                    b.Property<int>("CustomerRequestID")
                        .HasColumnType("int");

                    b.Property<int?>("ElementTypeID")
                        .HasColumnType("int");

                    b.Property<int>("ItemCount")
                        .HasColumnType("int");

                    b.Property<int>("KitCount")
                        .HasColumnType("int");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("RequestElementTypeID");

                    b.HasIndex("CustomerRequestID");

                    b.HasIndex("ElementTypeID");

                    b.ToTable("RequestElementType", (string)null);
                });

            modelBuilder.Entity("Estimator.Models.RequestOperation", b =>
                {
                    b.Property<int>("RequestOperationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequestOperationID"), 1L, 1);

                    b.Property<int>("ExecuteCount")
                        .HasColumnType("int");

                    b.Property<bool>("IsExecute")
                        .HasColumnType("bit");

                    b.Property<int>("RequestElementTypeID")
                        .HasColumnType("int");

                    b.Property<int>("SampleCount")
                        .HasColumnType("int");

                    b.Property<int?>("TestChainItemID")
                        .HasColumnType("int");

                    b.HasKey("RequestOperationID");

                    b.HasIndex("RequestElementTypeID");

                    b.HasIndex("TestChainItemID");

                    b.ToTable("RequestOperation", (string)null);
                });

            modelBuilder.Entity("Estimator.Models.StaffItem", b =>
                {
                    b.Property<int>("StaffItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StaffItemID"), 1L, 1);

                    b.Property<int>("CompanyHistoryID")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("QualificationID")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("StaffItemID");

                    b.HasIndex("CompanyHistoryID");

                    b.HasIndex("QualificationID");

                    b.ToTable("StaffItem", (string)null);
                });

            modelBuilder.Entity("Estimator.Models.TestAction", b =>
                {
                    b.Property<int>("TestActionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestActionID"), 1L, 1);

                    b.Property<int>("BatchLabor")
                        .HasColumnType("int");

                    b.Property<decimal>("ItemLabor")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("KitLabor")
                        .HasColumnType("int");

                    b.Property<int>("QualificationID")
                        .HasColumnType("int");

                    b.Property<int>("TestChainItemID")
                        .HasColumnType("int");

                    b.HasKey("TestActionID");

                    b.HasIndex("QualificationID");

                    b.HasIndex("TestChainItemID");

                    b.ToTable("TestAction", (string)null);
                });

            modelBuilder.Entity("Estimator.Models.TestChainItem", b =>
                {
                    b.Property<int>("TestChainItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestChainItemID"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("ElementTypeID")
                        .HasColumnType("int");

                    b.Property<int>("GroupOperation")
                        .HasColumnType("int");

                    b.Property<int>("OperationID")
                        .HasColumnType("int");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("TestChainItemID");

                    b.HasIndex("ElementTypeID");

                    b.HasIndex("OperationID");

                    b.ToTable("TestChainItem", (string)null);
                });

            modelBuilder.Entity("Estimator.Models.TestProgram", b =>
                {
                    b.Property<int>("TestProgramID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestProgramID"), 1L, 1);

                    b.Property<bool>("AllowEditChain")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ParentProgramID")
                        .HasColumnType("int");

                    b.HasKey("TestProgramID");

                    b.ToTable("TestProgram", (string)null);
                });

            modelBuilder.Entity("Estimator.Models.TestProgramTemplate", b =>
                {
                    b.Property<int>("TestProgramTemplateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestProgramTemplateID"), 1L, 1);

                    b.Property<string>("TemplateName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TestProgramID")
                        .HasColumnType("int");

                    b.HasKey("TestProgramTemplateID");

                    b.HasIndex("TestProgramID");

                    b.ToTable("TestProgramTemplate", (string)null);
                });

            modelBuilder.Entity("Estimator.Models.TestProgramTemplateItem", b =>
                {
                    b.Property<int>("TestProgramTemplateItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestProgramTemplateItemID"), 1L, 1);

                    b.Property<int>("ExecuteCount")
                        .HasColumnType("int");

                    b.Property<bool>("IsExecute")
                        .HasColumnType("bit");

                    b.Property<int?>("OperationID")
                        .HasColumnType("int");

                    b.Property<int>("TestProgramTemplateID")
                        .HasColumnType("int");

                    b.HasKey("TestProgramTemplateItemID");

                    b.HasIndex("OperationID");

                    b.HasIndex("TestProgramTemplateID");

                    b.ToTable("TestProgramTemplateItem", (string)null);
                });

            modelBuilder.Entity("Estimator.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Estimator.Models.ViewModels.RequestOperationGroupView", b =>
                {
                    b.Property<int>("ExecuteCount")
                        .HasColumnType("int");

                    b.Property<bool>("IsExecute")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationGroupCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OperationID")
                        .HasColumnType("int");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("SampleCount")
                        .HasColumnType("int");

                    b.ToTable("RequestOperationGroupViews");
                });

            modelBuilder.Entity("Estimator.Models.XLSXElementType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("AsuProtokolCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BeforeUploadedXLSXElementTypeID")
                        .HasColumnType("int");

                    b.Property<string>("Datasheet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DeliveryTime")
                        .HasColumnType("int");

                    b.Property<decimal>("ElementContractorPrice")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("ElementCount")
                        .HasColumnType("int");

                    b.Property<int>("ElementImportID")
                        .HasColumnType("int");

                    b.Property<decimal>("ElementKitPrice")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("ElementName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ElementPrice")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int?>("ElementTypeID")
                        .HasColumnType("int");

                    b.Property<string>("ElementTypeKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImportedQualificationLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RowNum")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ElementImportID");

                    b.ToTable("XLSXElementType", (string)null);
                });

            modelBuilder.Entity("Estimator.Models.AsuViews.DefectedType", b =>
                {
                    b.HasOne("Estimator.Models.ElementImport", null)
                        .WithMany("DefectedTypes")
                        .HasForeignKey("ElementImportID");
                });

            modelBuilder.Entity("Estimator.Models.CalcFactor", b =>
                {
                    b.HasOne("Estimator.Models.CompanyHistory", "CompanyHistory")
                        .WithMany("CalcFactors")
                        .HasForeignKey("CompanyHistoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyHistory");
                });

            modelBuilder.Entity("Estimator.Models.CustomerRequest", b =>
                {
                    b.HasOne("Estimator.Models.User", "CreateUser")
                        .WithMany()
                        .HasForeignKey("CreateUserID");

                    b.HasOne("Estimator.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Estimator.Models.User", "LastModificateUser")
                        .WithMany()
                        .HasForeignKey("LastModificateUserID");

                    b.HasOne("Estimator.Models.CustomerRequest", "ParentCustomerRequest")
                        .WithOne("ChildCustomerRequest")
                        .HasForeignKey("Estimator.Models.CustomerRequest", "ParentCustomerRequestID");

                    b.HasOne("Estimator.Models.TestProgram", "Program")
                        .WithMany()
                        .HasForeignKey("TestProgramID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreateUser");

                    b.Navigation("Customer");

                    b.Navigation("LastModificateUser");

                    b.Navigation("ParentCustomerRequest");

                    b.Navigation("Program");
                });

            modelBuilder.Entity("Estimator.Models.ElementImport", b =>
                {
                    b.HasOne("Estimator.Models.CustomerRequest", "CustomerRequest")
                        .WithMany()
                        .HasForeignKey("CustomerRequestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerRequest");
                });

            modelBuilder.Entity("Estimator.Models.ElementKey", b =>
                {
                    b.HasOne("Estimator.Models.ElementType", "ElementType")
                        .WithMany("Keys")
                        .HasForeignKey("ElementTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ElementType");
                });

            modelBuilder.Entity("Estimator.Models.ElementType", b =>
                {
                    b.HasOne("Estimator.Models.ClassECB", "Class")
                        .WithMany()
                        .HasForeignKey("ClassECBID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Estimator.Models.TestProgram", "Program")
                        .WithMany("ElementntTypes")
                        .HasForeignKey("ProgramID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Program");
                });

            modelBuilder.Entity("Estimator.Models.Operation", b =>
                {
                    b.HasOne("Estimator.Models.OperationGroup", "OperationGroup")
                        .WithMany()
                        .HasForeignKey("OperationGroupID");

                    b.Navigation("OperationGroup");
                });

            modelBuilder.Entity("Estimator.Models.RequestElementType", b =>
                {
                    b.HasOne("Estimator.Models.CustomerRequest", "CustomerRequest")
                        .WithMany("RequestElementTypes")
                        .HasForeignKey("CustomerRequestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Estimator.Models.ElementType", "ElementType")
                        .WithMany()
                        .HasForeignKey("ElementTypeID");

                    b.Navigation("CustomerRequest");

                    b.Navigation("ElementType");
                });

            modelBuilder.Entity("Estimator.Models.RequestOperation", b =>
                {
                    b.HasOne("Estimator.Models.RequestElementType", "RequestElementType")
                        .WithMany("RequestOperations")
                        .HasForeignKey("RequestElementTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Estimator.Models.TestChainItem", "TestChainItem")
                        .WithMany()
                        .HasForeignKey("TestChainItemID");

                    b.Navigation("RequestElementType");

                    b.Navigation("TestChainItem");
                });

            modelBuilder.Entity("Estimator.Models.StaffItem", b =>
                {
                    b.HasOne("Estimator.Models.CompanyHistory", "Company")
                        .WithMany("Staff")
                        .HasForeignKey("CompanyHistoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Estimator.Models.Qualification", "Qualification")
                        .WithMany()
                        .HasForeignKey("QualificationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Qualification");
                });

            modelBuilder.Entity("Estimator.Models.TestAction", b =>
                {
                    b.HasOne("Estimator.Models.Qualification", "Qualification")
                        .WithMany()
                        .HasForeignKey("QualificationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Estimator.Models.TestChainItem", "TestChainItem")
                        .WithMany("TestActions")
                        .HasForeignKey("TestChainItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Qualification");

                    b.Navigation("TestChainItem");
                });

            modelBuilder.Entity("Estimator.Models.TestChainItem", b =>
                {
                    b.HasOne("Estimator.Models.ElementType", "ElementType")
                        .WithMany("ChainItems")
                        .HasForeignKey("ElementTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Estimator.Models.Operation", "Operation")
                        .WithMany()
                        .HasForeignKey("OperationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ElementType");

                    b.Navigation("Operation");
                });

            modelBuilder.Entity("Estimator.Models.TestProgramTemplate", b =>
                {
                    b.HasOne("Estimator.Models.TestProgram", "Program")
                        .WithMany("Templates")
                        .HasForeignKey("TestProgramID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Program");
                });

            modelBuilder.Entity("Estimator.Models.TestProgramTemplateItem", b =>
                {
                    b.HasOne("Estimator.Models.Operation", "Operation")
                        .WithMany()
                        .HasForeignKey("OperationID");

                    b.HasOne("Estimator.Models.TestProgramTemplate", "ProgramTemplate")
                        .WithMany("TemplateItems")
                        .HasForeignKey("TestProgramTemplateID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Operation");

                    b.Navigation("ProgramTemplate");
                });

            modelBuilder.Entity("Estimator.Models.XLSXElementType", b =>
                {
                    b.HasOne("Estimator.Models.ElementImport", "ElementImport")
                        .WithMany("XLSXElementTypes")
                        .HasForeignKey("ElementImportID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ElementImport");
                });

            modelBuilder.Entity("Estimator.Models.CompanyHistory", b =>
                {
                    b.Navigation("CalcFactors");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Estimator.Models.CustomerRequest", b =>
                {
                    b.Navigation("ChildCustomerRequest");

                    b.Navigation("RequestElementTypes");
                });

            modelBuilder.Entity("Estimator.Models.ElementImport", b =>
                {
                    b.Navigation("DefectedTypes");

                    b.Navigation("XLSXElementTypes");
                });

            modelBuilder.Entity("Estimator.Models.ElementType", b =>
                {
                    b.Navigation("ChainItems");

                    b.Navigation("Keys");
                });

            modelBuilder.Entity("Estimator.Models.RequestElementType", b =>
                {
                    b.Navigation("RequestOperations");
                });

            modelBuilder.Entity("Estimator.Models.TestChainItem", b =>
                {
                    b.Navigation("TestActions");
                });

            modelBuilder.Entity("Estimator.Models.TestProgram", b =>
                {
                    b.Navigation("ElementntTypes");

                    b.Navigation("Templates");
                });

            modelBuilder.Entity("Estimator.Models.TestProgramTemplate", b =>
                {
                    b.Navigation("TemplateItems");
                });
#pragma warning restore 612, 618
        }
    }
}
