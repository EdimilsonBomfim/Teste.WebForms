using System;

namespace Cec.Sistemas.Entities
{
    /// <summary>
    /// Colaborador
    /// </summary>
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public string  Documento { get; set; }
        public string TipoPessoa { get; set; }

        public int GrupoId { get; set; }
        public virtual Grupo Grupo { get; set; }
    }
}
