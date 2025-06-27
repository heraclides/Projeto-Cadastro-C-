using System;

namespace ClientLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar;

            //repetição para cadastrar varios clientes
            do
            {
                float val_pag;

                Console.WriteLine("\n========== Cadastro de Cliente ==========\n");

                Console.WriteLine("Informar Nome:");
                string var_nome = Console.ReadLine();

                Console.WriteLine("Informar Endereço:");
                string var_endereco = Console.ReadLine();

                string var_tipo = "";

                //evita que o programa seja encerrado de forma insperada
                while (var_tipo != "f" && var_tipo != "j")
                {
                    Console.Write("Pessoa Física (f) ou Jurídica (j)? ");
                    var_tipo = Console.ReadLine().ToLower();

                    if (var_tipo != "f" && var_tipo != "j")
                    {
                        Console.WriteLine("Opção inválida. Digite apenas 'f' ou 'j'.");
                    }
                }

                if (var_tipo == "f")
                {
                    Pessoa_Fisica pf = new Pessoa_Fisica();
                    pf.nome = var_nome;
                    pf.endereco = var_endereco;

                    Console.WriteLine("Informar CPF: ");
                    pf.cpf = Console.ReadLine();

                    Console.WriteLine("Informar RG: ");
                    pf.rg = Console.ReadLine();

                    Console.WriteLine("Informar Valor de Compra: ");
                    val_pag = float.Parse(Console.ReadLine());

                    pf.Pagar_Imposto(val_pag);

                    Console.WriteLine("\n-------- Pessoa Física --------");
                    Console.WriteLine("Nome ..........: " + pf.nome);
                    Console.WriteLine("Endereço ......: " + pf.endereco);
                    Console.WriteLine("CPF ...........: " + pf.cpf);
                    Console.WriteLine("RG ............: " + pf.rg);
                    Console.WriteLine("Valor de Compra: " + pf.valor.ToString("C"));
                    Console.WriteLine("Imposto .......: " + pf.valor_imposto.ToString("C"));
                    Console.WriteLine("Total a Pagar : " + pf.total.ToString("C"));
                }
                else
                {
                    Pessoa_Juridica pj = new Pessoa_Juridica();
                    pj.nome = var_nome;
                    pj.endereco = var_endereco;

                    Console.WriteLine("Informar CNPJ: ");
                    pj.cnpj = Console.ReadLine();

                    Console.WriteLine("Informar IE: ");
                    pj.ie = Console.ReadLine();

                    Console.WriteLine("Informar Valor de Compra: ");
                    val_pag = float.Parse(Console.ReadLine());

                    pj.Pagar_Imposto(val_pag);

                    Console.WriteLine("\n-------- Pessoa Jurídica --------");
                    Console.WriteLine("Nome ..........: " + pj.nome);
                    Console.WriteLine("Endereço ......: " + pj.endereco);
                    Console.WriteLine("CNPJ ..........: " + pj.cnpj);
                    Console.WriteLine("IE ............: " + pj.ie);
                    Console.WriteLine("Valor de Compra: " + pj.valor.ToString("C"));
                    Console.WriteLine("Imposto .......: " + pj.valor_imposto.ToString("C"));
                    Console.WriteLine("Total a Pagar : " + pj.total.ToString("C"));
                }

                //pergunta se o atendente gostaria de cadastrar outro usuario ou finalizar
                Console.Write("\nDeseja cadastrar outro cliente? (s/n): ");
                continuar = Console.ReadLine().ToLower();

                while (continuar != "s" && continuar != "n")
                {
                    Console.Write("Resposta inválida. Digite 's' para sim ou 'n' para não: ");
                    continuar = Console.ReadLine().ToLower();
                }

            } while (continuar == "s");

            Console.WriteLine("\nPrograma encerrado. Obrigado por usar o sistema!");
        }
    }
}
