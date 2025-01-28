using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaSimplismenteEncadeada
{
    public class ListaEncadeada
    {
        private No primeiro = null;

        public No Primeiro { get=> primeiro; set=> primeiro =value; }

        public void AdicionarNoInicio(int valor)
        {
            No novo = new No { Valor = valor };

            if (primeiro == null)
                primeiro = novo;
            else
            {
                novo.Proximo = primeiro;
                primeiro = novo;
            }
        }

        public void AdicionarNoFinal(int valor)
        {
            var novo = new No { Valor = valor };

            if (primeiro == null)
                primeiro = novo;
            else
            {
                var atual = primeiro;

                while (atual.Proximo != null)
                {
                    atual = atual.Proximo;
                }

                atual.Proximo = novo;
            }
        }

        public void RemoverInicio()
        {
            if (primeiro == null)
                throw new Exception("Lista vazia!");

            primeiro = primeiro.Proximo;
        }
        public void RemoverFinal()
        {
            if (primeiro == null)
                throw new Exception("Lista vazia!");

            if (primeiro.Proximo == null)
                primeiro = null;
            else
            {
                No aux = primeiro;

                while (aux.Proximo.Proximo != null)
                {
                    aux=aux.Proximo;
                }

                aux.Proximo = null;
            }
            
        }
        public No Localizar(int valor){
            for(var no = primeiro; no != null; no = no.Proximo){
                if(no.Valor == valor)
                    return no;
            }
            return null;
        }
    }
}