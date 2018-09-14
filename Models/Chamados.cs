using System;

namespace TrabalhoChamados.Models
{
    public class Chamados
    {
        public Chamados(){}

        public Chamados(int id, string numerochamado,string descricao, DateTime data, string nomesolicitante, string telefone, string email, DateTime datasolucao, TimeSpan horainicio, TimeSpan horafinal)
        {
            this.id = id;   
            this.descricao = descricao;
            this.numerochamado = numerochamado;
            this.data = data;
            this.nomesolicitante = nomesolicitante;
            this.telefone = telefone;
            this.email = email;
            this.datasolucao = datasolucao;
            this.horainicio = horainicio;
            this.horafinal = horafinal;
        }
        public int id { get; set; }
        public string numerochamado { get; set; }
        public DateTime data { get; set; }
        public string nomesolicitante { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string descricao{get; set;}
        public DateTime datasolucao { get; set; }
        public TimeSpan horainicio { get; set; }
        public TimeSpan horafinal { get; set; }
        public TimeSpan duracao { get; set; }
        }
    }
