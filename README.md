
Ecogames
========
Ecogames es un juego educativo moderno tipo trivia pensado para realizar actividades sobre economía.

Requisitos
-------------

### Especificaciones mínimas
- Procesador: 1 núcleo @ 613 MHz, x86 (32 bits), sin soporte para instrucciones PAE/NX.
- Memoria RAM: 64 MB (**con un archivo de paginación de 96 MB o más**), o 160 MB (**no es necesario un archivo de paginación**).
- Sistema operativo: Windows XP **SP3** (x86).
- Almacenamiento: 1.5 MB de espacio libre.
- Software: .NET Framework 4.0.

### Especificaciones recomendadas
- Procesador: 1 núcleo @ 875 MHz, x86 (32 bits), con soporte para instrucciones PAE/NX, o superior.
- Memoria RAM: 128 MB (**con un archivo de paginación de 128 MB o más**), o 256 MB (**no es necesario un archivo de paginación**), o más.
- Sistema operativo: Windows 7 (x86), o superior.
- Almacenamiento: 5 MB o más de espacio libre.
- Software: .NET Framework 4.5, o superior.

Interfaz
---------
Al iniciar la aplicación, verá una pantalla de bienvenida en donde se mostrará la actividad interna en progreso.
<div style="text-align: center">
	<img src="https://i.imgur.com/AFimMhu.png" alt="Pantalla de bienvenida" />
</div>

### Administración
Durante el primer inicio, se le presentará el siguiente formulario, en donde deberá registrarse. Esto se realiza con el fin de intentar prevenir, o al menos obstaculizar, el ingreso de los usuarios al área de administración.
<div style="text-align: center">
	<img src="https://i.imgur.com/bOrmUxX.png" alt="Primer inicio" />
</div>


Es posible crear diferentes actividades, cuyos tipos se definen como: "**Crucigrama**", "**Ahorcado**", "**Preguntas abiertas**" y "**Preguntas con opciones**".


Además, será necesario asignarles un nombre y, opcionalmente, una descripción.
<div style="text-align: center">
	<img src="https://i.imgur.com/J2dUSxT.png" alt="Interfaz de administración" />
</div>


Todos los tipos de actividad soportan eliminación y modificación.
<div style="text-align: center">
	<img src="https://i.imgur.com/B3WAgBs.png" alt="Eliminando y modificando" />
</div>


De este modo se ve el formulario que le permite crear o modificar un crucigrama.
<div style="text-align: center">
	<img src="https://i.imgur.com/ZEKg1rc.png" alt="Crucigrama" />
</div>


Por otro lado, podrá crear juegos de tipo "ahorcado" con el siguiente formulario.

Tenga en cuenta que es libre de activar o desactivar las funciones como considere necesario.
<div style="text-align: center">
	<img src="https://i.imgur.com/oWMw8Kd.png" alt="Ahorcado" />
</div>


El formulario que ve a continuación, le permitirá realizar una pregunta abierta, es decir, una cuya respuesta no contenga opciones y el desarrollo de la respuesta sea libre al participante.

Note que, como característica experimental, puede marcar "**Evaluar automáticamente**" que, como el nombre sugiere, permite que la computadora intente evaluar la respuesta automáticamente. Puesto que es imposible determinar si una respuesta es correcta basándose en la respuesta almacenada en el sistema dado que el participante podrá escribir a su discreción lo que desee, requerirá de cierto tiempo de procesamiento y puede causar resultados inesperados.
<div style="text-align: center">
	<img src="https://i.imgur.com/x5nnVYv.png" alt="Ahorcado" />
</div>


También, es posible crear preguntas cerradas (con opciones).

En el formulario que se le presentará, tendrá que introducir la pregunta que desea realizar y, luego, pulsar "Siguiente".
<div style="text-align: center">
	<img src="https://i.imgur.com/yIQiCua.png" alt="Pregunta cerrada: añadiendo la pregunta" />
</div>

