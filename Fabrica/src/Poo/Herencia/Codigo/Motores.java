/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Poo.Herencia.Codigo;

/**
 *
 * @author UNAN-Chontales
 */
public class Motores implements I_Motores{
    private int Capacidad;
    private String TipoCombustible;
    private int Revoluciones;
    private float peso;
    private float dimenciones;

    public Motores() {
    }

    public Motores(int Capacidad, String TipoCombustible, int Revoluciones, float peso, float dimenciones) {
        this.Capacidad = Capacidad;
        this.TipoCombustible = TipoCombustible;
        this.Revoluciones = Revoluciones;
        this.peso = peso;
        this.dimenciones = dimenciones;
    }

    public int getCapacidad() {
        return Capacidad;
    }

    public void setCapacidad(int Capacidad) {
        this.Capacidad = Capacidad;
    }

    public String getTipoCombustible() {
        return TipoCombustible;
    }

    public void setTipoCombustible(String TipoCombustible) {
        this.TipoCombustible = TipoCombustible;
    }

    public int getRevoluciones() {
        return Revoluciones;
    }

    public void setRevoluciones(int Revoluciones) {
        this.Revoluciones = Revoluciones;
    }

    public float getPeso() {
        return peso;
    }

    public void setPeso(float peso) {
        this.peso = peso;
    }

    public float getDimenciones() {
        return dimenciones;
    }

    public void setDimenciones(float dimenciones) {
        this.dimenciones = dimenciones;
    }

    @Override
    public void Apagado(){
        
    }
    @Override
    public void Encendido(){
       
    }
   
    public void CambioVelocidad(int vel){}

    public void mostrar(){}

}
