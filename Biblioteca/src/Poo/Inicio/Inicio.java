/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Poo.Inicio;

import Poo.Codigo.Ciencia;
import Poo.Codigo.Libros;
import Poo.Codigo.Novela;
import Poo.Codigo.Poesia;
import java.util.ArrayList;

/**
 *
 * @author UNAN-Chontales
 */
public class Inicio {
    public static ArrayList<Libros> Vivlio = new ArrayList <>();

    public static void main(String[] args) {
        Ciencia Astrofisica = new Ciencia("Divulgacion", "A2405", "Astrofisica para gente con prisa", 
                        "N, Degrasse", 218, "Ciencia", "Articulo CIentifico", true,85);

        Novela Percy = new Novela("Percy Jackson", "Actual", "M2005", "Percy Jackson y los dioses del olimpo",
                         "R, Riordan", 310, "Novela", "Ficcion", false,4);
       
         Poesia iliada= new Poesia(24, 5, "I0800", "Iliada","Homero", 254, 
                        "Poesia", "Narrativo", true,5);
 
    Vivlio.add(Percy);
    Vivlio.add(Astrofisica);
    Vivlio.add(iliada);

 

        for (Libros Buchen : Vivlio) {
           Buchen.Mostrar();
        }

    }
}
