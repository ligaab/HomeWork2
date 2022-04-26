

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


Console.WriteLine();
Console.WriteLine("=============================");
Console.WriteLine();


Product product = new Product(4,2,6);

string weight = Console.ReadLine();
Console.WriteLine(weight);
string height = Console.ReadLine();
Console.WriteLine(height);
string width = Console.ReadLine();
Console.WriteLine(width);








Console.WriteLine();
Console.WriteLine("=============================");
Console.WriteLine();



Person person = new Person();

Console.WriteLine("What your name?");
string personname = Console.ReadLine();

Console.WriteLine("What your surname?");
string personsurname = Console.ReadLine();

string persongreeting = ($"Hello + {personname} {personsurname}!");
Console.WriteLine(persongreeting);

Console.WriteLine("What your birth date in format dd.mm.yyyy?");
string birthDateText = Console.ReadLine();
person.BirthDate = DateTime.Parse(birthDateText);

person.Name = personname;
person.Surname = personsurname;                 




string persongreeting1 = ($"Hello, my name is {personname} {personsurname} and i am {person.BirthDate} years old.");
Console.WriteLine(persongreeting1);







