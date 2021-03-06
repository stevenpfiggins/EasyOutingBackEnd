﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RedStarter.Database.Migrations
{
    public partial class changedDBName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationTableAccess",
                columns: table => new
                {
                    ApplicationEntityId = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    OwnerId = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTimeOffset>(nullable: false),
                    DateModified = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationTableAccess", x => x.ApplicationEntityId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactTableAccess",
                columns: table => new
                {
                    ApplicationEntityId = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactTableAccess", x => x.ApplicationEntityId);
                });

            migrationBuilder.CreateTable(
                name: "DemographicTableAccess",
                columns: table => new
                {
                    ApplicationEntityId = table.Column<Guid>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Ethnicity = table.Column<string>(nullable: true),
                    Married = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemographicTableAccess", x => x.ApplicationEntityId);
                });

            migrationBuilder.CreateTable(
                name: "EducationTableAccess",
                columns: table => new
                {
                    ApplicationEntityId = table.Column<Guid>(nullable: false),
                    HighSchoolGraduationInfo = table.Column<string>(nullable: true),
                    CollegeGraduationInfo = table.Column<string>(nullable: true),
                    FieldOfStudy = table.Column<string>(nullable: true),
                    CurrentlyEnrolled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationTableAccess", x => x.ApplicationEntityId);
                });

            migrationBuilder.CreateTable(
                name: "ExperienceTableAccess",
                columns: table => new
                {
                    ApplicationEntityId = table.Column<Guid>(nullable: false),
                    EmploymentStatus = table.Column<string>(nullable: true),
                    IncomeLevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceTableAccess", x => x.ApplicationEntityId);
                });

            migrationBuilder.CreateTable(
                name: "InterestsTableAccess",
                columns: table => new
                {
                    InterestsEntityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OwnerId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    UserLocation = table.Column<string>(nullable: true),
                    Canoeing = table.Column<bool>(nullable: false),
                    Kayaking = table.Column<bool>(nullable: false),
                    Hiking = table.Column<bool>(nullable: false),
                    RockClimbing = table.Column<bool>(nullable: false),
                    Camping = table.Column<bool>(nullable: false),
                    Fishing = table.Column<bool>(nullable: false),
                    SightSeeing = table.Column<bool>(nullable: false),
                    Football = table.Column<bool>(nullable: false),
                    Basketball = table.Column<bool>(nullable: false),
                    Soccer = table.Column<bool>(nullable: false),
                    Baseball = table.Column<bool>(nullable: false),
                    Hockey = table.Column<bool>(nullable: false),
                    Tennis = table.Column<bool>(nullable: false),
                    Golf = table.Column<bool>(nullable: false),
                    Running = table.Column<bool>(nullable: false),
                    WeightLifting = table.Column<bool>(nullable: false),
                    Yoga = table.Column<bool>(nullable: false),
                    Gymnastics = table.Column<bool>(nullable: false),
                    Restaurants = table.Column<bool>(nullable: false),
                    Bars = table.Column<bool>(nullable: false),
                    Wineries = table.Column<bool>(nullable: false),
                    Consoles = table.Column<bool>(nullable: false),
                    BoardGames = table.Column<bool>(nullable: false),
                    CardGames = table.Column<bool>(nullable: false),
                    Arcades = table.Column<bool>(nullable: false),
                    Movies = table.Column<bool>(nullable: false),
                    Theatre = table.Column<bool>(nullable: false),
                    Concerts = table.Column<bool>(nullable: false),
                    Festivals = table.Column<bool>(nullable: false),
                    Clubs = table.Column<bool>(nullable: false),
                    Bowling = table.Column<bool>(nullable: false),
                    Zoo = table.Column<bool>(nullable: false),
                    Painting = table.Column<bool>(nullable: false),
                    Knitting = table.Column<bool>(nullable: false),
                    Pottery = table.Column<bool>(nullable: false),
                    Museums = table.Column<bool>(nullable: false),
                    Aquariums = table.Column<bool>(nullable: false),
                    Galleries = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestsTableAccess", x => x.InterestsEntityId);
                });

            migrationBuilder.CreateTable(
                name: "OutingTableAccess",
                columns: table => new
                {
                    OutingEntityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OutingName = table.Column<string>(nullable: false),
                    OutingDescription = table.Column<string>(nullable: false),
                    OutingLocation = table.Column<string>(nullable: false),
                    OutingDate = table.Column<DateTimeOffset>(nullable: false),
                    OutingType = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    OwnerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutingTableAccess", x => x.OutingEntityId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationTableAccess");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ContactTableAccess");

            migrationBuilder.DropTable(
                name: "DemographicTableAccess");

            migrationBuilder.DropTable(
                name: "EducationTableAccess");

            migrationBuilder.DropTable(
                name: "ExperienceTableAccess");

            migrationBuilder.DropTable(
                name: "InterestsTableAccess");

            migrationBuilder.DropTable(
                name: "OutingTableAccess");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
