using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CDSSellectionApp
{
    class Program
    {
        static void Main(string[] args)
        {

            
            // a.	Prompt the user to enter the names of 9 students and add the names to a queue on a first-come-first-served basis. This will form the queue for the CDS selection process.

            Console.WriteLine("Welcome to the CDS Selection Application. You can join the queue by \nentering your name. On your turn, please select 1 for Music, 2 for Creative\nWriting and 3 for Theatrical Studies. Have a pleasant day!\n");
            
            //create all the queues here

            Queue myQueue = new Queue(9);
            Queue Queue1 = new Queue(3);
            Queue Queue2 = new Queue(3);
            Queue Queue3 = new Queue(3);

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Enter the name of student #" + (i+1)); //i+1 here because i start i with 0.so it will start with student 1.
                string input = Console.ReadLine();
                myQueue.Enqueue(input);
            }

         

           // b.	Once the CDS selection is in process, dequeue a student and prompt him/her for his/her CDS selection.

            
            int myQueueSize = myQueue.Count; //i put the count of myQueue into a variable so it doesnt change unless i want it to.

            while (!myQueue.IsEmpty())//while my queue is not empty means theres something in the queue. this will make sure that if the student can apply the cds again if its full.this goes on forever until he gets in the CDS he/she wants.
            {
                int round = 1;
                round++;
                Console.WriteLine("#" + round + "Round – CDS Selection in Process ….");

                for (int i = 0; i < myQueueSize; i++)
                {

                    string student = (string)myQueue.Dequeue();//when i take out from queue i need to cast to string so i can put into my student variable which is a string data type.

                    Console.Write("Hi " + student + ",\nPlease enter your choice of CDS: ");
                    int num = Convert.ToInt32(Console.ReadLine());//when you ReadLine(), it will be a string datatype.therefore i convert to an int to store into num.

  


                        //music CDS

                        if (num == 1)
                        {

                            if (Queue1.Count < 3) // if the queue has space
                            {
                                //got space

                                Queue1.Enqueue(student);
                                Console.WriteLine("Your application is successful!\n");


                            }
                            else
                            {
                                //no space
                                Console.WriteLine("Your application is unsuccessful! You will rejoin the queue for another selection.");
                                myQueue.Enqueue(student);

                            }
                        }


                        //Creative Writing CDS
                        if (num == 2)
                        {

                            if (Queue2.Count < 3) // if the queue has space
                            {
                                //got space

                                Queue2.Enqueue(student);
                                Console.WriteLine("Your application is successful!\n");


                            }
                            else
                            {
                                //no space
                                Console.WriteLine("Your application is unsuccessful! You will rejoin the queue for another selection.");
                                myQueue.Enqueue(student);


                            }
                        }


                        //Theatrical studies CDS

                        if (num == 3)
                        {

                            if (Queue3.Count < 3) // if the queue has space
                            {
                                //got space

                                Queue3.Enqueue(student);
                                Console.WriteLine("Your application is successful!\n");


                            }
                            else
                            {
                                //no space
                                Console.WriteLine("Your application is unsuccessful! You will rejoin the queue for another selection.");
                                myQueue.Enqueue(student);

                            }
                        }

                    }
 
      

                Console.WriteLine("End of CDS Selection Process….");

      
            }


        }
    }
}
