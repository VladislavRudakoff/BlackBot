﻿// <auto-generated />

using Bot.Data.AppContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Bot.Data.Migrations;

[DbContext(typeof(BotContext))]
partial class BotContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "6.0.4")
            .HasAnnotation("Relational:MaxIdentifierLength", 63);

        NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

        modelBuilder.Entity("Bot.Data.Models.User", b =>
        {
            b.Property<int>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("integer");

            NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

            b.Property<string>("FullName")
                .IsRequired()
                .HasColumnType("text");

            b.Property<int>("Role")
                .HasColumnType("integer");

            b.Property<string>("Username")
                .IsRequired()
                .HasColumnType("text");

            b.HasKey("Id");

            b.HasIndex("Id");

            b.HasIndex("Username");

            b.HasIndex("Id", "Username");

            b.ToTable("Users");
        });
#pragma warning restore 612, 618
    }
}