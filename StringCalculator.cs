using System;
using System.Collections.Generic;
using System.Linq;

public class StringCalculator
{
    public int Add(string numbers)
    {
       if(string.IsNullOrEmpty(numbers) || (numbers == "0"))
           return 0;

       string[] delimiters = GetDelimiters(numbers);
       List <int> numbersList = GetNumbers(numbers, delimiters);
       CheckNegativeNumbers(numbersList);
       return GetSum(numbersList);
    }

    
    private string[] GetDelimiters(string numbers)
    {
        string[] delimiters = new string[] {",","\n"};        
        return delimiters;
    }

     private List<int> GetNumbers(string numbers, string[] delimiters)
    {
        return numbers.Split(delimiters, StringSplitOptions.None).Select(int.Parse).ToList();
    }

    private void CheckNegativeNumbers(List <int> numbers)
    {
        List <int> negativeNumbers = numbers.Where(n => n < 0).ToList();
        
        if (negativeNumbers.Any())
        {
            throw new Exception("negatives not allowed : " + string.Join(",", negativeNumbers));
        }
    }
    
    private int GetSum(List <int> numbers)
    {
        return numbers.Where(n => n <= 1000).Sum();
    }
}
