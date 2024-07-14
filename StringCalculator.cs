using System;
using System.Collections.Generic;
using System.Linq;

public class StringCalculator
{
    public int Add(string numbers)
    {
       if(string.IsNullOrEmpty(numbers) || (numbers == "0"))
           return 0;

       List <int> numbersList = GettingNumbersList(numbers);
       CheckNegativeNumbers(numbersList);
       return GetSum(numbersList);
    }

    private List <int> GettingNumbersList(string numbers)
    {
        string[] delimiters = GetDelimiters(numbers, out string numbersWithoutDelimiters);
        List <int> numbersList = GetNumbers(numbersWithoutDelimiters, delimiters);
        return numbersList;
    }
    
    private string[] GetDelimiters(string numbers, out string numbersWithoutDelimiters)
    {
        numbersWithoutDelimiters = numbers;
        string[] delimiters = new string[] {",","\n"};   

        if (numbers.StartsWith("//"))
        {
            int delimiterEndIndex = numbers.IndexOf('\n');
            string customDelimiter = numbers.Substring(2, delimiterEndIndex - 2);
            delimiters = new string[] { customDelimiter };
            numbersWithoutDelimiters = numbers.Substring(delimiterEndIndex + 1);
        }
        
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
