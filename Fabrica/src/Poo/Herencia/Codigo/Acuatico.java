/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Poo.Herencia.Codigo;

import javax.swing.JOptionPane;

/**
 *
 * @author UNAN-Chontales
 */
public class Acuatico extends Motores {
   private boolean Sumergibilidad;
   private double Torque; 

    public Acuatico(String tipo) {
JOptionPane.showMessageDialog(null, tipo);
    }

    public Acuatico(boolean Sumergibilidad, double Torque, int Capacidad, String TipoCombustible, int Revoluciones, float peso, float dimenciones) {
        super(Capacidad, TipoCombustible, Revoluciones, peso, dimenciones);
        this.Sumergibilidad = Sumergibilidad;
        this.Torque = Torque;
    }

    public boolean getSumergibilidad() {
        return Sumergibilidad;
    }

    public void setSumergibilidad(boolean Sumergibilidad) {
        this.Sumergibilidad = Sumergibilidad;
    }

    public double getTorque() {
        return Torque;
    }

    public void setTorque(double Torque) {
        this.Torque = Torque;
    }


    @Override
     public void Apagado(){JOptionPane.showMessageDialog(null,"Señor, El bati acuatico se ha apagado");}

    @Override
     public void Encendido(){JOptionPane.showMessageDialog(null,"Señor, El bati acuatico se ha encendido");}

    @Override
    public void CambioVelocidad(int vel){
    if (vel ==0) {
            JOptionPane.showMessageDialog(null, "Esta en neutro, Se aumentara a 1","Cambio de velocidad",JOptionPane.INFORMATION_MESSAGE);
        }
    else if (vel >0) {
            JOptionPane.showMessageDialog(null, "La velocidad esta en: "+vel+"Cambiando a: "+(++vel),"Cambio de velocidad",JOptionPane.INFORMATION_MESSAGE);
        }

    }

    public boolean sumergirse(){
        if (this.getSumergibilidad()) {
        JOptionPane.showMessageDialog(null, "Señor, El bati submarino se ha sumergido");
        return true;
        }

        else{return false;}
    }

    public void Levantarse(){
        if (sumergirse()) 
            JOptionPane.showMessageDialog(null, "Señor, El bati submarino subio a la superficie");
        
        else JOptionPane.showMessageDialog(null, "Señor, El bati submarino nunca se sumergio");

    }
    
    @Override
    public void mostrar(){
    System.out.println("Capacidad: "+ super.getCapacidad()+"\n"
                            +"Revoluciones: " + super.getRevoluciones()+"\n"
                            +"Tipo de combustible: "+ super.getTipoCombustible()+"\n"
                            +"Peso: "+super.getPeso()+"\n"
                            +"Dimensiones: "+super.getDimenciones()+"\n"
                            +"Sumergibilidad: "+getSumergibilidad()+"\n"
                            +"Capacidad de torque: "+getTorque()+"\n"
                            );
    }

}
