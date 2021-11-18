package Udemy.poo.Codigo;


public class Rectangulo extends Figura  {
    private double LadoUno;
    private double LadoDos;

    //Constructor

    public Rectangulo(double LadoUno, double LadoDos, double x, double y) {
        super(x, y);
        this.LadoUno = LadoUno;
        this.LadoDos = LadoDos;
    }
    
    //Getter And Setter
    public double getLadoUno() {
        return LadoUno;
    }

    public void setLadoUno(double LadoUno) {
        this.LadoUno = LadoUno;
    }

    public double getLadoDos() {
        return LadoDos;
    }

    public void setLadoDos(double LadoDos) {        
        this.LadoDos = LadoDos;
    }

    //Metodos extendidos
    @Override
    public double Area() {
        return LadoUno * LadoDos;
        
    }

    @Override
    public double Perimetro() {
        return (2 * LadoUno) + (2 * LadoUno);
        
    }
    
    
}
