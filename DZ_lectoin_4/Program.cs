int SumNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number;
        number--;
    }
    return sum;
}


void Zadacha24()
{
    //Задача 24: Напишие программу которая принимает на вход число А
    //и выдает сумму от 1 до А

    Random rand = new Random();
    int number = rand.Next(1, 16);
    Console.WriteLine("Введено число:" + number);

    int counter = 1;
    int sum = 0;
    while (counter <= number)
    {
        Console.WriteLine($"{sum}+{counter}= ");
        sum = sum + counter;
        Console.WriteLine(sum);
        counter++;


    }
    Console.WriteLine("Ответ" + sum);
}
void Zadacha26()
{
    //Напишите программу которая принимает на вход число и 
    //И выдает количетство цифр в числе
    Random rand = new Random();
    int number = rand.Next(1, 100000);
    Console.WriteLine("Введено число:" + number);

    int result = 0;

    while (number > 0)
    {
        number = number / 10;
        result++;
    }
    Console.WriteLine("Ответ" + result);
}

void Zadacha28()
{
    //Напишите программу, которая принимает на вход число N
    // и выдает произведение чисел от 1 до N
    Random rand = new Random();
    int number = rand.Next(1, 5);
    Console.WriteLine("Введено число:" + number);

    int counter = 1;
    int sum = 1;
    while (counter <= number)
    {
        Console.WriteLine($"{sum}*{counter}= ");
        sum = sum * counter;
        Console.WriteLine(sum);
        counter++;
    }
    Console.WriteLine("Ответ " + sum);
}

void FillArray(int[] nums)
{
    Random rand = new Random();
    int size = nums.Length;
    for(int i=0;i < size;i++ )
    {
        nums [i] = rand.Next(0,2);
    }

}

void PrintArray(int[] nums)
{
   int size = nums.Length;
   for(int i=0;i < size;i++ )
    {
        Console.Write(nums [i]+ "  ");
    } 
}

void Zadacha30()
{
    //Выводит массив из 8 элементов, заполненный 0 и 1 в случайном
    //порядке
    int size = 8;
    int[] numbers = new int[size];

    FillArray(numbers);
    PrintArray(numbers);
    


}

//Zadacha26();
//Zadacha24();
//Zadacha28();
Zadacha30();
