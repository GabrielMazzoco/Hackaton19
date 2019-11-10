using System.Collections.Generic;
using HackatonApp.Entities;

namespace HackatonApp.Data.Repositories
{
    public interface ICandidatoRepository
    {
        IEnumerable<Candidato> GetCandidatos();

        Candidato GetCandidato(int idCandidato);

        Candidato RegisterCandidato(Candidato candidato);

        Candidato UpdateCandidato(Candidato candidato);

        void DeleteCandidato(int idCandidato);
    }
}
