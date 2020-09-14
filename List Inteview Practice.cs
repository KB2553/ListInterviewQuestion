//Given an array of numbers, 
//write a method 
//that only puts even numbers in a list and return that list

//Version 1
public List<int> Evens(int[] numbers)
{
    var evenNumbers = new List<int>();

    foreach(var num in numbers)
    {
        if(num % 2 == 0)
        {
             evenNumbers.Add(num);   
        }
    }
    
    return evenNumbers;
}

//Version 2
using System.Linq;

public static List<int> Evens(int[] numbers)
{
    return numbers.Where(num => num % 2 == 0).ToList();
}

var myList = ClassName.Evens(array);


