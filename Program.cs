using System;
using System.Text;

namespace DPRN2_U2_EA_ANEA
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int elegirVacuna=0;
            while(elegirVacuna==0||elegirVacuna==1||elegirVacuna==2||elegirVacuna==3){
                do{
                    string terminos="¿Acepta los términos?\nSí\nNo";
                    string noacepto="Haz elegido 'No'. Adiós.";        
                    string quedosis="Elige qué deseas realizar:\n1.- Aplicar primer dosis.\n2.- Aplicar segunda dosis.";
                    System.Console.WriteLine("*******************************************************");
                    System.Console.WriteLine("*****Bienvenido a tu aplicación contra el COVID-19*****");
                    System.Console.WriteLine("*******************************************************");
                    System.Console.WriteLine("Por favor selecciona una opción: \n1.- Elegir Vacuna.\n2.- Efectos secundarios.\n3.- Salir.");
                    var opcion = Console.ReadLine();
                    elegirVacuna = int.Parse(opcion);
                    switch(elegirVacuna){
                        case 1 when (elegirVacuna==1):
                            //La aplicación elige de forma aleatoria: 1.- Pfizer, 2.- AztraZeneca, 3.- Sputnik V
                            var randomNumberVacuna = new Random().Next(1, 4);
                            EfectoVacuna efectovacunaap = new EfectoVacuna(randomNumberVacuna);
                            efectovacunaap.mostrarVacunaSeleccionada();
                            //Vacuna Pfizer
                            if(randomNumberVacuna==1){
                                efectovacunaap.informacionGeneral();
                                System.Console.WriteLine(terminos);
                                var aceptacion = Console.ReadLine();
                                if(aceptacion=="Si"||aceptacion=="s"||aceptacion=="Sí"||aceptacion=="si"){
                                    System.Console.WriteLine(quedosis);
                                    var opciondosis = Console.ReadLine();
                                    int dosiselegida = int.Parse(opciondosis);
                                    efectovacunaap.inyectar(dosiselegida,randomNumberVacuna);
                                }
                                else if(aceptacion=="No"||aceptacion=="n"||aceptacion=="no"){
                                    System.Console.WriteLine(noacepto);
                                }
                            }
                            //Vacuna AztraZeneca
                            else if(randomNumberVacuna==2){ 
                                efectovacunaap.informacionGeneral();
                                System.Console.WriteLine(terminos);
                                var aceptacion = Console.ReadLine();
                                if(aceptacion=="Si"||aceptacion=="s"||aceptacion=="Sí"||aceptacion=="si"){
                                    System.Console.WriteLine(quedosis);
                                    var opciondosis = Console.ReadLine();
                                    int dosiselegida = int.Parse(opciondosis);
                                    string vacunaAztra = randomNumberVacuna.ToString();
                                    efectovacunaap.inyectar(dosiselegida,vacunaAztra);
                                }
                                else if(aceptacion=="No"||aceptacion=="n"||aceptacion=="no"){
                                    System.Console.WriteLine(noacepto);
                                }
                            }
                            //Vacuna Sputnik V
                            else if(randomNumberVacuna==3){
                                efectovacunaap.informacionGeneral();
                                System.Console.WriteLine(terminos);
                                var aceptacion = Console.ReadLine();
                                if(aceptacion=="Si"||aceptacion=="s"||aceptacion=="Sí"||aceptacion=="si"){
                                    System.Console.WriteLine(quedosis);
                                    var opciondosis = Console.ReadLine();
                                    int dosiselegida = int.Parse(opciondosis);
                                    string vacunaSputnik = randomNumberVacuna.ToString();
                                    efectovacunaap.inyectar(vacunaSputnik, dosiselegida);
                                }
                                else if(aceptacion=="No"||aceptacion=="n"||aceptacion=="no"){
                                    System.Console.WriteLine(noacepto);
                                }

                            }
                        break;
                        case 2 when (elegirVacuna==2):
                            //La aplicación elige de forma aleatoria: 1.- Pfizer, 2.- AztraZeneca, 3.- Sputnik V
                            var randomNumber = new Random().Next(1, 4);
                            EfectoVacuna efectovacuna = new EfectoVacuna(randomNumber);
                            if(randomNumber==1){
                                // System.Console.WriteLine("*** "+randomNumber+".- Pfizer***");
                                efectovacuna.mostrarVacunaSeleccionada();
                                efectovacuna.efectosPfizer();
                            }
                            else if(randomNumber==2){
                                // System.Console.WriteLine("*** "+randomNumber+".- AztraZeneca***");
                                efectovacuna.mostrarVacunaSeleccionada();
                                efectovacuna.efectosAztraZeneca();
                            }
                            else if(randomNumber==3){
                                // System.Console.WriteLine("*** "+randomNumber+".- Sputnik V***");
                                efectovacuna.mostrarVacunaSeleccionada();
                                efectovacuna.efectosSputnikV();
                            }
                        break;
                        case 3 when (elegirVacuna==3):
                            System.Console.WriteLine("Haz elegir salir. Hasta luego.");
                            Environment.Exit(0);
                        break;
                    }
                }
                while(elegirVacuna==1||elegirVacuna==2||elegirVacuna==3);
            }
        }
    }
}
