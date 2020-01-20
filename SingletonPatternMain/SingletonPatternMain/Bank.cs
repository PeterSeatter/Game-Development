using System;

public class Bank
 {
     // private field to store the Bank instance
     private static Bank bank;
     // Encapsulated constructor, stops other objects from doing new Bank()
     private Bank() { }
     // Instance of bank named Charity Account only be obtained through this 
     // getter property - in the main we type Bank.CharityAccount
     public static Bank CharityAccount
     {
         // if the instance does not exist then create a new one and return it,
         // otherwise return the existing instance
         get
         {
             if (bank == null)
             {
                 bank = new Bank();
             }
             return bank;
         }
     }
     // property to store money in the instance 
     public int CharityBalance { get; private set; } = 60;
     public void DonateMoney(int amountToDonate) {
         var result = CharityBalance - amountToDonate;
         if (result < 0)
         {
                 Console.WriteLine("Error, transaction aborted - there are insufficient funds!");
                 return;
         }
         // all good, just update the balance
         CharityBalance = result;
     }
 }