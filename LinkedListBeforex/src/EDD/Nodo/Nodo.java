/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package EDD.Nodo;

/**
 *
 * @author UNAN-Chontales
 */
public class Nodo {
    public String Informacion;
    public Nodo liga;
    
    public Nodo (String Informacion){
        this.Informacion=Informacion;
        this.liga=null;
    }
}
