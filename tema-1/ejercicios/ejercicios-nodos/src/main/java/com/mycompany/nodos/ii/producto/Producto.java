/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package com.mycompany.nodos.ii.producto;

import java.text.DecimalFormat;

/**
 *
 * @author JHM by Jorge Herrera Martín
 * version 1.0
 * Created on 17 sept 2024
 */
public class Producto {
    private int cantidad;
    
    private double precio;

    private String nombre;
    
    /**
    * Constructor por defecto
    * @param cantidad
    * @param precio
    */
    public Producto(String nombre, int cantidad, double precio){
        this.nombre = nombre;
        this.cantidad=cantidad;
        this.precio=precio;
    }
    
    /**
    * Devuelve la cantidad de productos
    * @return Cantidad de producto
    */
    public int getCantidad() {
        return cantidad;
    }
    
    /**
    * Devuelve el precio
    * @return Precio del producto
    */
    public double getPrecio() {
        return precio;
    }

    public String getNombre() {
        return nombre;
    }

    /**
    * Devuelve el precio final que tiene un producto
    * @return precio final
    */
    public double precioFinal(){
        //Formateamos el precio final por problemas de precision
        DecimalFormat df=new DecimalFormat("#,##");
        return Double.parseDouble(df.format(this.precio * this.cantidad));
    }
    
    /**
    * Genera un numero aleatorio entre dos numeros.
    * Entre el minimo y el maximo incluidos
    * @param minimo Número mínimo
    * @param maximo Número máximo
    * @return Número entre minimo y maximo
    */
    public static int generaNumeroAleatorio(int minimo, int maximo){
        int num=(int)Math.floor(Math.random()*(minimo-(maximo+1))+(maximo+1));
        return num;
    }
    
    
    
    /**
    * Genera un numero aleatorio entre dos numeros reales.
    * Entre el minimo y el maximo incluidos
    * Devuelve un numero con dos decimales.
    * @param minimo Número mínimo
    * @param maximo Número máximo
    * @return Número entre minimo y maximo
    */
    public static double generaNumeroRealAleatorio(double minimo, double maximo){
        double num=Math.rint(Math.floor(Math.random()*(minimo-((maximo*100)+1))+((maximo*100)+1)))/100;
        return num;
    }

}

