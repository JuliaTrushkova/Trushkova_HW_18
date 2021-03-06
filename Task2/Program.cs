// See https://aka.ms/new-console-template for more information
using Task2;

Console.WriteLine("Hello, Teacher!");

Train[] trains = new Train[8];

//Создание массива поездов
for (int i = 0; i < trains.Length; i++)
{
    trains[i] = Train.MakeTrain(i);
}

//Сортировка массива поездов по номеру поезда и вывод на экран всего списка
trains = Trains.SortingNumTrain(trains);
Console.WriteLine("\nЗагруженные в базу поезда:");
for (int i = 0; i < trains.Length; i++)
{    
    trains[i].Show();
}

//Вывод на экран информаци о поезде по номеру поезда
Console.WriteLine("\nВведите номер поезда для поиска по загруженной базе:");
int numberTrain = Convert.ToInt32(Console.ReadLine());
int? hasTrainIndex = Trains.HasTrain(numberTrain, trains);
if (hasTrainIndex.HasValue)
    trains[hasTrainIndex.Value].Show();
else
    Console.WriteLine("Такого поезда нет");
