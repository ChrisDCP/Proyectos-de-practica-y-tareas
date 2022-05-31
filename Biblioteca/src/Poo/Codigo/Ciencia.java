/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Poo.Codigo;


/**
 *
 * @author UNAN-Chontales
 */
public class Ciencia extends Libros{
   public String RamaCienia;

    public Ciencia(String RamaCienia, String ISBN, String Titulo, String Autor, int NPaginas, String Categoria, String SubCategoria, boolean Prestamo, int CalBase) {
        super(ISBN, Titulo, Autor, NPaginas, Categoria, SubCategoria, Prestamo, NPaginas);
        this.RamaCienia = RamaCienia;
    }

    public Ciencia() {
         super(null, null, null, 0, null, null, false, 0);
    }
   


    public String getRamaCienia() {
        return RamaCienia;
    }

    public void setRamaCienia(String RamaCienia) {
        this.RamaCienia = RamaCienia;
    }
   
    public String Status(){
    String estatus="";
    if (getCalBase()==0) { estatus="Principiante";}
    else if(getCalBase()>0 && getCalBase()<3){estatus = "junior";}
    else if(getCalBase()>=3 && getCalBase()<20){estatus = "intermedio";}
    else if(getCalBase()>=20 && getCalBase()<80){estatus = "Avanzado";}
    else if(getCalBase()>=80){estatus = "Senior";}

    return estatus;
    }

    @Override
    public void Calificacion(){
        System.out.println("La calificacion es: " + Status()+"\n");
    }

    @Override
    public void Mostrar(){
        System.out.println("Titulo: "+super.getTitulo()+"\n"
                        +"Categoria: "+super.getCategoria()+"\n"
                        +"ISBN: "+super.getISBN()+"\n"
                        +"Autor: "+super.getAutor()+"\n"
                        +"Numero de paginas: "+super.getNPaginas()+"\n"
                        +"Rama de la Ciencia: "+getRamaCienia()+"\n"
                        +"Categoria cientifica: "+super.getSubCategoria()
                        );
       
                    Calificacion();
}

}
