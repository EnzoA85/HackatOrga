using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OrgaHackat.Models
{
    public partial class bddboudero5Context : DbContext
    {
        public bddboudero5Context()
        {
        }

        public bddboudero5Context(DbContextOptions<bddboudero5Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Conference> Conferences { get; set; } = null!;
        public virtual DbSet<DoctrineMigrationVersion> DoctrineMigrationVersions { get; set; } = null!;
        public virtual DbSet<Evenement> Evenements { get; set; } = null!;
        public virtual DbSet<Hackathon> Hackathons { get; set; } = null!;
        public virtual DbSet<Initiation> Initiations { get; set; } = null!;
        public virtual DbSet<Inscription> Inscriptions { get; set; } = null!;
        public virtual DbSet<Intervenant> Intervenants { get; set; } = null!;
        public virtual DbSet<MessengerMessage> MessengerMessages { get; set; } = null!;
        public virtual DbSet<Participant> Participants { get; set; } = null!;
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=192.168.4.1;port=3306;user=sqldboudero;password=savary;database=bddboudero5;sslmode=none", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.5.18-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Conference>(entity =>
            {
                entity.ToTable("conference");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IntervenantId, "IDX_911533C8AB9A1716");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IntervenantId)
                    .HasColumnType("int(11)")
                    .HasColumnName("intervenant_id");

                entity.Property(e => e.Theme)
                    .HasMaxLength(255)
                    .HasColumnName("theme");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Conference)
                    .HasForeignKey<Conference>(d => d.Id)
                    .HasConstraintName("FK_911533C8BF396750");

                entity.HasOne(d => d.Intervenant)
                    .WithMany(p => p.Conferences)
                    .HasForeignKey(d => d.IntervenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_911533C8AB9A1716");
            });

            modelBuilder.Entity<DoctrineMigrationVersion>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PRIMARY");

                entity.ToTable("doctrine_migration_versions");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.Version)
                    .HasMaxLength(191)
                    .HasColumnName("version");

                entity.Property(e => e.ExecutedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("executed_at");

                entity.Property(e => e.ExecutionTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("execution_time");
            });

            modelBuilder.Entity<Evenement>(entity =>
            {
                entity.ToTable("evenement");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.HackathonId, "IDX_B26681E996D90CF");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Duree)
                    .HasColumnType("int(11)")
                    .HasColumnName("duree");

                entity.Property(e => e.HackathonId)
                    .HasColumnType("int(11)")
                    .HasColumnName("hackathon_id");

                entity.Property(e => e.Heure)
                    .HasColumnType("time")
                    .HasColumnName("heure");

                entity.Property(e => e.Libelle)
                    .HasMaxLength(255)
                    .HasColumnName("libelle");

                entity.Property(e => e.Salle)
                    .HasMaxLength(255)
                    .HasColumnName("salle");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

                entity.HasOne(d => d.Hackathon)
                    .WithMany(p => p.Evenements)
                    .HasForeignKey(d => d.HackathonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_B26681E996D90CF");
            });

            modelBuilder.Entity<Hackathon>(entity =>
            {
                entity.ToTable("hackathon");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CodePostal)
                    .HasMaxLength(5)
                    .HasColumnName("codePostal");

                entity.Property(e => e.DateDebut).HasColumnName("dateDebut");

                entity.Property(e => e.DateFin).HasColumnName("dateFin");

                entity.Property(e => e.DateLimite).HasColumnName("dateLimite");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.HeureDebut)
                    .HasColumnType("time")
                    .HasColumnName("heureDebut");

                entity.Property(e => e.HeureFin)
                    .HasColumnType("time")
                    .HasColumnName("heureFin");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.Lieu)
                    .HasMaxLength(255)
                    .HasColumnName("lieu");

                entity.Property(e => e.NbPlaces)
                    .HasColumnType("int(11)")
                    .HasColumnName("nbPlaces");

                entity.Property(e => e.Rue)
                    .HasMaxLength(255)
                    .HasColumnName("rue");

                entity.Property(e => e.Theme)
                    .HasMaxLength(255)
                    .HasColumnName("theme");

                entity.Property(e => e.Ville)
                    .HasMaxLength(255)
                    .HasColumnName("ville");
            });

            modelBuilder.Entity<Initiation>(entity =>
            {
                entity.ToTable("initiation");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.NbPlaceLimite)
                    .HasColumnType("int(11)")
                    .HasColumnName("nb_place_limite");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Initiation)
                    .HasForeignKey<Initiation>(d => d.Id)
                    .HasConstraintName("FK_EDC7AE6EBF396750");
            });

            modelBuilder.Entity<Inscription>(entity =>
            {
                entity.ToTable("inscription");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IdUtilisateur, "IDX_5E90F6D65D419CCB");

                entity.HasIndex(e => e.IdHackathon, "IDX_5E90F6D677D0DD19");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.DateInscription).HasColumnName("dateInscription");

                entity.Property(e => e.IdHackathon)
                    .HasColumnType("int(11)")
                    .HasColumnName("idHackathon");

                entity.Property(e => e.IdUtilisateur)
                    .HasColumnType("int(11)")
                    .HasColumnName("idUtilisateur");

                entity.Property(e => e.TexteLibre)
                    .HasMaxLength(255)
                    .HasColumnName("texteLibre");

                entity.HasOne(d => d.IdHackathonNavigation)
                    .WithMany(p => p.Inscriptions)
                    .HasForeignKey(d => d.IdHackathon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_5E90F6D677D0DD19");

                entity.HasOne(d => d.IdUtilisateurNavigation)
                    .WithMany(p => p.Inscriptions)
                    .HasForeignKey(d => d.IdUtilisateur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_5E90F6D65D419CCB");
            });

            modelBuilder.Entity<Intervenant>(entity =>
            {
                entity.ToTable("intervenant");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Mail)
                    .HasMaxLength(128)
                    .HasColumnName("mail");

                entity.Property(e => e.Nom)
                    .HasMaxLength(255)
                    .HasColumnName("nom");

                entity.Property(e => e.Prenom)
                    .HasMaxLength(255)
                    .HasColumnName("prenom");
            });

            modelBuilder.Entity<MessengerMessage>(entity =>
            {
                entity.ToTable("messenger_messages");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.DeliveredAt, "IDX_75EA56E016BA31DB");

                entity.HasIndex(e => e.AvailableAt, "IDX_75EA56E0E3BD61CE");

                entity.HasIndex(e => e.QueueName, "IDX_75EA56E0FB7336F0");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.AvailableAt)
                    .HasColumnType("datetime")
                    .HasColumnName("available_at");

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeliveredAt)
                    .HasColumnType("datetime")
                    .HasColumnName("delivered_at");

                entity.Property(e => e.Headers).HasColumnName("headers");

                entity.Property(e => e.QueueName)
                    .HasMaxLength(190)
                    .HasColumnName("queue_name");
            });

            modelBuilder.Entity<Participant>(entity =>
            {
                entity.ToTable("participant");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.InitiationId, "IDX_D79F6B11118CE583");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.InitiationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("initiation_id");

                entity.Property(e => e.Mail)
                    .HasMaxLength(255)
                    .HasColumnName("mail");

                entity.Property(e => e.Nom)
                    .HasMaxLength(255)
                    .HasColumnName("nom");

                entity.Property(e => e.Prenom)
                    .HasMaxLength(255)
                    .HasColumnName("prenom");

                entity.HasOne(d => d.Initiation)
                    .WithMany(p => p.Participants)
                    .HasForeignKey(d => d.InitiationId)
                    .HasConstraintName("FK_D79F6B11118CE583");
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.ToTable("utilisateur");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Mail, "UNIQ_1D1C63B35126AC48")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.DateNaissance).HasColumnName("dateNaissance");

                entity.Property(e => e.LienPortfolio)
                    .HasMaxLength(255)
                    .HasColumnName("lienPortfolio");

                entity.Property(e => e.Mail)
                    .HasMaxLength(128)
                    .HasColumnName("mail");

                entity.Property(e => e.Mdp)
                    .HasMaxLength(255)
                    .HasColumnName("mdp");

                entity.Property(e => e.Nom)
                    .HasMaxLength(255)
                    .HasColumnName("nom");

                entity.Property(e => e.Prenom)
                    .HasMaxLength(255)
                    .HasColumnName("prenom");

                entity.Property(e => e.Roles)
                    .HasColumnName("roles")
                    .HasComment("(DC2Type:json)");

                entity.Property(e => e.Tel)
                    .HasMaxLength(10)
                    .HasColumnName("tel");

                entity.HasMany(d => d.Hackathons)
                    .WithMany(p => p.Utilisateurs)
                    .UsingEntity<Dictionary<string, object>>(
                        "UtilisateurHackathon",
                        l => l.HasOne<Hackathon>().WithMany().HasForeignKey("HackathonId").HasConstraintName("FK_EB940363996D90CF"),
                        r => r.HasOne<Utilisateur>().WithMany().HasForeignKey("UtilisateurId").HasConstraintName("FK_EB940363FB88E14F"),
                        j =>
                        {
                            j.HasKey("UtilisateurId", "HackathonId").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("utilisateur_hackathon").UseCollation("utf8mb4_unicode_ci");

                            j.HasIndex(new[] { "HackathonId" }, "IDX_EB940363996D90CF");

                            j.HasIndex(new[] { "UtilisateurId" }, "IDX_EB940363FB88E14F");

                            j.IndexerProperty<int>("UtilisateurId").HasColumnType("int(11)").HasColumnName("utilisateur_id");

                            j.IndexerProperty<int>("HackathonId").HasColumnType("int(11)").HasColumnName("hackathon_id");
                        });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
