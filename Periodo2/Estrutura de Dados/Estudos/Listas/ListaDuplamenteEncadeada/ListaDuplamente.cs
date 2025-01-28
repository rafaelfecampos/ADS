using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaDuplamenteEncadeada
{
    public class ListaDuplamente
    {
        private No primeiro = null;
        private No ultimo = null;
        private int tamanho = 0;

        #region Descritores
        public No Primeiro
        {
            get { return primeiro; }
        }

        public No Ultimo
        {
            get { return ultimo; }
        }

        public int Tamanho
        {
            get { return tamanho; }
        }
        #endregion

        public void AdicionarNoInicio(int valor)
        {
            var novo = new No { Valor = valor };

            if (primeiro == null)
                primeiro = ultimo = novo;
            else
            {
                novo.Proximo = primeiro;
                primeiro.Anterior = novo;
                primeiro = novo;
            }
            this.tamanho++;
        }

        public void AdicionarNoFinal(int valor)
        {
            var novo = new No { Valor = valor };

            if (primeiro == null)
                primeiro = ultimo = novo;
            else
            {
                ultimo.Proximo = novo;
                novo.Anterior = ultimo;
                ultimo = ultimo.Proximo;
            }
            this.tamanho++;
        }

        public void RemoverInicio()
        {
            if (primeiro == null)
                throw new Exception("Lista vazia!");

            if (primeiro == ultimo)
                primeiro = ultimo = null;
            else
            {
                primeiro = primeiro.Proximo;
                primeiro.Anterior = null;
            }
            this.tamanho--;
        }
        public void RemoverFinal()
        {
            if (primeiro == null)
                throw new Exception("Lista vazia!");

            if (primeiro == ultimo)
                primeiro = ultimo = null;
            else
            {
                ultimo.Anterior.Proximo = null;
                ultimo = ultimo.Anterior;
            }
            this.tamanho--;
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
    }
}