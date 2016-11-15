using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // Create a new bank account with 25 % interest rate
            // (is that legal...?)


            BankAccount theAccount = null;
            
            
            try
            {
                theAccount = new BankAccount(25.0);
            }
            catch (IllegalInterestRateException)
            {

                Console.WriteLine("Interest rate shoudl be tween 0.0 and 20.0");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            ///

            try
            {
                theAccount.Deposit(-1000);
            }
            catch (NegativeAmountException)
            {
                Console.WriteLine("You tried to deposit a negative amount!");                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            try
            {
                theAccount.Withdraw(3000);
            }
            catch (WithdrawAmountTooLargeException)
            {
                Console.WriteLine("You tried to withdraw too much money!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }


            try
            {
                Console.WriteLine("Balance is now : " + theAccount.GetBalance());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);                
            }
            
            // The LAST line of code should be ABOVE this line
        }
    }
}
