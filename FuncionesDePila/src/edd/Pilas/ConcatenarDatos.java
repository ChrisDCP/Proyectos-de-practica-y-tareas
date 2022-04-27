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
public class ConcatenarDatos {

    public static int Arreglo1[];
    public static int Arreglo2[];
    public static int Arreglo3[];
    public static int max;
    public static int tope= -1;
    public static int tope2=-1;
    public static int tope3=-1;
    
  /*public static void main(String[] args) {
        int max = Integer.parseInt(JOptionPane.showInputDialog("Tamaño de las pilas"));
        Arreglo1= new int [max];
        Arreglo2= new int [max];
        Arreglo3=new int[max+max];
        llenarArreglo();
        mostarPilaUno();
        llenarArregloDos();
        MostarPilaDos();
        Intercambiar();
        MostrarPilaTres();
    }*/

    public static void llenarArreglo(){
        for (int i = 0; i < Arreglo1.length; i++) {
        int Dato = Integer.parseInt(JOptionPane.showInputDialog("Dato a ingresar pila 1"));
        tope++;
        Arreglo1[tope] = Dato;
        }
    }

    public static void mostarPilaUno(){
        System.out.println("Pila 1");
        for (int i = 0; i < Arreglo1.length; i++) {
            System.out.println("dato"+(i+1)+": "+ Arreglo1[i]);
        }

    }

    public static void llenarArregloDos(){
        for (int i = 0; i < Arreglo2.length; i++) {
        int Dato = Integer.parseInt(JOptionPane.showInputDialog("Dato a ingresar pila 2"));
        tope2++;
        Arreglo2[tope2] = Dato;
        }
    }
   

    public static void MostarPilaDos(){
        System.out.println("Pila 2");
        for (int i = 0; i < Arreglo2.length; i++) {
            System.out.println("dato"+(i+1)+": "+ Arreglo2[i]);
        }
    }


    public static void Intercambiar(){
        for (int i = 0; i < Arreglo1.length; i++) {
            tope3++;
            Arreglo3[tope3] = Arreglo1[tope];
            tope--;
            tope3++;
            Arreglo3[tope3] = Arreglo2[tope2];
            tope2--;
        }
            JOptionPane.showMessageDialog(null, "Los datos se han intercambiado");
    }

    public static void MostrarPilaTres(){
        System.out.println("Pila 3");
        for (int i = 0; i < Arreglo3.length; i++) {
            System.out.println("dato"+(i+1)+": "+ Arreglo3[i]);
        }

    }

    

}
