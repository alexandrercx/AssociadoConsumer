using Domain.Models;
using System;

namespace Domain.Interfaces
{
    public interface IAssociadoRepository
    {
        Int64 PostCadastroAssociado(Associado associado);
    }
}
