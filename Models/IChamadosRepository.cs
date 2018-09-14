using System.Collections.Generic;

namespace TrabalhoChamados.Models
{
    public interface IChamadosRepository
    {
         void Create(Chamados chamados);
         List<Chamados> GetAll();
         void Update(Chamados chamados);
         Chamados GetById(int id);
         void Delete (int id);
    }
}