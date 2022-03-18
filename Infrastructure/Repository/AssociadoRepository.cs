using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Context;
using System;

namespace Infrastructure.Repository
{
    public class AssociadoRepository : Repository<Associado>, IAssociadoRepository
    {
        private readonly Contexto _context;

        public AssociadoRepository(Contexto context) : base(context)
        {
            _context = context;
        }
        public Int64 PostCadastroAssociado(Associado associado)
        {
            _context.Associados.Add(associado);
            _context.SaveChanges();
            return associado.Id;
        }
    }
}
