using HtmlAgilityPack;
using WebParse.Data;
using WebParse.DTOs;
using WebParse.Models;

namespace WebParse
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            await VerileriYukle();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
            
        }

        static async Task VerileriYukle()
        {
            MovieDbContext db = new MovieDbContext();
            if (!db.Filmler.Any())
            {
                #region 1.adým
                //imdb.com film ID => ttleri okmak
                List<string> filmIds = new List<string>();
                string url = "https://www.imdb.com/search/title/?groups=top_250&sort=user_rating";
                //webPare iþlei nuget HYML Agility Pack
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.Load(url);
                HtmlNodeCollection films = doc.DocumentNode.SelectNodes("//div[@data-tconst]"); //XPATH 
                foreach (HtmlNode item in films)
                {
                    filmIds.Add(item.Attributes["data-tconst"].Value);
                }
                #endregion

                #region 2.adým
                //omdApi ye gelen (okuduðum, bulduðum -tconst) lara göre istek atam ve gelen veriyi istediðimiz þekilde alma
                //https://www.omdbapi.com/?i=tt3896198&apikey=8a457e53
                List<MovieDTO> movies = new List<MovieDTO>();
                string apiUrl = "https://www.omdbapi.com/?apikey=8a457e53&i=";
                HttpClient httpClient = new HttpClient();
                foreach (string filmId in filmIds)
                {
                    HttpResponseMessage result = await httpClient.GetAsync(apiUrl + filmId);
                    if (result.IsSuccessStatusCode)
                    {
                        //Microsoft.Aspnet.webApi.cilent => nuget
                        //sitring okumak yerine clas okumak için
                        movies.Add(await result.Content.ReadAsAsync<MovieDTO>());
                        //dto => data taransfer object
                    }

                }
                #endregion

                foreach (MovieDTO movie in movies)
                {
                    Film film = new Film()
                    {
                        Ad = movie.Title,
                        imdbId = movie.imdbID,
                        imdbPuaný = movie.imdbRating,
                        Yýl = movie.Year,
                        Poster = movie.Poster

                    };
                    string genreAd = movie.Genre.Split(',')[0].Trim();
                    Tur tur = db.Turler.FirstOrDefault(tur => tur.Ad == genreAd);
                    if (tur != null)
                    {
                        film.Tur = tur;
                    }
                    else
                    {
                        film.Tur = new Tur()
                        {
                            Ad = genreAd
                        };
                    }
                    List<string> oyuncular = movie.Actors.Split(',').ToList();
                    foreach (var item in oyuncular)
                    {
                        Oyuncu oyuncu = db.Oyuncular.FirstOrDefault(oyuncu => oyuncu.AdSoyAd == item.Trim());
                        if (oyuncu != null)
                        {
                            film.Oyuncular.Add(oyuncu);
                        }
                        else
                        {
                            film.Oyuncular.Add(new Oyuncu
                            {
                                AdSoyAd = item.Trim()
                            }

                                );
                        }
                    }
                    db.Filmler.Add(film);
                    await db.SaveChangesAsync();
                }


            }
        }
    }
}