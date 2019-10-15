using System;
using System.Collections.Generic;
using System.Text;

namespace ArquiteturaSoftware.Teste3Server.Intefaces
{
    interface IRepository
    {
        bool Salvar(object var);
        bool Deletar(object var);
        bool Editar(object var);
    }
}
