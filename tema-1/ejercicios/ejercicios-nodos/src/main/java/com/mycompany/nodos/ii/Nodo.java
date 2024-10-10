/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.nodos.ii;

/**
 *
 * @author JHM by Jorge Herrera Martín
 * version 1.0
 * Created on 16 sept 2024
 */
public class Nodo<T> {
    private T dato;
    private Nodo<T> siguiente;

    /**
     * Constructor por defecto
     */
    public Nodo() {
        siguiente = null;
    }

    /**
     * Le pasamos un dato al nodo
     * @param p Dato a insertar
     */
    public Nodo(T p) {
        siguiente = null;
        dato = p;
    }

    /**
     * Le pasamos un dato y su siguiente nodo al nodo
     * @param t Dato a insertar
     * @param siguiente Su siguiente nodo
     */
    public Nodo(T t, Nodo<T> siguiente) {
        this.siguiente = siguiente;
        dato = t;
    }

    public T getDato() {
        return dato;
    }

    public void setDato(T dato) {
        this.dato = dato;
    }

    public Nodo<T> getSiguiente() {
        return siguiente;
    }

    public void setSiguiente(Nodo<T> siguiente) {
        this.siguiente = siguiente;
    }
}

