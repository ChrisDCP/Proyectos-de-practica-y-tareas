/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package edd.Pilas;

import javax.swing.JOptionPane;
/**
 *
 * @author UNAN-Chontales
 */
public class ContarNegativos {
    public static int Arreglo[];
    public static int max;
    public static int tope=-1;

   /* public static void main(String[] args) {
        int max = Integer.parseInt(JOptionPane.showInputDialog("Tamaño de la pila"));
        Arreglo= new int [max];

        llenarDato();
        RecorrerArreglo();
    }*/

    public static void llenarDato(){
        for (int i = 0; i < Arreglo.length; i++) {

            tope++;
            Arreglo[tope] = Integer.parseInt(JOptionPane.showInputDialog("ingresa el dato a poner en pila"));
            
            JOptionPane.showMessageDialog(null, "EL dato se inserto");
        }       
    } 

    public static void RecorrerArreglo(){
        int negativos=0;
        for (int i = 0; i<Arreglo.length ; i++) {
            if(Arreglo[i]<0){
                negativos+=1;
                System.out.println(Arreglo[i]);
            }
        }
        JOptionPane.showMessageDialog(null, "Hay "+negativos+" numeros negativos");
    }
}
