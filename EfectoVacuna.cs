 using System;
class EfectoVacuna:Vacuna{

    public static string description="Sus posibles efectos secundarios son los siguientes:\n";
    public static string efectoPfizer="1.- En zona de administración: hinchazón, dolor.\n2.- Escalofrío.\n3.- Fiebre(Más elevada después de la 2da dosis).";
    public static string efectoAztraZeneca="1.- En zona de administración: Sensibilidad, dolor, calor, prurito, moratón.\n2.- Escalofríos, febrícula, malestar, fatiga, nauseas.\n3.- Mialgia, artralgia.";
    public static string efectoSputnikV="1.- Fiebre, cefalea y/o mialgias.\n2.- Dolor en zona de administración, hiperemia, hinchazón.\n3.- Síntomas gastrointestinales.";
    public static string informacionPfizer="***Pfizer-Biontech***\nOrigen: US, GER\nEfectividad: 95%\nCosto: 19USD\nCaracterística: El mensaje se codifica en una molécula de ARN que se encapsula en una membrana lipídica para que pueda entrar en las células.";
    public static string informacionAztraZeneca="***U de OXFORD ASTRAZENECA***\nOrigen: UK,SWE\nEfectividad: 70%\nCosto: 2.8USD\nCaracterística: El mensaje se codifica en un ADN, otro lenguaje genético, y se introduce en adenovirus del resfriado de los chimpancés.";
    public static string informacionSputnikV="***SPUTNIK V***\nOrigen: RU\nEfectividad: 92%\nCosto: 10USD\nCaracterística: El gen del adenovirus, se sustrae y en su lugar se inserta un gen con el código de la proteína de otro virus.";
    public static string aplicarPrimeraDosis ="Haz elegido aplicar la primera dosis.";
    public static string aplicarSegundaDosis="Haz elegido aplizar la segunda dosis.";
    public static string procesoPfizer="Con esta vacuna el ARN entra en las células humanas y hace que fabriquen proteínas de la espícula del coronavirus.\nLa espícula del virus es localizada por las células dendríticas: Se genera la respuesta inmune y se producen dos tipos de glóbulos blancos:\nlinfocitos B: Crean anticuerpos que bloquean el virus\nlinfocitos T: Destruye las células infectadas)";
    public static string procesoAztraZeneca="Con esta vacuna el ADN se copia en un ARN en el núcleo, el cual migra al citoplasma en donde, a partir de este, se producen o se fabrican las proteínas virales. La espícula del virus es localizada por las células dendtríticas. : Se genera la respuesta inmune y se producen dos tipos de glóbulos blancos:\nlinfocitos B: Crean anticuerpos que bloquean el virus\nlinfocitos T: Destruye las células infectadas)";
    public static string procesoSputnikV="El gen del adenovirus, se sustrae y en su lugar se inserta un gen con el código de la proteína de otro virus.";
    public static string finalPrimeraDosis="La aplicación de la primera dosis ha sido finalizada";
    public static string finalSegundaDosis ="La aplicación de la segunda dosis ha finalizado.\nSigue cuidándote y ciuda a tus seres queridos #QuedateEnCasa";
    public static string dias21= "Se deberá aplicar la segunda dosis dentro de 21 días.";
    public static string dias90="Se deberá aplicar la segunda dosis hasta dentro de 90 días.";
    public static string fechaSiguiente="La fecha de aplicación de la segunda dosis es: \n";
        
    public EfectoVacuna(int vacunaSeleccionadaAleatoria):base(vacunaSeleccionadaAleatoria){ }

    public override string efectosPfizer()
    {
        if(vacunaSeleccionada==1){  
            System.Console.WriteLine(description+"\n"+efectoPfizer+"\n");
        }
        return base.vacunaSeleccionada+"";
    }
    public override string efectosAztraZeneca()
    {
        if(vacunaSeleccionada==2){
            System.Console.WriteLine(description+"\n"+efectoAztraZeneca+"\n");
        }
        return base.vacunaSeleccionada+"";
    }
    public override string efectosSputnikV()
    {
        if(vacunaSeleccionada==3){
            System.Console.WriteLine(description+"\n"+efectoSputnikV+"\n");
        }
        return base.vacunaSeleccionada+"";
    }

    public void informacionGeneral(){
        if(vacunaSeleccionada==1){ System.Console.WriteLine(informacionPfizer); }
        if(vacunaSeleccionada==2){ System.Console.WriteLine(informacionAztraZeneca); }
        if(vacunaSeleccionada==3){ System.Console.WriteLine(informacionSputnikV); }
    }

    public int inyectar(int dosisElegida, int vacunaPfizer)
    {
        if(dosisElegida==1){
            System.Console.WriteLine(aplicarPrimeraDosis+"\n"+procesoPfizer);
            System.Console.WriteLine(finalPrimeraDosis);
            System.Console.WriteLine(dias21);
            var diasAgregados = DateTime.Now.AddDays(21);
            System.Console.WriteLine(fechaSiguiente+diasAgregados);
        }
        else if(dosisElegida==2){
            System.Console.WriteLine(aplicarSegundaDosis+"\n"+procesoPfizer);
            System.Console.WriteLine(finalSegundaDosis);
        }
        return dosisElegida;
    }
    public int inyectar(int dosisElegida, string vacunaAztraZeneca)
    {
        if(dosisElegida==1){
            System.Console.WriteLine(aplicarPrimeraDosis+"\n"+procesoAztraZeneca);
            System.Console.WriteLine(finalPrimeraDosis);
            System.Console.WriteLine(dias90);
            var diasAgregados = DateTime.Now.AddDays(90);
            System.Console.WriteLine(fechaSiguiente+diasAgregados);
        }
        else if(dosisElegida==2){
            System.Console.WriteLine(aplicarSegundaDosis+"\n"+procesoAztraZeneca);
            System.Console.WriteLine(finalSegundaDosis);
        }
        return dosisElegida;
    }
    public int inyectar(string vacunaSputnik, int dosisElegida)
    {
        if(dosisElegida==1){
            System.Console.WriteLine(aplicarPrimeraDosis+"\n"+procesoSputnikV);
            System.Console.WriteLine(finalPrimeraDosis);
            System.Console.WriteLine(dias21);
            var diasAgregados = DateTime.Now.AddDays(21);
            System.Console.WriteLine(fechaSiguiente+diasAgregados);
        }
        else if(dosisElegida==2){
            System.Console.WriteLine(aplicarSegundaDosis+"\n"+procesoSputnikV);
            System.Console.WriteLine(finalSegundaDosis);
        }
        return dosisElegida;
    }
    
}