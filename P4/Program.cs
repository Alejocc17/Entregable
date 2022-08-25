Console.WriteLine("Ingrese nombre:");
string Nombre=Console.ReadLine();

Console.WriteLine("Ingrese evaluación:");
float Evaluacion=float.Parse(Console.ReadLine());

int Bonificacion = 50000;
//float Result = Bonificacion * Evaluacion;

if (Evaluacion<0.1){
    Console.WriteLine("Su nivel es inaceptable, Su bonificación es:" + Bonificacion*Evaluacion);
}
else if(Evaluacion>0.3 && Evaluacion<0.5){
    Console.WriteLine("Su nivel es aceptable, Su bonificación es:" + Bonificacion*Evaluacion);
}
else if(Evaluacion>0.5){
    Console.WriteLine("Su nivel es meritoria, Su bonificación es:" + Bonificacion*Evaluacion);
}else{
    Console.WriteLine("Erroooor");
}
