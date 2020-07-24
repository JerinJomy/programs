using System;

namespace rckr
 {
  
   class Program{
       static void Main(string[] args)
       {
         Console.WriteLine("enter the number");
         string x=Console.ReadLine();
         int number=Convert.ToInt32(x);
         int a=x.Length;
         int flag=0;
         for(int i=0;i<a;i++)
         {
           x=x.Substring(1,(a-1))+x[0];
           int num=Convert.ToInt32(x);
           if(prime(num)==1)
           {
             Console.WriteLine("{0} is not circular prime",number);
              flag=1;
             break;
           }
           
         }
         if(flag==0)
         Console.WriteLine("{0} is circular prime",number);
       
      

         int prime(int a)
         {
           int flag=-1;
           for(int i=2;i<=a/2;i++)
           {
             if(a%i==0)
             {
               flag=1;
               break;
             }
           }
           return flag;
         }
         
}
}
}