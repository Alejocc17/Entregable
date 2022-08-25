Console.WriteLine("Ingrese renta semestral:");
int Renta=int.Parse(Console.ReadLine());
int RentaAnual=Renta*2;

if (Renta<10000){
    Console.WriteLine("Su renta anual es: " + RentaAnual + " Su total de renta a pagar es:"
     + (RentaAnual+RentaAnual*0.05));
}
else if(Renta>=10000 && Renta <20000){
    Console.WriteLine("Su renta anual es: " + RentaAnual + " Su total de renta a pagar es:" 
    + (RentaAnual+RentaAnual*0.10));
}
else if(Renta >=20000 && Renta <35000){
    Console.WriteLine("Su renta anual es: " + RentaAnual + " Su total de renta a pagar es:" 
    + (RentaAnual+RentaAnual*0.15));
}
else if(Renta >45000){
    Console.WriteLine("Su renta anual es: " + RentaAnual + " Su total de renta a pagar es:" 
    + (RentaAnual+RentaAnual*0.30));
}
else{
    Console.WriteLine("Erroooor");
}
