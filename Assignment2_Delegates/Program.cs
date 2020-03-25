    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Assignment2_Delegates
    {
        // Delegate types to describe predicates on ints and actions on ints.
        public delegate bool IntPredicate(int x);
        public delegate void IntAction(int x);
        // Integer lists with Act and Filter operations.
        // An IntList containing the element 7 9 13 may be constructed as 
        // new IntList(7, 9, 13) due to the params modifier.
        class IntList : List<int>
        {
            public IntList(params int[] elements) : base(elements)
            {
            }
            public void Act(IntAction f)
            {
                foreach (int i in this)
                {
                    f(i);
                }
            }
            public IntList Filter(IntPredicate p)
            {
                IntList res = new IntList();
                foreach (int i in this)
                    if (p(i))
                        res.Add(i);
                return res;
            }
        }
        class Program
        {
            public static void Main(String[] args)
            {
                IntList xs = new IntList { 1, 2, 3, 4, 6, 26 };
                xs.Act(Console.WriteLine);

                // the act function loops through the array and 
                // the filter function creates a new list and then returns the elements for which p(x) is true
                xs.Filter(delegate (int x)
                { return x % 2 == 0; }).Act(Console.WriteLine);
                Console.ReadLine();

                // The output is 26 
                xs.Filter(delegate (int x)
                {
                    return x > 25;
                }).Act(Console.WriteLine);
                Console.ReadLine();

                // the output is 42 
                int total = 0;
                xs.Act(delegate (int x)
                {
                    total += x;
                });
                Console.WriteLine(total);
                Console.ReadLine();
            }
        }
    }