﻿using Dex.AcessoDados.Comum.Entity;
using Dex.TrocaGames.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dex.TrocaGames.AcessoDados.Entity.TypeConfigurations
{
    class LugarTypeConfiguration : DexTypeConfiguration<Lugar>
    {
        protected override void ConfigurarNomeTabela()
        {
            ToTable("LUG_LUGAR");
        }

        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
                .HasColumnName("LUG_ID")                                            //. interface fluencia
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)       // como será gerado
                .IsRequired();

            Property(p => p.Nome)
                .HasColumnName("LUG_NOME")
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.Nome)
                .HasColumnName("LUG_ENDERECO")
                .HasMaxLength(150)
                .IsRequired();
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarChavesEstrangeiras()
        {
            
        }

        protected override void ConfigurarOutrasCoisas()
        {
            
        }
    }
}
