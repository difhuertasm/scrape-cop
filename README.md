Conversor de Pesos Colombianos a Divisas

Este programa en C# convierte un monto en pesos colombianos (COP) a varias monedas internacionales (EUR, USD, MXN, BRL, JPY) obteniendo los tipos de cambio actuales desde una página web mediante Html Agility Pack.

Características

1. Obtiene automáticamente los tipos de cambio actuales desde una fuente web.
2. Convierte COP a EUR, USD, MXN, BRL y JPY.
3. Interfaz gráfica sencilla (hecha en Windows Forms).
4. Manejo de errores para entradas inválidas.

Requisitos

1. .NET Framework o .NET Core / .NET 5+ (versión usada: Microsoft Visual Studio Community 2019
Versión 16.11.51)
2. Biblioteca Html Agility Pack
3. Puede instalar Html Agility Pack vía NuGet mediante:

Install-Package HtmlAgilityPack

o usando la consola de administrador de paquetes en Visual Studio.

Uso

1. Abre el proyecto en Visual Studio.
2. Restaurar los paquetes NuGet: haz clic derecho sobre la solución "ScrapeCop" en la sección "Explorador de soluciones" y selecciona "Administrar paquetes NuGet para la solución". Luego, busca "Html Agility Pack" e instala el paquete en el proyecto correspondiente. 

Ejecuta la aplicación.

1. Ingresa el monto en pesos colombianos en la interfaz.
2. Presiona el botón para realizar la conversión.
3. Visualiza los resultados con los montos convertidos.

Licencia

MIT License
