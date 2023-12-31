﻿Console.WriteLine("Добро пожаловать в управление банковским счетом!");
BankAccount account = new BankAccount(0, "none");
List<int> transactions = new List<int>();
Menu_Choice();

void Menu_Choice()
{ 
    var choice = 0; 
    while(choice != 6)
{
    Console.WriteLine("\n Введите номер выбранного действия:");
    Console.WriteLine("1. Создать новый счет");
    Console.WriteLine("2. Пополнить счет");
    Console.WriteLine("3. Снять деньги со счета");
    Console.WriteLine("4. Проверить баланс");
    Console.WriteLine("5. Вывести все транзакции");
    Console.WriteLine("6. Выйти из программы");
    Console.WriteLine("Введите номер выбранного действия:");
    choice = Convert.ToInt32(Console.ReadLine());
    
    switch (choice)
    {
        case 1:
            Create_Account();
            break;
        case 2:
            Replenish_Account();
            break;
        case 3:
            Withdraw_account();
            break;
        case 4:
            check_account();
            break;
        case 5:
            transactions_account();
            break;
        case 6:
            Environment.Exit(0);
            break;
    }  
    
}
}

void Create_Account()
{
    Console.WriteLine("Введите имя вашего нового аккаунта:");
    string name = Console.ReadLine();
    Console.WriteLine("Введите ваш стартовый баланс:");
    int balance = Convert.ToInt32(Console.ReadLine());
    account.UpdateBankAccount(balance,name);
}

void Replenish_Account()
{
    Console.WriteLine("Введите сумму пополнения счёта: ");
    int replenish_summ = Convert.ToInt32(Console.ReadLine());
    account.Balance += replenish_summ;
    transactions.Add(replenish_summ);
}

void Withdraw_account()
{
    Console.WriteLine("Введите сумму которую желаете снять счёта: ");
    int withdraw_summ = Convert.ToInt32(Console.ReadLine());
    account.Balance -= withdraw_summ;
    transactions.Add(-withdraw_summ);
}

void check_account()
{
    Console.WriteLine ($"имя счёта: {account.Name}");
    Console.WriteLine($"баланс счёта:  {account.Balance}");
}

void transactions_account()
{
    foreach (var item in transactions)
    {
        Console.WriteLine(item);
    }
}



public class BankAccount
{
    public int Balance { get; set; } // дает возможность работать с балансом,(чтение; запись;)
    public string Name{ get; set; } // дает возможность работать с именем аккаунта,(чтение; запись;)
    public BankAccount(int balance, string name) // в случаи созданного аккаунта выведет имя и баланс счёта
    {
        Name = name;
        Balance = balance;
    }

    public void UpdateBankAccount(int newBalance, string newName)
    {
        Name = newName;
        Balance = newBalance;
    }


}

