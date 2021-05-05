using lista_suspensa.Models;
using System.Collections.Generic;

namespace lista_suspensa.Services
{
    public static class EstadosService
    {
        public static IEnumerable<Estado> GetEstados() => CarregarEstados();

        private static IEnumerable<Estado> CarregarEstados()
        {
            var listaEstados = new List<Estado>()
            {
                new Estado(){ EstadoSigla="AL", EstadoNome="Alagoas"},
                new Estado(){ EstadoSigla="BA", EstadoNome="Bahia"},
                new Estado(){ EstadoSigla="CE", EstadoNome="Ceará"},
                new Estado(){ EstadoSigla="DF", EstadoNome="Distrito Federal"},
                new Estado(){ EstadoSigla="ES", EstadoNome="Espirito Santo"},
                new Estado(){ EstadoSigla="GO", EstadoNome="Goiás"},
                new Estado(){ EstadoSigla="PR", EstadoNome="Paraná"},
                new Estado(){ EstadoSigla="TO", EstadoNome="Tocantins"}
            };
            return listaEstados;
        }
    }
}
