package com.mycompany.nodos.ii.informe;

import com.mycompany.nodos.ii.ListaEnlazada;

public class MainInforme {
    public static void main(String[] args) {

        ListaEnlazada<Informe> listaInforme = new ListaEnlazada<>();

        //Creamos 10 informes y los metemos en la lista
        for(int i=0; i<10; i++){
            Informe i1 = new Informe(0, 1);
            listaInforme.insertarUltimo(i1);
            System.out.println("Código: " + i1.getCodigo() + " tarea: " + i1.getTarea());

        }
        System.out.println(" ");


        //Borramos la lista
        for(int i=0; i<listaInforme.cuantosElementos(); i++){
            listaInforme.quitarUltimo();
        }
        System.out.println("Lista vacia");

        //Creamos 5 informes
        for(int i=0; i<5; i++){
            Informe i1 = new Informe(1, 2);
            listaInforme.insertarUltimo(i1);
            System.out.println("Código: " + i1.getCodigo() + " tarea: " + i1.getTarea());
        }
    }
}
