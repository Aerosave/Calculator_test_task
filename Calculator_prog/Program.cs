namespace Calculator_prog
{
 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет!\nЧто ты хочешь откалькулировать?" +
                "\nДля сложения введи цифру [1]" +
                "\nДля вычитания введи цифру [2]" +
                "\nДля умножения введи цифру [3]" +
                "\nДля деления введи цифру [4]");

            string operationChoice = Console.ReadLine();
            Console.WriteLine("Введите первое число");
            string a = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            string b = Console.ReadLine();

            int num1 = int.Parse(a);
            int num2 = int.Parse(b);

            // Создание экземпляра класса Calculator
            Calculator calculator = new Calculator();

            int result = 0;
            // Выбор операции на основе ввода пользователя
            try
            {
                switch (operationChoice)
                {
                    case "1":
                        result = calculator.Additional(num1, num2);
                        break;
                    case "2":
                        result = calculator.Subtraction(num1, num2);
                        break;
                    case "3":
                        result = calculator.Miltiplication(num1, num2);
                        break;
                    case "4":
                        result = calculator.Division(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Неправильный выбор операции!");
                        break;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка: неверный формат ввода. Введите целое число.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(result);

            }
        }
    }
}
