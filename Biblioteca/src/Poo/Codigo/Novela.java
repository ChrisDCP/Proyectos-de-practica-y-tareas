/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Poo.Codigo;

/**
 *
 * @author UNAN-Chontales
 */
public class Novela extends Libros {
    private String Pprincipal;
    private String Epoca;

    public Novela(String Pprincipal, String Epoca, String ISBN, String Titulo, String Autor, int NPaginas, String Categoria, String SubCategoria, boolean Prestamo, int CalBase) {
        super(ISBN, Titulo, Autor, NPaginas, Categoria, SubCategoria, Prestamo,CalBase);
        this.Pprincipal = Pprincipal;
        this.Epoca = Epoca;
    }

    public Novela() {
        super(null, null, null, 0, null, null, false, 0);
    }


    public String getPprincipal() {
        return Pprincipal;
    }

    public void setPprincipal(String Pprincipal) {
        this.Pprincipal = Pprincipal;
    }

    public String getEpoca() {
        return Epoca;
    }

    public void setEpoca(String Epoca) {
        this.Epoca = Epoca;
    }


    @Override
    public void Calificacion(){
        System.out.println("La calificacion es: "+ super.getCalBase()+" Estrellas"+"\n");
    }

    @Override
    public void Mostrar(){
        System.out.println("Titulo: "+super.getTitulo()+"\n"
                        +"Categoria: "+super.getCategoria()+"\n"
                        +"ISBN: "+super.getISBN()+"\n"
                        +"Autor: "+super.getAutor()+"\n"
                        +"Numero de paginas: "+super.getNPaginas()+"\n"
                        +"Personaje principal: "+getPprincipal()+"\n"
                        +"Epoca de ambiemnte: "+getEpoca()+"\n"
                        +"Genero: "+super.getSubCategoria()
                        );
                    Calificacion();
    }
    
}
