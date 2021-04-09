# AyED_TP1_Custom
Version en C# con POO del TP1 de AyED UTN ISI. Se supone que debe hacerse en python y utilizando estructuras basicas, quiero llevarlo mas haya y usarlo como ejemplo para serguir aprendiendo POO.

## Consigna

Este proceso es de lógica, para poder comprender el diseño general de un sistema, por tal motivo, se solicita:

A. Definir como constante cual será la clave que usarán para el acceso de las empresas
desarrolladoras.

B. Lo primero que el diagrama debe presentar es un menú de dos opciones: Empresas o
Clientes.

C. Si seleccionan CLIENTES, se debe mostrar un cartel que diga ‘Programa en Proceso’.

D. Si seleccionan la opción empresas (1), se deberá solicitar que ingresen por teclado una
clave la cual se validará con la constante generada.
Si la clave **no coincide**, se le dará hasta 3 posibilidades solicitando que ingrese
nuevamente una clave correcta. Si en la 3era posibilidad no coincide no podrá acceder
al menú de empresas desarrolladoras mostrando un cartel ’clave incorrecta’.
Si **coincide**, se le dará acceso al nuevo menú de empresas desarrolladoras (que por el
momento solo tendrá una acción).

Con clave correcta, en dicho menú:
a. Desarrollar el alta (ingresar datos al sistema) de empresas desarrolladoras,
identificadas solo en 3 posibles ciudades: ROS - Rosario, CBA - Córdoba y BA -
Buenos Aires. Se desconoce la cantidad de empresas que ingresarán, por lo cual
deben establecer un fin de datos acorde.
Finalizada la carga:
**Calcular** cantidad de empresas ingresadas por ciudad, y
**Mostrar** que ciudad tiene registrada más empresas desarrolladoras

MENU PRINCIPAL | MENU EMPRESAS DESARROLLADORAS 
------------ | -------------
1 EMPRESAS | 1 Alta de EMPRESAS
2 CLIENTES | 2 .
0 salir | 3 0
**** | 0 Volver al menu principal
 
Los datos que corresponden ser cargados son los siguientes (determinar el tipo de datos que
considere se ajusta a cada uno de ellos, como es el modelo en COD_ciudad)

__**EMPRESAS CONSTRUCTORAS**__
COD-EMP :
Nombre :
Dirección :
Mail :
Telefono :
COD_ciudad : string(3)

__**CIUDADES**__
COD_ciudad : string(3)
Nombre-Ciudad :

## TODO:
[ ] Conteo de empresas registradas por ciudad.
[ ] Control de ingreso de datos.
[ ] Normalizacion de nomenclaturas.
