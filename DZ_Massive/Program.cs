//int Max(int arg1, int arg2, int arg3)
//{
    //int result = arg1;
    //if( arg2 >result) result = arg2;
    //if( arg3 > result) result = arg3;
    //return result;
//}

//              0  1   2  3  4  5  6  7  8
//int [] array = {13,24,35,46,255,62,73,85,39};
//здесь мы показываем как можно записать
//а здесь просим чтобы нам ее написали

//Найти максимальное число из 9 чисел

//int max = Max (
    //Max(array[0],array[1],array[2]), 
    //Max(array[3],array[4],array[5]), 
    //Max(array[6],array[7],array[8])); 

//Console.WriteLine("Максимальное число "+ max);

int[] array = {18,23,32,43,54,65,47,38};
int n= array.Length;// показывает количество элементов массива
int find = 4;
int index = 0;
while (index<n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
    }
    //index=index+1;
    index++;
}