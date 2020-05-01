using System;

namespace Interpreter
{
    class MainClass
    {
        //public static void Main(string[] args)
        //{
        //    string Description1 = "Although I like football matches very much, I don't usually watch.";
        //    string Description2 = "I attach great importance to breast milk for my baby's health.";
        //    string Description3 = "I hit the car on my way to the gym.";

        //    bool expResult = false;
        //    string word = "football";
        //    string word2 = "car";

        //    string word3 = "mother";
        //    string word4 = "baby";
        //    string word5 = "draw";
        //    string word6 = "rub";


        //    Console.Write(Description1 + " (Man):");
        //    //football || car
        //    expResult = Description1.ToLower().Contains(word.ToLower()) || Description1.ToLower().Contains(word2.ToLower());
        //    Console.WriteLine(expResult);

        //    //mother || baby , draw && car , rub && car
        //    Console.Write(Description2 + "(Woman):");
        //    expResult = ((Description2.ToLower().Contains(word3.ToLower()) || Description2.ToLower().Contains(word4.ToLower()))
        //        || (Description2.ToLower().Contains(word5.ToLower()) && Description2.ToLower().Contains(word2.ToLower()))
        //        || (Description2.ToLower().Contains(word6.ToLower()) && Description2.ToLower().Contains(word2.ToLower())));
        //    Console.WriteLine(expResult);

        //    //mother || baby , draw && car , rub && car
        //    Console.Write(Description3 + "(Woman):");
        //    expResult = ((Description3.ToLower().Contains(word3.ToLower()) || Description3.ToLower().Contains(word4.ToLower()))
        //       || (Description3.ToLower().Contains(word5.ToLower()) && Description3.ToLower().Contains(word2.ToLower()))
        //       || (Description3.ToLower().Contains(word6.ToLower()) && Description3.ToLower().Contains(word2.ToLower())));
        //    Console.WriteLine(expResult);

        //    Console.ReadLine();
        //}

        public static void Main(string[] args)
        {
            string Description1 = "Although I like football matches very much, I don't usually watch.";
            string Description2 = "I attach great importance to breast milk for my baby's health.";
            string Description3 = "I hit the car on my way to the gym.";

            Console.Write(Description1 + " (Man):");
            Console.WriteLine(InterpretPattern.getMaleExpression().Interpret(Description1));

            bool expResult = false;
            Console.Write(Description2 + "(Woman):");
            foreach (Expression exp in InterpretPattern.getFemailExpressions())
            {
                if (exp.Interpret(Description2)) { expResult = true; break; }
            }
            Console.WriteLine(expResult);

            bool expResult2 = false;
            Console.Write(Description3 + "(Woman):");
            foreach (Expression exp in InterpretPattern.getFemailExpressions())
            {
                if (exp.Interpret(Description3)) { expResult2 = true; break; }
            }
            Console.WriteLine(expResult2);
            Console.ReadLine();
        }
    }
}
