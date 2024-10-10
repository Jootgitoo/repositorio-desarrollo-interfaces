/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */

package com.mycompany.nodos.ii.persona;

import com.mycompany.nodos.ii.ListaEnlazada;

import java.util.ArrayList;
import java.util.LinkedList;

/**
 * 
 * @author JHM by Jorge Herrera Martín
 * @version 1.0
 * created on 16 sept 2024
 */
public class MainPersona {
    
    public static void main(String[] args) {
        //Creamos una lista enlazada de Personas
        ListaEnlazada<Persona> listaPersonas = new ListaEnlazada<Persona>();

        ArrayList<Persona> listPersonas = new ArrayList<>();
        
        //Genero 10 personas aleatorias y las añado a la lista
        for(int i=0; i<10; i++){
            Persona p1 = new Persona(Persona.generaNumeroAleatorio(5, 50));
            listaPersonas.introducirDato(i, p1);
            listPersonas.add(p1);
        }
        
        //Variable para almacenar el precio final
        double precioFinal = 0;
        
        //Me saca la edad de la persona y según esta suma un dinero u otro
        for(int i=0; i < listaPersonas.cuantosElementos(); i++){
            Persona personaTemp = (Persona) listaPersonas.devolverDato(i);
            int edad = personaTemp.getEdad();
            
            if (edad >= 5 && edad <= 10){
                precioFinal += 1;
            } else if (edad > 10 && edad <= 17) {
                precioFinal += 2.5;
            } else {
                precioFinal += 3.5;
            }
        }
        System.out.println("El precio final es: " + precioFinal + " euros");


        //Saco la edad de la persona y suma un dinero y otro (lo hago con el arrayList)
        precioFinal = 0;
        for (int i = 0; i<listPersonas.size(); i++){
            int edad = listPersonas.get(i).getEdad();

            if (edad >= 5 && edad <= 10){
                precioFinal += 1;
            } else if (edad > 10 && edad <= 17) {
                precioFinal += 2.5;
            } else {
                precioFinal += 3.5;
            }
        }
        System.out.println("El precio final 2 es: " + precioFinal + " euros");
    }
}
