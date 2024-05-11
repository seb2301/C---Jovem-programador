namespace Batata {
    public class Usuario {
        public string Login { get; set; }
        public string Senha { get; set; }

        public virtual void Logar() {
            Console.WriteLine("Bem-vindo(a) ao sistema");
        }
    }
}