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
public class Terrestre extends Motores{
    private int NºVelocidades;
    private int Cilindros;
    private int Valvulas;

    public Terrestre(String tipo) {
        JOptionPane.showMessageDialog(null, tipo);
    }

    public Terrestre(int NºVelocidades, int Cilindros, int Valvulas, int Capacidad, String TipoCombustible, int Revoluciones, float peso, float dimenciones) {
        super(Capacidad, TipoCombustible, Revoluciones, peso, dimenciones);
        this.NºVelocidades = NºVelocidades;
        this.Cilindros = Cilindros;
        this.Valvulas = Valvulas;
    }



    public int getNºVelocidades() {
        return NºVelocidades;
    }

    public void setNºVelocidades(int NºVelocidades) {
        this.NºVelocidades = NºVelocidades;
    }

    public int getCilindros() {
        return Cilindros;
    }

    public void setCilindros(int Cilindros) {
        this.Cilindros = Cilindros;
    }

    public int getValvulas() {
        return Valvulas;
    }

    public void setValvulas(int Valvulas) {
        this.Valvulas = Valvulas;
    }

    @Override
    public void Apagado(){JOptionPane.showMessageDialog(null,"Señor, El batimovil se ha apagado");}

     @Override
     public void Encendido(){JOptionPane.showMessageDialog(null,"Señor, El batimovil se ha encendido");}

    @Override
    public void CambioVelocidad(int vel){
        if (vel ==0) {
            JOptionPane.showMessageDialog(null, "Esta en neutro, Se aumentara a 1","Cambio de velocidad",JOptionPane.INFORMATION_MESSAGE);
        }
    else if (vel >0) {
            JOptionPane.showMessageDialog(null, "La velocidad esta en: "+vel+" Cambiando a: "+(++vel),"Cambio de velocidad",JOptionPane.INFORMATION_MESSAGE);
        }

    }

    @Override
    public void mostrar(){
    System.out.println("Capacidad: "+ super.getCapacidad()+"\n"
                            +"Revoluciones: " + super.getRevoluciones()+"\n"
                            +"Tipo de combustible: "+ super.getTipoCombustible()+"\n"
                            +"Peso: "+super.getPeso()+"\n"
                            +"Dimensiones: "+super.getDimenciones()+"\n"
                            +"Cantidad de velocidades: "+getNºVelocidades()+"\n"
                            +"Numero de cilindros: "+getCilindros()+"\n"
                            +"Numero de valvulas: "+ getValvulas()+"\n"
                            );
    }

}
