using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ShakespeareAssignment.Utils
{
    public class FileUtility
    {
        public static string[] toStringArray(string path, int numLines = -1, string delimiterPattern = "[^A-Za-z]+") {
            return (numLines >= 0 ? File.ReadAllLines(path).Take(numLines) : File.ReadAllLines(path))
                .SelectMany(line => Regex.Split(line, delimiterPattern))
                .Where(word => !String.IsNullOrEmpty(word))
                .Select(word => word.ToLower())
                .ToArray<string>();
        }
    }
}