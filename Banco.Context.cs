

namespace projetoTuristico
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    public partial class db_valor_viagemEntities : DbContext
    {
        public db_valor_viagemEntities()
            : base("name=db_valor_viagem")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<TB_Alimentacao> TB_Alimentacao { get; set; }
        public virtual DbSet<TB_Transporte> TB_Transporte { get; set; }
        public virtual DbSet<TB_Hospedagem> TB_Hospedagem { get; set; }
    }
}