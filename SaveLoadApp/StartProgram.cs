using System;
using System.Collections.Generic;
using System.Text;

namespace SaveLoadApp
{
    class StartProgram
    {
        public void madeList()
        {
            var par = new ProgramParams();
            foreach (var item in par.GetType().GetProperties())
            {
                Console.WriteLine("{0} = {1}", item.Name, item.GetValue(par, null));

            }
        }

        public void Start()
        {
            ItemsForSerializable test1 = new ItemsForSerializable("name 1", 32);
            ItemsForSerializable test2 = new ItemsForSerializable("name 2", "text");
            ItemsForSerializable test3 = new ItemsForSerializable("name 1", 999d);
            
            var par = new ProgramParams();

            List<ProgramParams> newListItems = new List<ProgramParams>();


            par.Save1(madeList());
            par.Load();



            //Operations operations = new Operations();

            //bool isContinue = true;

            //while (isContinue)
            //{
            //    Console.WriteLine("Write \"save\" to save file");
            //    Console.WriteLine("Write \"load\" to load file");
            //    Console.WriteLine("Write \"exit\" to exit program");
            //    Console.WriteLine();

            //    string displayOperation = Console.ReadLine();

            //    switch (displayOperation.ToLower())
            //    {
            //        case "save":
            //            operations.Save(Items);
            //            break;
            //        case "load":
            //            operations.Load();
            //            break;
            //        case "exit":
            //            isContinue = false;
            //            break;

            //        default:
            //            Console.WriteLine("Incorrect command " + displayOperation);
            //            break;
            //    }
            //    if (isContinue)
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("Press any key ");
            //        Console.ReadKey();
            //        Console.Clear();
            //    }
            //}
        }
    }
}
