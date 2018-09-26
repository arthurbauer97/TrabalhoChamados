using System.Collections.Generic;

namespace TrabalhoChamados.Models
{
    public interface IClienteRepository
    {
         
        void Create(Cliente cliente);
        List<Cliente> GetAll();
        void Update(Cliente cliente);
         Cliente GetById(int id);
         void Delete (int id);

    }
}