using Microsoft.EntityFrameworkCore;
using SweeftApiDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftApiDomain
{
    public class DBContext : DbContext
    {
        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<PupilTeacher> PupilTeachers { get; set; }


        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PupilTeacher>()
                .HasKey(pt => new { pt.PupilId, pt.TeacherId });

            modelBuilder.Entity<PupilTeacher>()
                .HasOne(pt => pt.Pupil)
                .WithMany(p => p.PupilTeachers)
                .HasForeignKey(pt => pt.PupilId);

            modelBuilder.Entity<PupilTeacher>()
                .HasOne(pt => pt.Teacher)
                .WithMany(t => t.PupilTeachers)
                .HasForeignKey(pt => pt.TeacherId);
        }

    }
}
