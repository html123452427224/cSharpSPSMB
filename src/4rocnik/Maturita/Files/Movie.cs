using System;

namespace Files
{
    public class Movie
    {
        public string film;
        public string genre;
        public string leadStudio;
        public int audienceScore;
        public int profitability;
        public int rottenTomatoes;
        public int worldwideGross;
        public int year;

        

        
        public Movie(string line)
        {
        
            var values = line.Split(',');

           

           
            film = values[0];
            genre = values[1];
            leadStudio = values[2];


            audienceScore = int.Parse(values[3]);
            profitability = int.Parse(values[4]);
            rottenTomatoes = int.Parse(values[5]);
            worldwideGross = int.Parse(values[6]);
            year = int.Parse(values[7]);
        }

       
        public override string ToString()
        {
            return $"{film} ({year}) + Genre: {genre}, Studio: {leadStudio}, " +
                   $"Audience Score: {audienceScore}, Rotten Tomatoes: {rottenTomatoes}%, " +
                   $"Profitability: {profitability}, Worldwide Gross: {worldwideGross}";
        }
    }
}
