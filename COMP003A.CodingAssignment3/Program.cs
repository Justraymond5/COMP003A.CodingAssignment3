namespace COMP003A.CodingAssignment3;
// Author: Raymond Gonzalez
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Budget management application demonstrating control flow.
class Program
{
    static void Main(string[] args)
        {   //List of Variables
            int monthlyIncome;
            int theirChoice;
            
            string expense;
            expense = "";
            
            int expenseCost = default;
            

            string removeExpense;
            removeExpense = "";
            //End List of Variables
        
            //Intro
            Console.WriteLine("Welcome to the Budget Management Tool!");
            Console.Write("\nEnter your monthly income: ");
            monthlyIncome = int.Parse(Console.ReadLine());
            //Begining of Loop
            while (true) 
            {
            Console.WriteLine("\n\nMenu:");
            Console.WriteLine("1. Add an Expense");
            Console.WriteLine("2. View Expenses and Budget");
            Console.WriteLine("3. Remove an Expense");
            Console.WriteLine("4. Exit");
            Console.Write("\nEnter your choice:  ");
            theirChoice = int.Parse(Console.ReadLine()); 
            //When condtion 1 is met, it runs program
            if (theirChoice == 1 )
            {
                Console.Write("\nEnter the expense name: ");
                expense = Console.ReadLine();
                Console.Write("Enter the expense cost: ");
                //expenseCost = Console.ReadLine(); 
                expenseCost = int.Parse(Console.ReadLine());
                
                Console.Write("Expense added successfully!");
                
            }
            //When condtion 2 is met, it runs program
            else if (theirChoice == 2 )
            {
                Console.Write("Expenses: ");
                Console.WriteLine($"\n{expense}: {expenseCost}");
                Console.WriteLine($"\nTotal Expenses: {expenseCost}");
                
                Console.WriteLine($"Remaining Budget: ${monthlyIncome - expenseCost}");
                

            }
            //When condtion 3 is met, it runs program
            else if (theirChoice == 3 )
            {
                Console.Write("Enter the name of the expense to remove: ");
                removeExpense = Console.ReadLine();
                if (removeExpense == expense)
                {
                    expense = "";
                    expenseCost = 0;
                    Console.WriteLine("Expense removed successfully!");
                    
                }
                else
                {
                    Console.Write("\nExpense not found or does not exist. Please try again");
                }
                
                
                
            }
            //When condtion 4 is met, it runs program
                else if (theirChoice == 4)
                {
                    Console.Write("\nGoodbye!");
                break;

                
                }
        }
    }
}