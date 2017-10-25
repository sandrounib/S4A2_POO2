using System;

namespace S4A2_POO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "Sandro";
            p1.idade = 25;
            p1.end = new Endereco();
            p1.end.bairro="Vila São josé";
            p1.end.numero = 104;
            p1.end.rua = "Divina Comédia";
            
            p1.MostrarPessoa(p1);

            
        }
    }
}
