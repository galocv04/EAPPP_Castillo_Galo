# Corrección del examen práctico de Diseño y Programación de Software

## Datos del estudiante

- Nombre: Galo Castillo Vargas
- Institución: Escuela Politécnica Nacional
- Asignatura: ITID 543 – Diseño y Programación de Software
- Docente: Jose Naranjo
- Período académico: 2026-B

## Descripción

Este proyecto corresponde a la corrección del examen práctico del primer
parcial. La aplicación permite gestionar pedidos de una cafetería
universitaria mediante un formulario desarrollado en C# con Windows Forms.

El usuario puede seleccionar productos del catálogo, ingresar cantidades,
agregar y quitar productos del pedido, elegir la modalidad de entrega y
seleccionar extras. El total se actualiza al realizar estos cambios.

La versión corregida se encuentra en la rama Coreccion. La versión inicial
se conserva en la rama main.

## Correcciones realizadas

- Se actualizaron los precios de acuerdo con el catálogo oficial.
- Se completó el catálogo con los diez productos solicitados.
- Se configuró la lista del pedido con producto, cantidad y subtotal.
- Se incorporaron validaciones para el cliente, el producto y la cantidad.
- Se implementó el cálculo del total mediante ActualizarTotal().
- Se agregó la eliminación de productos seleccionados.
- Se corrigió la selección de modalidad y el reinicio del pedido.
- Se incorporaron mensajes informativos en lblEstado.
- Se agregó .gitignore para excluir archivos temporales y compilados.

## Instrucciones de ejecución

1. Descargar o clonar el repositorio.
2. Seleccionar la rama Coreccion. Si se utiliza Git, ejecutar:

   git switch Coreccion

3. Abrir el archivo de solución .slnx en una versión compatible de Visual Studio.
4. Comprobar que esté instalada la carga de trabajo de desarrollo de
   escritorio con .NET.
5. Establecer el proyecto de la cafetería como proyecto de inicio.
6. Compilar y ejecutar con F5 o Ctrl + F5.

El formulario principal conserva el nombre Form1.

## Uso de la aplicación

1. Ingresar el nombre del cliente.
2. Seleccionar un producto del catálogo.
3. Escribir una cantidad entera mayor o igual a uno.
4. Presionar Agregar Ítem.
5. Seleccionar entrega en aula o los extras que se necesiten.
6. Consultar el total del pedido.
7. Para eliminar un producto, seleccionarlo en el pedido y presionar
   Quitar Seleccionado.
8. Para comenzar otro pedido, presionar Limpiar Pedido.

## Eventos implementados

| Evento | Controles | Función |
|---|---|---|
| Load | Form1 | Carga el catálogo, configura las listas y establece los valores iniciales. |
| SelectedIndexChanged | lvCatalogo | Obtiene el producto seleccionado y su precio. |
| SelectedIndexChanged | lvPedido | Habilita el botón para quitar la fila seleccionada. |
| Validating | txtCantidad | Comprueba que la cantidad sea un entero mayor o igual a uno. |
| TextChanged | txtCantidad y txtProducto | Actualiza la habilitación del botón Agregar. |
| CheckedChanged | rbtnMostrador y rbtnEntrega | Actualiza el total y comunica la modalidad seleccionada. |
| CheckedChanged | chkPostre y chkServilletas | Actualiza el total e informa sobre los extras. |
| Click | btnAgregar | Valida los datos y agrega el producto al pedido. |
| Click | btnQuitar | Elimina la fila seleccionada y recalcula el total. |
| Click | btnLimpiar | Reinicia el pedido y los controles. |

## Reglas de negocio

- El catálogo contiene diez productos con sus precios oficiales.
- El producto se selecciona desde el catálogo y su nombre aparece en un
  campo de solo lectura.
- El nombre del cliente es obligatorio y debe contener algún carácter
  diferente de espacios.
- Para agregar un ítem debe existir un producto seleccionado.
- La cantidad debe ser un número entero mayor o igual a uno.
- El subtotal de cada fila se calcula multiplicando la cantidad por el
  precio unitario.
- La entrega en aula agrega un recargo fijo de $0.50 por pedido.
- El postre agrega un valor fijo de $1.00 por pedido.
- Las servilletas y los cubiertos tienen un costo de $0.00.
- El total corresponde a la suma de subtotales, entrega y postre.
- Los recargos se aplican una sola vez al pedido.
- Al quitar productos o cambiar extras se actualiza el total.
- Al limpiar se restablece la cantidad a uno, se selecciona mostrador,
  se desmarcan los extras y el total vuelve a $0.00.

## Organización del cálculo

El método ActualizarTotal() recorre las filas de lvPedido con foreach,
suma los subtotales almacenados en Tag y agrega los extras activos.

Los eventos llaman a este método para reutilizar la misma fórmula y
aplicar el principio DRY.

## Archivos excluidos

El archivo .gitignore excluye las carpetas .vs, bin y obj, que contienen
archivos temporales de Visual Studio y resultados de compilación.
