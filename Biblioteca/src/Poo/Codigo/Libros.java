/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Poo.Codigo;

/**
 *
 * @author UNAN-Chontales
 */
public class Libros {
    
       private String ISBN;
       private String Titulo;
       private String Autor;
       private int NPaginas;
       private String Categoria;
       private String SubCategoria;
       private boolean Prestamo;
      private int CalBase;

    public Libros(String ISBN, String Titulo, String Autor, int NPaginas, String Categoria, String SubCategoria, boolean Prestamo, int CalBase) {
        this.ISBN = ISBN;
        this.Titulo = Titulo;
        this.Autor = Autor;
        this.NPaginas = NPaginas;
        this.Categoria = Categoria;
        this.SubCategoria = SubCategoria;
        this.Prestamo = Prestamo;
        this.CalBase = CalBase;
    }


    public String getISBN() {
        return ISBN;
    }

    public void setISBN(String ISBN) {
        this.ISBN = ISBN;
    }

    public String getTitulo() {
        return Titulo;
    }

    public void setTitulo(String Titulo) {
        this.Titulo = Titulo;
    }

    public String getAutor() {
        return Autor;
    }

    public void setAutor(String Autor) {
        this.Autor = Autor;
    }

    public int getNPaginas() {
        return NPaginas;
    }

    public void setNPaginas(int NPaginas) {
        this.NPaginas = NPaginas;
    }

    public String getCategoria() {
        return Categoria;
    }

    public void setCategoria(String Categoria) {
        this.Categoria = Categoria;
    }

    public String getSubCategoria() {
        return SubCategoria;
    }

    public void setSubCategoria(String SubCategoria) {
        this.SubCategoria = SubCategoria;
    }

    public boolean isPrestamo() {
        return Prestamo;
    }

    public void setPrestamo(boolean Prestamo) {
        this.Prestamo = Prestamo;
    }

    public int getCalBase() {
        return CalBase;
    }

    public void setCalBase(int CalBase) {
        this.CalBase = CalBase;
    }



public void Calificacion(){}

public void Mostrar(){}

}
