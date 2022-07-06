/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package unapila;

import javax.swing.JOptionPane;

/**
 *
 * @author UNAN-Chontales
 */
public class Unapila {

public static int pila[];
public static int max;
public static int tope = -1;
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        max = Integer.parseInt(JOptionPane.showInputDialog("tamaño de pila"));
        pila = new int[max];

        int opcion;
        
       do{
         opcion= Integer.parseInt(JOptionPane.showInputDialog("1- poner elemento en pila"+"\n"
                                +"2- quitar dato de pila"+"\n"+"3- pila llena"+"\n"
                                +"4- pila vacia"+ "\n"+"5- mostrar datos de pila"+"\n"
                                +"6- salir"));
         
         switch(opcion){
             case 1:llenarDato();
             break;

             case 2:Quitardato();
             break;

             case 3:pilallena();
             break;

             case 4:pilavacia();
             break;

             case 5:mostrarpila();
             break;

            case 6: Salir();
            break;

             default:JOptionPane.showMessageDialog(null,"Intente nuevamente","El numero no es una de las opciones"
                                        ,JOptionPane.ERROR_MESSAGE);
         }
            
           
       }while (opcion!=6);      

    }

    public static void llenarDato(){
        if(tope<max-1){         
            tope++;
            pila[tope] = Integer.parseInt(JOptionPane.showInputDialog("ingresa el dato a poner en pila"));

            JOptionPane.showMessageDialog(null, "EL dato se inserto");
        }
        else {
            JOptionPane.showMessageDialog(null,"pila llena");}
        } 

    private static void Quitardato() {
        //int objeto = pila[tope];
        if (tope>-1) {            
             tope--;
       JOptionPane.showMessageDialog(null, "EL dato se elimino");
        }
        else {JOptionPane.showMessageDialog(null,"LA pila esta vacia");}
       
    }

    private static void pilallena() {
        
    }

    private static void pilavacia() {
       
    }

    private static void mostrarpila() {
      if(tope == -1 ){
        JOptionPane.showMessageDialog(null,"La pila esta vacia");
        }else {
          System.out.println("Los datos de la pila son");
            for (int i = tope; i >=0; i--) {

                System.out.println(pila[i]);
               
            }
       

        }
        
    }

    private static void Salir() {
       System.exit(0);
    }
    
}
