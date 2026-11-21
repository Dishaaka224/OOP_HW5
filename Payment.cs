using System;
namespace Models;

class Payment
{
    public virtual void Pay(decimal amount)
    {
        Console.WriteLine($"To'landi: {amount} so'm");
    }
}
class CardPayment : Payment
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Karta orqali to'landi: {amount} so'm");
    }
}
class BankTransferPayment : Payment
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Bank o'tkazmasi orqali to'landi: {amount} so'm");
    }
}

class WalletPayment : Payment
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Elektron hamyon orqali to'landi: {amount} so'm");
    }
}