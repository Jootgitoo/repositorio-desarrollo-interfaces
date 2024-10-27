/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package com.mycompany.nodos.i;

/**
 *
 * @author JHM by Jorge Herrera Martín
 * version 1.0
 * Created on 16 sept 2024
 */
public class PilaDinamica<T> {
    //ATRIBUTOS
    private Nodo<T> top;//ULTIMO NODO INCLUIDO
    private int tamanio;
    
    //CONSTRUCTORES
    public PilaDinamica(){
        top= null; //NO HAY ELEMENTOS
        this.tamanio=0;
    }
    
    //METODOS
    /**
     * Indica si esta vacia o no
     * @return
     */
    public boolean isEmpty(){
        return top==null;
    }
    
    public int size(){
        return this.tamanio;
    }
    
    public T top(){
        if(isEmpty()){
            return null;
        }else{
            return top.getElemento();
        }
    }
    
    public T pop(){
        if(isEmpty()){
            return null;
        }else{
            T elemento=top.getElemento();
            Nodo<T> aux = top.getSiguiente();
            top=null;
            top=aux;
            this.tamanio--;
            return elemento;
        }
    }
    
    public T push(T elemento){
        Nodo<T> aux= new Nodo<>(elemento,top);
        top=aux;
        this.tamanio++;
        return aux.getElemento();
    }
    
    public String toString(){
        if(isEmpty()){
            return "La pila esta vacia";
        }else{
            String resultado="";
            Nodo<T> aux=top;
            while(aux!=null){
                resultado +=aux.toString();
                aux=aux.getSiguiente();
            }
            return resultado;
        }
    }
}
