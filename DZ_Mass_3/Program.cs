//Напишите программу, которая принимает на вход координаты точки (X and Y),
//причем Х не=0, Y не=0, выдает номер четверти плоскости
//в которой находится эта точка. право верх -1, лево вверх 2, низ лево 3

void Zadacha1()
{
//         перем    генератор    
    Random rand = new Random ();
    //тип данных_имя переменной= new тип данных ();
    int x = rand.Next (-10,11);
    int y = rand.Next (-10,11);
    Console.WriteLine($"A({x},{y})");

    if(x > 0 & y > 0)
    {
        Console.WriteLine("1-четверть");
    }
    else if (x > 0 & y < 0)
    {
        Console.WriteLine("4-четверть");
    }
    else if (x < 0 & y < 0)
    {
        Console.WriteLine("3-четверть");
    }
    else if (x < 0 & y < 0)
    {
        Console.WriteLine("2-четверть");
    }
    else 
    {
        Console.WriteLine("Точка лежит на координатной прямой");
    }


}

void Zadacha2()
{
    //Написать программу, которая по заданному номеру четверти
    //показывает диапозон возможных координат точек в этой четверти
    Console.WriteLine("Привет, дорогой!");
    Console.WriteLine("Введите номер четверти");
    int A = Convert.ToInt32(Console.ReadLine());
    
    if (A==1)
    {
        Console.WriteLine("x>0,y>0");
    }
    else if (A==2)
    {
        Console.WriteLine("x<0,y>0");
    }
    else if (A==3)
    {
        Console.WriteLine("x<0,y<0");
    }
    else if (A==4)
    {
        Console.WriteLine("x>0,y<0");
    }
    else
    {
        Console.WriteLine("Неверное значение, зачем так делаешь?");
    }
    
}

void Zadacha3()
{
    //Найти разницу между двумя координатами в 2Д пространстве
    //с введенными данными
    Console.WriteLine("Салам Алейкум,брат");
    Console.WriteLine("Введите координату первой точки по оси X");
    int X1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату первой точки по оси Y");
    int Y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату второй точки по оси X");
    int X2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату второй точки по оси Y");
    int Y2 = Convert.ToInt32(Console.ReadLine());

    int Z = Convert.ToInt32(Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)));
    Console.WriteLine($"Это разница брат {Z}");
}

void Zadacha4()
{
    Console.WriteLine("САЛАМ АЛЕЙКУМ, БРАТ!!!");
    Console.WriteLine("Введите число");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");

    for(int i=1; i <= A; i++)
    {
        int B= Convert.ToInt32(Math.Pow(i,2));
        Console.WriteLine(B);
    }
}





//Zadacha1();
//Zadacha2();
//Zadacha3();
//Zadacha4();
