abstract class Vacuna{
    //Declaración de datos miembro
    protected int vacunaSeleccionada;
    public static string elegida = "*** La vacuna elegida es ";
    public static string pfizer="Pfizer ***";
    public static string aztrazeneca="AztraZeneca ***";
    public static string sputnik="Sputnik V ***";
    //Método Vacuna con Parámetros
    public Vacuna(int VacunaSeleccionada){
        vacunaSeleccionada=VacunaSeleccionada;
    }
    //Método para mostrar la vacuna elegida
    public void mostrarVacunaSeleccionada(){
        if(vacunaSeleccionada==1){
            System.Console.WriteLine(elegida+pfizer);
        }
        else if(vacunaSeleccionada==2){
            System.Console.WriteLine(elegida+aztrazeneca);
        }
        else if(vacunaSeleccionada==3){
            System.Console.WriteLine(elegida+sputnik);
        }
    }
    //Métodos abstractos
    public abstract string efectosPfizer();
    public abstract string efectosAztraZeneca();
    public abstract string efectosSputnikV();
    //Interfaz para vacuna asignada
    public int datoVacuna{
        get{
            return vacunaSeleccionada;
        }
        set{
            vacunaSeleccionada=value;
        }
    }
    //Destructor
    ~Vacuna(){
        vacunaSeleccionada=0;
    } 

}