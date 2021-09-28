using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Adrian002
{
    public class Unidade
    { 
            public int Codigo { get; set; } 
            public string Cnpj { get; set; }
            public virtual Regiao Regiao { get; set; }
            public Guid RegiaoId { get; set; }
            public string Nome { get; set; }
            public string Status { get; set; }

     }
}
