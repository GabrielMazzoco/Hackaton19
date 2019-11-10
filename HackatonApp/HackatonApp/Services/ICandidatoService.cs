using System.Collections.Generic;
using HackatonApp.Entities;

namespace HackatonApp.Services
{
    public interface ICandidatoService
    {
        IEnumerable<Candidato> GetCandidatos();

        Candidato GetCandidato(int idCandidato);

        Candidato RegisterCandidato(Candidato candidato);

        Candidato UpdateCandidato(Candidato candidato);

        void DeleteCandidato(int idCandidato);
    }
}
