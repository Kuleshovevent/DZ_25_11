//Написать программу которая выводит случайное число из отрезка 
//[10,99] и показывает наибольшую цифру числа.
void Zadacha1()
{
    Random rand = new Random();
    int number; 
    number = rand.Next (10,100); //второе число- не входит
    Console.WriteLine("Случайное число "+number);

    int A = number / 10;
    int B = number % 10;

    Console.Write("Здесь показывается наибольшая цифра ");
    if (A>B)
    {
        Console.WriteLine(A);
    }
    else
    {
        Console.WriteLine(B);
    }
}

void Zadacha2() //Написать программу с 3-х значным числом и удалить вторую цифру этого числа
{
Random rand = new Random ();
int number;
number = rand.Next(100,1000);
Console.WriteLine("Случайное число "+ number);
int A = number / 100;
int B= number % 10;

Console.Write(A +""+B);
}

//Напишите программу, которая будет принимать на вход два числа и выводить,
//является ли второе число кратное первому. Если число 2 не кратно число 1, то программа выводит 
//остаток от деления.
void Zadacha3() 
{
    Console.WriteLine("Введите число 1");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число 2");
    int B = Convert.ToInt32(Console.ReadLine());
    int C = B % A;
    if (C==0)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine(C);
    }
       
}




//Zadacha1();
//Zadacha2();
//Zadacha3();