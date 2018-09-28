using System.Collections.Generic;

namespace TrabalhoChamados.Models
{
    public interface ISituacaoRepository
    {
        void Create(Situacao situacao);
        List<Situacao> GetAll();
        void Update(Situacao situacao);
        Situacao GetById(int id);
    }
}