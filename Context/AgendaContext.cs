using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIModulo.Entities;

namespace APIModulo.Context
{
    public class AgendaContext : DbContext
    {   //AgendaContext é a classe que vai acessar o banco de dados
        //gerencia a comunicação com o banco de dados
        //por isso que herda de DbContext (database)
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {//o construtor aqui recebe o "options" e o entrega 
         //para a classe DbContext

        }
        //pode ter vários atributos, mas aqui possui apenas "Contato"
        //propriedade que se refere a uma entidade neste caso "Contato".
        //Entidade quer dizer que ao mesmo tempo é uma classe e uma
        //tabela no banco de dados 
        public DbSet<Contato> Contatos { get; set; }
        //dentro do dbset significa que está dentro do programa
        //representado como classe (objeto) e tambem vai ser representado
        //como tabela pelo banco de dados.
        //Pelo Dbset ele acessa o registro da tabela de contatos
        //pelo atributo "Contatos" criado
    }
}