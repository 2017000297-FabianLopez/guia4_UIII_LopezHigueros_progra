Algoritmo Lecc32_inc1
    Definir metros, resultado Como Real
    Definir opcion Como Caracter
	
    Escribir "Ingrese la cantidad en metros:"
    Leer metros
	
    Escribir "Seleccione a qué desea convertir:"
    Escribir "a. Milímetros"
    Escribir "b. Centímetros"
    Escribir "c. Decímetros"
    Escribir "d. Hectómetros"
    Escribir "e. Kilómetros"
    Leer opcion
	
    Segun opcion Hacer
        "a", "A":
            resultado = metros * 1000
            Escribir metros, " metros equivale a ", resultado, " milímetros."
        "b", "B":
            resultado = metros * 100
            Escribir metros, " metros equivale a ", resultado, " centímetros."
        "c", "C":
            resultado = metros * 10
            Escribir metros, " metros equivale a ", resultado, " decímetros."
        "d", "D":
            resultado = metros / 100
            Escribir metros, " metros equivale a ", resultado, " hectómetros."
        "e", "E":
            resultado = metros / 1000
            Escribir metros, " metros equivale a ", resultado, " kilómetros."
        De Otro Modo:
            Escribir "Opción no válida."
    FinSegun
FinAlgoritmo