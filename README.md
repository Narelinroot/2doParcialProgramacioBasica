# UNIVERSIDAD CENTRAL DEL ESTE (UCE)
## Segundo Parcial – Programación Básica

Estudiante: Narelin Vittini

Matrícula: 2025-2618

Maestro: Gamalier Reyes del Carmen

Asignatura: Programación Básica

Lenguaje: C#

Entorno de desarrollo: Visual Studio

Tipo de proyecto: Windows Forms (.NET)

## Descripción

Desarrollo de un ejercicio práctico correspondiente al segundo parcial de Programación Básica, utilizando C# y Windows Forms.
El programa permite registrar pedidos de clientes, agregar productos y calcular automáticamente el monto total a pagar, 
aplicando descuentos, cargos por empaque e ITBIS.

## Objetivo

Desarrollar una aplicación con interfaz gráfica que permita ingresar, procesar y mostrar pedidos de una cafetería mediante diferentes controles y eventos.

## Elementos utilizados

Formulario (Form).

Label.

TextBox.

Button.

DateTimePicker.

NumericUpDown.

RadioButton.

CheckBox.

ListBox.

## Funcionalidades

Registro de los datos del cliente.

Ingreso del nombre y precio de los productos.

Selección de cantidad y tamaño.

Aplicación de cargos por tamaño grande y porción extra.

Registro de productos en el pedido.

Cálculo automático del subtotal.

Aplicación de descuento para clientes frecuentes.

Cálculo del empaque e ITBIS.

Presentación del total a pagar.

Limpieza de los datos para registrar un nuevo pedido.

Confirmación antes de salir del programa.

## Desarrollo del ejercicio

Nombre del ejercicio: Pedidos de la cafetería «El Buen Sabor».

### ¿Qué hará el programa?

El programa permitirá registrar los datos del cliente y agregar diferentes productos a un pedido. También calculará el subtotal, aplicará el descuento correspondiente si el cliente es frecuente, agregará el costo de empaque cuando el servicio sea para llevar y calculará el ITBIS del 18 % para obtener el total a pagar.

Clases y métodos utilizados:

Clase frmPedidos.

Constructor frmPedidos().

Método Form1_Load().

Método btnAgregar_Click().

Método btnCalcular_Click().

Método btnLimpiar_Click().

Método btnSalir_Click().

Datos de entrada

Nombre del cliente.

Fecha del pedido.

Nombre del producto.

Precio del producto.

Cantidad.

Tamaño normal o grande.

Selección de porción extra.

Tipo de servicio: local o para llevar.

Selección de cliente frecuente.

### Proceso

Se ingresan los datos del cliente.

Se escribe el nombre y precio del producto.

Se seleccionan la cantidad, el tamaño y la porción extra.

Se calcula el precio unitario según las opciones seleccionadas.

Se multiplica el precio unitario por la cantidad.

Se agregan los productos al pedido y se acumula el subtotal.

Se calcula el descuento del 10 % si el cliente es frecuente.

Se agrega RD$20 de empaque si el pedido es para llevar.

Se calcula el ITBIS del 18 %.

Se obtiene y muestra el total a pagar.

### Salida

El programa muestra:

La lista de productos agregados al pedido.

El subtotal.

El descuento aplicado.

El costo de empaque.

El ITBIS correspondiente.

El total final a pagar.

### Resultado de la prueba realizada:

Subtotal: RD$560.00

Descuento: RD$56.00

Empaque: RD$20.00

ITBIS: RD$94.32

Total a pagar: RD$618.32

## Capturas de pantalla del programa en ejecución

Pantalla inicial del formulario.


Registro de los datos del cliente y primer producto.



Primer producto agregado al pedido.

Lista con los dos productos agregados.

Pedido calculado con los resultados finales.

Mensaje de confirmación antes de salir.






Segundo Parcial – Programación Básica
Universidad Central del Este (UCE)
