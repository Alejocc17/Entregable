uint Entrada=15000;

System.Console.WriteLine("Ingrese nombre:");

string Nombre=Console.ReadLine();

System.Console.WriteLine("Ingrese edad:");
uint Edad=uint.Parse(Console.ReadLine());

if(Edad<4){
    Console.WriteLine("Entra gratis");
}
if(Edad>=4 && Edad <18){
    Console.WriteLine("Su pago es de:" + Entrada*0.95);
}
if(Edad>18){
    Console.WriteLine("Su pago es de:" + Entrada*0.97);
}
