using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {   //----------Day1----------
        class student
        {
            public string name;
            public int age;
            public double score;
            public void study()
            {
                Console.WriteLine("sinh vien dang hoc");
            }
            public void takeExam()
            {
                Console.WriteLine("sinh vien dang thi");
            }
            public void Ispassed()
            {
                if (score >= 5)
                {
                    Console.WriteLine("sinh vien da qua mon");
                }
                else
                {
                    Console.WriteLine("sinh vien chua qua mon");
                }
            }
        }
        class bankaccount
        {
            public string accountnumber;
            public string accountname;
            public double balance;
            public bankaccount(string accountnumber, string accountname, double balance)
            {
                this.accountnumber = accountnumber;
                this.accountname = accountname;
                this.balance = balance;
            }
            public void deposit(double amount)
            {
                balance += amount;
                Console.WriteLine("So du sau khi nap: " + balance);
            }
            public void withdraw(double amount)
            {
                balance -= amount;
                Console.WriteLine("So tien da rut: " + amount);
            }
            public void displaybalance()
            {
                Console.WriteLine("So du tai khoan: " + balance);
            }
        }
        class car
        {
            public string brand;
            public string color;
            public double speed;
            public car(string brand, string color, double speed)
            {
                this.brand = brand;
                this.color = color;
                this.speed = speed;
            }
            public void start()
            {
                Console.WriteLine("Xe bat dau chay");
            }
            public void stop()
            {
                Console.WriteLine("Xe dung");
            }
            public void accelerate(double amount)
            {
                speed += amount;
            }
            public void showinfo()
            {
                Console.WriteLine("Brand: " + brand);
                Console.WriteLine("Color: " + color);
                Console.WriteLine("Speed: " + speed);
            }
        }
        //----------Day2----------
        public class UserAccount
        {
            public string AccountID { get; set; } //init 
            public string UserName { get; set; }
            private string _password;
            public string Password
            {
                set
                {
                    _password = "[ENCRYPTED]_" + value;
                }
            }
            private decimal _balance;
            public decimal Balance
            {
                get
                {
                    return _balance;
                }
                set
                {
                    if (value >= 0) _balance = value;
                    else Console.WriteLine("Error: Balance cannot be negative");
                }
            }
            public bool IsVIP
            {
                get => Balance >= 10000;
            }
            public DateTime CreatedDate { get; }


            public UserAccount
                (
                string AccountID,
                string UserName,
                string Password,
                decimal Balance
                )
            {
                this.AccountID = AccountID;
                this.UserName = UserName;
                this.Password = Password;
                this.Balance = Balance;
                this.CreatedDate = DateTime.Now;
            }
            public void Deposit(decimal amount)
            {
                if (amount > 0)
                {
                    Balance += amount;
                    Console.WriteLine("So du sau khi nap: " + Balance);
                }
            }
            public string WithDraw(decimal amount)
            {
                if (amount > Balance) { return "So du khong du de rut"; }
                Balance -= amount;
                return "So tien da rut: " + amount;
            }
        }
        static void Main(string[] args)
        {   //----------Day1----------
            student student1 = new student();
            student1.name = "Hung";
            student1.age = 19;
            student1.score = 9;
            student1.study();
            student1.takeExam();
            student1.Ispassed();
            Console.WriteLine("------THE NGAN HANG CUA HUNG------");
            bankaccount account1 = new bankaccount("0326369336", "Pham Hung", 50000);
            //account1.accountnumber = "0326369336";
            //account1.accountname = "Pham Hung";
            //account1.balance = 500000000;
            account1.deposit(100000);
            account1.withdraw(2000);
            account1.displaybalance();
            Console.WriteLine("------THE NGAN HANG CUA TAN PHAT------");
            bankaccount account2 = new bankaccount("0988059546", "Phan Tan Phat", 20000);
            //account2.accountnumber = "0988059546";
            //account2.accountname = "Phan Tan Phat";
            //account2.balance = 36;
            account2.deposit(63);
            account2.withdraw(3);
            account2.displaybalance();
            Console.WriteLine("----------PHAN LOAI XE----------");
            car car1 = new car("Mitsubishi", "Grey", 50);
            car1.start();
            car1.accelerate(20);
            car1.showinfo();
            car1.stop();
            car car2 = new car("Toyota", "Violet", 40);
            car2.start();
            car2.accelerate(15);
            car2.showinfo();
            car2.stop();
            //----------Day2----------
            UserAccount user1 = new UserAccount("9326369336", "Pham Hung", "290707", 50000);
            Console.WriteLine("AccountID: " + user1.AccountID);
            Console.WriteLine("UserName: " + user1.UserName);
            Console.WriteLine("Balance: " + user1.Balance); 
            Console.WriteLine("IsVIP: " + user1.IsVIP);
            Console.WriteLine("CreatedDate: " + user1.CreatedDate);

            Console.WriteLine();

            user1.UserName = "Tony Bun";
            Console.WriteLine("UserName After Changed: " + user1.UserName);
            user1.Deposit(2000);
            Console.WriteLine(user1.WithDraw(7000));
            Console.WriteLine("Current Balance: " + user1.Balance);
            Console.WriteLine("IsVIP: " + user1.IsVIP);
        }
    }
}

