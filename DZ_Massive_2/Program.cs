//Тренируемся 
int[] array = new int [10];//new int создай новый массив в котором будет 10 элементов
void FillArray (int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while(index<lenght)
    {
        collectoin(index)= new Random().Next(1,10);
        index++;
    }
}
