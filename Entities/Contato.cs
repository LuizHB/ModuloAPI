using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIModulo.Entities
{
    public class Contato
    {        
        //pasta entidade possui uma classe (ou mais) trabalhada na API
        //e que também será utilizada pelo banco de dados como tabela
        //A classe contato possui atributos de ID,Nome,Telefone e Ativo
        public int ID { get; set; } 
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}