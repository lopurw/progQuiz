﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace progQuiz.API.Migrations
{
    /// <inheritdoc />
    public partial class RewardTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastRewardTime",
                table: "Users",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastRewardTime",
                table: "Users");
        }
    }
}
