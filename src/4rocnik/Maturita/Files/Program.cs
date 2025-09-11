using System;
using System.Collections.Generic;
using System.IO;

namespace Files
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      var streamReader = new StreamReader(@"C:\Users\jan.fuka\Desktop\csharp\src\4rocnik\Maturita\Files\movies.csv");
      Movie movie = new Movie(streamReader.ReadLine());
      while (!streamReader.EndOfStream)
      {
       Console.WriteLine(streamReader.ReadToEnd().Split());
        
      }




    }
  }
}