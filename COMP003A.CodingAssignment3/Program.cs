namespace COMP003A.CodingAssignment3;
// Author: Raymond Gonzalez
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Budget management application demonstrating control flow.
class Program
{
    static void Main(string[] args)
        {   
//List of Variables            
            int monthlyIncome;
            int theirChoice;
            
            string expense;
            expense = "";
            int expenseCost = default;
            
            string expense2;
            expense2 = "";
            int expenseCost2 = default;
            
            string expense3;
            expense3 = "";
            int expenseCost3 = default;
            
            string expense4;
            expense4 = "";
            int expenseCost4 = default;
            
            string expense5;
            expense5 = "";
            int expenseCost5 = default;
            
            
            

            string removeExpense;
            removeExpense = "";
//End of Variables   
        

            Console.WriteLine("Welcome to the Budget Management Tool!");
            Console.Write("\nEnter your monthly income: ");
            monthlyIncome = int.Parse(Console.ReadLine());
            //Beginning of Loop
            
            while (true) 
            {
                try
                {
                    Console.Write("\nEnter your monthly income: ");
                    monthlyIncome = int.Parse(Console.ReadLine());
                    break; 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for your monthly income.");
                }
            }
            
            while (true) 
            {
            Console.WriteLine("\n\nMenu:");
            Console.WriteLine("1. Add an Expense");
            Console.WriteLine("2. View Expenses and Budget");
            Console.WriteLine("3. Remove an Expense");
            Console.WriteLine("4. Exit");
            Console.Write("\nEnter your choice:  ");
            theirChoice = int.Parse(Console.ReadLine()); 
            try
            {
                theirChoice = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid choice. Please enter a valid number.");
                continue;
            }
            //When condtion 1 is met, it runs program
            if (theirChoice == 1 )
                {   Console.WriteLine("\nYou must enter five expenses at a time, if less than 5 enter 0 & 0 for expense name and cost.");
                    Console.Write("\nEnter the expense name: ");
                    expense = Console.ReadLine();
                    Console.Write("Enter the expense cost: ");
                    //expenseCost = Console.ReadLine(); 
                    expenseCost = int.Parse(Console.ReadLine());
                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the expense cost: ");
                            expenseCost = int.Parse(Console.ReadLine());
                            break; // Exit loop if input is valid
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid cost. Please enter a valid number for the expense cost.");
                        }
                    }
                    Console.Write("Expense added successfully!");
                    Console.WriteLine("\n");
                    
                    Console.Write("\nEnter the expense name: ");
                    expense2 = Console.ReadLine();
                    Console.Write("Enter the expense cost: ");
                    expenseCost2 = int.Parse(Console.ReadLine());
                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the expense cost: ");
                            expenseCost = int.Parse(Console.ReadLine());
                            break; // Exit loop if input is valid
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid cost. Please enter a valid number for the expense cost.");
                        }
                    }
                    Console.Write("Expense added successfully!");
                    Console.WriteLine("\n");
                    
                    Console.Write("\nEnter the expense name: ");
                    expense3 = Console.ReadLine();
                    Console.Write("Enter the expense cost: ");
                    expenseCost3 = int.Parse(Console.ReadLine());
                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the expense cost: ");
                            expenseCost = int.Parse(Console.ReadLine());
                            break; // Exit loop if input is valid
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid cost. Please enter a valid number for the expense cost.");
                        }
                    }
                    Console.Write("Expense added successfully!");
                    Console.WriteLine("\n");
                    
                    Console.Write("\nEnter the expense name: ");
                    expense4 = Console.ReadLine();
                    Console.Write("Enter the expense cost: ");
                    expenseCost4 = int.Parse(Console.ReadLine());
                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the expense cost: ");
                            expenseCost = int.Parse(Console.ReadLine());
                            break; // Exit loop if input is valid
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid cost. Please enter a valid number for the expense cost.");
                        }
                    }
                    Console.Write("Expense added successfully!");
                    Console.WriteLine("\n");
                    
                    Console.Write("\nEnter the expense name: ");
                    expense5 = Console.ReadLine();
                    Console.Write("Enter the expense cost: ");
                    expenseCost5 = int.Parse(Console.ReadLine());
                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the expense cost: ");
                            expenseCost = int.Parse(Console.ReadLine());
                            break; // Exit loop if input is valid
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid cost. Please enter a valid number for the expense cost.");
                        }
                    }
                    Console.Write("Expense added successfully!");
                    Console.WriteLine("\n");
                }
            //When condtion 2 is met, it runs program
            else if (theirChoice == 2 )
                {
                    Console.Write("Expenses: ");
                    Console.WriteLine("\n");
                    Console.WriteLine($"\n{expense}: {expenseCost}");
                    Console.WriteLine($"\n{expense2}: {expenseCost2}");
                    Console.WriteLine($"\n{expense3}: {expenseCost3}");
                    Console.WriteLine($"\n{expense4}: {expenseCost4}");
                    Console.WriteLine($"\n{expense5}: {expenseCost5}");
                    Console.WriteLine(
                        $"\nTotal Expenses: {expenseCost + expenseCost2 + expenseCost3 + expenseCost4 + expenseCost5}");
                    Console.WriteLine(
                        $"Remaining Budget: ${monthlyIncome - expenseCost - expenseCost - expenseCost2 - expenseCost3 - expenseCost4 - expenseCost5}");
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
                    else if (removeExpense == expense2)
                    {
                        expense2 = "";
                        expenseCost2 = 0;
                        Console.WriteLine("Expense removed successfully!");
                        
                    }
                    else if (removeExpense == expense3)
                    {
                        expense3 = "";
                        expenseCost3 = 0;
                        Console.WriteLine("Expense removed successfully!");
                        
                    }
                    else if (removeExpense == expense4)
                    {
                        expense4 = "";
                        expenseCost4 = 0;
                        Console.WriteLine("Expense removed successfully!");
                        
                    }
                    else if (removeExpense == expense5)
                    {
                        expense5 = "";
                        expenseCost5 = 0;
                        Console.WriteLine("Expense removed successfully!");
                        
                    }
                    else
                    { 
                        Console.Write("\nExpense not found or does not exist. Please try again");
                    }
                
            }
            //When condition 4 is met, it runs program    
            if (theirChoice == 4)
                   
            {Console.Write("\nGoodbye!"); 
                break; }
            
            
            }
            
            
        }
            
        }
    
