// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadInt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
int ax = ReadInt ("Введите первую координату первой точки");
int ay = ReadInt ("Введите вторую координату первой точки");
int az = ReadInt ("Введите третью координату первой точки");
int bx = ReadInt ("Введите первую координату второй точки");
int by = ReadInt ("Введите вторую координату второй точки");
int bz = ReadInt ("Введите третью координату второй точки");

int distanceX = (ax - bx);
int distanceY = (ay - by);
int distanceZ = (az - bz);
double len = Math.Sqrt(Math.Pow(distanceX,2) + Math.Pow(distanceY,2) + Math.Pow(distanceZ,2));
System.Console.WriteLine($"Расстояние между точками {len:f2}");
