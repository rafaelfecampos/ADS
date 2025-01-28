using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Questao1
{
    public class ListaEncadeada
    {
        private No primeiro = null;
        public No Primeiro
        {
            get { return primeiro; }
            set { primeiro = value; }
        }

        public void AdicionarInicio(int valor)
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

        public void AdicionarFinal(int valor)
        {
            No novo = new No { Valor = valor };

            if (primeiro == null)
                primeiro = novo;
            else
            {
                No aux = primeiro;
                while (aux.Proximo != null)
                    aux = aux.Proximo;
                aux.Proximo = novo;
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
                    aux = aux.Proximo;
                aux.Proximo = null;
            }
        }

        public No Localizar(int valor)
        {
            for (var no = primeiro; no != null; no = no.Proximo)
            {
                if (no.Valor == valor)
                    return no;
            }
            return null;
        }

        public void AdicionarVariosNoFinal(ListaEncadeada lista)
        {
            No novo = lista.Primeiro;
            if (primeiro == null)
                primeiro = novo;
            else
            {
                No aux = primeiro;
                while (aux.Proximo != null)
                    aux = aux.Proximo;
                aux.Proximo = novo;
            }
        }

        public void AdicionarVariosNoInicio(ListaEncadeada lista)
        {
            ListaEncadeada aux = lista;
            while (aux.Primeiro != null)
            {
                if (primeiro == null)
                    primeiro = aux.Primeiro;

                No novo = aux.Primeiro;
                
                if (novo.Proximo == null)
                {
                    novo.Proximo = primeiro;
                    primeiro = novo;
                    aux.RemoverFinal();
                }
                else
                {
                    while(novo.Proximo.Proximo!=null)
                        novo = novo.Proximo;
                    novo.Proximo = primeiro;
                    primeiro = novo;
                    aux.RemoverFinal();
                }
            }
        }
    }
}