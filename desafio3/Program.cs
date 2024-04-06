public class Program{
    public static void Main(string[] args){

Console.WriteLine("hola");
        bool validacion = true;
        int opcion;
        List<string> lista = new List<string>(){};

        do{
            Console.Clear();
            Console.WriteLine(@"
                -----------------------
                Menu Administrador
                ----------------------

                1. Mostrar
                2. Agregar
                3. Eliminar
                4. Salir
            ");



            opcion = int.Parse(Console.ReadLine());

            switch(opcion){
                case 1: 
                    Console.WriteLine("-------TAREAS DISPONIBLES-------");
                    foreach(string elemento in lista){
                        Console.WriteLine(elemento);
                    }
                
                    break;


                case 2:
                    Console.WriteLine("Escribe la tarea que deseas agregar: ");
                    string tareaPorAgregar = Console.ReadLine();
                    lista.Add(tareaPorAgregar);

                    break;

                case 3:
                    Console.WriteLine("Escribe la tarea que deseas eliminar: ");
                    string tareaPorEliminar = Console.ReadLine();

                    lista.Remove(tareaPorEliminar);

                    break;


                case 4: validacion = false; break;

                        
            }

            Console.ReadKey(true);
            

        } 


        while(validacion);
    }
}