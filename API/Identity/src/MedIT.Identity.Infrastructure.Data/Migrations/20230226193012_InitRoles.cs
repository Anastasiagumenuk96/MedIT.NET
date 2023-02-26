using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedIT.Identity.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO public.""AspNetRoles"" (""Id"",""Name"",""NormalizedName"") VALUES
                                   ('74F39C47-CA7A-45A0-939C-D2BDF997E147','Admin','ADMIN'),
                                   ('6E3874B1-13F9-4ACD-8F49-206FDC6E416A','Physician','PHYSICIAN'),
                                   ('3C8CE069-7335-428F-9030-D0658C3F8A77','Patient','PATIENT')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM public.""AspNetRoles""
                                   WHERE ""Id"" IN (
                                  '74F39C47-CA7A-45A0-939C-D2BDF997E147',
                                  '6E3874B1-13F9-4ACD-8F49-206FDC6E416A',
                                  '3C8CE069-7335-428F-9030-D0658C3F8A77');");
        }
    }
}
