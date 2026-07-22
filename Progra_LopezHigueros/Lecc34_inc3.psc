Algoritmo Lecc34_inc3
		Definir c, resultado Como Real
		Definir opcion Como Caracter
		
		Escribir "Ingrese la cantidad en grados centígrados (Celsius):"
		Leer c
		
		Escribir "Seleccione a qué desea convertir:"
		Escribir "a. Fahrenheit"
		Escribir "b. Celsius"
		Escribir "c. Kelvin"
		Leer opcion
		
		Segun opcion Hacer
			"a", "A":
				resultado = (c * 9/5) + 32
				Escribir c, " grados centígrados equivalen a ", resultado, " Fahrenheit."
			"b", "B":
				resultado = c
				Escribir c, " grados centígrados equivalen a ", resultado, " Celsius."
			"c", "C":
				resultado = c + 273.15
				Escribir c, " grados centígrados equivalen a ", resultado, " Kelvin."
			De Otro Modo:
				Escribir "Opción no válida."
		FinSegun
FinAlgoritmo

