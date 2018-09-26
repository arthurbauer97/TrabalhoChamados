using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TrabalhoChamados.Models
{
    public class ClienteRepository : IClienteRepository
     {
        private DataContext dataContext;

        public ClienteRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Create(Cliente cliente)
        {
            dataContext.Clientes.Add(cliente);
            dataContext.SaveChanges();
        }

        public List<Cliente> GetAll()
        {
            return dataContext.Clientes.ToList();
        }

           public void Update(Cliente cliente)
        {
           dataContext.Entry(cliente).State = EntityState.Modified;
            dataContext.SaveChanges();
        }

         public Cliente GetById(int id)
        {
            return dataContext.Clientes.SingleOrDefault(x=>x.id == id);
        }
        public void Delete(int id)
        {
            dataContext.Remove(GetById(id));
            dataContext.SaveChanges();
        }
    }
}