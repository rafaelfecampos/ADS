using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaCircular
{
    public class ListaCircu
    {
        private No primeiro = null;
        private No ultimo = null;
        private int tamanho = 0;

        #region Descritores
        public No Primeiro
        {
            set { primeiro = value; }
            get { return primeiro; }
        }

        public No Ultimo
        {
            set { ultimo = value; }
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
                primeiro.Anterior = ultimo;
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
                ultimo.Proximo = primeiro;
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
                primeiro.Anterior = ultimo;
                ultimo.Proximo = primeiro;
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
                // ultimo.Anterior.Proximo = primeiro;
                // ultimo = ultimo.Anterior;

                ultimo = ultimo.Anterior;
                primeiro.Anterior = ultimo;
                ultimo.Proximo = primeiro;
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