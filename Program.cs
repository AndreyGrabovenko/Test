using System;

string[] array = {"hello","2","world",":-)"};

string a = string.Empty;
string[] array1 = new string [array.Length];
for (int i = 0; i < array.Length ; i++)
{
        System.Console.Write(array[i] + " ");
        a = array[i];
        if(a.Length <= 3)
        array1[i] = a;
}
System.Console.WriteLine();
foreach(string B in array1)
{
    System.Console.Write(B);
}