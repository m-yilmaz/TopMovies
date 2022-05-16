using System.Collections.Generic;
using System.Linq;

namespace TopMovies.Models
{
    public static class ApplicationDbContextSeed
    {
        public static void Seed(ApplicationDbContext db)
        {
            if (db.Genres.Any() || db.Movies.Any()) return;

            var action = new Genre() { Name = "Action" };
            var adventure = new Genre() { Name = "Adventure" };
            var animation = new Genre() { Name = "Animation" };
            var biography = new Genre() { Name = "Biography" };
            var comedy = new Genre() { Name = "Comedy" };
            var crime = new Genre() { Name = "Crime" };
            var drama = new Genre() { Name = "Drama" };
            var family = new Genre() { Name = "Family" };
            var fantasy = new Genre() { Name = "Fantasy" };
            var filmNoir = new Genre() { Name = "Film-Noir" };
            var history = new Genre() { Name = "History" };
            var horror = new Genre() { Name = "Horror" };
            var music = new Genre() { Name = "Music" };
            var musical = new Genre() { Name = "Musical" };
            var mystery = new Genre() { Name = "Mystery" };
            var romance = new Genre() { Name = "Romance" };
            var sciFi = new Genre() { Name = "Sci-Fi" };
            var thriller = new Genre() { Name = "Thriller" };
            var war = new Genre() { Name = "War" };
            var western = new Genre() { Name = "Western" };

            var genres = new Genre[] { action, adventure, animation, biography, comedy, crime, drama, family, fantasy, filmNoir, history, horror, music, musical, mystery, romance, sciFi, thriller, war, western };

            foreach (var genre in genres)
            {
                db.Genres.Add(genre);
                db.SaveChanges();
            }

            var movies = new Movie[]
            {
                new Movie()
                {
                    ImdbId = "tt0111161",
                    Name = "The Shawshank Redemption",
                    Year = 1994,
                    Rating = 9.3m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama }
                },
                new Movie()
                {
                    ImdbId = "tt0068646",
                    Name = "The Godfather",
                    Year = 1972,
                    Rating = 9.2m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY98_CR1,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { crime, drama }
                },
                new Movie()
                {
                    ImdbId = "tt0468569",
                    Name = "The Dark Knight",
                    Year = 2008,
                    Rating = 9m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, crime, drama }
                },
                new Movie()
                {
                    ImdbId = "tt0167260",
                    Name = "The Lord of the Rings: The Return of the King",
                    Year = 2003,
                    Rating = 9m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzA5ZDNlZWMtM2NhNS00NDJjLTk4NDItYTRmY2EwMWZlMTY3XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, adventure, drama }
                },
                new Movie()
                {
                    ImdbId = "tt0108052",
                    Name = "Schindler's List",
                    Year = 1993,
                    Rating = 9m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDE4OTMxMTctNmRhYy00NWE2LTg3YzItYTk3M2UwOTU5Njg4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { biography, drama, history }
                },
                new Movie()
                {
                    ImdbId = "tt0071562",
                    Name = "The Godfather: Part II",
                    Year = 1974,
                    Rating = 9m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMWMwMGQzZTItY2JlNC00OWZiLWIyMDctNDk2ZDQ2YjRjMWQ0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY98_CR1,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { crime, drama }
                },
                new Movie()
                {
                    ImdbId = "tt0050083",
                    Name = "12 Angry Men",
                    Year = 1957,
                    Rating = 9m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMWU4N2FjNzYtNTVkNC00NzQ0LTg0MjAtYTJlMjFhNGUxZDFmXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { crime, drama }
                },
                new Movie()
                {
                    ImdbId = "tt0110912",
                    Name = "Pulp Fiction",
                    Year = 1994,
                    Rating = 8.9m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGNhMDIzZTUtNTBlZi00MTRlLWFjM2ItYzViMjE3YzI5MjljXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY98_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { crime, drama }
                },
                new Movie()
                {
                    ImdbId = "tt6710474",
                    Name = "Everything Everywhere All at Once",
                    Year = 2022,
                    Rating = 8.8m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BYTdiOTIyZTQtNmQ1OS00NjZlLWIyMTgtYzk5Y2M3ZDVmMDk1XkEyXkFqcGdeQXVyMTAzMDg4NzU0._V1_UY98_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, adventure, comedy }
                },
                new Movie()
                {
                    ImdbId = "tt1375666",
                    Name = "Inception",
                    Year = 2010,
                    Rating = 8.8m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, adventure, sciFi }
                },
                new Movie()
                {
                    ImdbId = "tt0167261",
                    Name = "The Lord of the Rings: The Two Towers",
                    Year = 2002,
                    Rating = 8.8m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BZGMxZTdjZmYtMmE2Ni00ZTdkLWI5NTgtNjlmMjBiNzU2MmI5XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, adventure, drama }
                },
                new Movie()
                {
                    ImdbId = "tt0137523",
                    Name = "Fight Club",
                    Year = 1999,
                    Rating = 8.8m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDIzNDU0YzEtYzE5Ni00ZjlkLTk5ZjgtNjM3NWE4YzA3Nzk3XkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama }
                },
                new Movie()
                {
                    ImdbId = "tt0120737",
                    Name = "The Lord of the Rings: The Fellowship of the Ring",
                    Year = 2001,
                    Rating = 8.8m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BN2EyZjM3NzUtNWUzMi00MTgxLWI0NTctMzY4M2VlOTdjZWRiXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, adventure, drama }
                },
                new Movie()
                {
                    ImdbId = "tt0109830",
                    Name = "Forrest Gump",
                    Year = 1994,
                    Rating = 8.8m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNWIwODRlZTUtY2U3ZS00Yzg1LWJhNzYtMmZiYmEyNmU1NjMzXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY98_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama, romance }
                },
                new Movie()
                {
                    ImdbId = "tt0060196",
                    Name = "The Good, the Bad and the Ugly",
                    Year = 1966,
                    Rating = 8.8m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNjJlYmNkZGItM2NhYy00MjlmLTk5NmQtNjg1NmM2ODU4OTMwXkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { adventure, western }
                },
                new Movie()
                {
                    ImdbId = "tt0133093",
                    Name = "The Matrix",
                    Year = 1999,
                    Rating = 8.7m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzQzOTk3OTAtNDQ0Zi00ZTVkLWI0MTEtMDllZjNkYzNjNTc4L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, sciFi }
                },
                new Movie()
                {
                    ImdbId = "tt0099685",
                    Name = "Goodfellas",
                    Year = 1990,
                    Rating = 8.7m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BY2NkZjEzMDgtN2RjYy00YzM1LWI4ZmQtMjIwYjFjNmI3ZGEwXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { biography, crime, drama }
                },
                new Movie()
                {
                    ImdbId = "tt0080684",
                    Name = "Star Wars: Episode V - The Empire Strikes Back",
                    Year = 1980,
                    Rating = 8.7m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BYmU1NDRjNDgtMzhiMi00NjZmLTg5NGItZDNiZjU5NTU4OTE0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, adventure, fantasy }
                },
                new Movie()
                {
                    ImdbId = "tt0073486",
                    Name = "One Flew Over the Cuckoo's Nest",
                    Year = 1975,
                    Rating = 8.7m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BZjA0OWVhOTAtYWQxNi00YzNhLWI4ZjYtNjFjZTEyYjJlNDVlL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama }
                },
                new Movie()
                {
                    ImdbId = "tt0816692",
                    Name = "Interstellar",
                    Year = 2014,
                    Rating = 8.6m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BZjdkOTU3MDktN2IxOS00OGEyLWFmMjktY2FiMmZkNWIyODZiXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { adventure, drama, sciFi }
                },
                new Movie()
                {
                    ImdbId = "tt0317248",
                    Name = "City of God",
                    Year = 2002,
                    Rating = 8.6m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BOTMwYjc5ZmItYTFjZC00ZGQ3LTlkNTMtMjZiNTZlMWQzNzI5XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { crime, drama }
                },
                new Movie()
                {
                    ImdbId = "tt0245429",
                    Name = "Spirited Away",
                    Year = 2001,
                    Rating = 8.6m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjlmZmI5MDctNDE2YS00YWE0LWE5ZWItZDBhYWQ0NTcxNWRhXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { animation, adventure, family }
                },
                new Movie()
                {
                    ImdbId = "tt0120815",
                    Name = "Saving Private Ryan",
                    Year = 1998,
                    Rating = 8.6m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BZjhkMDM4MWItZTVjOC00ZDRhLThmYTAtM2I5NzBmNmNlMzI1XkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama, war }
                },
                new Movie()
                {
                    ImdbId = "tt0120689",
                    Name = "The Green Mile",
                    Year = 1999,
                    Rating = 8.6m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTUxMzQyNjA5MF5BMl5BanBnXkFtZTYwOTU2NTY3._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { crime, drama, fantasy }
                },
                new Movie()
                {
                    ImdbId = "tt0118799",
                    Name = "Life Is Beautiful",
                    Year = 1997,
                    Rating = 8.6m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BYmJmM2Q4NmMtYThmNC00ZjRlLWEyZmItZTIwOTBlZDQ3NTQ1XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { comedy, drama, romance }
                },
                new Movie()
                {
                    ImdbId = "tt0114369",
                    Name = "Se7en",
                    Year = 1995,
                    Rating = 8.6m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BOTUwODM5MTctZjczMi00OTk4LTg3NWUtNmVhMTAzNTNjYjcyXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { crime, drama, mystery }
                },
                new Movie()
                {
                    ImdbId = "tt0103064",
                    Name = "Terminator 2: Judgment Day",
                    Year = 1991,
                    Rating = 8.6m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMGU2NzRmZjUtOGUxYS00ZjdjLWEwZWItY2NlM2JhNjkxNTFmXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, sciFi }
                },
                new Movie()
                {
                    ImdbId = "tt0102926",
                    Name = "The Silence of the Lambs",
                    Year = 1991,
                    Rating = 8.6m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNjNhZTk0ZmEtNjJhMi00YzFlLWE1MmEtYzM1M2ZmMGMwMTU4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { crime, drama, thriller }
                },
                new Movie()
                {
                    ImdbId = "tt0076759",
                    Name = "Star Wars",
                    Year = 1977,
                    Rating = 8.6m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzg4MjQxNTQtZmI5My00YjMwLWJlMjUtMmJlY2U2ZWFlNzY1XkEyXkFqcGdeQXVyODk4OTc3MTY@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, adventure, fantasy }
                },
                new Movie()
                {
                    ImdbId = "tt0056058",
                    Name = "Hara-Kiri",
                    Year = 1962,
                    Rating = 8.6m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BYjBmYTQ1NjItZWU5MS00YjI0LTg2OTYtYmFkN2JkMmNiNWVkXkEyXkFqcGdeQXVyMTMxMTY0OTQ@._V1_UY98_CR2,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, drama, mystery }
                },
                new Movie()
                {
                    ImdbId = "tt0047478",
                    Name = "Seven Samurai",
                    Year = 1954,
                    Rating = 8.6m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNWQ3OTM4ZGItMWEwZi00MjI5LWI3YzgtNTYwNWRkNmIzMGI5XkEyXkFqcGdeQXVyNDY2MTk1ODk@._V1_UY98_CR1,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, drama }
                },
                new Movie()
                {
                    ImdbId = "tt0038650",
                    Name = "It's a Wonderful Life",
                    Year = 1946,
                    Rating = 8.6m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BZjc4NDZhZWMtNGEzYS00ZWU2LThlM2ItNTA0YzQ0OTExMTE2XkEyXkFqcGdeQXVyNjUwMzI2NzU@._V1_UY98_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama, family, fantasy }
                },
                new Movie()
                {
                    ImdbId = "tt6751668",
                    Name = "Parasite",
                    Year = 2019,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BYWZjMjk3ZTItODQ2ZC00NTY5LWE0ZDYtZTI3MjcwN2Q5NTVkXkEyXkFqcGdeQXVyODk4OTc3MTY@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { comedy, drama, thriller }
                },
                new Movie()
                {
                    ImdbId = "tt2582802",
                    Name = "Whiplash",
                    Year = 2014,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BOTA5NDZlZGUtMjAxOS00YTRkLTkwYmMtYWQ0NWEwZDZiNjEzXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama, music }
                },
                new Movie()
                {
                    ImdbId = "tt1675434",
                    Name = "The Intouchables",
                    Year = 2011,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTYxNDA3MDQwNl5BMl5BanBnXkFtZTcwNTU4Mzc1Nw@@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { biography, comedy, drama }
                },
                new Movie()
                {
                    ImdbId = "tt0482571",
                    Name = "The Prestige",
                    Year = 2006,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjA4NDI0MTIxNF5BMl5BanBnXkFtZTYwNTM0MzY2._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama, mystery, thriller }
                },
                new Movie()
                {
                    ImdbId = "tt0407887",
                    Name = "The Departed",
                    Year = 2006,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTI1MTY2OTIxNV5BMl5BanBnXkFtZTYwNjQ4NjY3._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { crime, drama, thriller }
                },
                new Movie()
                {
                    ImdbId = "tt0253474",
                    Name = "The Pianist",
                    Year = 2002,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BOWRiZDIxZjktMTA1NC00MDQ2LWEzMjUtMTliZmY3NjQ3ODJiXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UY98_CR2,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { biography, drama, music }
                },
                new Movie()
                {
                    ImdbId = "tt0172495",
                    Name = "Gladiator",
                    Year = 2000,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDliMmNhNDEtODUyOS00MjNlLTgxODEtN2U3NzIxMGVkZTA1L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, adventure, drama }
                },
                new Movie()
                {
                    ImdbId = "tt0120586",
                    Name = "American History X",
                    Year = 1998,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BZTJhN2FkYWEtMGI0My00YWM4LWI2MjAtM2UwNjY4MTI2ZTQyXkEyXkFqcGdeQXVyNjc3MjQzNTI@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama }
                },
                new Movie()
                {
                    ImdbId = "tt0114814",
                    Name = "The Usual Suspects",
                    Year = 1995,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BYTViNjMyNmUtNDFkNC00ZDRlLThmMDUtZDU2YWE4NGI2ZjVmXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { crime, drama, mystery }
                },
                new Movie()
                {
                    ImdbId = "tt0110413",
                    Name = "Léon: The Professional",
                    Year = 1994,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BODllNWE0MmEtYjUwZi00ZjY3LThmNmQtZjZlMjI2YTZjYmQ0XkEyXkFqcGdeQXVyNTc1NTQxODI@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, crime, drama }
                },
                new Movie()
                {
                    ImdbId = "tt0110357",
                    Name = "The Lion King",
                    Year = 1994,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BYTYxNGMyZTYtMjE3MS00MzNjLWFjNmYtMDk3N2FmM2JiM2M1XkEyXkFqcGdeQXVyNjY5NDU4NzI@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { animation, adventure, drama }
                },
                new Movie()
                {
                    ImdbId = "tt0095765",
                    Name = "Cinema Paradiso",
                    Year = 1988,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BM2FhYjEyYmYtMDI1Yy00YTdlLWI2NWQtYmEzNzAxOGY1NjY2XkEyXkFqcGdeQXVyNTA3NTIyNDg@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama, romance }
                },
                new Movie()
                {
                    ImdbId = "tt0095327",
                    Name = "Grave of the Fireflies",
                    Year = 1988,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BZmY2NjUzNDQtNTgxNC00M2Q4LTljOWQtMjNjNDBjNWUxNmJlXkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { animation, drama, war }
                },
                new Movie()
                {
                    ImdbId = "tt0088763",
                    Name = "Back to the Future",
                    Year = 1985,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BZmU0M2Y1OGUtZjIxNi00ZjBkLTg1MjgtOWIyNThiZWIwYjRiXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { adventure, comedy, sciFi }
                },
                new Movie()
                {
                    ImdbId = "tt0078788",
                    Name = "Apocalypse Now",
                    Year = 1979,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDdhODg0MjYtYzBiOS00ZmI5LWEwZGYtZDEyNDU4MmQyNzFkXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama, mystery, war }
                },
                new Movie()
                {
                    ImdbId = "tt0078748",
                    Name = "Alien",
                    Year = 1979,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BOGQzZTBjMjQtOTVmMS00NGE5LWEyYmMtOGQ1ZGZjNmRkYjFhXkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { horror, sciFi }
                },
                new Movie()
                {
                    ImdbId = "tt0064116",
                    Name = "Once Upon a Time in the West",
                    Year = 1968,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BODQ3NDExOGYtMzI3Mi00NWRlLTkwNjAtNjc4MDgzZGJiZTA1XkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { western }
                },
                new Movie()
                {
                    ImdbId = "tt0054215",
                    Name = "Psycho",
                    Year = 1960,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNTQwNDM1YzItNDAxZC00NWY2LTk0M2UtNDIwNWI5OGUyNWUxXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { horror, mystery, thriller }
                },
                new Movie()
                {
                    ImdbId = "tt0047396",
                    Name = "Rear Window",
                    Year = 1954,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGUxYWM3M2MtMGM3Mi00ZmRiLWE0NGQtZjE5ODI2OTJhNTU0XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { mystery, thriller }
                },
                new Movie()
                {
                    ImdbId = "tt0034583",
                    Name = "Casablanca",
                    Year = 1942,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BY2IzZGY2YmEtYzljNS00NTM5LTgwMzUtMzM1NjQ4NGI0OTk0XkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama, romance, war }
                },
                new Movie()
                {
                    ImdbId = "tt0027977",
                    Name = "Modern Times",
                    Year = 1936,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BYjJiZjMzYzktNjU0NS00OTkxLWEwYzItYzdhYWJjN2QzMTRlL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { comedy, drama, romance }
                },
                new Movie()
                {
                    ImdbId = "tt0021749",
                    Name = "City Lights",
                    Year = 1931,
                    Rating = 8.5m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BY2I4MmM1N2EtM2YzOS00OWUzLTkzYzctNDc5NDg2N2IyODJmXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { comedy, drama, romance }
                },
                new Movie()
                {
                    ImdbId = "tt8267604",
                    Name = "Capernaum",
                    Year = 2018,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BY2Y3OWNkMTctYzNjYS00NWVkLTg4OWEtY2YxN2I3NDhlYzE0XkEyXkFqcGdeQXVyMTI3ODAyMzE2._V1_UY98_CR1,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama }
                },
                new Movie()
                {
                    ImdbId = "tt7286456",
                    Name = "Joker",
                    Year = 2019,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGVjNWI4ZGUtNzE0MS00YTJmLWE0ZDctN2ZiYTk2YmI3NTYyXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { crime, drama, thriller }
                },
                new Movie()
                {
                    ImdbId = "tt5311514",
                    Name = "Your Name.",
                    Year = 2016,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BODRmZDVmNzUtZDA4ZC00NjhkLWI2M2UtN2M0ZDIzNDcxYThjL2ltYWdlXkEyXkFqcGdeQXVyNTk0MzMzODA@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { animation, drama, fantasy }
                },
                new Movie()
                {
                    ImdbId = "tt4633694",
                    Name = "Spider-Man: Into the Spider-Verse",
                    Year = 2018,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjMwNDkxMTgzOF5BMl5BanBnXkFtZTgwNTkwNTQ3NjM@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { animation, action, adventure }
                },
                new Movie()
                {
                    ImdbId = "tt4154796",
                    Name = "Avengers: Endgame",
                    Year = 2019,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc5MDE2ODcwNV5BMl5BanBnXkFtZTgwMzI2NzQ2NzM@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, adventure, drama }
                },
                new Movie()
                {
                    ImdbId = "tt4154756",
                    Name = "Avengers: Infinity War",
                    Year = 2018,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjMxNjY2MDU1OV5BMl5BanBnXkFtZTgwNzY1MTUwNTM@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, adventure, sciFi }
                },
                new Movie()
                {
                    ImdbId = "tt2380307",
                    Name = "Coco",
                    Year = 2017,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BYjQ5NjM0Y2YtNjZkNC00ZDhkLWJjMWItN2QyNzFkMDE3ZjAxXkEyXkFqcGdeQXVyODIxMzk5NjA@._V1_UY98_CR1,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { animation, adventure, comedy }
                },
                new Movie()
                {
                    ImdbId = "tt1853728",
                    Name = "Django Unchained",
                    Year = 2012,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjIyNTQ5NjQ1OV5BMl5BanBnXkFtZTcwODg1MDU4OA@@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama, western }
                },
                new Movie()
                {
                    ImdbId = "tt1345836",
                    Name = "The Dark Knight Rises",
                    Year = 2012,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTk4ODQzNDY3Ml5BMl5BanBnXkFtZTcwODA0NTM4Nw@@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, crime, drama }
                },
                new Movie()
                {
                    ImdbId = "tt1187043",
                    Name = "3 Idiots",
                    Year = 2009,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNTkyOGVjMGEtNmQzZi00NzFlLTlhOWQtODYyMDc2ZGJmYzFhXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UY98_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { comedy, drama }
                },
                new Movie()
                {
                    ImdbId = "tt0910970",
                    Name = "WALL·E",
                    Year = 2008,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjExMTg5OTU0NF5BMl5BanBnXkFtZTcwMjMxMzMzMw@@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { animation, adventure, family }
                },
                new Movie()
                {
                    ImdbId = "tt0405094",
                    Name = "The Lives of Others",
                    Year = 2006,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNmQyNmJjM2ItNTQzYi00ZjMxLWFjMDYtZjUyN2YwZDk5YWQ2XkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama, mystery, thriller }
                },
                new Movie()
                {
                    ImdbId = "tt0364569",
                    Name = "Oldboy",
                    Year = 2003,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTI3NTQyMzU5M15BMl5BanBnXkFtZTcwMTM2MjgyMQ@@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, drama, mystery }
                },
                new Movie()
                {
                    ImdbId = "tt0209144",
                    Name = "Memento",
                    Year = 2000,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BZTcyNjk1MjgtOWI3Mi00YzQwLWI5MTktMzY4ZmI2NDAyNzYzXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { mystery, thriller }
                },
                new Movie()
                {
                    ImdbId = "tt0169547",
                    Name = "American Beauty",
                    Year = 1999,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNTBmZWJkNjctNDhiNC00MGE2LWEwOTctZTk5OGVhMWMyNmVhXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama }
                },
                new Movie()
                {
                    ImdbId = "tt0119698",
                    Name = "Princess Mononoke",
                    Year = 1997,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGIzY2IzODQtNThmMi00ZDE4LWI5YzAtNzNlZTM1ZjYyYjUyXkEyXkFqcGdeQXVyODEzNjM5OTQ@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { animation, action, adventure }
                },
                new Movie()
                {
                    ImdbId = "tt0112573",
                    Name = "Braveheart",
                    Year = 1995,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMzkzMmU0YTYtOWM3My00YzBmLWI0YzctOGYyNTkwMWE5MTJkXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { biography, drama, history }
                },
                new Movie()
                {
                    ImdbId = "tt0090605",
                    Name = "Aliens",
                    Year = 1986,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BZGU2OGY5ZTYtMWNhYy00NjZiLWI0NjUtZmNhY2JhNDRmODU3XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, adventure, sciFi }
                },
                new Movie()
                {
                    ImdbId = "tt0086879",
                    Name = "Amadeus",
                    Year = 1984,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNWJlNzUzNGMtYTAwMS00ZjI2LWFmNWQtODcxNWUxODA5YmU1XkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { biography, drama, music }
                },
                new Movie()
                {
                    ImdbId = "tt0082971",
                    Name = "Indiana Jones and the Raiders of the Lost Ark",
                    Year = 1981,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjA0ODEzMTc1Nl5BMl5BanBnXkFtZTcwODM2MjAxNA@@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, adventure }
                },
                new Movie()
                {
                    ImdbId = "tt0082096",
                    Name = "The Boat",
                    Year = 1981,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BOGZhZDIzNWMtNjkxMS00MDQ1LThkMTYtZWQzYWU3MWMxMGU5XkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama, war }
                },
                new Movie()
                {
                    ImdbId = "tt0081505",
                    Name = "The Shining",
                    Year = 1980,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BZWFlYmY2MGEtZjVkYS00YzU4LTg0YjQtYzY1ZGE3NTA5NGQxXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama, horror }
                },
                new Movie()
                {
                    ImdbId = "tt0057565",
                    Name = "High and Low",
                    Year = 1963,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BOTI4NTNhZDMtMWNkZi00MTRmLWJmZDQtMmJkMGVmZTEzODlhXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { crime, drama, mystery }
                },
                new Movie()
                {
                    ImdbId = "tt0057012",
                    Name = "Dr. Strangelove or: How I Learned to Stop Worrying and Love the Bomb",
                    Year = 1964,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BZWI3ZTMxNjctMjdlNS00NmUwLWFiM2YtZDUyY2I3N2MxYTE0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { comedy, war }
                },
                new Movie()
                {
                    ImdbId = "tt0051201",
                    Name = "Witness for the Prosecution",
                    Year = 1957,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDQwODU5OWYtNDcyNi00MDQ1LThiOGMtZDkwNWJiM2Y3MDg0XkEyXkFqcGdeQXVyMDI2NDg0NQ@@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { crime, drama, mystery }
                },
                new Movie()
                {
                    ImdbId = "tt0050825",
                    Name = "Paths of Glory",
                    Year = 1957,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BOTI5Nzc0OTMtYzBkMS00NjkxLThmM2UtNjM2ODgxN2M5NjNkXkEyXkFqcGdeQXVyNjQ2MjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama, war }
                },
                new Movie()
                {
                    ImdbId = "tt0043014",
                    Name = "Sunset Blvd.",
                    Year = 1950,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTU0NTkyNzYwMF5BMl5BanBnXkFtZTgwMDU0NDk5MTI@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama, filmNoir }
                },
                new Movie()
                {
                    ImdbId = "tt0032553",
                    Name = "The Great Dictator",
                    Year = 1940,
                    Rating = 8.4m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMmExYWJjNTktNGUyZS00ODhmLTkxYzAtNWIzOGEyMGNiMmUwXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { comedy, drama, war }
                },
                new Movie()
                {
                    ImdbId = "tt2106476",
                    Name = "The Hunt",
                    Year = 2012,
                    Rating = 8.3m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTg2NDg3ODg4NF5BMl5BanBnXkFtZTcwNzk3NTc3Nw@@._V1_UY98_CR1,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama }
                },
                new Movie()
                {
                    ImdbId = "tt0435761",
                    Name = "Toy Story 3",
                    Year = 2010,
                    Rating = 8.3m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTgxOTY4Mjc0MF5BMl5BanBnXkFtZTcwNTA4MDQyMw@@._V1_UY98_CR1,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { animation, adventure, comedy }
                },
                new Movie()
                {
                    ImdbId = "tt0361748",
                    Name = "Inglourious Basterds",
                    Year = 2009,
                    Rating = 8.3m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BOTJiNDEzOWYtMTVjOC00ZjlmLWE0NGMtZmE1OWVmZDQ2OWJhXkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { adventure, drama, war }
                },
                new Movie()
                {
                    ImdbId = "tt0338013",
                    Name = "Eternal Sunshine of the Spotless Mind",
                    Year = 2004,
                    Rating = 8.3m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTY4NzcwODg3Nl5BMl5BanBnXkFtZTcwNTEwOTMyMw@@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama, romance, sciFi }
                },
                new Movie()
                {
                    ImdbId = "tt0211915",
                    Name = "Amélie",
                    Year = 2001,
                    Rating = 8.3m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDg4NjM1YjMtYmNhZC00MjM0LWFiZmYtNGY1YjA3MzZmODc5XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { comedy, romance }
                },
                new Movie()
                {
                    ImdbId = "tt0180093",
                    Name = "Requiem for a Dream",
                    Year = 2000,
                    Rating = 8.3m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BOTdiNzJlOWUtNWMwNS00NmFlLWI0YTEtZmI3YjIzZWUyY2Y3XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama }
                },
                new Movie()
                {
                    ImdbId = "tt0119217",
                    Name = "Good Will Hunting",
                    Year = 1997,
                    Rating = 8.3m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BOTI0MzcxMTYtZDVkMy00NjY1LTgyMTYtZmUxN2M3NmQ2NWJhXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama, romance }
                },
                new Movie()
                {
                    ImdbId = "tt0114709",
                    Name = "Toy Story",
                    Year = 1995,
                    Rating = 8.3m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDU2ZWJlMjktMTRhMy00ZTA5LWEzNDgtYmNmZTEwZTViZWJkXkEyXkFqcGdeQXVyNDQ2OTk4MzI@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { animation, adventure, comedy }
                },
                new Movie()
                {
                    ImdbId = "tt0105236",
                    Name = "Reservoir Dogs",
                    Year = 1992,
                    Rating = 8.3m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BZmExNmEwYWItYmQzOS00YjA5LTk2MjktZjEyZDE1Y2QxNjA1XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { crime, drama, thriller }
                },
                new Movie()
                {
                    ImdbId = "tt0087843",
                    Name = "Once Upon a Time in America",
                    Year = 1984,
                    Rating = 8.3m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMGFkNWI4MTMtNGQ0OC00MWVmLTk3MTktOGYxN2Y2YWVkZWE2XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { crime, drama }
                },
                new Movie()
                {
                    ImdbId = "tt0086190",
                    Name = "Star Wars: Episode VI - Return of the Jedi",
                    Year = 1983,
                    Rating = 8.3m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BOWZlMjFiYzgtMTUzNC00Y2IzLTk1NTMtZmNhMTczNTk0ODk1XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, adventure, fantasy }
                },
                new Movie()
                {
                    ImdbId = "tt0062622",
                    Name = "2001: A Space Odyssey",
                    Year = 1968,
                    Rating = 8.3m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMmNlYzRiNDctZWNhMi00MzI4LThkZTctMTUzMmZkMmFmNThmXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { adventure, sciFi }
                },
                new Movie()
                {
                    ImdbId = "tt0056172",
                    Name = "Lawrence of Arabia",
                    Year = 1962,
                    Rating = 8.3m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BYWY5ZjhjNGYtZmI2Ny00ODM0LWFkNzgtZmI1YzA2N2MxMzA0XkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_UY98_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { adventure, biography, drama }
                },
                new Movie()
                {
                    ImdbId = "tt0053125",
                    Name = "North by Northwest",
                    Year = 1959,
                    Rating = 8.3m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BZDA3NDExMTUtMDlhOC00MmQ5LWExZGUtYmI1NGVlZWI4OWNiXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { action, adventure, mystery }
                },
                new Movie()
                {
                    ImdbId = "tt0052357",
                    Name = "Vertigo",
                    Year = 1958,
                    Rating = 8.3m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BYTE4ODEwZDUtNDFjOC00NjAxLWEzYTQtYTI1NGVmZmFlNjdiL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { mystery, romance, thriller }
                },
                new Movie()
                {
                    ImdbId = "tt0045152",
                    Name = "Singin' in the Rain",
                    Year = 1952,
                    Rating = 8.3m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BZDRjNGViMjQtOThlMi00MTA3LThkYzQtNzJkYjBkMGE0YzE1XkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_UY98_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { comedy, musical, romance }
                },
                new Movie()
                {
                    ImdbId = "tt0033467",
                    Name = "Citizen Kane",
                    Year = 1941,
                    Rating = 8.3m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BYjBiOTYxZWItMzdiZi00NjlkLWIzZTYtYmFhZjhiMTljOTdkXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { drama, mystery }
                },
                new Movie()
                {
                    ImdbId = "tt0022100",
                    Name = "M",
                    Year = 1931,
                    Rating = 8.3m,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BODA4ODk3OTEzMF5BMl5BanBnXkFtZTgwMTQ2ODMwMzE@._V1_UX67_CR0,0,67,98_AL_.jpg",
                    Genres = new List<Genre>() { crime, mystery, thriller }
                }
            };

            foreach (var movie in movies)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
            }
        }
    }
}
