using System;
using System.Collections.Generic;
using Logic.Models;
using Microsoft.EntityFrameworkCore;

namespace Logic.Data;

public partial class LibraryContext : DbContext
{
    public LibraryContext()
    {
    }

    public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Record> Records { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__books__3213E83F1B7BAD23");

            entity.ToTable("books");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Author)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("author");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.GenreId).HasColumnName("genre_id");
            entity.Property(e => e.IsRemoved).HasColumnName("is_removed");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Publisher)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("publisher");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.Genre).WithMany(p => p.Books)
                .HasForeignKey(d => d.GenreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__books__genre_id__3B75D760");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__genres__3213E83FDD17C2BA");

            entity.ToTable("genres");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Record>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__records__3213E83FE0AC01B3");

            entity.ToTable("records");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BookId).HasColumnName("book_id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.IsTaken).HasColumnName("is_taken");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Book).WithMany(p => p.Records)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__records__book_id__403A8C7D");

            entity.HasOne(d => d.User).WithMany(p => p.Records)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__records__user_id__3F466844");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__3213E83F9127ABCD");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.IsRemoved).HasColumnName("is_removed");
            entity.Property(e => e.JoiningDate)
                .HasColumnType("datetime")
                .HasColumnName("joining_date");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("last_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
