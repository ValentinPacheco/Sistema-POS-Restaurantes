# Sistema POS para pequeños negocios restauranteros

**Equipo:**  
- Camargo Loaiza Miguel Angel 
- Pacheco Olivs Juan Pablo Valentín 

---

## Problemática

En la ciudad de **Hermosillo**, existe una gran cantidad de pequeños y medianos negocios del sector restaurantero (taquerías, fondas, cafeterías y puestos de comida) que operan con procesos administrativos deficientes, principalmente por:

- Uso de libretas o registros manuales  
- Falta de control real sobre ventas diarias  
- Errores frecuentes en cortes de caja  
- Pérdida de información histórica  
- Desconocimiento de productos más vendidos  
- Falta de control de inventarios  
- Dependencia total de la memoria del encargado  

Estas prácticas provocan **pérdidas económicas**, desorganización operativa y dificultan la toma de decisiones, limitando el crecimiento del negocio.

Además, muchos propietarios no utilizan sistemas comerciales existentes debido a:

- Costos elevados  
- Complejidad de uso  
- Requerimientos técnicos (internet constante, hardware especial)  
- Falta de adaptación a la realidad local  

---

## Objetivo general

Desarrollar un **sistema de punto de venta (POS)** para restaurantes pequeños en Hermosillo que permita mejorar la administración, el control de ventas y la toma de decisiones, mediante una herramienta **accesible, fácil de usar y adaptada** a las necesidades reales del negocio local.

---

## Objetivos específicos

- Automatizar el proceso de ventas, reduciendo errores humanos al registrar pedidos y cobros.  
- Centralizar la información de ventas, usuarios y caja en una base de datos estructurada y segura.  
- Facilitar el control de caja, permitiendo aperturas, cierres y registros de movimientos claros y verificables.  
- Proporcionar reportes básicos:
  - Ventas diarias  
  - Productos más vendidos  
  - Ingresos por método de pago  
- Mejorar la transparencia del negocio, identificando inconsistencias en ingresos y gastos.  
- Ofrecer una solución económica y práctica para pequeños negocios.  
- Reducir la dependencia de procesos manuales, permitiendo al propietario enfocarse en el crecimiento del negocio.  

---

## Enfoque, limitaciones y expectativas

### Enfoque del sistema
- Restaurantes pequeños y medianos  
- Operación local (una sola sucursal)  
- Uso en equipos de escritorio  
- Funcionamiento sin conexión constante a internet  

### No contempla inicialmente
- Facturación electrónica  
- Integraciones bancarias  
- Operación multisucursal  

### Expectativas
Se espera que los negocios que implementen el sistema:

- Mejoren su control administrativo  
- Disminuyan pérdidas por mala gestión  
- Logren una mejor gestión operativa  
- Obtengan información confiable para la toma de decisiones  
- Profesionalicen su negocio  

---

## Tecnologías

### Lenguaje y plataforma
El sistema será desarrollado utilizando **C#** como lenguaje de programación principal, ejecutándose sobre la plataforma **.NET**, permitiendo construir una aplicación robusta, eficiente y adecuada para entornos empresariales.

### Interfaz gráfica
La interfaz será implementada mediante **Windows Forms**, ofreciendo un entorno visual intuitivo, sencillo de usar y optimizado para equipos de cómputo utilizados en restaurantes.

---

## Sistema gestor de base de datos

Para el almacenamiento y gestión de la información se utilizará **Microsoft SQL Server**, permitiendo manejar de forma segura los datos relacionados con:

- Usuarios  
- Roles  
- Productos  
- Categorías  
- Pedidos  
- Pagos  
- Caja  
- Movimientos financieros  

El acceso a la base de datos se realizará mediante **ADO.NET**, permitiendo la ejecución de consultas SQL, procedimientos almacenados y transacciones desde la aplicación en C#.

---

## Seguridad de datos

Se implementará el uso de **System.Security.Cryptography** para el cifrado de contraseñas, evitando el almacenamiento de información sensible en texto plano y fortaleciendo el control de acceso al sistema.

---

## Arquitectura del sistema

El sistema seguirá una **arquitectura en capas**, separando:

- Interfaz gráfica  
- Lógica de negocio  
- Acceso a datos  

Esto permitirá un desarrollo ordenado, escalable y fácil de mantener, además de facilitar futuras mejoras o migraciones tecnológicas.
