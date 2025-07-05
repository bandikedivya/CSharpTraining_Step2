using CseDeptWeekSch;
using EeeDeptWeekSch;
using MechDeptWeekSch;
using EceDeptWeekSch;
using System;

namespace MainProgramSystem
{
    class MainProgram
    {
        public static void Main()
        {

            Console.WriteLine("********************CSE DEPARTMENT************************");
            CseDeptWeekSch.Monday monday1= new CseDeptWeekSch.Monday();
            Console.WriteLine(monday1.subjLab);
            //Monday monday1 = new Monday();  // used by mentioning namespace like using namespace on line 1

            CseDeptWeekSch.Wednesday wednesday1 = new CseDeptWeekSch.Wednesday();
            Console.WriteLine(wednesday1.subjLab);
            // Wednesday wednesday1 = new Wednesday();


            CseDeptWeekSch.Friday friday1 = new CseDeptWeekSch.Friday();
            Console.WriteLine(friday1.subjLab);
            //Friday friday1 = new Friday();

            Console.WriteLine("********************EEE DEPARTMENT************************");
            EeeDeptWeekSch.Monday monday2 = new EeeDeptWeekSch.Monday();
            Console.WriteLine(monday2.subjLab);
            //Monday monday2 = new Monday();
            //Console.WriteLine(monday2.subjLab);

            EeeDeptWeekSch.Wednesday wednesday2 = new EeeDeptWeekSch.Wednesday(); 
            Console.WriteLine(wednesday2.subjLab);

            EeeDeptWeekSch.Friday friday2 = new EeeDeptWeekSch.Friday();
            Console.WriteLine(friday2.subjLab);

            Console.WriteLine("********************MECH DEPARTMENT************************");
            MechDeptWeekSch.Monday monday3 = new MechDeptWeekSch.Monday();
            Console.WriteLine(monday3.subjLab);

            MechDeptWeekSch.Wednesday wednesday3 = new MechDeptWeekSch.Wednesday();
            Console.WriteLine(wednesday3.subjLab);


            MechDeptWeekSch.Friday friday3 = new MechDeptWeekSch.Friday();
            Console.WriteLine(friday3.subjLab);


            Console.WriteLine("********************ECE DEPARTMENT************************");

            EceDeptWeekSch.Monday moday4 = new EceDeptWeekSch.Monday();
            Console.WriteLine(moday4.subjLab);

            EceDeptWeekSch.Wednesday wednesday4 = new EceDeptWeekSch.Wednesday();
            Console.WriteLine(wednesday4.subjLab);

            EceDeptWeekSch.Friday friday4 = new EceDeptWeekSch.Friday();
            Console.WriteLine(friday4.subjLab);
































        }
    }
}