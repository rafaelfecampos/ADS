using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaSimplesmenteEncadeadaComDescritor
{
    public class ListaEncadeada
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
            No novo = new No { Valor = valor };

            if (primeiro == null)
                primeiro = ultimo = novo;
            else
            {
                novo.Proximo = primeiro;
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
                ultimo.Proximo=novo;
                ultimo = ultimo.Proximo;
            }
            this.tamanho++;
        }

        public void RemoverInicio()
        {
            if (primeiro == null)
                throw new Exception("Lista vazia!");

            if(primeiro == ultimo)
                primeiro = ultimo = null;
            else{
                primeiro = primeiro.Proximo;
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
                var atual = primeiro;

                while (atual.Proximo.Proximo != null)
                {
                    atual=atual.Proximo;
                }

                atual.Proximo = null;
                ultimo = atual;
            }
            this.tamanho--;            
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