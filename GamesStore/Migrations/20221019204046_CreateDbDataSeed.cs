using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesStore.Migrations
{
    public partial class CreateDbDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConsoleDevices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsoleDevices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    ConsoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_ConsoleDevices_ConsoleId",
                        column: x => x.ConsoleId,
                        principalTable: "ConsoleDevices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ConsoleDevices",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Xbox360" },
                    { 2, "PS3" },
                    { 3, "PS4" },
                    { 4, "PS5" },
                    { 5, "Xbox" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "A game that simulates the practice of sports. Some games emphasize actually playing the sport, whilst others emphasize strategy and sport management", "Simulation and Sports" },
                    { 2, "A video game genre in which the player participates in a racing competition. They are distributed along a spectrum between more realistic racing simulations and more fantastical arcade-style racing games", "Racing" },
                    { 3, "In these games, players often have less concrete goals and narrative pathways to pursue. Instead of beating the boss and saving the princess, you may face a variety of tasks you can accomplish in a number of different ways. This draws players into more immersive experiences, encouraging experimantation with what may be unfamiliar mechanics", "Sandbox" },
                    { 4, "Players control different factions and compete against each other simultaneously in 'real-time' hence the term 'real-time strategy'", "Real-time strategy" },
                    { 5, "The shooter is a long standing genre that developed several early offshoots and branched out into two primary sub-genres: the first person(FPS) and third-person(TPS).", "Shooter(FPS and TPS)" },
                    { 6, "The basic premise of the role playing game is simple and ubiquitious in numerous games: you create or take control of a character that you can then level up through experience points", "Role-playing games" },
                    { 7, "Among the earliest recognizable hybrid genres, action-adventure games have a deep focus on plot and combat through story involvement and tight gameplay mechanics", "Action-adventure" },
                    { 8, "The core mechanics of a survival game centers on resource management, often incorporating crafting or salvage systems that you can use to help keep your character alive. Horror is an even broader category, arguably encompassing dozens of survival titles. Almost anything with zombies, a post-apocalyptic storyline, or loads of jump scares is considered horror", "Survival and Horror" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "ConsoleId", "Description", "GenreId", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 2, "A Japanese horror game series and a media franchise created by Capcom. It consists of survival horro, third-person shooter ad first-person shooter games, with players typically surviving in environments filled with zombies and other creatures", 8, "https://images.unsplash.com/photo-1575844261401-d69721eb5044?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8cmVzaWRlbnQlMjBldmlsfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60", "Resident Evil", 130.50m },
                    { 2, 4, "From a galaxy far, far away comes action and adventure with the heroes and villians of Star Wars. Master the art of starfighter combat in the authentic piloting experience. Master your hero's journey and play through massive battles across iconic locations in all three cinematic eras", 7, "https://images.unsplash.com/flagged/photo-1589829482673-03413c918c48?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OHx8c3RhciUyMHdhcnN8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60", "Star Wars", 100.75m },
                    { 3, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 8, "https://images.unsplash.com/photo-1563506644863-444710df1e03?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTN8fG5iYXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60", "NBA 2K", 130.50m },
                    { 4, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 5, "https://images.unsplash.com/photo-1602901248692-06c8935adac0?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8Y2FsbCUyMG9mJTIwZHV0eXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60", "Call of Duty", 150.50m },
                    { 5, 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 4, "https://images.unsplash.com/photo-1612404819070-77c6da472e68?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8d2FyY3JhZnR8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60", "Warcraft", 80.20m },
                    { 6, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 3, "https://images.unsplash.com/photo-1640079421264-61f50d89a736?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8bWluZWNyYWZ0fGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60", "Minecraft", 200.50m },
                    { 7, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 3, "https://images.unsplash.com/photo-1624085568108-36410cfe4d24?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTB8fGdyYW5kJTIwdGhlZnQlMjBhdXRvfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60", "Grand Theft Auto", 120.55m },
                    { 8, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 3, "https://images.unsplash.com/photo-1496252223350-db9ad24b108c?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8dGhlJTIwc2ltc3xlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60", "The Sims", 90.50m },
                    { 9, 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 4, "https://images.unsplash.com/photo-1630713079609-4356d4106410?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8N3x8d2FyY3JhZnR8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60", "Age of Empires", 130.75m },
                    { 10, 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 4, "https://images.unsplash.com/photo-1638451490307-80b960906103?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OXx8d2FyY3JhZnR8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60", "Command & Conquer", 100.25m },
                    { 11, 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 5, "https://images.unsplash.com/photo-1598776454302-94acd47baaa8?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8c2hvb3RpbmclMjBnYW1lfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60", "DOOM", 120.50m },
                    { 12, 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 5, "https://images.unsplash.com/photo-1620231150904-a86b9802656a?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8M3x8Y2FsbCUyMG9mJTIwZHV0eXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60", "Half-life", 120.30m },
                    { 13, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 5, "https://images.unsplash.com/photo-1621364525332-f9c381f3bfe8?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NXx8Y2FsbCUyMG9mJTIwZHV0eXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60", "Gears of War", 90.50m },
                    { 14, 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 5, "https://images.unsplash.com/photo-1621886289899-6e78c8f379b0?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8N3x8Y2FsbCUyMG9mJTIwZHV0eXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60", "The Division", 60.50m },
                    { 15, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 5, "https://images.unsplash.com/photo-1612212909979-5f9128008f87?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTl8fGNhbGwlMjBvZiUyMGR1dHl8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60", "Halo", 170.40m },
                    { 16, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 6, "https://images.unsplash.com/photo-1521252879211-999820594c75?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTZ8fHJvbGUlMjBwbGF5aW5nJTIwZ2FtZXN8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60", "Skyrim", 220.50m },
                    { 17, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 6, "https://images.unsplash.com/photo-1484608577325-c7540cc6794d?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTJ8fGZhbGxvdXR8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60", "Fallout 4", 115.50m },
                    { 18, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 1, "https://images.unsplash.com/photo-1624432105547-898636528f55?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTR8fGdyYW5kJTIwdGhlZnQlMjBhdXRvfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60", "Forza Motorsport", 300.50m },
                    { 19, 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 1, "https://images.unsplash.com/photo-1598121876853-82437626c783?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8N3x8bWVzc2l8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60", "FIFA 2023", 320.50m },
                    { 20, 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 1, "https://images.unsplash.com/photo-1522778034537-20a2486be803?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8cm9uYWxkb3xlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60", "FIFA 2022", 280.50m },
                    { 21, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 7, "https://images.unsplash.com/photo-1652718425243-8fb1512f4026?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8YXNzYXNpbiUyMGNyZWVkfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60", "Assassin's Creed", 120.50m },
                    { 22, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 7, "https://plus.unsplash.com/premium_photo-1661901234139-d833950e05e0?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTN8fGd1bnN8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60", "Monkey Island", 220.50m },
                    { 23, 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 7, "https://images.unsplash.com/photo-1602901248692-06c8935adac0?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTZ8fGd1bnN8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60", "Watch Dogs", 270.50m },
                    { 24, 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 7, "https://images.unsplash.com/photo-1519669556878-63bdad8a1a49?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8Z2FtZXN8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60", "Titanfall", 90.50m },
                    { 25, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 8, "https://images.unsplash.com/photo-1543844481-52e5d6b93760?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8Z29kJTIwb2YlMjB3YXJ8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60", "The Long Dark", 200.50m },
                    { 26, 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 7, "https://images.unsplash.com/photo-1608744221958-a842da518d01?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8Z29kJTIwb2YlMjB3YXJ8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60", "Don't Starve", 190.50m },
                    { 27, 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.", 6, "https://images.unsplash.com/photo-1622643048696-883eafe4d8dc?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8d2l0Y2hlcnxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60", "The Witcher 3", 90.50m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_ConsoleId",
                table: "Games",
                column: "ConsoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_GenreId",
                table: "Games",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "ConsoleDevices");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
