namespace COMP003A.CodingAssignment3;
// Author: Raymond Gonzalez
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Budget management application demonstrating control flow.
class Program
{
    static void Main(string[] args)
    {
        int monthlyIncome;
        int theirChoice;
        string expense;
        int expenseAmount;
        int rentCost; 
        
        while (true){
        Console.WriteLine("Welcome to the Budget Management Tool!");
        Console.Write("\nEnter your monthly income: ");
        monthlyIncome = int.Parse(Console.ReadLine());
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Add an Expense");
        Console.WriteLine("2. View Expenses and Budget");
        Console.WriteLine("3. Remove an Expense");
        Console.WriteLine("4. Exit");
        Console.Write("\nEnter your choice:  ");
        theirChoice = int.Parse(Console.ReadLine());
        
        
        if (theirChoice == 1 )
        {
            Console.Write("\nEnter the expense name: ");
            expense = Console.ReadLine();
            Console.Write("Enter the expense amount:");
            expenseAmount = int.Parse(Console.ReadLine()); 
            Console.Write("Expense added successfully!");
        }
        if (theirChoice == 2 )
        {
            Console.WriteLine("Expenses: ");
            Console.Write("\nRent Cost: ");
            rentCost = int.Parse(Console.ReadLine()); 
            Console.Write($"Total Expenses: {rentCost}");
            expenseAmount = int.Parse(Console.ReadLine()); 
            
            //Console.Write($"remaining: {remainingBudget}");
            
        }
        if (theirChoice == 3 )
        {
            Console.Write("\nEnter the expense name:");
            expense = Console.ReadLine();
            Console.Write("Enter the expense amount:");
            expenseAmount = int.Parse(Console.ReadLine()); 
            Console.Write("Expense added successfully!");
        }
        if (theirChoice == 4 )
        {
            Console.Write("\nEnter the expense name:");
            expense = Console.ReadLine();
            Console.Write("Enter the expense amount:");
            expenseAmount = int.Parse(Console.ReadLine()); 
            Console.Write("Expense added successfully!");
        }
    }
    }
}