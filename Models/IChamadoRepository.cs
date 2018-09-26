using System.Collections.Generic;

namespace TrabalhoChamados.Models
{
    public interface IChamadoRepository
    {
         void Create(Chamado chamado);
         List<Chamado> GetAll();
         void Update(Chamado chamado);
         Chamado GetById(int id);
         void Delete (int id);
    }
}