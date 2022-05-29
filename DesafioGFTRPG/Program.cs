using System;
using DesafioGFTRPG;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {           
            Knight Arus = new Knight("Arus", 59,"Knight");
            Wizard Wizard = new Wizard("Jennica", 47, "White Wizard");
            Ninja Ninja = new Ninja("Jiraya", 48, "Ninja");
            BlackWizard BlackWizard = new BlackWizard("Gorpo", 51, "BlackWizard");

            Console.WriteLine(BlackWizard.Attack());
            Console.WriteLine(Ninja.Attack());
            Console.WriteLine(Arus.Attack());
            Console.WriteLine(Wizard.Attack());
        }
    }
}