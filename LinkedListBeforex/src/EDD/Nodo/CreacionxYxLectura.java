/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package EDD.Nodo;

import javax.swing.JOptionPane;

/**
 *
 * @author UNAN-Chontales
 */
public class CreacionxYxLectura {
    public static Nodo p;
public static Nodo T;

    public void CrearInicio(){
        String Informacion = JOptionPane.showInputDialog("Escribe algo");
        p=new Nodo(Informacion);
        p.liga =null;
        JOptionPane.showMessageDialog(null, "El elemento se ha insertado");

        int res = Integer.parseInt(JOptionPane.showInputDialog(null, "¿Desea agregar otro nodo?"+
                                    "\n"+"1.Si"+"\n"+"2.No"));

        while (res == 1) {
            Informacion = JOptionPane.showInputDialog("Escribe algo");
            Nodo Q = new Nodo(Informacion);
            Q.liga = p;
            p = Q;

            res = Integer.parseInt(JOptionPane.showInputDialog(null, "¿Desea agregar otro nodo?"+
                                    "\n"+"1.Si"+"\n"+"2.No"));
        }

    }

    public void ImprimirLista(){

        Nodo Q=p;
        while(Q != null){
            System.out.println(Q.Informacion);
            Q=Q.liga;
        }
    }

    public void InsertarAntesdeX(Nodo p,String Dato, String X){

    Nodo Q = p; int Band =1;

        while((Q.Informacion != X) && (Band ==1)){

         if (Q.liga !=null) T = Q;
         else Band = 0;
        }

        if (Band == 1) {
            Nodo x = new Nodo(Dato);
            x.Informacion = Dato;

              if (p == Q) {
                x.liga = p;
                p = x;
              }
              else {
                T.liga = x;
                x.liga = Q;
              }
        }
        else {JOptionPane.showMessageDialog(null, "El nodo dado no se encuentra en la lista","oops",JOptionPane.ERROR_MESSAGE);} 
    }

}
