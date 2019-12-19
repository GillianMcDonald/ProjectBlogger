using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBlogger.Migrations
{
    public partial class seedDataTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "Email", "FirstName", "LastName", "Password", "UserName" },
                values: new object[] { 2, "Jody@Jody.com", "Jody", "Richardson", "JodyMcJoderson", "JDog" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "Email", "FirstName", "LastName", "Password", "UserName" },
                values: new object[] { 3, "Heather@Heather.com", "Heather", "Smith", "HeatherMcHeatherson", "HDog" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "Email", "FirstName", "LastName", "Password", "UserName" },
                values: new object[] { 4, "Hammad@Hammad.com", "Hammad", "Ali", "HammadMcHammerson", "HADog" });

            migrationBuilder.InsertData(
                table: "MyBlogs",
                columns: new[] { "MyBlogsID", "ActualBlog", "BlogName", "BlogOfTheWeek", "Description", "ImageUrl", "ThumbUrl", "UserID" },
                values: new object[] { 10, "This will be the Blog content", "How to Code", true, "This is the short Description", "https://cdn.wearecodenation.com/app/uploads/Dan.jpg", "https://cdn.wearecodenation.com/app/uploads/Dan.jpg", 2 });

            migrationBuilder.InsertData(
                table: "MyBlogs",
                columns: new[] { "MyBlogsID", "ActualBlog", "BlogName", "BlogOfTheWeek", "Description", "ImageUrl", "ThumbUrl", "UserID" },
                values: new object[] { 11, "This will be the Blog content", "How NOT to Code", false, "This is the short Description", "https://cdn.wearecodenation.com/app/uploads/Dan.jpg", "https://cdn.wearecodenation.com/app/uploads/Dan.jpg", 2 });

            migrationBuilder.InsertData(
                table: "MyBlogs",
                columns: new[] { "MyBlogsID", "ActualBlog", "BlogName", "BlogOfTheWeek", "Description", "ImageUrl", "ThumbUrl", "UserID" },
                values: new object[] { 12, "This will be the Blog content", "Do you know how to Code?", false, "This is the short Description", "https://cdn.wearecodenation.com/app/uploads/Dan.jpg", "https://cdn.wearecodenation.com/app/uploads/Dan.jpg", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MyBlogs",
                keyColumn: "MyBlogsID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MyBlogs",
                keyColumn: "MyBlogsID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MyBlogs",
                keyColumn: "MyBlogsID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 2);
        }
    }
}
