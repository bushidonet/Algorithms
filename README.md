ALGORITMOS ORDENACION

1) BUBBLE SORT
2) INSERT SORT


1 BUBBLE SORT
Eplicacion:
Compara y intercambia elementos adyacentes si están en el orden incorrecto.
Este algoritmo tiene una complejidad de O(n²), por lo que es ineficiente para listas grandes.

![image](https://github.com/user-attachments/assets/7ac58c35-4be9-4287-a84d-9ecbec4aefe0)

Primera pasada:

Comparar 5 y 2 → intercambiar → [2, 5, 9, 1, 5, 6]
Comparar 5 y 9 → no intercambiar.
Comparar 9 y 1 → intercambiar → [2, 5, 1, 9, 5, 6]
Comparar 9 y 5 → intercambiar → [2, 5, 1, 5, 9, 6]
Comparar 9 y 6 → intercambiar → [2, 5, 1, 5, 6, 9]
Ahora, el 9 está en su lugar final.

Segunda pasada:

Comparar 2 y 5 → no intercambiar.
Comparar 5 y 1 → intercambiar → [2, 1, 5, 5, 6, 9]
Comparar 5 y 5 → no intercambiar.
Comparar 5 y 6 → no intercambiar.
El 6 ahora está en su lugar final.

Este proceso se repite hasta que la lista esté completamente ordenada.

