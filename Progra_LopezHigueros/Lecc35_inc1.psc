Algoritmo Lecc35_inc1
	Definir cantidad Como Real
    Definir respuesta Como Caracter
    
    Repetir
        Escribir "--- Convertidor de Moneda ---"
        Escribir "Ingrese la cantidad en su moneda local:"
        Leer cantidad
        
        Escribir ""
        Escribir "Equivalente en 5 países:"
        
        // Tasas de cambio de ejemplo (puedes ajustarlas según tu moneda local)
        Escribir "1. Estados Unidos (Dólar): $", cantidad * 0.13
        Escribir "2. Europa (Euro): ?", cantidad * 0.12
        Escribir "3. México (Peso mexicano): $", cantidad * 2.20
        Escribir "4. Japón (Yen): ¥", cantidad * 20.50
        Escribir "5. Reino Unido (Libra): £", cantidad * 0.10
        
        Escribir ""
        Escribir "¿Desea convertir otra cantidad? (s/n):"
        Leer respuesta
        
    Hasta Que respuesta = "n" O respuesta = "N"
FinAlgoritmo
