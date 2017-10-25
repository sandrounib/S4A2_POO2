public class Endereco{
    public string bairro { get; set; }
    public string rua { get; set; }
    public int numero { get; set; }

    public void MostrarEndereco(string bairro_,string rua_,int numero_){
        System.Console.WriteLine(bairro_ + "-" + rua_ + "-" + numero_);

    }
}