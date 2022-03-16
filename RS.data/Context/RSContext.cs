using Microsoft.EntityFrameworkCore;
using RS.data.Model;

#nullable disable

namespace RS.data.Context
{
    public partial class RSContext : DbContext
    {

        public RSContext(DbContextOptions<RSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Commit> Commits { get; set; }
        public virtual DbSet<ConectionTrack> ConectionTracks { get; set; }
        public virtual DbSet<Release> Releases { get; set; }
        public virtual DbSet<ReleaseInfo> ReleaseInfos { get; set; }
        public virtual DbSet<WorkItem> WorkItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Commit>(entity =>
            {
                entity.ToTable("Commit");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Sha)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Release)
                    .WithMany(p => p.Commits)
                    .HasForeignKey(d => d.ReleaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Commit_Release");
            });

            modelBuilder.Entity<ConectionTrack>(entity =>
            {
                entity.ToTable("ConectionTrack");

                entity.Property(e => e.Datelog).HasColumnType("datetime");

                entity.Property(e => e.Params).HasMaxLength(250);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.TraceIdentifier)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Release>(entity =>
            {
                entity.ToTable("Release");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ReleaseInfo>(entity =>
            {
                entity.ToTable("ReleaseInfo");

                entity.Property(e => e.CurrentReleaseDate).HasColumnType("date");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WorkItem>(entity =>
            {
                entity.HasKey(e => new { e.WorkItemId, e.CommitId });

                entity.ToTable("WorkItem");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.HasOne(d => d.Commit)
                    .WithMany(p => p.WorkItems)
                    .HasForeignKey(d => d.CommitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkItem_Commit");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
