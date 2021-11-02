using System;

namespace C_Task_1._7._1
{
    class Program
    {

        static void Main(string[] args)
        {

            #region Task-2
            /*int[] arr = { 7, 8, 3, 7, 4, 3, 5 };
            arrycopy(arr);*/
            #endregion

            #region Task-3
            /* int[] Arry = new int[5] { 5, 7, 3, 4, 6 };
             Console.WriteLine("ededi girin:");
             int a = Convert.ToInt32(Console.ReadLine());
             arry(Arry, a);
             Console.WriteLine(arry(Arry, a)); */


            #endregion

            #region Task-4
            /*int[] Arry = new int[10] { 5, 7, 3, 4, 6, 5, 13, 84, 41, 22 };

            BeginEnd(Arry);*/

            #endregion

            #region Task-5 
            /* int[] Arry =  { 5, 7, 3, 4, 6, };
             int[] Arry2 = new int[5] { 11, 13, 84, 41, 22 };
             int[] Arry3 = new int[] { Arry.Length + Arry2.Length };

             Arry.CopyTo(Arry3, 0);
             Arry2.CopyTo(Arry3, Arry.Length);
             Array.Sort(Arry3);
             for (int i = Arry3.Length - 1; i >= 0; i--)
             {
                 Console.WriteLine(Arry3[i] + " ");
             }

             int[] a = { 1, 2, 3, 4 };
             int[] b = { 5, 6, 7, 8 };
             int[] MergeArr = new int[a.Length + b.Length];
             a.CopyTo(MergeArr, 0);
             b.CopyTo(MergeArr, a.Length);
             Array.Sort(MergeArr);
             for (int i = MergeArr.Length - 1; i >= 0; i--)
             {
                 Console.WriteLine(MergeArr[i] + " ");*/


            #endregion

            #region Task-6
            /* int[] Arry = { 5, 2, 16, -21, -4, 0 };

              MenMus menmus1 = new MenMus();
            menmus1.method1(Arry);*/

            #endregion

            #region Task-7
            /* Console.WriteLine("reqemi yazn:");
             int a = Convert.ToInt32(Console.ReadLine());

             sezon(a);*/
            #endregion

            #region Task-8
          /*  Console.WriteLine("1ci eded:" + " ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("operatoru daxil et: ");
            char operation = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("2ci eded:" + " ");
            int b = Convert.ToInt32(Console.ReadLine());


            Match(a, b, operation);*/
            #endregion
        }








        #region Task-2(method)
        /* static void arrycopy(int[] arr)
         {
             int Count = 0;
             for (int i = 0; i < arr.Length; i++)
             {
                 for (int j = 0; j < arr.Length; j++)
                 {
                     if (arr[i] == arr[j] && i != j)
                     {
                         Count++;
                     }
                 }
             }
             Console.WriteLine(Count);

         }*/
        #endregion

        #region Task-3(method)
        /*static bool arry(int[] Arry, int a)
        {
            for (int i = 0; i < Arry.Length; i++)
            {
                if (a == Arry[i])
                {
                    return true;
                }
            }
            return false;*/
        #endregion

        #region Task-4(method)
        /*  static void BeginEnd(int [] Arry)
      {
          Array.Reverse(Arry);

          foreach (var Arry2 in Arry)
          {
            Console.WriteLine(Arry2);
          }

      }*/
        #endregion

        #region Task-7(method)
        /* static void sezon(int a)
         {

             switch (a)
             {
                 case 1:
                 case 2:
                 case 12:
                     Console.WriteLine("Qis");
                     break;

                 case 3:        
                 case 4:
                 case 5:
                     Console.WriteLine("Yaz");
                     break;
                 case 6:             
                 case 7:
                 case 8:
                     Console.WriteLine("yay");
                     break;
                 case 9:       
                 case 10:    
                 case 11:
                     Console.WriteLine("payiz");
                     break;
             }
        */
        #endregion

        #region Task-8(method)
       /* static void Match(int a, int b, char operation)
        {
            if (operation == '+')
            {
                Plus(a, b);
            }

            else if (operation == '-')
            {
                Sub(a, b);
            }

            else if (operation == '*')
            {
                Multi( a, b);
            }
            else if (operation == '/')
            {
                Devide(a, b);
            }
            else
                Console.WriteLine("sehv melumat"); 
        }*/
        #endregion

        #region Task-8.0(method)
         /*static void Plus(int a, int b)
        {
            Console.WriteLine("cavab" + " " + (a + b));
        }*/
        #endregion

        #region Task-8.1(method)
        /*static void Sub(int a, int b)
        {
            Console.WriteLine("cavab" + " " + (a - b));
        }*/
        #endregion

        #region Task-8.2(method)
       /* static void Multi(int a, int b)
        {
            Console.WriteLine("cavab" + " " + (a * b));
        }*/
        #endregion

        #region Task-8.3(method)
       /* static void Devide(int a, int b)
        {
            Console.WriteLine("cavab" + " " + (a / b));
        }*/
        #endregion
    }
}


