using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "03c3b8c9-6dcb-4737-9fc0-840d3284c8a7");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "30ae0d23-64db-43e8-be22-ec539f3c87b0");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "7a4328ba-9b67-4c00-ad35-e81cdc7dbaaa");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "8213266a-6af1-4ec7-b759-73ffbdb0fe51");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "cc9bb9ef-9a5a-45bf-8899-fa31cc65485d");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "d827b0f2-7cf8-4334-bf90-dffe56951721");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "d8c8fc2a-640a-4f63-bcd2-fa07675f9266");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "320ca047-6db9-46ce-9389-f208a8e6b2ed", "CSS" },
                    { "36370279-e7d1-4345-bcfe-785dba0c0d96", "Angular" },
                    { "55c59bce-fdf7-4e46-8da5-04bd51fb7ca3", "React" },
                    { "6ada9e49-4939-404d-8163-fe8b466ce5cf", "JavaScript" },
                    { "b8a94b7d-cc67-46ec-84df-9bf0d060a71c", "HTML" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "Name", "Phono" },
                values: new object[,]
                {
                    { "6495a526-21fe-4994-8db3-d56c2500fb06", "Alexandria", new DateTime(2001, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziad.mohamed@example.com", "Ziad Mohamed", "01234567890" },
                    { "b8f9f496-1f7d-4a4a-a4b3-01c4b2d44f78", "Cairo", new DateTime(2000, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahmed.ali@example.com", "Ahmed Ali", "01012345678" },
                    { "c7a129fc-1e41-4bb3-a1b7-20560b4a0390", "Giza", new DateTime(1999, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "mariam.hassan@example.com", "Mariam Hassan", "01198765432" },
                    { "ce7ada32-7649-4f0a-b64f-dfe3b98b6f09", "Cairo", new DateTime(2001, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manar.mohamed@example.com", "Manar Mohamed", "01234567890" },
                    { "da4a48c4-b2f4-4005-a2ad-bf10b72c4f56", "Alexandria", new DateTime(2001, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "omar.mohamed@example.com", "Omar Mohamed", "01234567890" }
                });

            migrationBuilder.InsertData(
                table: "CourseStudent",
                columns: new[] { "CoursesId", "StudentsId" },
                values: new object[,]
                {
                    { "320ca047-6db9-46ce-9389-f208a8e6b2ed", "b8f9f496-1f7d-4a4a-a4b3-01c4b2d44f78" },
                    { "320ca047-6db9-46ce-9389-f208a8e6b2ed", "c7a129fc-1e41-4bb3-a1b7-20560b4a0390" },
                    { "55c59bce-fdf7-4e46-8da5-04bd51fb7ca3", "b8f9f496-1f7d-4a4a-a4b3-01c4b2d44f78" },
                    { "55c59bce-fdf7-4e46-8da5-04bd51fb7ca3", "c7a129fc-1e41-4bb3-a1b7-20560b4a0390" },
                    { "55c59bce-fdf7-4e46-8da5-04bd51fb7ca3", "ce7ada32-7649-4f0a-b64f-dfe3b98b6f09" },
                    { "6ada9e49-4939-404d-8163-fe8b466ce5cf", "6495a526-21fe-4994-8db3-d56c2500fb06" },
                    { "6ada9e49-4939-404d-8163-fe8b466ce5cf", "da4a48c4-b2f4-4005-a2ad-bf10b72c4f56" },
                    { "b8a94b7d-cc67-46ec-84df-9bf0d060a71c", "b8f9f496-1f7d-4a4a-a4b3-01c4b2d44f78" },
                    { "b8a94b7d-cc67-46ec-84df-9bf0d060a71c", "ce7ada32-7649-4f0a-b64f-dfe3b98b6f09" },
                    { "b8a94b7d-cc67-46ec-84df-9bf0d060a71c", "da4a48c4-b2f4-4005-a2ad-bf10b72c4f56" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { "320ca047-6db9-46ce-9389-f208a8e6b2ed", "b8f9f496-1f7d-4a4a-a4b3-01c4b2d44f78" });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { "320ca047-6db9-46ce-9389-f208a8e6b2ed", "c7a129fc-1e41-4bb3-a1b7-20560b4a0390" });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { "55c59bce-fdf7-4e46-8da5-04bd51fb7ca3", "b8f9f496-1f7d-4a4a-a4b3-01c4b2d44f78" });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { "55c59bce-fdf7-4e46-8da5-04bd51fb7ca3", "c7a129fc-1e41-4bb3-a1b7-20560b4a0390" });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { "55c59bce-fdf7-4e46-8da5-04bd51fb7ca3", "ce7ada32-7649-4f0a-b64f-dfe3b98b6f09" });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { "6ada9e49-4939-404d-8163-fe8b466ce5cf", "6495a526-21fe-4994-8db3-d56c2500fb06" });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { "6ada9e49-4939-404d-8163-fe8b466ce5cf", "da4a48c4-b2f4-4005-a2ad-bf10b72c4f56" });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { "b8a94b7d-cc67-46ec-84df-9bf0d060a71c", "b8f9f496-1f7d-4a4a-a4b3-01c4b2d44f78" });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { "b8a94b7d-cc67-46ec-84df-9bf0d060a71c", "ce7ada32-7649-4f0a-b64f-dfe3b98b6f09" });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { "b8a94b7d-cc67-46ec-84df-9bf0d060a71c", "da4a48c4-b2f4-4005-a2ad-bf10b72c4f56" });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "36370279-e7d1-4345-bcfe-785dba0c0d96");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "320ca047-6db9-46ce-9389-f208a8e6b2ed");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "55c59bce-fdf7-4e46-8da5-04bd51fb7ca3");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "6ada9e49-4939-404d-8163-fe8b466ce5cf");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "b8a94b7d-cc67-46ec-84df-9bf0d060a71c");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "6495a526-21fe-4994-8db3-d56c2500fb06");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "b8f9f496-1f7d-4a4a-a4b3-01c4b2d44f78");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "c7a129fc-1e41-4bb3-a1b7-20560b4a0390");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "ce7ada32-7649-4f0a-b64f-dfe3b98b6f09");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "da4a48c4-b2f4-4005-a2ad-bf10b72c4f56");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "03c3b8c9-6dcb-4737-9fc0-840d3284c8a7", "CSS" },
                    { "30ae0d23-64db-43e8-be22-ec539f3c87b0", "Angular" },
                    { "7a4328ba-9b67-4c00-ad35-e81cdc7dbaaa", "JavaScript" },
                    { "8213266a-6af1-4ec7-b759-73ffbdb0fe51", "React" },
                    { "cc9bb9ef-9a5a-45bf-8899-fa31cc65485d", "HTML" },
                    { "d827b0f2-7cf8-4334-bf90-dffe56951721", "Physics" },
                    { "d8c8fc2a-640a-4f63-bcd2-fa07675f9266", "Math" }
                });
        }
    }
}
