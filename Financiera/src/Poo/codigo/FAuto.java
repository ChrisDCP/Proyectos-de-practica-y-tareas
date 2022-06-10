/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Poo.codigo;

/**
 *
 * @author UNAN-Chontales
 */
public class FAuto extends Prestamos{
    private String Modelo;
    private int Año;
    private float Precio;
    private float Prima;
        //constructores
    public FAuto(String Titular, float Salario, String Cedula, boolean Activo, float Monto, int Plazo, 
                 String TipoFinanciamiento,String Modelo, int Año, float Precio, float Prima) {
        super(Titular, Salario, Cedula, Activo, Monto, Plazo, TipoFinanciamiento);
        this.Modelo=Modelo;
        this.Año=Año;
        this.Precio=Precio;
        this.Prima=Prima;

    }

    public FAuto() {
        super(null, 0, null, false, 0, 0, null);
    }
        //get y set
    public String getModelo() {
        return Modelo;
    }

    public void setModelo(String Modelo) {
        this.Modelo = Modelo;
    }

    public int getAño() {
        return Año;
    }

    public void setAño(int Año) {
        this.Año = Año;
    }

    public float getPrecio() {
        return Precio;
    }

    public void setPrecio(float Precio) {
        this.Precio = Precio;
    }

    public float getPrima() {
        return Prima;
    }

    public void setPrima(float Prima) {
        this.Prima = Prima;
    }

        //metodos
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
    float MontoInteres = (super.getMonto()*12)/100;
    float cuota = (super.getMonto()+MontoInteres)/super.getPlazo();
    return cuota;
}

    public void mostrar(){
        System.out.println("Tipo de Financiamiento: "+ super.getTipoFinanciamiento()+"\n"
                            +"Titular: " + super.getTitular()+"\n"
                            +"Cedula del titular: "+ super.getCedula()+"\n"
                            +"Modelo del auto: "+getModelo()+"\n"
                            +"Año del auto: "+getAño()+"\n"
                            +"Precio del auto: "+getPrecio()+"\n"
                            +"Prima: "+getPrima()+"\n"
                            +"Salario: "+ super.getSalario()+"\n"
                            +"Monto: "+super.getMonto()+"\n"
                            +"Plazo: "+super.getPlazo()+"\n"
                            +"Estado del prestamo: "+super.getActivo()+"\n"
                            +"La cuota a pagar es de: "+CalcularCuota()+" cordobas."+"\n");
}
}
