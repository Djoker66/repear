using System;

namespace repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[3];

            users[0] = new User("Abbas", "Dajweoi1");
            users[1] = new User("Hikmet", "A2opkoi1");
            users[2] = new User("Ali", "23Fikswe");

            string input;

            do
            {
                Console.WriteLine("\n1.User əlavə et");
                Console.WriteLine("2.Userlere bax");
                Console.WriteLine("3.Userler üzrə axtarış et");

                input = Console.ReadLine();

                if (input == "1")
                {
                    InsertUser(ref users, CreateUser());

                }

                else if (input == "2")
                {
                    ShowUsersInfo(users);
                }

                else if (input == "3")
                {
                    Console.WriteLine("Axtaris deyerini daxil edin:");
                    string find = Console.ReadLine();

                    var filter = searchUser(ref users, find);
                    ShowUsersInfo(filter);
                } 

            } while (input != "1" || input != "2" || input != "3");
        }

        static void ShowUsersInfo(User[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].Showinfo());
            }
        }

        static User[] searchUser(ref User[] arr, string find)
        {
            User[] newArr = new User[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].UserName.Contains(find, StringComparison.OrdinalIgnoreCase))
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = arr[i];
                }
            }
            return newArr;
        }

        static User[] InsertUser(ref User[] userArr, User user)
        {
            Array.Resize(ref userArr, userArr.Length + 1);
            userArr[userArr.Length - 1] = user;

            return userArr;
        }

        static User CreateUser()
        {
            User user = new User(string username, string password);

            do
            {
                Console.Write("Username daxil edin");
                user.UserName = (Console.ReadLine());

            } while (user.UserName == null);

            do
            {
                Console.Write("Pass daxil edin");
                user.Password = Console.ReadLine();

            } while (user.Password == null);

            return user;
        }
    }
}
