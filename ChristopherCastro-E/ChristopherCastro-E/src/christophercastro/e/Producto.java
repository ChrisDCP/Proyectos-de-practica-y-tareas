/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package christophercastro.e;
/**
 *
 * @author PC26-B5
 */
public class Producto {
    
    private String NombreProducto;
    private double Precio;
    private int Ccantidad;
    

    public Producto(String NombreProducto, double Precio, int Ccantidad) {
        this.NombreProducto = NombreProducto;
        this.Precio = Precio;
        this.Ccantidad = Ccantidad;
    }


    public String getNombreProducto() {
        return NombreProducto;
    }

    public void setNombreProducto(String NombreProducto) {
        this.NombreProducto = NombreProducto;
    }

    public double getPrecio() {
        return Precio;
    }

    public void setPrecio(double Precio) {
        this.Precio = Precio;
    }

    public int getCcantidad() {
        return Ccantidad;
    }

    public void setCcantidad(int Ccantidad) {
        this.Ccantidad = Ccantidad;
    }

}
