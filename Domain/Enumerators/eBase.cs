using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enumerators
{
    public enum eTipoAmbiente
    {
        Base_Resultados = 0,
        Teste_OnPremise = 1,
        Teste_Cloud = 2,
    }

    public enum eOperacao
    {
        Nenhuma = 0,
        Adicionar = 1,
        Alterar = 2,
        Deletar = 3,
    }
}
