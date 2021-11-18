package Udemy.poo.Codigo;

/*
 * @author Christopher C.
 */

public abstract class Figura {
    
    private double x;
    private double y;

    //constructor vacio
    public Figura(){
    }
    
    //constructor 
    public Figura(double x, double y) {
        this.x = x;
        this.y = y;
    }

    //getter and setter
    public double getX() {
        return x;
    }

    public void setX(double x) {
        this.x = x;
    }

    public double getY() {
        return y;
    }

    public void setY(double y) {
        this.y = y;
    }
    
    public abstract double Area();
    
    public abstract double Perimetro();
    
}
