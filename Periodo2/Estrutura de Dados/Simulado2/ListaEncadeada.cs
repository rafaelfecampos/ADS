using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulado2
{
    public class ListaEncadeada
    {
        private No primeiro = null;
        public No Primeiro
        {
            get { return primeiro; }
        }
        private No ultimo = null;
        public No Ultimo
        {
            get { return ultimo; }
        }
        private int tamanho = 0;
        public int Tamanho
        {
            get { return tamanho; }
        }

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
            tamanho++;
        }
        public void AdicionarNoFinal(int valor)
        {
            No novo = new No { Valor = valor };
            if (primeiro == null)
                primeiro = ultimo = novo;
            else
            {
                ultimo.Proximo = novo;
                ultimo = novo;
            }
            tamanho++;
        }
        public void RemoverNoInicio()
        {
            if (primeiro == null)
                throw new Exception("Lista Vazia!!!");
            if (primeiro == ultimo)
                primeiro = ultimo = null;
            else
            {
                primeiro = primeiro.Proximo;
            }
            tamanho--;
        }
        public void RemoverNoFinal()
        {
            if (primeiro == null)
                throw new Exception("Lista Vazia!!!");
            if (primeiro == ultimo)
                primeiro = ultimo = null;
            else
            {
                No aux = primeiro;
                while (aux.Proximo.Proximo != null)
                {
                    aux = aux.Proximo;
                }
                ultimo = aux;
                ultimo.Proximo = null;
            }
            tamanho--;
        }
    }
}