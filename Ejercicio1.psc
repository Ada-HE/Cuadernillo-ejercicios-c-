Proceso  Descuento_cantidadpagar
	Escribir "Ingrese la cantidad a pagar";
    Leer CP;
    Si CP >=1800 Entonces
        DESC <- CP*0.30;
    SiNo
        DES <- CP*0.10;
    FinSi
    PF <- CP-DESC;
    Escribir "Valor de descuento: ", DESC;
    Escribir "Valor de precio final: ", PF;
FinProceso