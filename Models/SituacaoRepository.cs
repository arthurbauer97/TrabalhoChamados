using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TrabalhoChamados.Models
{
    public class SituacaoRepository : ISituacaoRepository
    {
        private DataContext dataContext;
        

        public SituacaoRepository(DataContext dataContext){
            this.dataContext = dataContext;
        }

        public void Create(Situacao situacao){
            dataContext.Add(situacao);
            dataContext.SaveChanges();
        }

        public List<Situacao> GetAll()
        {
            return dataContext.Situacoes.ToList();
        }

           public void Update(Situacao situacao)
        {
           dataContext.Entry(situacao).State = EntityState.Modified;
            dataContext.SaveChanges();
        }

         public Situacao GetById(int id)
        {
            return dataContext.Situacoes.SingleOrDefault(x=>x.id == id);
        }
        public void Delete(int id)
        {
            dataContext.Remove(GetById(id));
            dataContext.SaveChanges();
        }
    }
} 
