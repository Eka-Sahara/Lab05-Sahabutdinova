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

int temperature = 15;

string result = temperature switch {
    < 0 => "Мороз",
    >= 0 and < 15  => "Прохладно",
    >= 15 and < 25 => "Комфортно",
    >= 25 and < 35 => "Жарко",
    _ => "Очень жарко"
};

System.Console.WriteLine(result);