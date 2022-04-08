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
    public static int[] pila;
    public static int max;
    public static int tope =-1;
    
    public static void main(String[] args) {
       int opcion;
       
       JOptionPane.showInputDialog("Ingrese el tamaño del arreglo");
        
       do{
         opcion= Integer.parseInt(JOptionPane.showInputDialog("1- poner elemento en pila"+"\n"
                                +"2- quitar dato de pila"+"\n"+"3- opcion 3"+"\n"
                                +"4- opcion 4"+ "\n"+"5- mostrar datos de pila"+"\n"
                                +"6- salir"));
         
         switch(opcion){
             case 1: llenarDato();
             break;
         
         }
            
           
       }while (opcion!=6);
        
    }
    
    public static void llenarDato(){
        if(tope<max-1){
        
        pila[tope]= Integer.parseInt(JOptionPane.showInputDialog("ingresa el dato a poner en pila"));
        tope++;
        }
        else if(tope ==max-1){JOptionPane.showMessageDialog(null,"pila llena");}
            
    }
    
    public static void QuitarDato(){
    if (tope>-1){
    pila[tope]=0;
    tope--;
        }else{JOptionPane.showMessageDialog(null,"pila vacia");}
    }
    
    public static void funcion(){
    
    }
    
    public static void pilallena(){
    
    }
    
    public static void pilavacia(){
    
    }
    
    public static void mostrarpila(){
        for (int i = max-1; i>0; i++) {
            
            if (pila[i]==0){
            JOptionPane.showMessageDialog(null,"| |");
            }else{
            JOptionPane.showMessageDialog(null,(i+1)+"|"+pila[i]+"\n");
            }
            
        }
    }
    
}
