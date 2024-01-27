// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

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
