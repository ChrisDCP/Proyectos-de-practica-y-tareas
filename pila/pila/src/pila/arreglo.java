/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pila;

import javax.swing.JOptionPane;


/**
 *
 * @author UNAN-Chontales
 */
public class arreglo {

      int[] pila;
      int max;
      int tope;

    public arreglo(int max) {
        this.pila = new int [this.max+1];
        this.max = max;
        this.tope = -1;
    }

    public int[] getPila() {
        return pila;
    }

    public int getMax() {
        return max;
    }

    public int getTope() {
        return tope;
    }


  public void llenarDato(){
        if(this.tope<this.max-1){         
            this.tope++;
            this.pila[this.tope] = Integer.parseInt(JOptionPane.showInputDialog("ingresa el dato a poner en pila"));
            

            JOptionPane.showMessageDialog(null, "EL dato se inserto");
        }
        else {
            JOptionPane.showMessageDialog(null,"pila llena");}
        } 
        
  public void Quitardato(){
    
    int objeto = this.pila[this.tope];
    tope--;
    JOptionPane.showMessageDialog(null, "EL dato se elimino");
    }
    

    public void pilallena(){
    if (this.tope==this.max-1){
        JOptionPane.showMessageDialog(null,"LA PILA ESTA LLENA",
                                    "verificacion de pila llena",JOptionPane.INFORMATION_MESSAGE);
        }
    }
    
    public void pilavacia(){
    if(this.tope == -1 ){
        JOptionPane.showMessageDialog(null,"LA pila esta vacia",
                                    "verificacion de pila vacia",JOptionPane.INFORMATION_MESSAGE);
        }
    }
    
    public void mostrarpila(){
    if(this.tope == -1 ){
        JOptionPane.showMessageDialog(null,"LA pila esta vacia");
        }else {
       String sumativa = "";
            for (int i = -1; i <=this.tope; i++) {
                sumativa = sumativa + (i+1)+this.pila[i] +"\n"; 
            }
        JOptionPane.showMessageDialog(null, "LOS DATOS DE LA PILA SON : " + sumativa,
                                "MOSTRAR DATOS",JOptionPane.INFORMATION_MESSAGE);

        }
        
    }

    public void Salir(){
        System.exit(0);
    }

}
