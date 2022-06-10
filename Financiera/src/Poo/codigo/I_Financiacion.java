/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package Poo.codigo;

/**
 *
 * @author UNAN-Chontales
 */
public interface I_Financiacion {
    void RegistrarSolicitud();

    void AprobarPrestamo();

    void CancelarPrestamo();

    abstract float CalcularCuota();
}
