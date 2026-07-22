Algoritmo lecc34_act1
	Definir opcion Como Entero
    Definir num_decimal, aux, residuo, i, potencia, decimal_calculado Como Entero
    Definir num_binario, digito Como Caracter
	
    Escribir "--- Conversor Numérico ---"
    Escribir "1. Convertir de Decimal a Binario"
    Escribir "2. Convertir de Binario a Decimal"
    Escribir "Elija una opción (1 o 2):"
    Leer opcion
	
    Segun opcion Hacer
        1:
            Escribir "Ingrese un número decimal entero positivo:"
            Leer num_decimal
            Si num_decimal = 0 Entonces
                num_binario = "0"
            SiNo
                num_binario = ""
                aux = num_decimal
              
                Mientras aux > 0 Hacer
                    residuo = aux Mod 2
                    num_binario = ConvertirATexto(residuo) + num_binario
                    aux = trunc(aux / 2)
                FinMientras
            FinSi
            Escribir "El número en binario es: ", num_binario
			
        2:
            Escribir "Ingrese un número binario (solo ceros y unos):"
            Leer num_binario
            decimal_calculado = 0
            potencia = 0
        
            Para i = Longitud(num_binario) Hasta 1 Con Paso -1 Hacer
                digito = Subcadena(num_binario, i, i)
                Si digito = "1" Entonces
                    decimal_calculado <- decimal_calculado + (2^potencia)
                FinSi
                potencia = potencia + 1
            FinPara
            Escribir "El número en decimal es: ", decimal_calculado
			
        De Otro Modo:
            Escribir "Opción no válida."
    FinSegun
FinAlgoritmo
