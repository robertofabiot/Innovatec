# 🌳 Innovatec - Gestión de Árboles y Grafos 🗺️

Este proyecto es una aplicación de escritorio de Windows Forms desarrollada en C# para gestionar dos sistemas principales del parque tecnológico "Innovatec", como parte de un caso de estudio sobre estructuras de datos.

La aplicación demuestra la implementación y el uso práctico de **Árboles Generales** (para jerarquías) y **Grafos No Dirigidos Ponderados** (para rutas).

---

## 🚀 Módulos y Funcionalidades

El sistema se divide en dos pestañas principales:

---

## 1. Jerarquía Organizativa (Árboles)

Este módulo permite a un administrador construir y visualizar la estructura organizativa completa del parque.  
La lógica de esta sección está implementada directamente en la **Vista** (patrón Code-Behind) para una manipulación visual directa.

### **Funcionalidades Clave**

#### ✔ Construcción Dinámica
- Añadir **"Puestos Principales"** (nodos raíz), permitiendo múltiples jerarquías (bosques).
- Añadir **"Puestos Subordinados"** (nodos hijos) a cualquier puesto seleccionado.

#### ✔ Búsqueda Interactiva
- Un cuadro de búsqueda que filtra y resalta en tiempo real los nodos del árbol (*StartsWith*).

#### ✔ Recorridos Visuales
- Animaciones visuales con *async/await* para:
  - Preorden  
  - Inorden  
  - Postorden  
- Los nodos se resaltan uno por uno para demostrar el algoritmo.

#### ✔ Contadores
- Muestra:
  - Total de puestos en el parque.
  - Total de subordinados bajo el puesto seleccionado.

---

## 2. Sistema de Rutas (Grafos)

Este módulo permite mapear las conexiones físicas entre los edificios del parque.  
Esta sección sigue una arquitectura **Modelo-Vista-Controlador (MVC)** estricta:

### **Arquitectura**
- **Modelo (Model/):** `Conexion.cs`, `RutaResultado.cs` (POCOs).
- **Controlador (Controller/RutaController.cs):** Lógica de negocio. Usa una **Lista de Adyacencia** (`Dictionary`) para el grafo.
- **Vista (View/Form1.cs):** Llama al controlador, recibe códigos de estado y se actualiza.

### **Funcionalidades Clave**

#### ✔ Gestión del Grafo
- **Agregar Edificios (Nodos):** Registrar nuevos edificios.
- **Agregar Rutas (Aristas):** Conectar dos edificios con una distancia (peso).

#### ✔ Validación de Negocio (en el Controlador)
- No se permiten rutas duplicadas.  
- No se permite una ruta de un edificio a sí mismo.  
- No se pueden agregar rutas a edificios inexistentes.  
- La distancia debe ser un número positivo.

#### ✔ Cálculo de Rutas
- Implementación del **Algoritmo de Dijkstra** para hallar la ruta más corta entre dos edificios.

#### ✔ Análisis del Grafo
- **Lista de Adyacencia:** Vista en texto que se actualiza en tiempo real.  
- **Validación de Conexidad:** Botón que usa **BFS** para verificar si el grafo es conexo.

---

## 🛠️ Tecnologías Utilizadas

- C# (.NET Framework 4.7.2)  
- Windows Forms  
- **Estructuras de Datos:** `TreeView`, `Dictionary`, `List` 
- **Algoritmos:** Dijkstra, Preorden, Inorden, Postorden  
- **Patrones de Arquitectura:**
  - Code-Behind (Árboles)
  - MVC (Grafo)