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
            chamado.situacao = dataContext.Situacoes.Find(chamado.situacao.id);
            dataContext.Chamados.Add(chamado);
            dataContext.SaveChanges();
        }
        public List<Chamado> GetAll()
        {   
            return dataContext.Chamados.Include(s => s.situacao).Include(c => c.cliente).ToList();
        }

         public Chamado GetById(int id)
        {
            return dataContext.Chamados.Include(s => s.situacao).Include(c => c.cliente).SingleOrDefault(x => x.id == id);
           
        }
        public void Update(Chamado chamado)
        {
        chamado.duracao = chamado.horafinal.Subtract(chamado.horainicio);
        chamado.situacao = dataContext.Situacoes.Find(chamado.situacao.id);
        dataContext.Entry(chamado).State = EntityState.Modified;
        dataContext.SaveChanges();
        }

        public void Delete(int id)
        {
            dataContext.Remove(GetById(id));
            dataContext.SaveChanges();
        }

    }
}