using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TrabalhoChamados.Models
{
    public class ChamadoRepository : IChamadoRepository
    {
        private DataContext dataContext;
        public ChamadoRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Create(Chamado chamado){
            chamado.cliente = dataContext.Clientes.Find(chamado.cliente.id);
            dataContext.Add(chamado);
            dataContext.SaveChanges();
        }
        public List<Chamado> GetAll()
        {
            return dataContext.Chamados.Include(s => s.cliente).ToList();
        }

        public void Update(Chamado chamado)
        {
        chamado.duracao = chamado.horafinal.Subtract(chamado.horainicio);
        dataContext.Entry(chamado).State = EntityState.Modified;
        dataContext.SaveChanges();
        }

        public Chamado GetById(int id)
        {
            return dataContext.Chamados.SingleOrDefault(x=>x.id == id);
        }
        public void Delete(int id)
        {
            dataContext.Remove(GetById(id));
            dataContext.SaveChanges();
        }

    }
}