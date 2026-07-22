Algoritmo Lecc35_inc2
	Definir precio, pago, cambio Como Real
    Definir b200, b100, b50, b20, monedas Como Entero
    
    Escribir "Ingrese el precio del producto:"
    Leer precio
    Escribir "Ingrese la denominación del billete con que pagó:"
    Leer pago
    
    Si pago >= precio Entonces
        cambio <- pago - precio
        Escribir "Cambio total a devolver: $", cambio
        
        b200 <- trunc(cambio / 200)
        cambio <- cambio - (b200 * 200)
        
        b100 <- trunc(cambio / 100)
        cambio <- cambio - (b100 * 100)
        
        b50 <- trunc(cambio / 50)
        cambio <- cambio - (b50 * 50)
        
        b20 <- trunc(cambio / 20)
        cambio <- cambio - (b20 * 20)
        
        monedas <- cambio
        
        Escribir "Billetes de 200: ", b200
        Escribir "Billetes de 100: ", b100
        Escribir "Billetes de 50: ", b50
        Escribir "Billetes de 20: ", b20
        Escribir "Monedas / Resto: ", monedas
    SiNo
        Escribir "El pago es menor que el precio del producto."
    FinSi
	
FinAlgoritmo
