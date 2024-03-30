// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
public class InputMethodDemoTwo
{
    public static void Main() {
        Console.WriteLine("Это калькулятор");
        IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
        while (true) {
            Console.WriteLine("\nВыберите действие \n1)Деление\n2)Умножение\n3)Сложение\n4)Вычитание");
            int user_enter = Convert.ToInt32(Console.ReadLine());
            NumberEnter();
            double ConvertToDouble(string user_enter)
            {
                    if (user_enter.Contains("."))
                       return double.Parse(user_enter, formatter);
                    else
                       return Convert.ToDouble(user_enter);
               
            }
             void NumberEnter()
            {
                double first=0;
                double second=0;
                    Console.WriteLine("Введите 1-е число");
                    string user_number_first = Console.ReadLine();
                try 
                {
                    first = ConvertToDouble(user_number_first);
                }
                catch(FormatException) { Console.WriteLine("Число не должно сдержать букв"); return; }
                   
                    Console.WriteLine("Введите 2-е число");
                    string user_number_second = Console.ReadLine();
                try
                {
                    second = ConvertToDouble(user_number_second);
                }
                catch (FormatException) { Console.WriteLine("Число не должно сдержать букв"); return; }

                switch (Convert.ToInt32(user_enter))
                {
                    case 1:
                        {
                            try {
                                if(second ==0) { throw new Exception("Ошибка! На 0 делить нельзя"); }
                                Console.WriteLine("Результат: " + (first / second));
                                
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Результат: " + (first * second));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Результат: " + (first + second));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Результат: " + (first - second));
                            break;
                        }
                }
            }
        }
        
    }
}