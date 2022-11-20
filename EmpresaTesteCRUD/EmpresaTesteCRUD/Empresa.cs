using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Empresa
{

    private static int cont = 1;
    private int id;
    private string nome;
    private string telefone;

    public Empresa(string nome, string telefone)
    {
        this.id = cont++;
        this.nome = nome;
        this.telefone = telefone;
    }

    public Empresa()
    {
        this.id = cont++;
    }

    public int getId()
    {
        return this.id;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public void setTelefone(string telefone)
    {
        this.telefone = telefone;
    }

    public string getNome()
    {
        return this.nome;
    }

    public string getTelefone()
    {
        return this.telefone;
    }

    public string toString()
    {
        return "Empresa:{id:" + this.id + ", nome:" + this.nome + ", telefone:" + this.telefone + "}";
    }

}

