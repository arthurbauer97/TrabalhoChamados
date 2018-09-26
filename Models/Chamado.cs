using System;

namespace TrabalhoChamados.Models
{
    public class Chamado
    {
        public Chamado(){}

        public Chamado(int id,string descricao, DateTime data, DateTime datasolucao, TimeSpan horainicio, TimeSpan horafinal)
        {
            this.id = id;   
            this.descricao = descricao;
            this.data = data;
            this.datasolucao = datasolucao;
            this.horainicio = horainicio;
            this.horafinal = horafinal;
        }   
        public int id { get; set; }
        public DateTime data { get; set; }
        public string descricao{get; set;}
        public DateTime datasolucao { get; set; }
        public TimeSpan horainicio { get; set; }
        public TimeSpan horafinal { get; set; }
        public TimeSpan duracao { get; set; }
        public Cliente cliente {get; set;}
         public Situacao tiposituacao {get; set;}
        }
    }
