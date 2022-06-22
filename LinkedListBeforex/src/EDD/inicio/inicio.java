/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package EDD.inicio;

import javax.swing.JOptionPane;
import EDD.Nodo.CreacionxYxLectura;
import EDD.Nodo.Nodo;

/**
 *
 * @author UNAN-Chontales
 */
public class inicio {
    public static Nodo p;
    public static void main(String[] args) {
        CreacionxYxLectura metodos = new CreacionxYxLectura();

        int opcion;
        
       do{
         opcion= Integer.parseInt(JOptionPane.showInputDialog("1. Ingresar elementos"+"\n"
                                +"2. Mostrar elementos"+"\n"+"3. Insertar antes de x"+"\n"
                                +"4. Salir"));
         
         switch(opcion){
             case 1: metodos.CrearInicio();
             break;

             case 2:metodos.ImprimirLista();
             break;

             case 3: String Dato =JOptionPane.showInputDialog("ingrese el dato");
            String X = JOptionPane.showInputDialog("Ingrese la informacion del nodo");
                    metodos.InsertarAntesdeX(p, Dato, X);
             break;

            case 4:Salir();
            break;

             default:JOptionPane.showMessageDialog(null,"Intente nuevamente","El numero no es una de las opciones"
                                        ,JOptionPane.ERROR_MESSAGE);
         }
            
           
       }while (opcion!=4); 
    }

public static void Salir(){System.exit(0);}

}
