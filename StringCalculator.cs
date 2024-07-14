using System;
using System.Collections.Generic;
using System.Linq;

public class StringCalculator
{
    public int Add(string numbers)
    {
       if(string.IsNullOrEmpty(numbers) || (numbers == "0"))
           return 0;
       return -1;
    }
}
