using System;
using System.Collections.Generic;

namespace BankAccount
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

            while (input != "end")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                int accountId = int.Parse(tokens[1]);
                switch (command)
                {
                    case "create":
                        Create(accountId, accounts);
                            break;
                    case "deposit":
                        decimal amount = decimal.Parse(tokens[2]);
                        Deposit(accountId, accounts, amount);
                        break;
                    case "withdraw":
                        decimal withdrawAmount = decimal.Parse(tokens[2]);
                        Withdraw(accountId, accounts, withdrawAmount);
                        break;
                    case "print":
                        Print(accountId, accounts);
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine().ToLower();
            }
        }

        static void Print(int accountId, Dictionary<int, BankAccount> accounts)
        {
            if (accounts.ContainsKey(accountId))
            {
                Console.WriteLine(accounts[accountId].ToString());
                return;
            }
            Console.WriteLine("Account does not exist");
        }

        static void Create(int accountId, Dictionary<int, BankAccount> accounts)
        {
            if (!accounts.ContainsKey(accountId))
            {
                var account = new BankAccount();
                account.Id = accountId;
                accounts.Add(accountId, account);
                return;
            }
            Console.WriteLine("Account already exist");
        }

        static void Deposit(int accountId, Dictionary<int, BankAccount> accounts, decimal amount)
        {
            if (accounts.ContainsKey(accountId))
            {
                accounts[accountId].Balance += amount;
                return;
            }
            Console.WriteLine("Account does not exists");
        }

        static void Withdraw(int accountId, Dictionary<int, BankAccount> accounts, decimal amount)
        {
            if (accounts.ContainsKey(accountId))
            {
                decimal balance = accounts[accountId].Balance;
                if (balance >= amount)
                {
                    accounts[accountId].Balance -= amount;
                    return;
                }
                Console.WriteLine("Insufficient balance");
                return;
            }
            Console.WriteLine("Account does not exist");
        }
    }
}
