/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package udemy.poo.codigo;

import java.io.EOFException;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.util.logging.Level;
import java.util.logging.Logger;
/**
 *
 * @author UNAN-Chontales
 */
public class leoUnArchivo {
    public static void main(String[] args) throws IOException, ClassNotFoundException{
        
            FileInputStream fi = null;
        try {
            File f = new File(System.getProperty("user.dir") + "/archivo");
            System.out.println(f);
            fi = new FileInputStream(f);
            ObjectInputStream oi = new ObjectInputStream(fi);
            Persona ob = null;
            
            do {                
                ob = (Persona)oi.readObject();
                System.out.println(ob.toString());
            } while (true);
            
        } catch (FileNotFoundException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            System.out.println("Fin del archivo");
        } catch (ClassNotFoundException ex) {
            ex.printStackTrace();
        } finally {
            try {
                fi.close();
            } catch (IOException ex) {
                Logger.getLogger(leoUnArchivo.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
    }
    
}
