using System;

namespace rckr
 {
  
   class Program{
       static void Main(string[] args)
       {
         Console.WriteLine("enter the string");
        string str1=Console.ReadLine();
        string str2="";
        foreach(char x in str1)
        {
          str2=x+str2;
        }
        if(str1==str2)
        Console.WriteLine("the string is a palindrome");
        else
        Console.WriteLine("the string is not a palindrome");
   }
}
}