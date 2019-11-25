using System;

namespace banksystem
{
    class Program
    {
        static void Main(string[] args)
        {
             int c_balance = 50000;
                        int amount;
                        int new_balance = 0;
                        int choice;
                        string fname;
                        string sname;
                        string gender;
                        string currency;
                        double account;
                        int fee;
                        Console.WriteLine("Enter first name:");
                        fname = Console.ReadLine();
                        Console.WriteLine("Enter second name:");
                        sname = Console.ReadLine();
                        Console.WriteLine("Enter Genger:");
                        gender = Console.ReadLine();
                        Console.WriteLine("Enter currency type:");
                        currency = Console.ReadLine();
                        Console.WriteLine("Enter account number");
                        account = Convert.ToInt32(Console.ReadLine());
                        
                        
                        Start:
                        Console.WriteLine("\n \n");
                        Console.WriteLine("if you want to withdraw choose 1");
                        Console.WriteLine("if you want to deposit choose 2\n");
                        
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1) 
                        {
                            Console.WriteLine("FIST NAME  : " + fname);
                            Console.WriteLine("SECOND NAME:"  + sname);
                            Console.WriteLine("GENDER     : " + gender);
                            Console.WriteLine("ACCOUNT NUMBER: " + account);
                            Console.WriteLine("BALANCE IS : " + c_balance + " " + currency);
                            Console.WriteLine("\n ");
                            Console.WriteLine("inter amount you want to withdraw");
                            amount = Convert.ToInt32(Console.ReadLine());
            
                            if (amount <= c_balance && c_balance >= 0)
                            {
                                if (amount >= 0 && amount < 1500)
                                {
                                    fee = 200;
                                    new_balance = c_balance - amount - fee;
                                    c_balance = new_balance;
                                    Console.WriteLine("\n");
                                    Console.WriteLine("FIST NAME  : " + fname);
                                    Console.WriteLine("SECOND NAME: " + sname);
                                    Console.WriteLine("GENDER     : " + gender);
                                    Console.WriteLine("ACCOUNT NUMBER: " + account);
                                    Console.WriteLine("WITHDRAW FEE    : " + fee + " " + currency);
                                    Console.WriteLine("WITHDRAW     : " + amount);
                                    Console.WriteLine("BALANCE IS : " + new_balance + " " + currency);
                                    Console.WriteLine("\n ");
                                }
                                else if(amount >= 1500 && amount <= 5000)
                                {
                                    fee = 350;
                                    new_balance = c_balance - amount - fee;
                                    c_balance = new_balance;
                                    Console.WriteLine("\n");
                                    Console.WriteLine("FIST NAME  : " + fname);
                                    Console.WriteLine("SECOND NAME: " + sname);
                                    Console.WriteLine("GENDER     : " + gender);
                                    Console.WriteLine("ACCOUNT NUMBER: " + account);
                                    Console.WriteLine("WITHDRAW FEE    : " + fee + " " + currency);
                                    Console.WriteLine("WITHDRAW     : " + amount + " " + currency);
                                    Console.WriteLine("BALANCE IS : " + new_balance + " " + currency);
                                    Console.WriteLine("\n ");
                                }
                                else
                                {
                                    fee = 500;
                                    new_balance = c_balance - amount - fee;
                                    c_balance = new_balance;
                                    Console.WriteLine("\n");
                                    Console.WriteLine("FIST NAME  : " + fname);
                                    Console.WriteLine("SECOND NAME: " + sname);
                                    Console.WriteLine("GENDER     : " + gender);
                                    Console.WriteLine("ACCOUNT NUMBER: " + account);
                                    Console.WriteLine("WITHDRAW FEE    : " + fee + " " + currency);
                                    Console.WriteLine("WITHDRAW     : " + amount + " " + currency);
                                    Console.WriteLine("BALANCE IS : " + new_balance + " " + currency);
                                    Console.WriteLine("\n"); 
                                }
                            }
                            else
                            {
                                Console.WriteLine("you have no money " );
                                Console.WriteLine("\n");
                            }    
                            goto Start;
                            
                        } 
                        else if (choice == 2) 
                        {
                            Console.WriteLine("your balance is " + c_balance);
                            Console.WriteLine("inter amount you want to DEPOSIT");
                            amount = Convert.ToInt32(Console.ReadLine());
            
                            if (amount >= 0)
                            {
                                new_balance = c_balance + amount;
                                c_balance = new_balance;
                                Console.WriteLine("\n");
                                Console.WriteLine("FIST NAME  : " + fname);
                                Console.WriteLine("SECOND NAME: " + sname);
                                Console.WriteLine("GENDER     : " + gender);
                                Console.WriteLine("ACCOUNT NUMBER: " + account);
                                Console.WriteLine("DEPOSIT     : " + amount + " " + currency);
                                Console.WriteLine("BALANCE IS : " + new_balance + " " + currency);  
                                Console.WriteLine("\n");
                            }
                            else
                            {
                                Console.WriteLine("no money  TO BE DEPOSIT" ); 
                                Console.WriteLine("\n ");
                            }    
                            goto Start;
                        } 
                        else 
                        {
                            Console.WriteLine("invalid input.");
                            Console.WriteLine("\n");
                            goto Start;
                        }
        }
    }
}