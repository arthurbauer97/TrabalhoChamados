namespace TrabalhoChamados.Models
{
    public class Situacao
    { 
    public Situacao(){}

    public Situacao(int id,string tiposituacao){
       this.id = id;
       this.tiposituacao = tiposituacao;
    }

    public int id {get; set;}
    public string tiposituacao {get; set;}

    }
}

    