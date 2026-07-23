Algoritmo lecc32_ac1_pag116 
	Definir m,op,r Como Real
	Escribir "Ingrese la cantidad de metros"
	Leer m
	Escribir "Seleccione una opcion"
	Escribir "1. milimetros"
	Escribir "2. centimetros"
	Escribir "3. decimetros"
	Escribir "4. hectometros"
	Escribir "5. kilometros"
	Leer op
	Segun op Hacer
		1: r=m*1000
			Escribir r, " mili"
		2: r=m*100
			Escribir r, " cm"
		3: r=m*10
			Escribir r, " dm"
		4: r=m/100
			Escribir r, " hect"
		5: r=m/1000
			Escribir r, " km"
		De Otro Modo:
			Escribir "No existe esta opcion"
	FinSegun
FinAlgoritmo