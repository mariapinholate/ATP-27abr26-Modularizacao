class Exemplo {
    public static void Rodar(){
        int x,y,z;

        Console.WriteLine("Digite o lado x: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o lado y: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o lado z: ");
        z = Convert.ToInt32(Console.ReadLine());

        if(x < y + z && y < x + z && z < x + y ){
            if( x == y && y == z){
            Console.WriteLine("Triangulo Equilatero");
            }
            else if (x == y  || x == z || y == z ){
                Console.WriteLine("Triangulo Isosceles");
            }
           
            else{
                Console.WriteLine("Triangulo Escaleno (ou triangulo qualquer)");
            }

        }
        else {
            Console.WriteLine("Os valores não formam um triangulo");
        }
        
      
    }
}