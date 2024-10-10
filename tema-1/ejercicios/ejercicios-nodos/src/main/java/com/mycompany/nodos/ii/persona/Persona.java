/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package com.mycompany.nodos.ii.persona;

/**
 *
 * @author JHM by Jorge Herrera Martín
 * version 1.0
 * Created on 16 sept 2024
 */
public class Persona {
    private int edad;
    
    /**
    * Constructor por defecto
    * @param edad
    */
    public Persona(int edad){
        this.edad=edad;
    }
    
    /**
    * Devuelve la edad
    * @return Edad acutal
    */
    public int getEdad() {
        return edad;
    }
    
    /**
    * Modifica la edad
    * @param edad Valor edad
    */
    public void setEdad(int edad) {
        this.edad = edad;
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
        double num = Math.rint(Math.floor(Math.random()*(minimo-((maximo*100)+1))+((maximo*100)+1)))/100;
        return num;
    }

}

