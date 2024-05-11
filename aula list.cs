namespace Batata {
    public class Program {
        static void Main(){
            Cachorro resposta = new Cachorro();

            Console.WriteLine("O nome do cachorro é:");
            resposta.Nome = Console.ReadLine();

            Console.WriteLine("e o seu dono é");
            resposta.Dono = Console.ReadLine();

            Console.WriteLine("Informe sua idade:");
            resposta.Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe Qtde brinquedos:");
            resposta.QtdeBrinquedos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fica dormindo? [1] - Sim [2] - Não");
            resposta.Dormindo = Convert.ToInt32(Console.ReadLine());
            if (resposta.Dormindo == 1){

            }else if (resposta.Dormindo == 2){
                
            }


        
        for (int i=0;i<=1;i++){
            
        }

            resposta.Apresentar(); 


            

        }
    }
}
