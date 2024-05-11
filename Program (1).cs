namespace Batata {
    public class Program {

        static List<string> itens = new List<string>();

        static void Main(){
            int op = 0;
            do {
                Console.WriteLine("1 - (C) Criar um nome");
                Console.WriteLine("2 - (R) Ler os nomes");
                Console.WriteLine("3 - (U) Alterar um nome");
                Console.WriteLine("4 - (D) Deletar um nome");
                Console.WriteLine("5 - Para sair");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op) {
                    case 1:
                        CriarNome();
                        break;
                    case 2:
                        LerNomes();
                        break;
                    case 3:
                        AlterarNome();
                        break;
                    case 4:
                        DeletarNome();
                        break;
                    case 5:
                        Console.WriteLine("Tchau - Até mais.");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida.");
                        break;
                }

            }while(op != 5);
        }

        static void CriarNome() {
            Console.WriteLine("Digite um nome: ");
            string nome = Console.ReadLine() ?? "";
            itens.Add(nome);
            Console.WriteLine($"O nome: {nome}, foi adicionado com sucesso");
        }

        static void LerNomes() {
            // foreach (string item in itens) {
            //     Console.WriteLine(item);
            // }
            // itens.ForEach(item => {
            //     Console.WriteLine(item);
            // });

            if (itens.Count > 0) {
                Console.WriteLine("-------- Os nomes são ---------");
                itens.ForEach(Console.WriteLine);
                Console.WriteLine("-------------------------------");
            } else {
                Console.WriteLine("Lista de nomes está vazia.");
            }
            
        }

        static void AlterarNome() {
            Console.WriteLine("Informe o indice para alterar: ");
            int indice = Convert.ToInt32(Console.ReadLine());
            if (indice >= 0 && indice < itens.Count){
                Console.WriteLine("Informe o novo nome: ");
                string novoNome = Console.ReadLine() ?? "";
                string nomeAntigo = itens[indice];
                itens[indice] = novoNome;
                Console.WriteLine($"Nome alterado de {nomeAntigo} para {novoNome}");
            } else {
                Console.WriteLine("Indice inválido.");
            }
        }

        static void DeletarNome() {
            Console.WriteLine("Informe o indice para deletar: ");
            int indice = Convert.ToInt32(Console.ReadLine());
            if (indice >= 0 && indice < itens.Count){
                itens.RemoveAt(indice);
                Console.WriteLine("Deletado com sucesso");
            } else {
                Console.WriteLine("Indice inválido.");
            }
        }
    }
}