using System;
using System.Collections.Generic;
using System.Linq;
using DotnetIteration.Models;

namespace DotnetIteration
{

    public static class Iteration
    {
        /*
           Welcome to Interation

           In each method below you will see instructions that detail the requirements
           the method must implement to make the test pass.

           To start on a method comment out, or remove, the line
           `throw new System.NotImplementedException();`

           As you write and save your code, you can look in your terminal where you
           ran `dotnet watch test` to see if your code is working. The tests
           continuously check your work each time you save. If a test is failing
           you have not yet completed that method. Once you finish a method and have
           it correct, the test will tell you how the next method is working.
        */


        //  
        // 1) Complete the method named `yelling` that takes a list of
        //    words as an argument and returns a new list with all
        //    the words forced to uppercase.
        //
        public static IEnumerable<string> Yelling(List<string> words)
        {
            var upperCaseWords = words.Select(word => word.ToUpper());

            return upperCaseWords;

        }


        // 
        // 2) Complete the method named `Double` that takes a list of
        //    numbers as an argument and returns a new list with all
        //    the numbers multiplied by 2.
        // 
        public static IEnumerable<int> Double(List<int> numbers)
        {
            var newNumber = numbers.Select(number => number * 2);
            return newNumber;


        }


        // 
        // 3) Complete the method `StringyIndexes` that takes a list of
        //    strings as an argument and returns a new list with each
        //    string suffixed with " is at index X" where X is the index
        //    of the element.
        // 
        public static IEnumerable<string> StringyIndexes(List<string> words)
        {
            var stringyWords = words.Select((word, index) => $"{word} is at index {index}");

            return stringyWords;


        }


        // 
        // 4) Complete the method OnlyTheEvenSurvive that accepts a list of
        //    numbers and returns only the elements that are even.
        // 
        public static IEnumerable<int> OnlyTheEvenSurvive(List<int> numbers)
        {
            //Where statement needs to compare values to output a bool
            var evenNumbers = numbers.Where(number => number % 2 == 0);
            return evenNumbers;


        }


        // 
        // 5) Complete the method OnlyTheEvenIndexedSurvive that accepts a
        //    list of numbers and returns only the elements at indexes that
        //    are even.
        // 
        public static IEnumerable<int> OnlyTheEvenIndexedSurvive(List<int> numbers)
        {
            var listOfNumbers = numbers.Where((numbers, index) => index % 2 == 0);
            return listOfNumbers;


            //var onlyTheEvenNumbers = numbers.Where(number => number % 2 == 0).Select((numbers, index)
        }


        // 
        // 6) Complete the method BestMoviesOfTheYear that accepts a list of
        //    movie objects AND a year and returns the names of movies that are
        //    from that year AND have a score more than 90.
        // 
        // A movie object looks like this:
        // 
        // new Movie() 

        //   Name: "Get Out",
        //   Year: "2017",
        //   Score: 99
        // }
        // 
        public static IEnumerable<string> BestMovieOfTheYear(List<Movie> movies, int yearToMatch)
        {

            var popularMovieInOneLine = movies.Where(movie => movie.Score >= 90 && movie.Year == yearToMatch).Select(movies => movies.Name);
            return popularMovieInOneLine;

        }


        // 
        // 7) Complete the method EveryoneIsOdd that accepts a list of
        //    numbers and returns true if every element of the list is odd.
        // 
        public static bool EveryoneIsOdd(List<int> numbers)
        {
            // Figure out if all the movies are old movies, before 1965
            var allOddNumbers = numbers.All(number => number % 2 != 0);
            return allOddNumbers;



        }


        // 
        // 8) Complete the method FindTheNeedle that accepts a list of
        //    strings and returns the one string that contains the word
        //    `needle`.
        // 
        public static string FindTheNeedle(List<string> sentences)
        {
            var specificWord = sentences.First(sentence => sentence.Contains("needle"));
            return specificWord;


            //var newWord = sentences.Select(sentence = needle )
        }


        // 
        // 9) Complete the method FindTheNeedleIndex that accepts a list of
        //    strings and returns the index of the string that contains
        //    the word `needle` inside.
        // 
        public static int FindTheNeedleIndex(List<string> sentences)
        {
            var insideWord = sentences.FindIndex(sentence => sentence.Contains("needle"));
            return insideWord;



        }


        // 
        // 10) Complete the method SomeoneToLove that accepts a list of
        //     strings and returns true if at least one string is exactly
        //     four characters long.
        // 
        public static bool SomeoneToLove(List<string> words)
        {
            //var areAllOldMovies = movies.All(
            // movie => movie.ReleasedDate.Year < 1965);
            // Our favorite movie is Jaws, let's get it from the list if it is there. If it isn't we'll get an exception/error
            // var fourCharacters = words.First(word => word.Name == "Jaws");
            //return fourCharacters;
            var someoneToLoveWord = words.Any(word => word.Length == 4);
            return someoneToLoveWord;


        }
    }
}
