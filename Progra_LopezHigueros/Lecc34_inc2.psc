Algoritmo Lecc34_inc2
	Definir peso, altura, imc Como Real
    
    Escribir "Ingrese su peso en kg:"
    Leer peso
    Escribir "Ingrese su altura en metros (ej. 1.75):"
    Leer altura
    
    Si altura > 0 Entonces
        imc = peso / (altura * altura)
        Escribir "Su Índice de Masa Corporal (IMC) es: ", imc
    SiNo
        Escribir "La altura debe ser mayor a cero."
    FinSi
FinAlgoritmo
