/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pila;

import javax.swing.JOptionPane;

/**
 *
 * @author PC18-B5
 */
public class Pila {
    /**
     * @param args the command line arguments
     */

public static arreglo pi;
  
    public static void main(String[] args) {

      int MAX;
      MAX = Integer.parseInt(JOptionPane.showInputDialog(null,"INGRESE EL TAMAÑO DE LA PILA"));  
      pi= new arreglo(MAX);


       int opcion;
        
       do{
         opcion= Integer.parseInt(JOptionPane.showInputDialog("1- poner elemento en pila"+"\n"
                                +"2- quitar dato de pila"+"\n"+"3- pila llena"+"\n"
                                +"4- pila vacia"+ "\n"+"5- mostrar datos de pila"+"\n"
                                +"6- salir"));
         
         switch(opcion){
             case 1: pi.llenarDato();
             break;

             case 2:pi.Quitardato();
             break;

             case 3: pi.pilallena();
             break;

             case 4: pi.pilavacia();
             break;

             case 5: pi.mostrarpila();
             break;

             default:JOptionPane.showMessageDialog(null,"Intente nuevamente","El numero no es una de las opciones"
                                        ,JOptionPane.ERROR_MESSAGE);
         }
            
           
       }while (opcion!=6);       
    }    
}
