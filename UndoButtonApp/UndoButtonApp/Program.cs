using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace UndoButtonApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //a.	Prompt the user to enter 5 action names. Create an Action object for each action name entered and insert the Action object onto a stack.
            
            Stack s = new Stack(5); // creates a new stack
         

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter an action: ");
                string input = Console.ReadLine(); //get from console put in variable(it will be stored as a string)
                actionClass a = new actionClass(input); //create actionClass Object with input as parameter
                s.Push(a); //push that actionClass Object into the Stack s.
            }


            //b.	Prompt the user to enter the number of times the Undo button is clicked.

            Console.WriteLine("Enter the number of times the Undo button is clicked");
            string input2 = Console.ReadLine();//get from console put in variable(it will be stored as a string)
            int num = Convert.ToInt32(input2); //convert the input2 to int data type and store in num variable

            //c.	Emulate the undo button by displaying the corresponding action name for each click. 



            for (int i = 0; i < num; i++)
            {

                if (!s.IsEmpty())//if Stack s is not empty means got something inside the stack
                {
                    actionClass temp = (actionClass)s.Pop();//pop it from the Stack s then cast it to actionClass object so you can put in temp variable because temp variable is using actionClass Object
                    Console.WriteLine("Undoing: " + temp.ActionName);//temp.ActionName displays the ActionName of temp.
                }
                else
                {
                    Console.WriteLine("No more action to undo");
                }

            }


        }
    }
}
