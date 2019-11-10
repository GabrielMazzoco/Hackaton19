using System.Collections.Generic;
using HackatonApp.Data.Repositories;
using HackatonApp.Entities;

namespace HackatonApp.Services
{
    public class CandidatoService : ICandidatoService
    {
        private readonly ICandidatoRepository _candidatoRepository;

        public CandidatoService(ICandidatoRepository candidatoRepository)
        {
            _candidatoRepository = candidatoRepository;
        }

        public IEnumerable<Candidato> GetCandidatos()
        {
            var candidatos = _candidatoRepository.GetCandidatos();

            return candidatos;
        }

        public Candidato GetCandidato(int idCandidato)
        {
            var candidato = _candidatoRepository.GetCandidato(idCandidato);

            return candidato;
        }

        public Candidato RegisterCandidato(Candidato candidato)
        {
            var candidatoDb = _candidatoRepository.RegisterCandidato(candidato);

            return candidatoDb;
        }

        public Candidato UpdateCandidato(Candidato candidato)
        {
            var candidatoEditado = _candidatoRepository.UpdateCandidato(candidato);

            return candidatoEditado;
        }

        public void DeleteCandidato(int idCandidato)
        {
            _candidatoRepository.DeleteCandidato(idCandidato);
        }
    }
}
