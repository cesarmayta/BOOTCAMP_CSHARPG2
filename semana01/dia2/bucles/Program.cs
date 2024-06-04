// bucles
// for
Console.WriteLine("Ingrese la tabla a multiplicar : ");
int tabla = Convert.ToInt32(Console.ReadLine());
for (int i = 1;i <= 12; i++)
{
    Console.WriteLine($"{tabla} X {i} = {tabla * i}");
}

Console.WriteLine("=============== TABLA CON WHILE ===========");
//while
int c = 1;
while(c <= 12)
{
    Console.WriteLine($"{tabla} X {c} = {tabla * c}");
    c++;
}
