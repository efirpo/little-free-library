using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Available", "Condition", "Title" },
                values: new object[,]
                {
                    { 1, "Gabriel Garcia Marquez", true, "Good", "Living to Tell the Tale" },
                    { 36, "Bill McKibben", true, "Fair", "The Age of Missing Information" },
                    { 37, "Gore Vidal", true, "Good", "Empire" },
                    { 38, "Gabriel Garcia Marquez", true, "Fair", "Of Love and Other Demons" },
                    { 39, "Stephen J. Gould", true, "Good", "Wonderful Life" },
                    { 40, "Carl Jung", true, "Fair", "Modern Man in Search of a Soul" },
                    { 41, "Will Eisner", true, "Excellent", "Comics and Sequential Art" },
                    { 42, "Will Eisner", true, "Excellent", "Graphic Storytelling and Visual Narrative" },
                    { 44, "Albert Camus", true, "Poor", "The Myth of Sisyphus and Other Essays" },
                    { 45, "J.R.R. Tolkien", true, "Poor", "The Fellowship of the Ring" },
                    { 46, "J.R.R. Tolkien", true, "Poor", "The Two Towers" },
                    { 47, "J.R.R. Tolkien", true, "Poor", "The Return of the King" },
                    { 48, "Peter Kropotkin", true, "Fair", "The Conquest of Bread" },
                    { 49, "Haider Warraich", true, "Good", "Modern Death" },
                    { 50, "John F. Kennedy", true, "Poor", "The Strategy of Peace" },
                    { 51, "Bertrand Russell", true, "Fair", "The Problems of Philosophy" },
                    { 52, "Cicero", true, "Poor", "On The Good Life" },
                    { 53, "Ursula LeGuin", true, "Poor", "The Left Hand of Darkness" },
                    { 54, "Art Spiegelman", true, "Good", "Maus" },
                    { 55, "Grant Morrison", true, "Excellent", "Arkham Asylum: A Serious House on Serious Earth" },
                    { 56, "Thurman Arnold", true, "Poor", "The Folklore of Capitalism" },
                    { 57, "Naomi Klein", true, "Good", "This Changes Everything" },
                    { 58, "Terry Gilliam", true, "Excellent", "Gilliamesque" },
                    { 59, "Hunter S. Thompson", true, "Fair", "Fear and Loathing on the Campaign Trial ’72" },
                    { 60, "Hunter S. Thompson", true, "Good", "The Great Shark Hunt" },
                    { 61, "Dante Alighieri", true, "Good", "The Divine Comedy" },
                    { 62, "Gabriel Garcia Marquez", true, "Excellent", "Love in the Time of Cholera" },
                    { 63, "Oscar Wilde", true, "Good", "The Picture of Dorian Grey" },
                    { 64, "Fyodor Dostoevsky", true, "Fair", "The Brothers Karamazov" },
                    { 65, "Paul Klee", true, "Poor", "The Pedagogical Sketchbook" },
                    { 35, "Aristotle", true, "Fair", "Nicomachean Ethics" },
                    { 34, "Dave McKean", true, "Poor", "Cages" },
                    { 43, "Thomas Winter", true, "Good", "Erasmus/Luther: Discourse on Free Will" },
                    { 32, "John Collier", true, "Good", "Punch and Judy: A Complete History and Text" },
                    { 2, "Howard Phillips Lovecraft", true, "Poor", "The Call of Cthulhu" },
                    { 3, "Stephen Ambrose", true, "Excellent", "Undaunted Courage" },
                    { 4, "Marion Starkey", true, "Poor", "The Devil in Massachusetts" },
                    { 5, "Robert Frost", true, "Fair", "The Poetry of Robert Frost" },
                    { 6, "Marcus Aurelius", true, "Good", "Meditations" },
                    { 7, "Aleister Crowley", true, "Fair", "The Book of Lies" },
                    { 33, "Bill Baker", true, "Fair", "Alan Moore Spells It Out" },
                    { 9, "Isaac Asimov", true, "Poor", "A Choice of Catastrophes" },
                    { 10, "Bill Bryson", true, "Excellent", "At Home" },
                    { 11, "Yuval Noah Harari", true, "Excellent", "Sapiens" },
                    { 12, "Mircea Eliade", true, "Good", "Shamanism" },
                    { 13, "Susan Neiman", true, "Good", "Evil in Modern Society" },
                    { 14, "Stephen J. Gould", true, "Fair", "Full House" },
                    { 15, "Carla Emery", true, "Fair", "The Encyclopedia of Country Living" },
                    { 16, "Frederich Nietzsche", true, "Poor", "Thus Spake Zarathustra" },
                    { 8, "Timothy Silver", true, "Fair", "A New Face on the Countryside" },
                    { 18, "Bertrand Russell", true, "Poor", "Authority and the Individual" },
                    { 17, "Carl Jung", true, "Poor", "Man and His Symbols" },
                    { 31, "Anton Szandor LaVey", true, "Excellent", "The Satanic Rituals" },
                    { 30, "Joseph Campbell", true, "Poor", "Myths to Live By" },
                    { 29, "Stephen J. Gould", true, "Good", "The Fossil Trail" },
                    { 27, "Simone de Beauvoir", true, "Good", "The Mandarins" },
                    { 26, "H.G. Wells", true, "Poor", "The New World Order" },
                    { 25, "Tom Wolfe", true, "Poor", "The Right Stuff" },
                    { 28, "Gabriel Garcia Marquez", true, "Excellent", "One Hundred Years of Solitude" },
                    { 23, "Yuval Noah Harari", true, "Excellent", "Homo Deus" },
                    { 22, "George Dow", true, "Poor", "Everyday Life in the Massachusetts Bay Colony" },
                    { 21, "Henry Miller", true, "Good", "Tropic of Capricorn" },
                    { 20, "Henry Miller", true, "Good", "Tropic of Cancer" },
                    { 19, "Howard Zinn", true, "Good", "A People’s History of the United States" },
                    { 24, "Carleen Madigan", true, "Fair", "The Backyard Homestead" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "Address", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
                    { 18, "113 se 28th ave, Portland OR 97214", 45.521f, -122.637f, "Charter 67860" },
                    { 11, "7310 NE Failing St, Portland OR 97213", 45.55f, -122.588f, "Carter 16292" },
                    { 17, "SE 59th Avenue and Stark Street, Portland OR 97215", 45.51f, -122.603f, "Charter 45756" },
                    { 16, "1707 Se 43rd Ave, Portland OR 97215", 45.51f, -122.618f, "Charter 88936" },
                    { 15, "7230 Se Grant St, Portland OR 97215", 45.507f, -122.588f, "Charter 98773" },
                    { 14, "7814 SE Grant Street, Portland OR 97215", 45.507f, -122.583f, "Charter 36705" },
                    { 13, null, 45.512f, -122.609f, "Charter 2400" },
                    { 12, "6701 NE Prescott St, Portland OR 97218", 45.556f, -122.594f, "Charter 60705" },
                    { 10, "6906 NE Siskiyou St., Portland OR 97213", 45.545f, -122.592f, "Carter 54633" },
                    { 3, "88th & Oak, 8885 Nw Oak St, Portland OR 97229", 45.521f, -122.768f, "Charter 23646" },
                    { 8, "3145 NE 54th, Portland OR 97213", 45.546f, -122.608f, "Carter 19749" },
                    { 7, "4525 Ne Campaign St, Portland OR 97218", 45.554f, -122.617f, "Carter 92069" },
                    { 6, "6830 N Olin Ave, Portland OR 97203", 45.574f, -122.72f, "Carter 84632" },
                    { 5, "8310 N. Dana Ave, PORTLAND OR 97203", 45.583f, -122.712f, "Carter 76693" },
                    { 4, "5635 NE 12th Ave, Portland OR 97211", 45.563f, -122.653f, "Charter 10710" },
                    { 2, null, 45.552f, -122.683f, "Charter 738" },
                    { 1, "320 SE 16th Ave, Portland OR 97229", 45.52f, -122.648f, "Charter 70947" },
                    { 19, "2336 NE 45th Ave, Portland OR 97213", 45.539f, -122.617f, "Charter 19064" },
                    { 9, "2531 NE 38th Ave, Portland OR 97212", 45.541f, -122.624f, "Carter 35332" },
                    { 20, "8885 Nw Oak St, Portland OR 97229", 45.521f, -122.768f, "Charter 23646" }
                });

            migrationBuilder.InsertData(
                table: "BookLocation",
                columns: new[] { "BookLocationId", "BookId", "CurrentLocation", "LocationId" },
                values: new object[,]
                {
                    { 58, 21, true, 3 },
                    { 26, 50, false, 14 },
                    { 27, 49, true, 14 },
                    { 28, 48, true, 14 },
                    { 23, 53, true, 15 },
                    { 24, 52, true, 15 },
                    { 25, 51, false, 15 },
                    { 17, 10, true, 16 },
                    { 18, 63, true, 16 },
                    { 19, 54, true, 16 },
                    { 20, 40, true, 16 },
                    { 21, 34, true, 16 },
                    { 31, 45, true, 13 },
                    { 22, 33, true, 16 },
                    { 15, 7, false, 17 },
                    { 16, 18, true, 17 },
                    { 10, 8, true, 18 },
                    { 11, 17, true, 18 },
                    { 12, 14, true, 18 },
                    { 13, 6, true, 18 },
                    { 7, 3, true, 19 },
                    { 8, 22, true, 19 },
                    { 9, 8, false, 19 },
                    { 3, 18, true, 20 },
                    { 4, 13, true, 20 },
                    { 14, 5, true, 17 },
                    { 30, 46, true, 13 },
                    { 29, 47, false, 13 },
                    { 34, 42, true, 12 },
                    { 57, 22, true, 4 },
                    { 55, 24, true, 5 },
                    { 56, 23, true, 5 },
                    { 52, 27, true, 6 },
                    { 53, 26, true, 6 },
                    { 54, 25, true, 6 },
                    { 51, 28, true, 7 },
                    { 48, 31, true, 8 },
                    { 49, 30, true, 8 },
                    { 50, 29, true, 8 },
                    { 43, 33, true, 9 },
                    { 44, 32, true, 9 },
                    { 45, 31, true, 9 },
                    { 46, 33, true, 9 },
                    { 47, 32, true, 9 },
                    { 39, 37, true, 10 },
                    { 40, 36, true, 10 },
                    { 41, 35, true, 10 },
                    { 42, 34, true, 10 },
                    { 35, 41, false, 11 },
                    { 36, 40, true, 11 },
                    { 37, 39, true, 11 },
                    { 38, 38, true, 11 },
                    { 32, 44, true, 12 },
                    { 33, 43, true, 12 },
                    { 5, 1, false, 20 },
                    { 6, 19, false, 20 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "BookLocationId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 20);
        }
    }
}
