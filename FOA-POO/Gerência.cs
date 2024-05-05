using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOA_POO
{
    public interface Gerência
    {
        void Adicionar();

        void Excluir(string id);

        void Listar();

        int ExibirQuantidade();
        

    }
}
