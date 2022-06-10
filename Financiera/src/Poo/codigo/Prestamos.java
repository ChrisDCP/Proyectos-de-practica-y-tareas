/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Poo.codigo;

/**
 *
 * @author UNAN-Chontales
 */
public abstract class Prestamos implements I_Financiacion{
    private String Titular;
    private float Salario;
    private String Cedula;
    private boolean Activo;
    private float Monto;
    private int Plazo;
    private String TipoFinanciamiento;

    public Prestamos(String Titular, float Salario, String Cedula, boolean Activo, float Monto, int Plazo, String TipoFinanciamiento) {
        this.Titular = Titular;
        this.Salario = Salario;
        this.Cedula = Cedula;
        this.Activo = Activo;
        this.Monto = Monto;
        this.Plazo = Plazo;
        this.TipoFinanciamiento = TipoFinanciamiento;
    }

    public String getTitular() {
        return Titular;
    }

    public void setTitular(String Titular) {
        this.Titular = Titular;
    }

    public float getSalario() {
        return Salario;
    }

    public void setSalario(float Salario) {
        this.Salario = Salario;
    }

    public String getCedula() {
        return Cedula;
    }

    public void setCedula(String Cedula) {
        this.Cedula = Cedula;
    }

    public boolean getActivo() {
        return Activo;
    }

    public void setActivo(boolean Activo) {
        this.Activo = Activo;
    }

    public float getMonto() {
        return Monto;
    }

    public void setMonto(float Monto) {
        this.Monto = Monto;
    }

    public int getPlazo() {
        return Plazo;
    }

    public void setPlazo(int Plazo) {
        this.Plazo = Plazo;
    }

    public String getTipoFinanciamiento() {
        return TipoFinanciamiento;
    }

    public void setTipoFinanciamiento(String TipoFinanciamiento) {
        this.TipoFinanciamiento = TipoFinanciamiento;
    }

   @Override 
    public void RegistrarSolicitud(){}

    @Override
    public void AprobarPrestamo(){}

    @Override
    public void CancelarPrestamo(){}

    @Override
    public abstract float CalcularCuota();

    public void mostrar(){}


}
