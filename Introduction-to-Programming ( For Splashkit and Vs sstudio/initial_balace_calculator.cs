using static SplashKitSDK.SplashKit;
string name;
WriteLine("Welcome to our bank appliciation");
WriteLine("Enter your name?Enter name");
name= ReadLine();
float initialbalance;
WriteLine("Enter your initial balance?Enter initial balance");
initialbalance=Convert.ToInt32(ReadLine());
float transactionamount;
WriteLine("Enter transaction amount?Enter amount");
transactionamount=Convert.ToInt32(ReadLine());
float addtransactionamount;
addtransactionamount=initialbalance+transactionamount;
if (transactionamount<1000)
{
    WriteLine("Invalid transaction");
    WriteLine("Note:-Enter amount more than 1000");
}
else
{
WriteLine("Your account summary... " +name);
WriteLine("Your initial balance is " +initialbalance);
WriteLine("Transaction amount is " +transactionamount);
WriteLine("Your Current balance is "+addtransactionamount);
WriteLine("Thanku for using....");
}
