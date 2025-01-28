using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Revisao
{
    public class ListaDupla
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

        public void AdicionarNoInicio(int valor)
        {
            No novo = new No { Valor = valor };
            if (primeiro == null)
            {
                primeiro = ultimo = novo;
            }
            else{
                novo.Proximo=primeiro;
                primeiro.Anterior = novo;
                primeiro = novo;
            }
        }
        public void AdicionarNoFinal(int valor){
            No novo = new No{Valor=valor};
            if(primeiro == null)
                primeiro = ultimo = novo;
            else{
                ultimo.Proximo=novo;
                novo.Anterior=ultimo;
                ultimo=novo;
            }
        }
        public void RemoverNoInicio(){
            if(primeiro==null)
                throw new Exception("Lista vazia!!!");
            if(primeiro == ultimo)
                primeiro = ultimo = null;
            else{
                primeiro = primeiro.Proximo;
                primeiro.Anterior = null;
            }
        }
        public void RemoverNoFinal(){
            if(primeiro==null)
                throw new Exception("Lista vazia!!!");
            if(primeiro == ultimo)
                primeiro=ultimo=null;
            else{
                ultimo=ultimo.Anterior;
                ultimo.Proximo = null;
            }
        }
        public No Localizar(int valor){
            No aux = primeiro;
            if(primeiro.Valor == valor){
                return aux;
            }
            else{
                while(aux!=ultimo.Proximo){
                    if(aux.Valor==valor)
                        return aux;
                    aux=aux.Proximo;
                }
            }
            return null;
        }
    }
}