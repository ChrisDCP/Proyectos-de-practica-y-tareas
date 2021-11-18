package Udemy.poo.Codigo;


public class Elipse extends Figura {

   private double EjeUno;
   private double EjeDos;

   //constructor vacio
    public Elipse() {
    }

   //constructor
    public Elipse(double EjeUno, double EjeDos) {
        this.EjeUno = EjeUno;
        this.EjeDos = EjeDos; 
    }

    //getter and setter
    public double getEjeUno() {
        return EjeUno;
    }

    public void setEjeUno(double EjeUno) {
        this.EjeUno = EjeUno;
    }

    public double getEjeDos() {
        return EjeDos;
    }

    public void setEjeDos(double EjeDos) {
        this.EjeDos = EjeDos;
    }
   
   //metodos extendidos
    
    @Override
    public double Area() {
       return Math.PI * EjeUno * EjeDos;  
    }

    @Override
    public double Perimetro() {
        return(Math.PI *(3*(EjeUno * EjeDos)) 
        - (Math.sqrt((3 * EjeUno + EjeDos) * (EjeUno + 3))));
    }

}
