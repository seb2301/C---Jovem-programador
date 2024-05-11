namespace Batata {
    public class Pessoa : Usuario {
        // Atributos da minha classe pessoa
        public string Nome { get; set; } = "Nome não informado";
        public double Altura { get; set; }
        public double Peso { get; set; }
        public string Cpf { get; set; } = "Cpf não informado";
        public int Idade { get; set; }

        // Metodos da minha classe pessoa
        public override void Logar() {
            Console.WriteLine($"Bem vindo ao sistema, {Nome}");
        }
        public void Apresentar(){
            Console.WriteLine($"Oi, meu nome é {Nome}, eu tenho {Idade} anos, Meu CPF: {Cpf}");
        }
        public void Andar(){
            Console.WriteLine("Estou andando");
        }
    }
}