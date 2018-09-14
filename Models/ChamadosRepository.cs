using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TrabalhoChamados.Models
{
    public class ChamadosRepository : IChamadosRepository
    {
        private DataContext dataContext;
        public ChamadosRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Create(Chamados chamados){
            chamados.duracao = chamados.horafinal.Subtract(chamados.horainicio);
            dataContext.Add(chamados);
            dataContext.SaveChanges();
        }
        public List<Chamados> GetAll()
        {
            return dataContext.Chamados.ToList();
        }

        public void Update(Chamados chamados)
        {
           chamados.duracao = chamados.horafinal.Subtract(chamados.horainicio);
           dataContext.Entry(chamados).State = EntityState.Modified;

            dataContext.SaveChanges();
        }

        public Chamados GetById(int id)
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