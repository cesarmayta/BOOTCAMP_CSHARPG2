//bucles
bool continuar = true;

while(continuar == true)
{
    Console.WriteLine("Ingresa la tabla a multiplicar : ");
    int tabla = int.Parse(Console.ReadLine());

    for (int i = 1; i <= 12; i++)
    {
        Console.WriteLine($" {tabla} x {i} = {tabla * i}");
    }

    Console.WriteLine("Desea continuar ? (si,no) :  ");
    string respuesta = Console.ReadLine();
    if(respuesta == "no")
    {
        continuar = false;
    }
}

int contador = 0;
do
{
    contador++;
    int par = contador * 2;
    Console.WriteLine(par);
} while (contador < 50);




