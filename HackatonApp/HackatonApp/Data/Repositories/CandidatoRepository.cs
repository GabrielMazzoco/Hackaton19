using System.Collections.Generic;
using System.Linq;
using HackatonApp.Entities;

namespace HackatonApp.Data.Repositories
{
    public class CandidatoRepository : ICandidatoRepository
    {
        private readonly DataContext _dbContext;

        public CandidatoRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Candidato> GetCandidatos()
        {
            return _dbContext.Candidatos;
        }

        public Candidato GetCandidato(int idCandidato)
        {
            return _dbContext.Candidatos.FirstOrDefault(x => x.Id == idCandidato);
        }

        public Candidato RegisterCandidato(Candidato candidato)
        {
            _dbContext.Candidatos.Add(candidato);

            _dbContext.SaveChanges();

            return candidato;
        }

        public Candidato UpdateCandidato(Candidato candidato)
        {
            _dbContext.Candidatos.Update(candidato);

            _dbContext.SaveChanges();

            return candidato;
        }

        public void DeleteCandidato(int idCandidato)
        {
            var candidato = _dbContext.Candidatos.FirstOrDefault(x => x.Id == idCandidato);

            if (candidato == null) return;

            _dbContext.Candidatos.Remove(candidato);

            _dbContext.SaveChanges();
        }
    }
}
