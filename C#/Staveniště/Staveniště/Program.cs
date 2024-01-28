// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

static int DescendingOrder(int num)
{
   
}

//static int SquareSum(int[] numbers)
//{
//    int sum = 0;
//    foreach (int number in numbers)
//    {
//        int x = number * number;
//        sum += x;
//    }
//    return sum;
//}

//static string Bmi(double weight, double height)
//{
//    double bmi = weight / (height * 2);
//    string result = string.Empty;
//    if(bmi<= 18.5)
//    {
//        result = "Underweight";
//    }
//    else if((bmi>=18.5)&&(bmi<=25))
//    {
//        result = "Normal";
//    }
//    else if((bmi<=25)&&(bmi<=30))
//    {
//        result = "Overweight";
//    }
//    else
//    {
//        result = "Obese";
//    }

//    return result;
//}

//static int CountSheeps(bool[] sheeps)
//{
//    int x = 0;
//    foreach (bool b in sheeps)            public static int CountSheeps(bool[] sheeps)
//{
//    return sheeps.Count(s => s);
//}
//    {
//        if (b)
//        {
//            x++;
//        }
//    }
//    return x;
//}

//static int[] InvertValues(int[] input)
//{
//    int[] result = new int[input.Length];

//    for (int i = 0; i < input.Length; i++)
//    {
//        result[i] = -input[i];
//    }

//    return result;
//}

//static int FindShort(string s)
//{
//    string[] words = s.Split(' ');
//      int x = words[0].Length;
//    foreach(string word in words)
//    {
//        if(word.Length < x)
//        {
//            x = word.Length;
//        }
//    }
//    return x;
//}

//static IEnumerable<string> FriendOrFoe(string[] names)
//{
//    foreach (string name in names)
//    {
//        if(name.Length ==4)
//        {
//            yield return name;
//        }
//    }
//}

//static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
//{
//    List<int> list = listOfItems.OfType<int>().ToList();
//    return list;
//}

//static int[] ReturnArray()
//{
//    int UserInput = int.Parse(Console.ReadLine());
//    int[] MainArray = new int[UserInput];
//    MainArray[0] = 1;

//    for(int i = 0; i < MainArray.Length; i++)
//    {
//        MainArray[i] = i + 1;
//    }

//    Array.Reverse(MainArray);
//    return MainArray;
//}

//static double FindAverage(double[] array)
//{

//    if (array.Length == 0) { return 0; }
//    else
//    {

//        double sum = 0;

//        foreach (double X in array)
//        {
//            sum += X;
//        }
//        double Average = sum / array.Length;
//        return Average;
//    }
//}

//static int[] Maps(int[] x)
//{
//    foreach(int a in x)
//    {
//        int b = a*2;
//        x[a] = b;
//    }
//    return x;
//}
