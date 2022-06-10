/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Poo.inicio;

import Poo.codigo.FAuto;
import Poo.codigo.FCasa;
import Poo.codigo.FPersonal;
import Poo.codigo.Prestamos;
import java.util.ArrayList;
import javax.swing.JOptionPane;
/**
 *
 * @author UNAN-Chontales
 */
public class Inicio {
        public static ArrayList<Prestamos> moroso = new ArrayList <Prestamos>();
    public static void main(String[] args) {

        FCasa mia = new FCasa("super man", 20000, "001-241298-1112D", true, 100000, 18, "Casa", "polo norte", 0);
        FAuto mio =new FAuto("batman", 3000000, "001-311299-1111D", false, 0, 0, "Auto", "bati movil", 89, 2500000, 0);
        FPersonal yo = new FPersonal("jijija", 8800,"121-240503-1002M" , true, 50000, 18, "Personal");

moroso.add(yo);
moroso.add(mio);
moroso.add(mia);


        for (Prestamos cobro : moroso) {
            cobro.mostrar();
        }

    }
}
