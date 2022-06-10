/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Poo.codigo;

/**
 *
 * @author UNAN-Chontales
 */
public class FPersonal extends Prestamos{
    
    public FPersonal(String Titular, float Salario, String Cedula, boolean Activo, float Monto, int Plazo, String TipoFinanciamiento) {
        super(Titular, Salario, Cedula, Activo, Monto, Plazo, TipoFinanciamiento);
    }

    public FPersonal() {
        super(null, 0, null, false, 0, 0, null);
    }

    
    public void RegistrarSolicitud(){
        System.out.println("La solicitud de prestamo esta siendo registrada");
    }

    public void AprobarPrestamo(){
        super.setActivo(true);
        System.out.println("Su prestamo esta aprobado");
}

    public void CancelarPrestamo(){
        super.setActivo(false);
        System.out.println("Su prestamo no esta activo");
    }

    public float CalcularCuota(){
    float MontoInteres = (super.getMonto()*18)/100;
    float cuota = (super.getMonto()+MontoInteres)/super.getPlazo();
    return cuota;
    }

    public void mostrar(){
        System.out.println("Tipo de Financiamiento: "+ super.getTipoFinanciamiento()+"\n"
                            +"Titular: " + super.getTitular()+"\n"
                            +"Cedula del titular: "+ super.getCedula()+"\n"
                            +"Salario: "+ super.getSalario()+"\n"
                            +"Monto: "+super.getMonto()+"\n"
                            +"Plazo: "+super.getPlazo()+"\n"
                            +"Estado del prestamo: "+super.getActivo()+"\n"
                            +"La cuota a pagar es de: "+CalcularCuota()+" cordobas."+"\n"
        );
    }
}
