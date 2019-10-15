using ArquiteturaSoftware.Teste3Server.Intefaces;
using ArquiteturaSoftware.Teste3Server.Model;
using ArquiteturaSoftware.Teste3Server.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArquiteturaSoftware.Teste3Server.Services
{
    class VendedorService : IVendedor {
        private IRepository _repository;

        public VendedorService()
        {
            _repository = new VendedorRepository();
        }

        public bool CriarVendedor(Vendedor vendedor)
        {
            try {
                _repository.Salvar(vendedor);
            } catch {
                return false;
            }
            return true;
        }

    }
}
