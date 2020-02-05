﻿// <auto-generated />
using System;
using Estimator.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Estimator.Migrations
{
    [DbContext(typeof(EstimatorContext))]
    partial class EstimatorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Estimator.Models.ClassECB", b =>
                {
                    b.Property<int>("ClassECBID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ClassECBID");

                    b.ToTable("ClassECB");
                });

            modelBuilder.Entity("Estimator.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("INN")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Estimator.Models.CustomerRequest", b =>
                {
                    b.Property<int>("CustomerRequestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<bool>("IsProceed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RequestNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("TestProgramID")
                        .HasColumnType("int");

                    b.HasKey("CustomerRequestID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("TestProgramID");

                    b.ToTable("CustomerRequests");
                });

            modelBuilder.Entity("Estimator.Models.ElementType", b =>
                {
                    b.Property<int>("ElementTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassECBID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("ProgramID")
                        .HasColumnType("int");

                    b.HasKey("ElementTypeID");

                    b.HasIndex("ClassECBID");

                    b.HasIndex("ProgramID");

                    b.ToTable("ElementType");
                });

            modelBuilder.Entity("Estimator.Models.Operation", b =>
                {
                    b.Property<int>("OperationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)")
                        .HasMaxLength(4);

                    b.Property<bool>("DPO")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("OperationID");

                    b.ToTable("Operation");
                });

            modelBuilder.Entity("Estimator.Models.Qualification", b =>
                {
                    b.Property<int>("QualificationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("QualificationID");

                    b.ToTable("Qualification");
                });

            modelBuilder.Entity("Estimator.Models.RequestElementType", b =>
                {
                    b.Property<int>("RequestElementTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BatchCount")
                        .HasColumnType("int");

                    b.Property<int>("CustomerRequestID")
                        .HasColumnType("int");

                    b.Property<int?>("ElementTypeID")
                        .HasColumnType("int");

                    b.Property<int>("ItemCount")
                        .HasColumnType("int");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("RequestElementTypeID");

                    b.HasIndex("CustomerRequestID");

                    b.HasIndex("ElementTypeID");

                    b.ToTable("RequestElementType");
                });

            modelBuilder.Entity("Estimator.Models.TestAction", b =>
                {
                    b.Property<int>("TestActionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BatchLabor")
                        .HasColumnType("int");

                    b.Property<int>("ItemLabor")
                        .HasColumnType("int");

                    b.Property<int>("QualificationID")
                        .HasColumnType("int");

                    b.Property<int>("TestChainItemID")
                        .HasColumnType("int");

                    b.HasKey("TestActionID");

                    b.HasIndex("QualificationID");

                    b.HasIndex("TestChainItemID");

                    b.ToTable("TestAction");
                });

            modelBuilder.Entity("Estimator.Models.TestChainItem", b =>
                {
                    b.Property<int>("TestChainItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ElementTypeID")
                        .HasColumnType("int");

                    b.Property<int>("OperationID")
                        .HasColumnType("int");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("TestChainItemID");

                    b.HasIndex("ElementTypeID");

                    b.HasIndex("OperationID");

                    b.ToTable("TestChainItem");
                });

            modelBuilder.Entity("Estimator.Models.TestProgram", b =>
                {
                    b.Property<int>("TestProgramID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AllowEditChain")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("TestProgramID");

                    b.ToTable("TestProgram");
                });

            modelBuilder.Entity("Estimator.Models.CustomerRequest", b =>
                {
                    b.HasOne("Estimator.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Estimator.Models.TestProgram", "Program")
                        .WithMany()
                        .HasForeignKey("TestProgramID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                });
#pragma warning restore 612, 618
        }
    }
}
