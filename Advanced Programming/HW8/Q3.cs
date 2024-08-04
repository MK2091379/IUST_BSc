using Assignment11;
using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {

            var data = File.ReadAllLines(@"..\..\IMDB-Movie-Data.csv")
                .Skip(1)
                .Select(line => new IMDBData(line));
            var comedyFilm = data.ComedyFilmFinder();
            var directorOf2014 = data.DirectorOf2014Finder();
            var MoreThan110MinTime = data.MoreThan110MinTimeFinder();
            var MoveisOfBenAffleck = data.MoveisOfBenAffleckFinder();
       
            // If necessary, you can use more than one extension method to calculate these answers.
            Console.WriteLine($"Question 1: {data.HighestScoreFinder().Title}");
            Console.WriteLine($"Question 2: {data.DirectorWhitLowestScoreFinder().Director}");
            for (int counter = 0; counter < comedyFilm.Count; counter++)
            {
                if (counter == 0) Console.WriteLine($"Question 3:" + "\n" + "     " + $"[{counter + 1}]{comedyFilm[counter].Title}");
                else Console.WriteLine("     " + $"[{counter + 1}]{comedyFilm[counter].Title}");
            }
            for (int counter = 0; counter < MoveisOfBenAffleck.Count; counter++)
            {
                if (counter == 0) Console.WriteLine($"Question 4:" + "\n" + "     " + $"[{counter + 1}]{MoveisOfBenAffleck[counter].Title}");
                else Console.WriteLine("     " + $"[{counter + 1}]{MoveisOfBenAffleck[counter].Title}");
            }
            Console.WriteLine($"Question 5: {data.HighScoreActionMovei().Title}");
            for (int counter = 0; counter < directorOf2014.Count; counter++)
            {
                if (counter == 0) Console.WriteLine($"Question 6:" + "\n" + "     " + $"[{counter + 1}]{directorOf2014[counter].Director}");
                else Console.WriteLine("     " + $"[{counter + 1}]{directorOf2014[counter].Director}");
            }
            Console.WriteLine($"Question 7: {data.HighDramVoteFinder().Title}");
            Console.WriteLine($"Question 8: {data.MoveisBoxOffice()}");
            for (int counter = 0; counter < MoreThan110MinTime.Count; counter++)
            {
                if (counter == 0) Console.WriteLine($"Question 9:" + "\n" + "     " + $"[{counter + 1}]{MoreThan110MinTime[counter].Title}");
                else Console.WriteLine("     " + $"[{counter + 1}]{MoreThan110MinTime[counter].Title}");
            }
            Console.WriteLine($"Question 10: {data.TomHardyMoveis()}");
            Console.WriteLine($"Question 12: {data.MoviesLessThan95Min()}");
            Console.WriteLine($"Question 13: {data.votesVolume()}");



        }
    }

    public static class Extensions
    {
        public static Nullable<int> ParseIntOrNull(this string str)
            => !string.IsNullOrEmpty(str) ? int.Parse(str) as Nullable<int> : null;
        public static string ParseStringOrNull(this string str)
            => !string.IsNullOrEmpty(str) ? str : null;

        //For example
        public static IMDBData HighestScoreFinder(this IEnumerable<IMDBData> data)
            => data.OrderByDescending(x => x.Metascore).First();

        /// <summary>
        /// you must modify the name of this method and its 
        /// implementation to fit your need and create more methods like this
        public static IMDBData ExtensionMethodPlaceHolder(this IEnumerable<IMDBData> data)
            => data.First();
        public static IMDBData DirectorWhitLowestScoreFinder(this IEnumerable<IMDBData> data)
            => data.Where(item => item.Metascore != null).OrderBy(item => item.Metascore).First();
        public static List<IMDBData> ComedyFilmFinder(this IEnumerable<IMDBData> data)
            => data.Where(item=>item.Genre.ToLower().Contains("comedy")).ToList();
        public static List<IMDBData> MoveisOfBenAffleckFinder(this IEnumerable<IMDBData> data)
            => data.Where(item => item.Actor1.Contains("Ben Affleck") || item.Actor2.Contains("Ben Affleck") || item.Actor3.Contains("Ben Affleck") || item.Actor4.Contains("Ben Affleck")).ToList();
        public static IMDBData HighScoreActionMovei(this IEnumerable<IMDBData> data)
            => data.Where(item => item.Genre.ToLower().Contains("action")).OrderByDescending(item => item.Metascore).First();
        public static List<IMDBData> DirectorOf2014Finder(this IEnumerable<IMDBData> data)
        => data.Where(item => item.Year == 2014).ToList();
        public static IMDBData HighDramVoteFinder (this IEnumerable<IMDBData> data)
           => data.Where(item => item.Genre.ToLower().Contains("drama")).OrderByDescending(item => item.Votes).First();
        public static double MoveisBoxOffice(this IEnumerable<IMDBData> data)
            => data.Where(item => item.Year == 2006).Where(item => item.Revenue != null).Sum(item => double.Parse(item.Revenue));
        public static List<IMDBData> MoreThan110MinTimeFinder(this IEnumerable<IMDBData> data)
            => data.Where(item => item.Runtime > 110).ToList();
        public static double TomHardyMoveis (this IEnumerable<IMDBData> data)
            =>data.Count(item => item.Actor1.Contains("Tom Hardy") || item.Actor2.Contains("Tom Hardy") || item.Actor3.Contains("Tom Hardy") || item.Actor4.Contains("Tom Hardy"))*(100/(double)data.Count());
        public static double MoviesLessThan95Min(this IEnumerable<IMDBData> data)
          => data.Count(item => item.Runtime < 95) * (100 / (double)data.Count());
        public static double votesVolume(this IEnumerable<IMDBData> data)
         => data.Count(item => item.Votes > 1e4 && item.Votes < 12e3);
        
    }
}



    public class IMDBData
    {


        public IMDBData(string line)
        {
            var toks = line.Split(',');
            Rank = int.Parse(toks[0]);
            Title = toks[1];
            Genre = toks[2];
            Director = toks[3];
            Actor1 = toks[4];
            Actor2 = toks[5];
            Actor3 = toks[6];
            Actor4 = toks[7];
            Year = int.Parse(toks[8]);
            Runtime = int.Parse(toks[9]);
            Rating = (toks[10]);
            Votes = int.Parse(toks[11]);
            Revenue = toks[12].ParseStringOrNull();
            Metascore = toks[13].ParseIntOrNull();
        }
        public int Rank;
        public string Title;
        public string Genre;
        public string Director;
        public string Actor1;
        public string Actor2;
        public string Actor3;
        public string Actor4;
        public int Year;
        public int Runtime;
        public string Rating;
        public int Votes;
        public string Revenue;
        public Nullable<int> Metascore;
    }

