using ArquiteturaSoftware.Teste3Server.Intefaces;
using ArquiteturaSoftware.Teste3Server.Model;
using ArquiteturaSoftware.Teste3Server.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArquiteturaSoftware.Teste3Server.Controller
{
    public class VendedorController
    {
        private IVendedor _vendedorService;
        public VendedorController()
        {
            //_vendedorService = new VendedorService(this.ModelState, new ProductRepository());
            _vendedorService = new VendedorService();
        }

        public string Index()
        {
            string str = "teste";

            Vendedor vendedor = new Vendedor();

            _vendedorService.CriarVendedor(vendedor);

            return str;
        }

    }
}
