namespace Batata {
    public class Program {
        static void Main(){
            Pessoa[] pessoas = new Pessoa[2];

            for(int i = 0; i <= 1; i++){
                pessoas[i] = new Pessoa();
                Console.WriteLine("Informe o seu nome: ");
                pessoas[i].Nome = Console.ReadLine();

                Console.WriteLine("Informe seu login: ");
                pessoas[i].Login = Console.ReadLine();
                Console.WriteLine("Informe sua senha: ");
                pessoas[i].Senha = Console.ReadLine();

                Console.WriteLine("Informe o seu idade: ");
                pessoas[i].Idade = Convert.ToInt32(Console.ReadLine());
            }

            pessoas[1].Logar();
        }
    }
}