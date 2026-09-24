// using System.Collections;

// int dayNumber = 5;

// switch (dayNumber)
// {
//     case 6 or 7 or 5: System.Console.WriteLine("Выходной"); break;
//     default: System.Console.WriteLine("Будний"); break;
// }

// int score = 77;

// switch (score) {
//     case >= 0 and < 40:
//         System.Console.WriteLine("Неудовлетворительно");
//         break;
//     case >= 40  and < 60:
//         System.Console.WriteLine("Удовлетворительно");
//         break;
//     case >= 60 and < 80:
//         System.Console.WriteLine("Хорошо");
//         break;
//     case >= 80 and <= 100:
//         System.Console.WriteLine("Отлично");
//         break;
//     default:
//         System.Console.WriteLine("Некорректный балл");
//         break;
// }

// int temperature = 15;

// string result = temperature switch {
//     < 0 => "Мороз",
//     >= 0 and < 15  => "Прохладно",
//     >= 15 and < 25 => "Комфортно",
//     >= 25 and < 35 => "Жарко",
//     _ => "Очень жарко"
// };

// System.Console.WriteLine(result);

// string role = "user";

// string result = role switch
// {
//     "admin" => "Полный доступ",
//     "teacher" => "Доступ преподавателя",
//     not "admin" and not "teacher" => "Ограниченный доступ"
// };

// System.Console.WriteLine(result);

// int age = 15;
// bool hasTicket = true;

// switch (age) {
//     case >= 18 when hasTicket:
//         System.Console.WriteLine("Вход разрешён");
//         break;
//     case >= 18:
//         System.Console.WriteLine("Нет билета");
//         break;
//     default:
//         System.Console.WriteLine("Возраст не подходит");
//         break;
// }

// int level = 2;

// switch (level) {
//     case 1:
//         System.Console.WriteLine("Начальный уровень");
//         break;
//     case 2:
//         System.Console.WriteLine("Средний уровень");
//         goto case 1;
//     case 3:
//         System.Console.WriteLine("Продвинутый уровень");
//         break;
// }

// System.Console.WriteLine($"Время года");
// Console.Write("Введите номер месяца: ");
// int month = int.Parse(Console.ReadLine());

// string season = month switch
// {
//     12 or 1 or 2 => "Зима",
//     3 or 4 or 5 => "Весна",
//     6 or 7 or 8 => "Лето",
//     9 or 10 or 11 => "Осень",
//     _ => "Неверный месяц"
// };
// System.Console.WriteLine(season);

// System.Console.WriteLine("Уровень доступа");
// Console.Write("Введите роль: ");
// string role = (Console.ReadLine());

// string result = role switch
// {
//     "admin" => "Полный доступ",
//     "teacher" => "Доступ преподавателя",
//     not "admin" and not "teacher" => "Ограниченный доступ"
// };

// System.Console.WriteLine(result);

// System.Console.WriteLine("Стоимость напитка");
// Console.Write("Введите размер напитка: ");
// string drink = (Console.ReadLine());
// Console.Write("Есть студенческая скидка: ");
// bool student = bool.Parse(Console.ReadLine());

// string cost = drink switch
// {
//     "S" when student => "135 руб.",
//     "M" when student => "180 руб.",
//     "L" when student => "225 руб.",
//     "S" => "150 руб.",
//     "M" => "200 руб.",
//     "L" => "250 руб.",
//     _ => "Неизвестный размер"
// };

// System.Console.WriteLine(cost);

// System.Console.WriteLine("Тариф по времени");
// Console.Write("Введите время: ");
// int time = int.Parse(Console.ReadLine());

// string tariff = time switch
// {
//     > 0 and <= 5 => "Ночной тариф",
//     >= 6 and <= 9 => "Утренний тариф",
//     >= 10 and <= 17 => "Дневной тариф",
//     >= 18 and <= 23 => "Вечерний тариф",
//     _ => "Неизвестное время"
// };

// System.Console.WriteLine(tariff);
