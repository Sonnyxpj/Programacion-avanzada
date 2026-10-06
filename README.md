# 🔧 Dinobot's Mechanical Workshop 🔧

Aplicación de consola en **C# (.NET 7)** que simula la atención de clientes en un taller mecánico. El programa registra los datos del cliente y de su vehículo (automóvil, motocicleta o camión), le muestra un menú de servicios con su tiempo estimado y costo, y simula la impresión de la boleta con una barra de carga.

Proyecto desarrollado para el curso de **Programación Avanzada**, aplicando conceptos de programación orientada a objetos: herencia, clases abstractas, polimorfismo, interfaces, encapsulamiento con propiedades y sobrecarga de constructores.

## Funcionalidades

- **Registro de cliente:** nombre, RUT y edad son obligatorios. El correo y el teléfono son opcionales. Valida campos vacíos, mayoría de edad y formato de teléfono (9 dígitos, por ejemplo `912345678`).
- **Registro de vehículo:** marca, modelo, patente (6 caracteres), año y kilometraje, más un dato propio de cada tipo:
  - Automóvil → color
  - Motocicleta → cilindrada (cc)
  - Camión → capacidad de carga (kg)
- **Menú de servicios:** 11 servicios del taller, cada uno con tiempo estimado y costo.

| # | Servicio | Tiempo estimado | Costo |
|---|----------|-----------------|-------|
| 1 | Ajuste de motor | 4 días | $700.000 |
| 2 | Balanceo de ruedas | 20 min | $10.000 |
| 3 | Cambio de aceite | 30 min | $8.000 |
| 4 | Cambio de bujías | 20 min | $10.000 |
| 5 | Cambio de correa de distribución | 3 horas | $60.000 |
| 6 | Cambio de pastillas de freno | 30 min | $10.000 |
| 7 | Cambio de kit de embrague | 6 horas | $120.000 |
| 8 | Cambio de suspensión y amortiguación | 2 horas | $45.000 |
| 9 | Cambio de filtro de combustible | 15 min | $15.000 |
| 10 | Mantención de sistema electrónico | 20 min | $15.000 |
| 11 | Escáner | 30 min | $25.000 |

- **Boleta:** barra de progreso en consola durante la "impresión". La clase `Boleta` también puede generar `Boleta.txt` a partir de los datos de la sucursal (`Sucursal.txt`).
- **Métodos de pago:** interfaz `IPago` con dos implementaciones, `Efectivo` y `Tarjeta`.

## Estructura del proyecto

```
Projecto/
├── Program.cs          # Flujo principal: registro, menú de servicios y boleta
├── Cliente.cs          # Clase Cliente (constructores sobrecargados)
├── Vehiculos.cs        # Clase abstracta Vehiculo con método abstracto describir()
├── Automovil.cs        # Hereda de Vehiculo (+ color)
├── Moto.cs             # Hereda de Vehiculo (+ cilindrada)
├── Camion.cs           # Hereda de Vehiculo (+ capacidad de carga)
├── IPagos.cs           # Interfaz IPago
├── MetodoPago.cs       # Implementaciones Efectivo y Tarjeta
├── Boleta.cs           # Generación de boleta y barra de carga
├── Sucursal.txt        # Datos de la sucursal para la boleta
├── servicios.txt       # Listado de servicios y precios (formato nombre;precio)
└── Projecto.csproj
```

### Diagrama de clases (resumen)

```
           Vehiculo (abstracta)
   marca, modelo, patente, anio, kilometraje
          + describir() : abstract
         /          |           \
  Automovil        Moto        Camion
   + color     + cilindrada  + capCarga

        IPago (interfaz)
        + Pago(total)
         /         \
    Efectivo     Tarjeta
```

## Requisitos

- [.NET SDK 7.0](https://dotnet.microsoft.com/download) o superior

## Ejecución

```bash
git clone https://github.com/Sonnyxpj/Programacion-avanzada.git
cd Programacion-avanzada/Projecto
dotnet run
```

Para que la boleta encuentre `Sucursal.txt`, ejecuta el programa desde la carpeta `Projecto`.

## Estado del proyecto

El proyecto está en desarrollo. Quedan pendientes, entre otras cosas:

- Integrar la selección de método de pago (`Efectivo` / `Tarjeta`) al flujo principal.
- Generar la boleta en archivo con el detalle del cliente, el vehículo y el servicio.
- Leer los servicios y precios desde `servicios.txt` en lugar de tenerlos fijos en el código.
- Agregar manejo de excepciones en las entradas numéricas (por ejemplo, el teléfono).
