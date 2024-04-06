using System.Globalization;
using System.Data;
using System.Runtime.ExceptionServices;

namespace juego;


public class Tablero{
    public string[,] tablero;


    public Tablero(){
        this.tablero = new string[3,3];
        this.InicializarTablero();
    }

     public void InicializarTablero(){
        for (int i = 0; i < tablero.GetLength(0); i++){
            for (int j = 0; j < tablero.GetLength(1); j++){
                    tablero[i,j] = "_";
                }
            }
        }
    

    public void mostrarTablero(){
        for (int i = 0; i < tablero.GetLength(0); i++){
            for (int j = 0; j < tablero.GetLength(1); j++){
                Console.Write("\t [" +tablero[i,j] + "]");
                if (j == tablero.GetLength(1)-1 ){
                    Console.WriteLine();
                }
            }
        }


        
    }



    public bool MarcarPosicion(int fila, int columna, string jugador){
        if (tablero[fila, columna] != "_"){
            Console.WriteLine("Ya hay una posicion Ocupada");
            return false;
        }

        tablero[fila, columna] = jugador;
        return true;
    }



}

public class Jugador{
    public string ficha{get;}

    public Jugador(string ficha){
        this.ficha = ficha;
    }

}

public class Juego{

    private Jugador jugador1;
    private Jugador jugador2;

    private Tablero tablero;

    private int contador;
    private string [] bienvenida;


    public Juego(){
        this.jugador1 = new Jugador("X");
        this.jugador2 = new Jugador("O");
        this.tablero = new Tablero();

        this.Iniciar();
    }


    private void Iniciar(){
        bool jugar = true;
        string posicion;

        do{
            Console.Clear();
            string palabrasJuego = @"



┏┳┓┏┓┏┳┓┳┏┳┓┏┓  ┳┓     ┏┓          
 ┃ ┃┃ ┃ ┃ ┃ ┃┃  ┣┫┓┏•  ┣ ┏┓┏┓┏┓┏┓┏┓
 ┻ ┗┛ ┻ ┻ ┻ ┗┛  ┻┛┗┫•  ┻ ┗ ┛ ┛┗┗┻┛┗
                   ┛             
";
        Console.WriteLine($"{palabrasJuego}");

        tablero.mostrarTablero();
        Jugador jugadorActual = contador%2==0? jugador1 : jugador2;
        Console.WriteLine("JUEGAAA!");
        Console.WriteLine($"Tu ficha es {jugadorActual.ficha}");
        Console.Write("Elige una posicion para jugar estilo 1,1 o 2,2 par marcar donde quieres: ");
        posicion = Console.ReadLine();
        procesarJugada(posicion,jugadorActual.ficha);
        if (procesarSiGano(jugadorActual.ficha, tablero)){
            break;
        }
        ++this.contador;
        
        }while(jugar);
        
        
        
    }



    private void procesarJugada(string posicion, string jugador){
        string[] dimensiones = posicion.Split(",");
        int dimensionUno = int.Parse(dimensiones[0]);
        int dimensionDos = int.Parse(dimensiones[1]);


        this.tablero.MarcarPosicion(dimensionUno-1, dimensionDos-1, jugador);
        
    }


    private bool procesarSiGano(string jugador, Tablero tablero){
        
        //validacion horizontal

        if (tablero.tablero[0,0] == jugador &&  tablero.tablero[0,1] == jugador &&  tablero.tablero[0,2] == jugador  ){
            Console.WriteLine($"Gano {jugador}");
            return true;
        }

        else if (tablero.tablero[1,0] == jugador &&  tablero.tablero[1,1] == jugador &&  tablero.tablero[1,2] == jugador  ){
            Console.WriteLine($"Gano {jugador}");
            return true;
        }

        else if (tablero.tablero[2,0] == jugador &&  tablero.tablero[2,1] == jugador &&  tablero.tablero[2,2] == jugador  ){
            Console.WriteLine($"Gano {jugador}");
            return true;
        }


        //validacion vertical

        if (tablero.tablero[0,0] == jugador && tablero.tablero[1,0] == jugador && tablero.tablero[2,0] == jugador){
            Console.WriteLine($"Gano {jugador}");
            return true;
        }

        else if (tablero.tablero[0,1] == jugador && tablero.tablero[1,1] == jugador && tablero.tablero[2,1] == jugador){
            Console.WriteLine($"Gano {jugador}");
            return true;
        }

        else if (tablero.tablero[0,2] == jugador && tablero.tablero[1,2] == jugador && tablero.tablero[2,2] == jugador){
            Console.WriteLine($"Gano {jugador}");
            return true;
        }
        



        //validacion diagonal

         if (tablero.tablero[0,0] == jugador && tablero.tablero[1,1] == jugador && tablero.tablero[2,2] == jugador){
            Console.WriteLine($"Gano {jugador}");
            return true;
        }
        if (tablero.tablero[0,2] == jugador && tablero.tablero[1,1] == jugador && tablero.tablero[2,0] == jugador){
            Console.WriteLine($"Gano {jugador}");
            return true;
        }


        return false;

    }
    



}