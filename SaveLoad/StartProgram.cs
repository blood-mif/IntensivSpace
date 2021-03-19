using System;

namespace SaveLoad
{
    class StartProgram
    {
        public void Start()
        {

            var programParams = new ProgramParams();

//            programParams.Serrialize(programParams);
            programParams.DeSerrialize();

            programParams.FlyLongCal = 4;
            programParams.SkipLongCal = 5;
            programParams.UseLongCal = 6;

            //ProgramParams CreateNewExClass()
            //{
            //    var newProgramParams = programParams;
            //    return newProgramParams;
            //}

            //ProgramParams Refleksi(ProgramParams refParametr)
            //{

            //    foreach (var item in refParametr.GetType().GetProperties())
            //    {
            //        Console.WriteLine("{0} = {1}", item.Name, item.GetValue(refParametr, null));
            //    }

            //    return refParametr;
            //}

            //Refleksi(programParams);

            bool isContinue = true;

            while (isContinue)
            {
                //Console.WriteLine("Write \"1\" to Serialize file");
                //Console.WriteLine("Write \"2\" to DeSerialize file");
                Console.WriteLine("Write \"3\" to Serialize file with inheritance");
                Console.WriteLine("Write \"4\" to DeSerialize file with inheritance");
                Console.WriteLine("Write \"x\" to exit program");
                Console.WriteLine();

                string displayOperation = Console.ReadLine();

                switch (displayOperation.ToLower())
                {
                    //case "1":
                    //    //serClass.Serrialize(programParams);
                    //    break;
                    //case "2":
                    //    //serClass.DeSerrialize();
                    //    break;
                    case "3":
                        //programParams.Serrialize(CreateNewExClass());
                        programParams.Serrialize(programParams);
                        break;
                    case "4":
                        //  programParams = new ProgramParams();
                        programParams.DeSerrialize();
                        break;
                    case "x":
                        isContinue = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect command " + displayOperation);
                        break;
                }
                if (isContinue)
                {
                    Console.WriteLine();
                    Console.WriteLine("Press any key ");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
