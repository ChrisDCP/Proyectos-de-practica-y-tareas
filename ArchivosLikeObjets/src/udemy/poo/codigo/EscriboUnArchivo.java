/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package udemy.poo.codigo;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectOutput;
import java.io.ObjectOutputStream;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author UNAN-Chontales
 */
public class EscriboUnArchivo {
    public static void main(String[] args) throws IOException {
               FileOutputStream fo = null;
        try {
            File f = new File(System.getProperty("user.dir") + "/archivo");
            fo = new FileOutputStream(f);
            ObjectOutput ou = new ObjectOutputStream(fo);
            ou.writeObject(new Persona("Maria", "Hernández", "Sánchez", 23));
            ou.writeObject(new Persona("Pepe", "Martínez", "Salvador", 22));
            ou.writeObject(new Persona("Mercader", "Hernández", "Jiménez", 21));
            ou.writeObject(new Persona("Moisés", "Solveria", "Sorrotela", 20));
            ou.writeObject(new Persona("Monses", "Tapia", "Curiel", 15));
            ou.close();
        } catch (FileNotFoundException ex) {
            ex.printStackTrace();
        } finally {
            try {
                fo.close();
            } catch (IOException ex) {
                ex.printStackTrace();
            }
        }
    }
}

