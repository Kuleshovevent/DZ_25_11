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
        Console.WriteLine("Остаток "+ C);
    }
       
}

//Программа, которая принимает на вход число и показывает кратно ли оно и 7 и 23
void Zadacha4()
{
   Console.WriteLine("Введите число ");
    int number = Convert.ToInt32(Console.ReadLine());
    int C=number%7;
    int B = number%23;
    if (C==0 )
    {
        if(B == 0)
        {
            Console.WriteLine("Да, кратно");
        }
        else
        {
            Console.WriteLine("Нет, не кратно");
        }
    }
    else
    {
      Console.WriteLine("Нет, не кратно");  
    }

}

//Напишите программу которая принимает на вход два числа и проверяет, является ли одно число 
//квадратом другого
void Zadacha5()
{
    Console.WriteLine("Введите число 1");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число 2");
    int B = Convert.ToInt32(Console.ReadLine());
    if (A*A == B)
    {
        Console.WriteLine("Первое число квадрат второго");
    }
    else if (B*B == A)
        {
        Console.WriteLine("Второе число явлется квадратом первого");
        }
        else 
        {
           Console.WriteLine("Числа не являются квадратами друг друга"); 
        }
    
}

void Zadacha6()
{
    Console.WriteLine("Введите число в диапазоне от 1 до 7");
    int A = Convert.ToInt32(Console.ReadLine()); 
    if (A==6 | A==7)
    {
        Console.WriteLine("Это выходной день");
    }
    else 
    {
        Console.WriteLine("Это не выходной день");
    }
}

//Работа с текстом 
//Дан текст. В тексте нужно все пробелы заменить черточками
//маленькие буквы "к" заменить большими "К"
//А большие С заменить маленькими с

string text= "-Я думаю, - сказал князь, улыбаясь, - что,"
            +"Ежели бы вас поCлали вместо нашего милого Винценгероде, "
            +"вы бы взяли приступом согласие прусского короля."
            +"Вы так краCноречивы. Вы дадите мне чаю?";

//string s = "qwerty"
//            0123
//s[3] // r
void Zadacha7()
{
    string Replace(string text, char oldValue, char newValue)
    {
    string result = String.Empty;

    int length = text.Length;
    for (int i=0; i<length; i++)
    {
        if(text[i]==oldValue) result= result + $"{newValue}";
        else result=result + $"{text [i]}";
    }

    return result;
    }

    string newText = Replace(text, ' ' ,'|'  );

    Console.WriteLine(newText);
    Console.WriteLine();
    newText = Replace(newText, 'к', 'К');
    Console.WriteLine(newText);
    Console.WriteLine();
    newText = Replace(newText, 'C', 'c');
    Console.WriteLine(newText);
    }

//Zadacha1();
//Zadacha2();
//Zadacha3();
//Zadacha4();
//Zadacha5();
//Zadacha6();
//Zadacha7();
