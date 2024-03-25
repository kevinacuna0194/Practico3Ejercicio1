# Práctico 3 Ejercicio 1 :bookmark_tabs:
~~~
Un banco nos solicita un sistema para gestionar su actividad.  
De los clientes:  
Se conoce el documento de identidad (string de largo 8), nombre completo (no puede ser vacío 
ni nulo)  y una cuenta bancaria.  
De las cuentas:  
Se conoce el número de cuenta (10 dígitos), el tipo de moneda en formato ISO (se debe realizar 
la verificación mediante enumerados sabiendo que el banco solo trabaja con cuentas en 
dólares o pesos uruguayos) y el saldo actual (mayor o igual a 0).   
Códigos de divisa 
UYU 858 
USD 840 
AR 
32 
EUR 978 
Se podrá hacer un depósito a la cuenta y se debe controlar que no supere los $ 50000 o U$S 
1000. Este método debe indicar si fue posible realizar la operación.  
Se podrá hacer un retiro de la cuenta, no se puede retirar más dinero que el que tiene 
disponible. Este método debe indicar si fue posible realizar la operación.  
Las cuentas (tanto en pesos como en dólares) deben tener la posibilidad de expresar su saldo 
en dólares respetando el tipo de cambio del día, común a todas las cuentas. 
Se debe poder además, modificar el tipo de cambio de las cuentas en cualquier momento. 
Discutir posibles soluciones para este requerimiento.  
Se pide:  
1. Realiza el UML de acuerdo con la realidad planteada.  
2. Crear las clases cuenta y cliente con validaciones  
3. Realizar pruebas en consola y mostrar todos los datos del cliente, incluyendo los de 
la cuenta. 
~~~
---
<p align="center" font-weight="bold">
      <img src="https://img.shields.io/badge/CSharp-323330?style=for-the-badge&logo=CSharp&logoColor=F7DF1E">
      <br>
      <img src="https://img.shields.io/badge/RESUELTO-informational?style=social&logo=csharp">
</p>
