﻿// <auto-generated />
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SL.API.Migrations
{
    [DbContext(typeof(DndSpellContext))]
    [Migration("20190825031642_column_correction_spell")]
    partial class column_correction_spell
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Model.Entities.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_class")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("class");
                });

            modelBuilder.Entity("DAL.Model.Entities.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_material")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CupperCost")
                        .HasColumnName("cupper_cost");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<int>("ElectrumCost")
                        .HasColumnName("electrum_cost");

                    b.Property<int>("GoldCost")
                        .HasColumnName("gold_cost");

                    b.Property<int>("SilverCost")
                        .HasColumnName("silver_cost");

                    b.Property<string>("Unit")
                        .HasColumnName("unit");

                    b.HasKey("Id");

                    b.ToTable("material");
                });

            modelBuilder.Entity("DAL.Model.Entities.Spell", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_spell")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CastingTime")
                        .HasColumnName("casting_time");

                    b.Property<string>("Components")
                        .HasColumnName("components");

                    b.Property<bool>("Concentration")
                        .HasColumnName("concentration");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<string>("Duration")
                        .HasColumnName("duration");

                    b.Property<int>("Level")
                        .HasColumnName("level");

                    b.Property<string>("MagicSchool")
                        .HasColumnName("magic_school");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("Range")
                        .HasColumnName("range");

                    b.Property<bool>("Ritual")
                        .HasColumnName("ritual");

                    b.Property<int>("SpellType")
                        .HasColumnName("spell_type");

                    b.HasKey("Id");

                    b.ToTable("spell");
                });

            modelBuilder.Entity("DAL.Model.Entities.SpellClass", b =>
                {
                    b.Property<int>("IdClass")
                        .HasColumnName("id_class");

                    b.Property<int>("IdSpell")
                        .HasColumnName("id_spell");

                    b.HasKey("IdClass", "IdSpell");

                    b.HasIndex("IdSpell");

                    b.ToTable("spell_class");
                });

            modelBuilder.Entity("DAL.Model.Entities.SpellMaterial", b =>
                {
                    b.Property<int>("IdMaterial")
                        .HasColumnName("id_material");

                    b.Property<int>("IdSpell")
                        .HasColumnName("id_spell");

                    b.Property<int>("Quantity")
                        .HasColumnName("quantity");

                    b.HasKey("IdMaterial", "IdSpell");

                    b.HasIndex("IdSpell");

                    b.ToTable("spell_material");
                });

            modelBuilder.Entity("DAL.Model.Entities.SpellSpellbook", b =>
                {
                    b.Property<int>("IdSpell")
                        .HasColumnName("id_spell");

                    b.Property<int>("IdSpellbook")
                        .HasColumnName("id_spellbook");

                    b.HasKey("IdSpell", "IdSpellbook");

                    b.HasIndex("IdSpellbook");

                    b.ToTable("spell_spellbook");
                });

            modelBuilder.Entity("DAL.Model.Entities.Spellbook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_spellbook")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdClass")
                        .HasColumnName("id_class");

                    b.Property<int>("IdUser")
                        .HasColumnName("id_user");

                    b.Property<int>("LevelCharacter")
                        .HasColumnName("level_character");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("NameCharacter")
                        .HasColumnName("name_character");

                    b.Property<int>("PrincipalFocusType")
                        .HasColumnName("principal_focus_type");

                    b.Property<int?>("SideFocusType")
                        .HasColumnName("side_focus_type");

                    b.HasKey("Id");

                    b.HasIndex("IdUser");

                    b.ToTable("spellbook");
                });

            modelBuilder.Entity("DAL.Model.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_user")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("user");
                });

            modelBuilder.Entity("DAL.Model.Entities.SpellClass", b =>
                {
                    b.HasOne("DAL.Model.Entities.Class", "Class")
                        .WithMany("SpellsClass")
                        .HasForeignKey("IdClass")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Model.Entities.Spell", "Spell")
                        .WithMany("SpellsClass")
                        .HasForeignKey("IdSpell")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.Entities.SpellMaterial", b =>
                {
                    b.HasOne("DAL.Model.Entities.Material", "Material")
                        .WithMany("SpellMaterials")
                        .HasForeignKey("IdMaterial")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Model.Entities.Spell", "Spell")
                        .WithMany("SpellMaterials")
                        .HasForeignKey("IdSpell")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.Entities.SpellSpellbook", b =>
                {
                    b.HasOne("DAL.Model.Entities.Spell", "Spell")
                        .WithMany("SpellbookSpells")
                        .HasForeignKey("IdSpell")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Model.Entities.Spellbook", "Spellbook")
                        .WithMany("SpellbookSpells")
                        .HasForeignKey("IdSpellbook")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.Entities.Spellbook", b =>
                {
                    b.HasOne("DAL.Model.Entities.User", "User")
                        .WithMany("Spellbooks")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}