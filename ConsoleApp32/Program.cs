//using Microsoft.VisualBasic;

//Student[] students = new Student[3];
//for (int i = 0; i < students.Length; i++)
//{
//    Console.WriteLine("Введите имя: "); 
//    string name = Console.ReadLine();
//    Console.WriteLine("Введите группу: ");
//    string group = Console.ReadLine();
//    Console.WriteLine("Введите год рождения: ");
//    int year = int.Parse(Console.ReadLine());
//    Console.WriteLine("Введите оценку по физике: ");
//    int physics = int.Parse(Console.ReadLine());
//    Console.WriteLine("Введите оценку по математике: ");
//    int math = int.Parse(Console.ReadLine());
//    Console.WriteLine("Введите оценку по информатике: ");
//    int informatics = int.Parse(Console.ReadLine());
//    students[i] = new Student(name, group, year, physics, math, informatics);
//}
//for(int i = 0; i < students.Length; i++)
//{
//    if (DateTime.Now.Year - students[i].year > 19)
//        students[i].Print();
//}

//struct Student
//{
//    public string name;
//    public string group;
//    public int year;
//    public int physics;
//    public int math;
//    public int informatics;

//    public Student(string name, string group, int year, int physics, int math, int informatics)
//    {
//        this.name = name;
//        this.group = group;
//        this.year = year;
//        this.physics = physics;
//        this.math = math;
//        this.informatics = informatics;
//    }
//    public void Print()
//    {
//        Console.WriteLine($"Имя: {name}, группа: {group}, год рождения: {year}, оценка по физике: {physics}, оценка по математике: {math}, оценка по информатике: {informatics}");
//    }
//}
Flight[] flight = new Flight[3];
for (int i = 0; i < 3; i++)
{
    Console.Write("Введите номер рейса: ");
    string flightNum = Console.ReadLine();
    Console.Write("Введите время вылета: ");
    DateTime departure = DateTime.Parse(Console.ReadLine());
    Console.Write("Введите время прилёта: ");
    DateTime arrive = DateTime.Parse(Console.ReadLine());
    Console.Write("Введите направление: ");
    string direction = Console.ReadLine();
    Console.Write("Введите марку самолёта: ");
    string band = Console.ReadLine();
    Console.WriteLine("Введите растояние ");
    double distance = double.Parse(Console.ReadLine());
}
TimeSpan max= TimeSpan.MinValue;
for (int i = 0; i < flight.Length; i++)
{
    TimeSpan temp = flight[i].arrive.Subtract(flight[i].departure);
    if (temp > max) max = temp;
}
for (int i = 0; i < flight.Length; i++)
{
    if (flight[i].arrive.Subtract(flight[i].departure) == max)
        flight[i].Print();
}

struct Flight
{
    public string flightNum;
    public DateTime departure;
    public DateTime arrive;
    public string direction;
    public string band;
    public double distance;

    public Flight(string flightNum, DateTime departure, DateTime arrive, string direction, string band, double distance)
    {
        this.flightNum = flightNum;
        this.departure = departure;
        this.arrive = arrive;
        this.direction = direction;
        this.band = band;
        this.distance = distance;
    }
    public void Print()
    {
        Console.WriteLine($"Имя: {flightNum}, группа: {departure}, год рождения: {arrive}, оценка по физике: {direction}, оценка по математике: {band}, оценка по информатике: {distance}");
    }
}