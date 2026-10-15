# Sintaxis Básica de C#

Proyectos en consola C# para ejercitar tipos de datos, memoria, asignación e interpolación.

---

## 💻 Resumen de Ejercicios

* **1. Tipos de Datos y Memoria (`tiposDeDatos`)**
  Declara un entero, un arreglo y un `string`. Muestra cómo las modificaciones en una variable que apunta a un arreglo afectan al dato original en la memoria *Heap* (tipos de referencia).

* **2. Operadores y Cálculos (`operadoresAritmeticos`)**
  Calcula el subtotal de una compra, le descuenta 20 unidades con asignación compuesta (`-=`), le suma el 19% de IVA y muestra el total formateado en pantalla.

* **3. Conversión de Datos e Interpolación (`interpolacionDeStrings`)**
  Convierte textos a números (`int.Parse` y `double.Parse`), calcula la edad en meses y la estatura en centímetros, e imprime los resultados usando interpolación (`$""`).

* **4. Reto: Tipos Primitivos (`retoTiposDeDatos`)**
  Declara variables usando los 5 tipos primitivos (`int`, `double`, `bool`, `string`, `char`) y las muestra en consola con etiquetas descriptivas.

* **5. Reto: Recálculo Geométrico (`retoOperadores`)**
  Calcula área y perímetro de un rectángulo (7x5), ajusta sus medidas con asignación compuesta (`+= 3` y `-= 2`), y vuelve a calcular y mostrar las nuevas dimensiones (10x3).

---

## 📂 Estructura

```text
.
├── Sintaxis_CSharp.sln
├── ejercicios/
│   ├── tiposDeDatos/
│   ├── operadoresAritmeticos/
│   └── interpolacionDeStrings/
└── retos/
    ├── retoTiposDeDatos/
    └── retoOperadores/