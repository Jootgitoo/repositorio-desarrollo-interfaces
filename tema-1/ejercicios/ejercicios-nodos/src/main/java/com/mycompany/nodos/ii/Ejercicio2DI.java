/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package com.mycompany.nodos.ii;

/**
 *
 * @author JHM by Jorge Herrera Martín
 * version 1.0
 * Created on 16 sept 2024
 */
public class Ejercicio2DI {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // Creo la lista enlazada de números
        // Puede ser de String, double, Objetos, etc.
        ListaEnlazada<Integer> lista = new ListaEnlazada<>();
        
        System.out.println("Inserción de números del 0 al 9 en forma de cola");
        for (int i = 0; i < 10; i++) {
            lista.insertarUltimo(i);
        }
        
        // Mostramos la lista
        lista.mostrar();
        
        System.out.println("");
        
        System.out.println("Número de elementos: " + lista.cuantosElementos());
        System.out.println("");
        
        System.out.println("Eliminación del dato que está en la posición 3");
        lista.borraPosicion(3); // Elimina el dato 3
        
        lista.mostrar();
        
        System.out.println("Número de elementos: " + lista.cuantosElementos());
        System.out.println("");
        
        System.out.println("Inserción del dato 2 en la posición 5");
        lista.introducirDato(5, 2);
        
        lista.mostrar();
        
        System.out.println("Número de elementos: " + lista.cuantosElementos());
        System.out.println("");
        
        System.out.println("Modificamos el dato de la posición 5 por un 3");
        lista.modificarDato(5, 3);
        
        lista.mostrar();
        
        System.out.println("Número de elementos: " + lista.cuantosElementos());
        System.out.println("");
        
        System.out.println("Inserto en la posición 0");
        lista.introducirDato(0, 10);
        
        lista.mostrar();
        System.out.println("");
        
        System.out.println("Inserto en la última posición");
        // Equivalente a insertarUltimo
        lista.introducirDato(lista.cuantosElementos(), 11);
        
        lista.mostrar();
        System.out.println("");
        
        System.out.println("Posición del dato 5: " + lista.indexOf(5));
        System.out.println("Posición del dato 5 desde la posición 7: " + lista.indexOf(5, 7));
        
        System.out.println("");
        
        System.out.println("¿Existe el dato 10 en la lista? " + lista.datoExistente(10));
        System.out.println("¿Existe el dato 20 en la lista? " + lista.datoExistente(20));
    }

}

