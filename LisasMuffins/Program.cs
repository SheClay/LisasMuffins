﻿using System;

namespace LisasMuffins
{
    class Program
    {
        static void Main(string[] args)
        { 
        //Initialize Variables
     
        int cupsOfSugarRequired = 7;
        int currentCupsOfSugar = 2;
        int remainingCupsRequired = 0;

            //Variable Computation
    
            remainingCupsRequired = cupsOfSugarRequired - currentCupsOfSugar;
            
                        //Variable Output
            Console.WriteLine("Lisa still needs {0} cups", remainingCupsRequired);

            Console.ReadKey();
                
        }
    }
}
