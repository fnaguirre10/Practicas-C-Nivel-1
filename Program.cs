// Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. 
//A partir de dichos datos informar:
// a. El mayor de los números pares.
// b. La cantidad de números impares.
// c. El menor de los números primos.
// Nota: evaluar el uso de una función que analice si un número dado es primo o no
//y que devuelva true o false según corresponda.

Console.WriteLine("Hola!");
int numero, minimoPrimos = 0, contadorImpares = 0, banderaPares = 0;
int maxPares = 0;
bool numPrimo, banderaPrimo;

Console.WriteLine("Ingrese un numero o ingrese 0 para finalizar el programa");
numero= int.Parse(Console.ReadLine());
banderaPrimo = false;

while (numero!= 0){

    if (numero % 2 == 0){
        banderaPares ++;
        if (banderaPares == 1){
            maxPares = numero;
        } else {
            if(numero > maxPares){
                    maxPares = numero;
            }
        }
    }else {
        contadorImpares ++;
    }

    if (numero > 0){
        numPrimo = primo (numero);
        if (numPrimo == true){
            if (banderaPrimo == false){
                banderaPrimo = true;
                minimoPrimos = numero;
            } else {
                if(numero < minimoPrimos){
                    minimoPrimos = numero;
                }
            }
        }
    }

    numero= int.Parse(Console.ReadLine());
}

if (maxPares != 0){
    Console.WriteLine("El mayor de los números pares es " + maxPares);
} else {
    Console.WriteLine("No hay numeros pares");
}

if (contadorImpares != 0){
    Console.WriteLine("La cantidad de numeros impares es " + contadorImpares);
} else {
    Console.WriteLine("No hay numeros impares");
}

if (minimoPrimos != 0){
    Console.WriteLine("El menor de los numeros primos es " + minimoPrimos);
} else {
    Console.WriteLine("No hay numeros primos");
}

static bool primo (int num){
    int con=0;
    bool r;
    for(int x=1;x<=num; x++){
        if (num % x ==0){
            con++;
        }
    }
    if (con == 2){
        r = true;
    }else{
        r = false;
    }
    return r;
}