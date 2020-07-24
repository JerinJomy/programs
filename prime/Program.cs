using System;

namespace jerin
 {
  
   class Program{
       static void Main(string[] args)
       {
         int flag=0;
         Console.WriteLine("enter a number");
         int x=Convert.ToInt32(Console.ReadLine());
         if(x==1)
         Console.WriteLine("the number {0} is neither prime or composite",x);
         else
         {
           for(int i=2;i<=x/2;i++)
           {
             if(x%i==0)
             {
               flag++;
               break;
             }
           }
            if(flag==1)
            Console.WriteLine("the number {0} is not a prime number",x);
            else
            Console.WriteLine("the number {0} is a prime number",x);
         }

         
      }
   }
}