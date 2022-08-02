using System;
using System.Collections.Generic;
using System.Linq;

namespace SigmaCamp_HomeTask15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>()
            {
                4,
                1,
                7,
                5
            };
            List<string> lines = new List<string>()
            {
                //"kjeeerj",
                //"9",
                //"63u3u",
                //"0gdkgjs433"
                "ffhdjfhdj",
                "3kj3k3j",
                "338",
                "fsmdsff",
                "43",
                "jy"
            };
            //Print<string>(GetHW15_1Result(nums, lines));
            Print<(char, int)>(GetHW15_2Result(lines));
        }
        static List<string> GetHW15_1Result(List<int> nums, List<string> lines)
        {
            return nums.Select(num => lines
            .Where(line => Char.IsDigit(line[0]) && line.Length == num)
            .ToList().FirstOrDefault() ?? "Не знайдено")
                .ToList();
        }
        static List<(char, int)> GetHW15_2Result(List<string> lines)
        {
            return lines.GroupBy(line => line[0])
                .Select(g => new { KeySign = g.Key, TotalLength = g.Sum(line => line.Length) })
                .OrderByDescending(a => a.TotalLength)
                .ThenBy(a => a.KeySign)
                .Select(a => (KeySign: a.KeySign, TotalLength: a.TotalLength))
                .ToList();
        }
        static List<(int, int)> GetHW15_3Result(List<Applicant> applicants, List<int> years)
        {
            return years.Select(year => (Year: year, 
                NumberOfSchools: applicants.Where(a => a.EntryYear == year)
                .Select(a => a.SchoolNumber)
                .Distinct()
                .Count()))
                .OrderBy(r => r.NumberOfSchools)
                .ThenBy(r => r.Year)
                .ToList();
        }
        static Dictionary<int, List<string>> GetHW15_4Result(List<Applicant> applicants)
        {
            return applicants.Select(a => a.EntryYear).ToDictionary(year => year, year => applicants.Where(a => a.EntryYear == year).Select(a => a.Surname).ToList());
        }
        static void Print<T>(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
