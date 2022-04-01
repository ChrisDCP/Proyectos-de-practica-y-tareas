Algoritmo sin_titulo
	Para i<-1 hasta 5 Con Paso 1 Hacer
		Escribir "ingrese la nota";
		Leer nota;
		suma<-suma+nota;
	FinPara
	promedio	<-suma/5;
	Escribir "El promedio del estudiante es: ",promedio;
	si promedio>=60 escribir "Aprobado"
	SiNo
		Escribir "F";
	FinSi
FinAlgoritmo
