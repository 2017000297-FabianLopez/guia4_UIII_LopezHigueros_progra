Algoritmo lecc33_act2
	Definir frase, frase_invertida Como Caracter
    Definir i, longitud_frase Como Entero
    
    Escribir "Ingrese una frase:"
    Leer frase
    

    longitud_frase = Longitud(frase)
    frase_invertida = ""
    
   
    Para i = longitud_frase Hasta 1 Con Paso -1 Hacer
        
        frase_invertida <- frase_invertida + Subcadena(frase, i, i)
    FinPara
    
    Escribir ""
    Escribir "La frase invertida es:"
    Escribir frase_invertida
	
FinAlgoritmo