Al hacerlo, accederá al resto de la interfaz, donde podrá agregar, quitar y modificar opciones de respuesta.
<div style="text-align: center">
	<img src="https://i.imgur.com/nf30vwd.png" alt="Pregunta cerrada: añadiendo opciones" />
</div>

##### Teclas especiales
Una vez realizada la configuración inicial, a fin de prevenir el acceso no autorizado de los participantes al área de administración, la única manera de acceder a esta, será utilizando la siguiente combinación de teclas:

`CTRL` + `S`

Asimismo, si cree necesario eliminar todas las actividades, como último recurso, puede utilizar la combinación de teclas a continuación:

`CTRL` + `ALT`

Si desea hacerlo, continúe pulsando y, a continuación, notará que "**Eliminar**" pasará a ser "**Eliminar todo**", haga clic sobre este para realizar la operación. Se le solicitará una última confirmación.

### Usuario
El usuario posee una interfaz como la que observa a continuación.

Aquí, podrán resolver crucigramas, jugar "ahorcados" y responder preguntas abiertas y cerradas.
<div style="text-align: center">
	<img src="https://i.imgur.com/wStEt3N.png" alt="Actividades" />
</div>


La interfaz de los crucigramas, generalmente, se verá de la siguiente manera.
<div style="text-align: center">
	<img src="https://i.imgur.com/YMO3lIx.png" alt="Resolviendo crucigrama" />
</div>


Mientras que el "ahorcado", se ve así.
<div style="text-align: center">
	<img src="https://i.imgur.com/CepvBdx.png" alt="Resolviendo ahorcado" />
</div>


Las preguntas abiertas, así.
<div style="text-align: center">
	<img src="https://i.imgur.com/54dNKsl.png" alt="Resolviendo pregunta abierta" />
</div>


Y, por último, las preguntas cerradas, de este modo.
<div style="text-align: center">
	<img src="https://i.imgur.com/zSBdJ4Y.png" alt="Resolviendo pregunta cerrada" />
</div>

Especificaciones técnicas
-------------------------------

### Estadísticas

    Project: Ecogames
    Configuration: Debug
    Scope: Project
    Maintainability Index: 64
    Cyclomatic Complexity: 750
    Depth of Inheritance: 9
    Class Coupling: 118
    Lines of Code: 3,069

Según los resultados del análisis del IDE con el que fue realizado el proyecto, este tiene un índice de mantenibilidad de 64 puntos, un muy buen resultado.

> Para más información, puede [consultar la documentación oficial de Microsoft](https://docs.microsoft.com/en-us/visualstudio/code-quality/code-metrics-values?view=vs-2019).

### Estructura del código

La mayor parte del código reutilizable, se encuentra en el módulo global (`General.vb`), este incluye procedimientos y funciones que sirven como apoyo para el resto de clases.

A lo largo del código de las clases, existen categorías implícitas que determinan cómo se separarán visualmente las líneas dentro de un mismo bloque padre.

A continuación, podrá observar un ejemplo.
<div style="text-align: center">
	<img src="https://i.imgur.com/xB8ufuh.png" alt="Bloques de código" />
</div>

Además, como medida de optimización a largo plazo, y en busca de prevenir "leaks" de datos internos, los símbolos de depuración no se compilarán en versiones finales.
<div style="text-align: center">
	<img src="https://i.imgur.com/tH62uh4.png" alt="Símbolos de depuración" />
</div>

### Dependencias

#### Tiempo de ejecución
Las dependencias requeridas durante el tiempo de ejecución son incluídas de manera dinámica en el paquete de distribución al público.

- MetroFramework

#### Compilación
- Visual Studio 2017 Community (o superior)
- NuGet
- MetroFramework

### Licencias
- Visual Studio 2017 Community: refiérase a [su EULA](https://visualstudio.microsoft.com/license-terms/mlt553321/).
- MetroFramework: bajo la [licencia de MetroFramework](https://github.com/thielj/MetroFramework/blob/master/LICENSE.md).
- Ecogames (a excepción de sus dependencias externas): bajo la [licencia del MIT](LICENSE).
