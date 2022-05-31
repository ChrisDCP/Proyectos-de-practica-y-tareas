/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Poo.Codigo;

/**
 *
 * @author UNAN-Chontales
 */
public class Poesia extends Libros{
    private int CantidadPoemas;
    private int Factor;

    public Poesia(int CantidadPoemas, int Factor, String ISBN, String Titulo, String Autor, int NPaginas, String Categoria, String SubCategoria, boolean Prestamo, int CalBase) {
        super(ISBN, Titulo, Autor, NPaginas, Categoria, SubCategoria, Prestamo, NPaginas);
        this.CantidadPoemas = CantidadPoemas;
        this.Factor = Factor;
    }

    public Poesia() {
        super(null, null, null, 0, null, null, false, 0);
    }

   

   
    public int getCantidadPoemas() {
        return CantidadPoemas;
    }

    public void setCantidadPoemas(int CantidadPoemas) {
        this.CantidadPoemas = CantidadPoemas;
    }

    public int getFactor() {
        return Factor;
    }

    public void setFactor(int Factor) {
        this.Factor = Factor;
    }

    @Override
    public void Calificacion(){
         System.out.println("La calificacion del autor es: "+ (super.getCalBase()*Factor/getCantidadPoemas())+"\n");
    }

    @Override
    public void Mostrar(){
        System.out.println("Titulo: "+super.getTitulo()+"\n"
                        +"Categoria: "+super.getCategoria()+"\n"
                        +"ISBN: "+super.getISBN()+"\n"
                        +"Autor: "+super.getAutor()+"\n"
                        +"Numero de paginas: "+super.getNPaginas()+"\n"
                        +"Cantidad de poemas: "+getCantidadPoemas()
                        );
                    Calificacion();
}

}
