//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());*/

double exponentiate (int A, int B)
{
    double result = Math.Pow(A, B);
    Console.WriteLine(A+" в степени "+B+" равно "+result);
    return result;
}

exponentiate(2,3);
exponentiate(3,5);
exponentiate(2,4);



