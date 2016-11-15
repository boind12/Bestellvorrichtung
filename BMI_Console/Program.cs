using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Name : Christian Esser
 * Klasse: BE141
 * Datum: 24.10.2016
 * Funktion: Berechnet den BMI
*/

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deckare_Part 
            string string_weight = "", string_size = "", string_sex = "";
            double double_weight = 0.0, double_size = 0.0, double_bmi= 0.0;
            bool sex = false;

            //Input_Part
            Console.Write("Geben Sie bitte Ihr Gewicht ein (in kg): ");
            string_weight=Console.ReadLine();
            Console.Write("Geben Sie bitte Ihre Groesse ein (in Metern mit , getrennt): ");
            string_size = Console.ReadLine();
            Console.Write("Geben Sie ihr Geschlecht ein (m oder w): ");
            string_sex = Console.ReadLine();

            //Make decision if female or male
            if (string_sex == "m") 
            {
                sex = true;
            }

            //Convert_Part
            double_weight = Convert.ToDouble(string_weight);
            double_size = Convert.ToDouble(string_size);

            //Output_Part
            double_bmi = double_weight / (double_size * double_size);

            Console.WriteLine("Ihr BMI ist:" + String.Format("{0:00.0}", double_bmi));

            if (sex == true)
            {
                if (double_bmi < 18.5)
                {
                    Console.WriteLine("Sie haben Untergewicht");
                }
                else if (double_bmi > 18.5 && double_bmi < 25)
                {
                    Console.WriteLine("Sie haben Normalgewicht");
                }
                else
                {
                    Console.Write("Sie sind Übergewichtig. Genauer haben Sie: ");
                    if (double_bmi < 30)
                    {
                        Console.WriteLine("Präadispositas");
                    }
                    else if (double_bmi >= 30 && double_bmi < 35)
                    {
                        Console.WriteLine("Adipositas Grad I");
                    }
                    else if (double_bmi >= 35 && double_bmi < 40)
                    {
                        Console.WriteLine("Adipositas Grad II");
                    }
                    else
                    {
                        Console.WriteLine("Adipositas Grad III");
                    }
                }
            }
            else
            {
                if (double_bmi < 17.5)
                {
                    Console.WriteLine("Sie haben Untergewicht");
                }
                else if (double_bmi > 17.5 && double_bmi < 24)
                {
                    Console.WriteLine("Sie haben Normalgewicht");
                }
                else
                {
                    Console.Write("Sie sind Übergewichtig. Genauer haben Sie: ");
                    if (double_bmi < 29)
                    {
                        Console.WriteLine("Präadispositas");
                    }
                    else if (double_bmi >= 29 && double_bmi < 34)
                    {
                        Console.WriteLine("Adipositas Grad I");
                    }
                    else if (double_bmi >= 34 && double_bmi < 39)
                    {
                        Console.WriteLine("Adipositas Grad II");
                    }
                    else
                    {
                        Console.WriteLine("Adipositas Grad III");

                    }


                }
            }
            Console.ReadKey();
        }
    }
}
