

using homework2;

Phone phone = new Phone();

Console.WriteLine("Enter size mark model");
String mark = Console.ReadLine();
String size = Console.ReadLine();
String model = Console.ReadLine();

phone.Mark = mark;
phone.Size = size;
phone.Mark = model;


Console.WriteLine();
Console.WriteLine("=============================");
Console.WriteLine();



Car car = new Car();

car.Brand = "BMW";
car.Speed = 100;
car.Nummber = "GH 989";



string CarName = car.Brand;
Console.WriteLine($"Cars mark: { CarName}");

string CarNummber = car.Nummber;
Console.WriteLine($"Cars plate nummber is {CarNummber}");

double CarSpeed = car.Speed;
Console.WriteLine($"Car is driving {CarSpeed} KM/H");

car.StartToDrive();

car.GoFaster();

car.Beep();

car.SlowDown();





