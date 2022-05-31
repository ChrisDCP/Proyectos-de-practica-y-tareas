/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Colaarreglos;

import javax.swing.JOptionPane;

/**
 *
 * @author PC16-B5
 */
public class ColaArreglos {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        //declaracion de colas
        int cola1[];
        int cola2[];
        int cola3[];
        int frente1 = -1;
        int frente2 = -1;
        int frente3 = -1;
        int final1 = -1;
        int final2 = -1;
        int final3 = -1;
        int max;

        //asignacion de tamaños
        max = Integer.parseInt(JOptionPane.showInputDialog("ingrese el tamaño de la pila"));
        cola1 = new int[max];
        cola2 = new int[max];
        cola3 = new int[max];

        //llenar cola 1
        System.out.println("Llenando cola 1");
        while (final1 < max - 1) {
            final1++;
            cola1[final1] = Integer.parseInt(JOptionPane.showInputDialog("ingrese un numero mayor al anterior"));
            if (final1 == 0) {
                frente1 = 0;
            }
        }
        //mostrar cola 1
        System.out.println("cola 1" + "\n");
        for (int i = 0; i < cola1.length; i++) {
            System.out.println(cola1[i]);
        }
        System.out.println(" ");

        //llenado de cola 2
        System.out.println("Llenando cola 2");
        while (final2 < max - 1) {
            final2++;
            cola2[final2] = Integer.parseInt(JOptionPane.showInputDialog("ingrese un numero mayor al anterior"));
            if (final2 == 0) {
                frente2 = 0;
            }
        }

        //mostar cola 2
        System.out.println("cola 2" + "\n");
        for (int i = 0; i < cola2.length; i++) {
            System.out.println(cola2[i]);
        }
        System.out.println(" ");

        //bucle para comparacion
        while (frente1 != -1 && frente2 != -1) {

            if (cola1[frente1] == cola2[frente2]) {
                //
                final3++;
                cola3[final3] = cola1[frente1];
                if (final3 == 0) { frente3 = 0;}
                //eliminar cola 1
                if (frente1 == final1) {
                    frente1 = -1;
                    final1 = -1;
                } else {
                    frente1++;                    
                    
                }
                //eliminar frente 2
                if (frente2 == final2) {
                    frente2 = -1;
                    final2 = -1;
                } else {
                    frente2++;                    
                    
                }

            } else if (cola1[frente1] < cola2[frente2]) {
                 if (frente1 == final1) {
                    frente1 = -1;
                    final1 = -1;
                }else {
                    frente1++;                    
                    
                }
                 
            } else if (cola1[frente1] > cola2[frente2]) {
                if (frente2 == final2) {
                    frente2 = -1;
                    final2= -1;
                } else {
                    frente2++;                    
                    
                }
            }
        }

        //mostrar cola 3
        System.out.println("cola 3" + "\n");
        for (int i = frente3; i <= final3; i++) {
            System.out.println(cola3[i]);
       
        }
    }
}
