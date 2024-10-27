/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package com.mycompany.nodos.ii.producto;

import com.mycompany.nodos.ii.ListaEnlazada;

import java.util.ArrayList;

import static com.mycompany.nodos.ii.persona.Persona.generaNumeroAleatorio;

/**
 *
 * @author JHM by Jorge Herrera Martín
 * version 1.0
 * Created on 17 sept 2024
 */
public class MainProducto {
    
    public static void main(String []args){
        
        //Creo una lista enlazada de Productos (clase producto)
        ListaEnlazada <Producto> listaProductos = new ListaEnlazada<>();

        ArrayList<Producto> listProducto = new ArrayList<>();
        
        //Genero una lista de entre 1 y 8 productos (generados aleatoriamente. La cantidad y el precio del producto también se genera aleatoriamente
        int longitudLista = generaNumeroAleatorio(1, 8);
        System.out.println("Longitud lista: " +longitudLista);
        System.out.println("");
        
        for (int i=0; i<longitudLista; i++){
            Producto p1 = new Producto( "Producto "+ i,generaNumeroAleatorio(1, 5), generaNumeroAleatorio(1,50));
            listaProductos.insertarUltimo(p1);
            listProducto.add(p1);
            System.out.println("Producto generado correctamente");
            System.out.println("");
        }


        //Utilizo la lista enlazada
        double precioFinal = 0.0;
        for(int i=0; i < longitudLista; i++){
            
            Producto p1 = (Producto) listaProductos.devolverDato(i);
            int cantidad = p1.getCantidad() ;
            double precio = p1.getPrecio();
            
            precioFinal += (cantidad * precio);

            System.out.println(p1.getNombre() +":  cantidad: "+ p1.getCantidad() +" precio: " +p1.getPrecio());
            
        }
        System.out.println(" ");
        System.out.println("El precio final es de " +precioFinal+ " euros");
        System.out.println(" ");


        //Utilizo el ArrayList
        precioFinal = 0.0;
        for(int i=0; i<listProducto.size(); i++){

            int cantidad = listProducto.get(i).getCantidad();
            double precio = listProducto.get(i).getPrecio();

            precioFinal += (cantidad * precio);

        }
        System.out.println(" ");
        System.out.println("El precio final es de " +precioFinal+ " euros");
        System.out.println(" ");

    }
    

}
