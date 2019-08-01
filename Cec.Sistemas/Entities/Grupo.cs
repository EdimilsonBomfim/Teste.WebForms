using System.Collections.Generic;

namespace Cec.Sistemas.Entities
{
    /// <summary>
    /// Departamento
    /// </summary>
    public class Grupo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        /// <summary>
        /// Colaborador responsável pelo departamento
        /// </summary>
        public int? ReponsavelId { get; set; }

        /// <summary>
        /// Relacionamento
        /// </summary>
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
