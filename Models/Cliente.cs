using System.Collections.Generic;

namespace TrabalhoChamados.Models
{
    public class Cliente
    {
        public Cliente(){}

        
    public Cliente(int id,string nomecliente,string email,string telefone){
       this.id = id;
       this.nomecliente = nomecliente;
       this.email = email;
       this.telefone = telefone;
    }

    public int id {get; set;}

    public string nomecliente {get; set;}

    public string email{get; set;}

    public string telefone {get; set;}

    }

}