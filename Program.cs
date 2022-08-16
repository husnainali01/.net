using System;
 namespace VSCodeNetTest
 {
    class program
    {
     static void Main(string[] args)
     {
        LinkedList<string> Arr = new LinkedList<string>();
        Arr.AddFirst("Husnain");
        Arr.AddLast("Ali");
        Arr.AddLast("Asghar");
         foreach(var temp in Arr)
        {
              Console.WriteLine(temp);
        }
     }
    }
 }