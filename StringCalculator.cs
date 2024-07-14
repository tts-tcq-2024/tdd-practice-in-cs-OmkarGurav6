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
       List<int> numberList = GetNumbers(numbers, delimiters);
       return GetSum(numbersList);
    }

    
    private string[] GetDelimiters(string numbers)
    {
        string[] delimiters = new string[] {","};        
        return delimiters;
    }

     private List<int> GetNumbers(string numbers, string[] delimiters)
    {
        return numbers.Split(delimiters).Select(int.Parse).ToList();
    }

    private int GetSum(List<int> numbers)
    {
        return numbers.Where(n => n <= 1000).Sum();
    }
}
