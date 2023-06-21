// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void findingDistance3d(int ax, int ay, int az, int bx, int by, int bz)
{
    double AB = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay) + (bz - az) * (bz - az));
    Console.WriteLine(AB);
}



int AX = Prompt("Введите координату Ax: ");
int AY = Prompt("Введите координату Ay:");
int AZ = Prompt("Введите координату Az: ");

int BX = Prompt("Введите координату Bx: ");
int BY = Prompt("Введите координату By: ");
int BZ = Prompt("Введите координату Bz: ");

findingDistance3d(AX, AY, AZ, BX, BY, BZ);