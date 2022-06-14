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
public class AeroNautica extends Motores {
    private int Impulso;
    private double AltMaxima;

    public AeroNautica(String tipo) {
        JOptionPane.showMessageDialog(null, tipo);
    }

    public AeroNautica(int Impulso, double AltMaxima, int Capacidad, String TipoCombustible, int Revoluciones, float peso, float dimenciones) {
        super(Capacidad, TipoCombustible, Revoluciones, peso, dimenciones);
        this.Impulso = Impulso;
        this.AltMaxima = AltMaxima;
    }

    public int getImpulso() {
        return Impulso;
    }

    public void setImpulso(int Impulso) {
        this.Impulso = Impulso;
    }

    public double getAltMaxima() {
        return AltMaxima;
    }

    public void setAltMaxima(double AltMaxima) {
        this.AltMaxima = AltMaxima;
    }



    @Override
     public void Apagado(){JOptionPane.showMessageDialog(null,"Señor, El bati jet se ha apagado");}

    @Override
     public void Encendido(){JOptionPane.showMessageDialog(null,"Señor, El bati jet se ha encendido");}

    public void CambioPropulsion(int prop){
       switch (prop){
        case 1: JOptionPane.showMessageDialog(null, "Propulsion baja, aumentando a media","Cambio de propulsion",JOptionPane.INFORMATION_MESSAGE);
        prop++;
        break;

        case 2: JOptionPane.showMessageDialog(null, "Propulsion media, aumentando a alta","Cambio de propulsion",JOptionPane.INFORMATION_MESSAGE);
        prop++;
        break;

        case 3: JOptionPane.showMessageDialog(null, "Propulsion alta, bajando a media","Cambio de propulsion",JOptionPane.INFORMATION_MESSAGE);
        prop--;
        break;
        }
    }

    @Override
    public void mostrar(){
    System.out.println("Capacidad: "+ super.getCapacidad()+"\n"
                            +"Revoluciones: " + super.getRevoluciones()+"\n"
                            +"Tipo de combustible: "+ super.getTipoCombustible()+"\n"
                            +"Peso: "+super.getPeso()+"\n"
                            +"Dimensiones: "+super.getDimenciones()+"\n"
                            +"Impulso: "+getImpulso()+"\n"
                            +"Altura maxima: "+getAltMaxima()+"\n"
                            );
    }

}
