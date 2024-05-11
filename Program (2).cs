namespace Batata
{
    public class Program
    {

        static List<Pessoa> pessoas = new List<Pessoa>();
        // |                            |

        static void Main()
        {
            int op = 0;

            do
            {
                Console.WriteLine("Informe o que vc gostaria de fazer");
                Console.WriteLine("1 - Criar Pessoa");
                Console.WriteLine("2 - Listar Pessoas");
                Console.WriteLine("3 - Alterar Pessoa");
                Console.WriteLine("4 - Deletar Pessoa");
                Console.WriteLine("5 - Detalhar Pessoa");
                Console.WriteLine("6 - Fechar programa");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        CriarPessoa();
                        break;
                    case 2:
                        break;
                    case 3:
                        AlterarPessoa();
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        Console.WriteLine("Tchau");
                        break;

                    default:
                        Console.WriteLine("Op inválida");
                        break;
                }


            } while (op != 6);
        }

        public static void CriarPessoa()
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Informe o Nome da pessoa: ");
            pessoa.Nome = Console.ReadLine() ?? "";
            Console.WriteLine("Informe o Altura da pessoa: ");
            pessoa.Altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o Peso da pessoa: ");
            pessoa.Peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o Cpf da pessoa: ");
            pessoa.Cpf = Console.ReadLine() ?? "";
            Console.WriteLine("Informe o Idade da pessoa: ");
            pessoa.Idade =  Convert.ToInt32(Console.ReadLine());

            pessoas.Add(pessoa);
        }
        
        static void AlterarPessoa() {
            Console.WriteLine("Informe o indice para alterar: ");
            int indice = Convert.ToInt32(Console.ReadLine());

            if (indice >= 0 && indice < pessoas.Count){
                // Pessoa pessoa = pessoas[indice];

                // Console.WriteLine("Informe o novo nome: ");
                // pessoa.Nome = Console.ReadLine() ?? "";
                // Console.WriteLine("Informe a nova altura: ");
                // pessoa.Altura = Convert.ToDouble(Console.ReadLine());
                
                // pessoas[indice] = pessoa;
                Console.WriteLine("Informe o novo nome: ");
                pessoas[indice].Nome = Console.ReadLine() ?? "";
                Console.WriteLine("Informe a nova altura: ");
                pessoas[indice].Altura = Convert.ToDouble(Console.ReadLine());
            } else {
                Console.WriteLine("Indice inválido.");
            }
        }
    }
}