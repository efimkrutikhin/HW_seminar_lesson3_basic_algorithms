
Console.WriteLine("Введите пятизначное число: ");
    int[] num_array = new int[5];

int num = int.Parse(Console.ReadLine());
// Проверка на корректность
if( num < 10000 || num > 99999){
    Console.WriteLine("Введено некорректное число");
}else //Запись элементов в массив
{
    for( int i = 4; i >= 0; i-- ){
        num_array[i] = num % 10;
        num /= 10;
    }
    if( num_array[0] == num_array[4] && num_array[1] == num_array[3]){ //Проверка на палиндром
    Console.WriteLine("ЭТО ПАЛИНДРОМ");
}else
{
    Console.WriteLine("НЕ ЯВЛЯЕТСЯ ПАЛИНДРОМОМ");
}
}
