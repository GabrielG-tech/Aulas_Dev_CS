using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Gabriel_Souza_DR4_TP3 {

    public class InfnetDbContext: DbContext {
        public InfnetDbContext(DbContextOptions<InfnetDbContext> options)
        : base(options) {
        }

        public DbSet<Aluno> Alunos {
            get; set;
        } // Isso vai representar a tabela Alunos no banco de dados

        // Outros DbSet para outras entidades, se necessário

        // Configurações adicionais do contexto, como chaves estrangeiras, restrições, etc., podem ser adicionadas aqui
    }

}
