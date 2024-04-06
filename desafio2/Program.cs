class Program{
    public static void Main(string[] args){

        int [,] numeros = new int[5,5];
        
        CalcularCompras(numeros);

        Console.ReadKey(true);
    }


    //metodo que reciba un arreglo bidimensional



    public static void CalcularCompras(int[,] listaCompras){
            int[] precioFinalClientes = new int [ listaCompras.GetLength(0)];



            for (int i = 0; i < listaCompras.GetLength(0);i++){
                for (int j = 0; j < listaCompras.GetLength(1);j++){
                    Console.WriteLine($"Ingresa el precio del cliente {i +1} de la Compra No.{j+1}: ");
                    listaCompras[i,j] = int.Parse(Console.ReadLine());
                    precioFinalClientes[i] += listaCompras[i,j];

                
                }
            }


            for ( int i = 0; i < precioFinalClientes.Length; i++){
                if (precioFinalClientes[i] <= 99){
                    Console.WriteLine($" cliente {i+1} no aplica descuento");
                }

                else if (precioFinalClientes[i] >=100 && precioFinalClientes[i]<=1000){
                    Console.WriteLine($" cliente {i+1} si aplico al descuento del 10% que tendria un precio final de: { precioFinalClientes[i]-(precioFinalClientes[i] * 0.1) }");

                }
                else if (precioFinalClientes[i] >=1000){
                    Console.WriteLine($" cliente {i+1} si aplico al descuento del 20% que tendria un precio final de: {precioFinalClientes[i]-(precioFinalClientes[i] * 0.2)}");

                }

            }
        


    }


}