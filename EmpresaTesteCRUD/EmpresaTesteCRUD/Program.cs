using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTesteCRUD
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Empresa> empresas = new List<Empresa>();
            string op;

            do
            {
                op = getMenuOp();

                switch (op)
                {
                    case "1":
                        listarEmpresas(empresas);
                        break;
                    case "2":
                        empresas = cadastrarEmpresa(empresas);
                        break;
                    case "3":
                        empresas = editarEmpresa(empresas);
                        break;
                    case "4":
                        empresas = deletarEmpresa(empresas);
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente");
                        break;
                }

            } while (!op.Equals("5"));
        }

        static void listarEmpresas(List<Empresa> empresas)
        {
            empresas.ForEach(empresa => Console.WriteLine(empresa.toString()));
        }

        static List<Empresa> cadastrarEmpresa(List<Empresa> empresas)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            empresas.Add(new Empresa(nome, telefone));
            return empresas;
        }

        static List<Empresa> editarEmpresa(List<Empresa> empresas)
        {

            Console.Write("Informe o id da empresa que deseja editar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Boolean exists = false;

            for (int i = 0; i < empresas.Count; i++)
            {
                if (empresas[i].getId() == id)
                {
                    exists = true;
                    Empresa empresa = empresas[i];

                    Console.Write("Informe o novo nome da empresa: ");
                    string novoNome = Console.ReadLine();
                    Console.Write("Informe o novo telefone da empresa: ");
                    string novoTelefone = Console.ReadLine();

                    empresa.setNome(novoNome);
                    empresa.setTelefone(novoTelefone);
                    empresas[i] = empresa;
                }
            }

            if (!exists)
            {
                Console.WriteLine("Não existe empresa com este id");
            }

            return empresas;
        }

        static List<Empresa> deletarEmpresa(List<Empresa> empresas)
        {

            Console.Write("Informe o id da empresa que deseja deletar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Boolean exists = false;

            for (int i = 0; i < empresas.Count; i++)
            {
                if (empresas[i].getId() == id)
                {
                    exists = true;
                    empresas.RemoveAt(i);
                }
            }

            if (!exists)
            {
                Console.WriteLine("Não existe empresa com este id");
            }

            return empresas;
        }

        static string getMenuOp()
        {
            Console.WriteLine("1 - Listar empresas");
            Console.WriteLine("2 - Cadastrar empresa");
            Console.WriteLine("3 - Editar empresa");
            Console.WriteLine("4 - Deletar empresa");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha a opção desejada: ");
            return Console.ReadLine();
        }

    }
}