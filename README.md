# tl1-tp6-2024-SanBarrio
## Ejercicio 4
### ¿String es una tipo por valor o un tipo por referencia?
- En C#, string es un tipo de referencia. Aunque se comporta de manera similar a los tipos de valor en ciertos aspectos, como la inmutabilidad (es decir, no puedes cambiar el valor de un objeto string una vez que se ha creado), técnicamente es un tipo de referencia.

### ¿Qué secuencias de escape tiene el tipo string?
Las secuencias de escape en las cadenas de texto en C# son:
- \\ : Barra invertida
- \\' : Comilla simple
- \\" : Comilla doble
- \\0 : Nulo
- \\a : Alerta
- \\b : Retroceso
- \\f : Avance de página
- \\n : Nueva línea
- \\r : Retorno de carro
- \\t : Tabulación horizontal
- \\v : Tabulación vertical

### ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
- @ : El prefijo @ en C# se utiliza para crear cadenas literales. Las cadenas literales no reconocen las secuencias de escape, lo que significa que puedes incluir caracteres como barras invertidas sin tener que escaparlas.
- $ : El prefijo $ en C# se utiliza para crear cadenas interpoladas. Las cadenas interpoladas pueden contener expresiones incrustadas, que son reemplazadas por sus valores cuando se ejecuta la cadena. Las expresiones incrustadas se identifican por las llaves {}.