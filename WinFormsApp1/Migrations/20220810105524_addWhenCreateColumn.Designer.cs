﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinFormsApp1;

#nullable disable

namespace WinFormsApp1.Migrations
{
    [DbContext(typeof(DatabaseConnection))]
    [Migration("20220810105524_addWhenCreateColumn")]
    partial class addWhenCreateColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("WinFormsApp1.Models.CollisionCheck", b =>
                {
                    b.Property<int>("CollisionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Checked")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Meteor1X")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Meteor1Y")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Meteor2X")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Meteor2Y")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("WhenCreated")
                        .HasColumnType("TEXT");

                    b.HasKey("CollisionId");

                    b.ToTable("collisionChecks");
                });
#pragma warning restore 612, 618
        }
    }
}
