using System;

namespace IntensivSpace
{
    class Program
    {
        class _test
        {
            public String A { get; set; }
            public String B { get; set; }
            public String C { get; set; }
        }
        static void Main(string[] args)
        {
            var output = new _test { A = "Это A", B = "Это В", C = "Это С" };
            foreach (var item in output.GetType().GetProperties())
            {
                Console.WriteLine("{0} = {1}", item.Name, item.GetValue(output, null));
            }
            Console.ReadLine();
        }

     //   return output.GetType().GetProperties().ToDictionary(item => item.Name, item => item.GetValue(output, null).ToString());

    }

}
