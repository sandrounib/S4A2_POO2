public class  Pessoa{
    public string nome { get; set; }
    public int idade { get; set; }    
    public Endereco end { get; set; }

    public void MostrarPessoa(Pessoa p){
        System.Console.WriteLine(p.end);
        System.Console.WriteLine(p.nome);
        System.Console.WriteLine(p.idade);
        System.Console.WriteLine(p.end.bairro);
        System.Console.WriteLine(p.end.numero);
        System.Console.WriteLine(p.end.rua);
        
        

    }

}
