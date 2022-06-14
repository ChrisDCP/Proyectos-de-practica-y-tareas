/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Inicio;

import Poo.Herencia.Codigo.Terrestre;
import Poo.Herencia.Codigo.Acuatico;
import Poo.Herencia.Codigo.AeroNautica;
import Poo.Herencia.Codigo.Motores;
import java.util.ArrayList;
import javax.swing.JOptionPane;


/**
 *
 * @author UNAN-Chontales
 */
public class Inicio {

    public static ArrayList<Motores> baticosas = new ArrayList<>();
    public static void main(String[] args) {
        Terrestre BatiMovil = new Terrestre();
        Acuatico BatiAcuatico = new  Acuatico();
        AeroNautica BatiJet = new AeroNautica();



    baticosas.add(BatiMovil);
    baticosas.add(BatiAcuatico);
    baticosas.add(BatiJet);

        for (Motores DC : baticosas) {
            DC.mostrar();
        }

    }
}
