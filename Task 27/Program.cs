//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int sumNumbers (int A)
{
    int result = 0;
    while (A !=0)
    {
        result = result + A % 10;
        A = A /10;
    }
    Console.WriteLine(result);
    return result;
}


sumNumbers(452);
sumNumbers(82);
sumNumbers(9012);
sumNumbers(555);



