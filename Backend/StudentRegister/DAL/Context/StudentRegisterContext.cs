using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class StudentRegisterContext : DbContext
    {
        public StudentRegisterContext(DbContextOptions<StudentRegisterContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ////////
            ///seeding course
            //////////
            modelBuilder.Entity<Course>().HasData(
                new Course { Id = "55c59bce-fdf7-4e46-8da5-04bd51fb7ca3", Name = "React" },
                new Course { Id = "320ca047-6db9-46ce-9389-f208a8e6b2ed", Name = "CSS" },
                new Course { Id = "b8a94b7d-cc67-46ec-84df-9bf0d060a71c", Name = "HTML" },
                new Course { Id = "6ada9e49-4939-404d-8163-fe8b466ce5cf", Name = "JavaScript" },
                new Course { Id = "36370279-e7d1-4345-bcfe-785dba0c0d96", Name = "Angular" }
            );

            ////////
            ///seeding student
            //////////
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = "b8f9f496-1f7d-4a4a-a4b3-01c4b2d44f78",
                    Name = "Ahmed Ali",
                    Email = "ahmed.ali@example.com",
                    DateOfBirth = new DateTime(2000, 5, 12),
                    Phono = "01012345678",
                    Address = "Cairo"
                },
                new Student
                {
                    Id = "c7a129fc-1e41-4bb3-a1b7-20560b4a0390",
                    Name = "Mariam Hassan",
                    Email = "mariam.hassan@example.com",
                    DateOfBirth = new DateTime(1999, 8, 21),
                    Phono = "01198765432",
                    Address = "Giza"
                },
                new Student
                {
                    Id = "da4a48c4-b2f4-4005-a2ad-bf10b72c4f56",
                    Name = "Omar Mohamed",
                    Email = "omar.mohamed@example.com",
                    DateOfBirth = new DateTime(2001, 2, 10),
                    Phono = "01234567890",
                    Address = "Alexandria"
                }
                ,
                new Student
                {
                    Id = "ce7ada32-7649-4f0a-b64f-dfe3b98b6f09",
                    Name = "Manar Mohamed",
                    Email = "Manar.mohamed@example.com",
                    DateOfBirth = new DateTime(2001, 2, 10),
                    Phono = "01234567890",
                    Address = "Cairo"
                }
                ,
                new Student
                {
                    Id = "6495a526-21fe-4994-8db3-d56c2500fb06",
                    Name = "Ziad Mohamed",
                    Email = "Ziad.mohamed@example.com",
                    DateOfBirth = new DateTime(2001, 2, 10),
                    Phono = "01234567890",
                    Address = "Alexandria"
                }
            );
            ////////
            ///seeding student with courses
            //////////

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Courses)
                .WithMany(c => c.Students)
                .UsingEntity(j => j.HasData(
                    new { StudentsId = "b8f9f496-1f7d-4a4a-a4b3-01c4b2d44f78", CoursesId = "55c59bce-fdf7-4e46-8da5-04bd51fb7ca3" },
                    new { StudentsId = "c7a129fc-1e41-4bb3-a1b7-20560b4a0390", CoursesId = "55c59bce-fdf7-4e46-8da5-04bd51fb7ca3" },
                    new { StudentsId = "ce7ada32-7649-4f0a-b64f-dfe3b98b6f09", CoursesId = "55c59bce-fdf7-4e46-8da5-04bd51fb7ca3" },

                    new { StudentsId = "b8f9f496-1f7d-4a4a-a4b3-01c4b2d44f78", CoursesId = "320ca047-6db9-46ce-9389-f208a8e6b2ed" },
                    new { StudentsId = "c7a129fc-1e41-4bb3-a1b7-20560b4a0390", CoursesId = "320ca047-6db9-46ce-9389-f208a8e6b2ed" },

                    new { StudentsId = "b8f9f496-1f7d-4a4a-a4b3-01c4b2d44f78", CoursesId = "b8a94b7d-cc67-46ec-84df-9bf0d060a71c" },
                    new { StudentsId = "da4a48c4-b2f4-4005-a2ad-bf10b72c4f56", CoursesId = "b8a94b7d-cc67-46ec-84df-9bf0d060a71c" },
                    new { StudentsId = "ce7ada32-7649-4f0a-b64f-dfe3b98b6f09", CoursesId = "b8a94b7d-cc67-46ec-84df-9bf0d060a71c" },

                    new { StudentsId = "da4a48c4-b2f4-4005-a2ad-bf10b72c4f56", CoursesId = "6ada9e49-4939-404d-8163-fe8b466ce5cf" },
                    new { StudentsId = "6495a526-21fe-4994-8db3-d56c2500fb06", CoursesId = "6ada9e49-4939-404d-8163-fe8b466ce5cf" }
                ));

        }
    }
}
