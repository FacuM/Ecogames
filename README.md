
Ecogames
========
Ecogames es un juego educativo moderno tipo trivia pensado para realizar actividades sobre economía.

Requisitos
-------------

### Especificaciones mínimas
- Procesador: 1 núcleo @ 613 MHz, x86 (32 bits), sin soporte para instrucciones PAE/NX.
- Memoria RAM: 64 MB (**con un archivo de paginación de 96 MB o más**), o 160 MB (**no es necesario un archivo de paginación**).
- Sistema operativo: Windows XP (x86).
- Almacenamiento: 7 MB de espacio libre.
- Software: .NET Framework 2.0.

### Especificaciones recomendadas
- Procesador: 1 núcleo @ 875 MHz, x86 (32 bits), con soporte para instrucciones PAE/NX, o superior.
- Memoria RAM: 128 MB (**con un archivo de paginación de 128 MB o más**), o 256 MB (**no es necesario un archivo de paginación**), o más.
- Sistema operativo: Windows 7 (x86), o superior.
- Almacenamiento: 10 MB o más de espacio libre.
- Software: .NET Framework 4.0, o superior.

Interfaz
---------
Al iniciar la aplicación, verá una pantalla de bienvenida en donde se mostrará la actividad interna en progreso.
<p align="center">
	<img src="https://i.imgur.com/AFimMhu.png" alt="Pantalla de bienvenida" />
</p>

### Administración
Durante el primer inicio, se le presentará el siguiente formulario, en donde deberá registrarse. Esto se realiza con el fin de intentar prevenir, o al menos obstaculizar, el ingreso de los usuarios al área de administración.
<p align="center">
	<img src="https://i.imgur.com/bOrmUxX.png" alt="Primer inicio" />
</p>

---

Es posible crear diferentes actividades, cuyos tipos se definen como: "**Crucigrama**", "**Ahorcado**", "**Preguntas abiertas**" y "**Preguntas con opciones**".


Además, será necesario asignarles un nombre y, opcionalmente, una descripción.
<p align="center">
	<img src="https://i.imgur.com/J2dUSxT.png" alt="Interfaz de administración" />
</p>

---

Todos los tipos de actividad soportan eliminación y modificación.
<p align="center">
	<img src="https://i.imgur.com/B3WAgBs.png" alt="Eliminando y modificando" />
</p>

---

De este modo se ve el formulario que le permite crear o modificar un crucigrama.
<p align="center">
	<img src="https://i.imgur.com/ZEKg1rc.png" alt="Crucigrama" />
</p>

---

Por otro lado, podrá crear juegos de tipo "ahorcado" con el siguiente formulario.

Tenga en cuenta que es libre de activar o desactivar las funciones como considere necesario.
<p align="center">
	<img src="https://i.imgur.com/oWMw8Kd.png" alt="Ahorcado" />
</p>

---

El formulario que ve a continuación, le permitirá realizar una pregunta abierta, es decir, una cuya respuesta no contenga opciones y el desarrollo de la respuesta sea libre al participante.

Note que, como característica experimental, puede marcar "**Evaluar automáticamente**" que, como el nombre sugiere, permite que la computadora intente evaluar la respuesta automáticamente. Puesto que es imposible determinar si una respuesta es correcta basándose en la respuesta almacenada en el sistema dado que el participante podrá escribir a su discreción lo que desee, requerirá de cierto tiempo de procesamiento y puede causar resultados inesperados.
<p align="center">
	<img src="https://i.imgur.com/x5nnVYv.png" alt="Ahorcado" />
</p>

---

También, es posible crear preguntas cerradas (con opciones).

En el formulario que se le presentará, tendrá que introducir la pregunta que desea realizar y, luego, pulsar "Siguiente".
<p align="center">
	<img src="https://i.imgur.com/yIQiCua.png" alt="Pregunta cerrada: añadiendo la pregunta" />
</p>

---

Al hacerlo, accederá al resto de la interfaz, donde podrá agregar, quitar y modificar opciones de respuesta.
<p align="center">
	<img src="https://i.imgur.com/nf30vwd.png" alt="Pregunta cerrada: añadiendo opciones" />
</p>

---

##### Teclas especiales
Una vez realizada la configuración inicial, a fin de prevenir el acceso no autorizado de los participantes al área de administración, la única manera de acceder a esta, será utilizando la siguiente combinación de teclas:

`CTRL` + `S`

Asimismo, si cree necesario eliminar todas las actividades, como último recurso, puede utilizar la combinación de teclas a continuación:

`CTRL` + `ALT`

Si desea hacerlo, continúe pulsando y, a continuación, notará que "**Eliminar**" pasará a ser "**Eliminar todo**", haga clic sobre este para realizar la operación. Se le solicitará una última confirmación.

### Usuario
El usuario posee una interfaz como la que observa a continuación.

Aquí, podrán resolver crucigramas, jugar "ahorcados" y responder preguntas abiertas y cerradas.
<p align="center">
	<img src="https://i.imgur.com/wStEt3N.png" alt="Actividades" />
</p>

---

La interfaz de los crucigramas, generalmente, se verá de la siguiente manera.
<p align="center">
	<img src="https://i.imgur.com/YMO3lIx.png" alt="Resolviendo crucigrama" />
</p>

---

Mientras que el "ahorcado", se ve así.
<p align="center">
	<img src="https://i.imgur.com/CepvBdx.png" alt="Resolviendo ahorcado" />
</p>

---

Las preguntas abiertas, así.
<p align="center">
	<img src="https://i.imgur.com/54dNKsl.png" alt="Resolviendo pregunta abierta" />
</p>

---

Y, por último, las preguntas cerradas, de este modo.
<p align="center">
	<img src="https://i.imgur.com/zSBdJ4Y.png" alt="Resolviendo pregunta cerrada" />
</p>

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
<p align="center">
	<img src="https://i.imgur.com/xB8ufuh.png" alt="Bloques de código" />
</p>

---

Además, como medida de optimización a largo plazo, y en busca de prevenir "leaks" de datos internos, los símbolos de depuración no se compilarán en versiones finales.
<p align="center">
	<img src="https://i.imgur.com/tH62uh4.png" alt="Símbolos de depuración" />
</p>

### Dependencias

#### Tiempo de ejecución
Las dependencias requeridas durante el tiempo de ejecución son incluídas de manera dinámica en el paquete de distribución al público.

- [MetroFramework](https://github.com/dennismagno/metroframework-modern-ui)

#### Compilación
- Visual Studio 2017 Community (o superior)
- NuGet
- [MetroFramework](https://github.com/dennismagno/metroframework-modern-ui)

### Recursos

#### Visual
- [Imagen de fondo de la pantalla de bienvenida](https://pixabay.com/es/illustrations/analytics-análisis-de-datos-gráfico-2158454/) por [Nikin (en Pixabay)](https://pixabay.com/es/users/nikin-253338/), bajo la [licencia de Pixabay](https://pixabay.com/es/service/license/)
- [Íconos de la interfaz Pinpoint](https://www.iconfinder.com/iconsets/pinpoint-interface) por [PINPOINT.WORLD (en Iconfinder)](https://www.iconfinder.com/pinpointworld), bajo [Creative Commons 3.0](https://creativecommons.org/licenses/by/3.0/).
- [Ícono de las actividades de resolución de crucigramas](https://www.publicdomainpictures.net/en/view-image.php?image=261720&picture=crossword-puzzle-background) por [Linnaea Mallette (en PublicDomainPictures)](https://www.publicdomainpictures.net/en/browse-author.php?a=18382), bajo [CC0 Public Domain](https://creativecommons.org/publicdomain/zero/1.0/).

#### Audio
- [Pack: SFX for games/apps](https://freesound.org/people/rhodesmas/packs/17958/) por [Andy Rhode (rhodesmas en freesound)](https://freesound.org/people/rhodesmas/), bajo [Creative Commons 3.0](https://creativecommons.org/licenses/by/3.0/).
- [Pack: Real and Generated](https://freesound.org/people/M-RED/packs/2470/) por [M-RED (M-RED en freesound)](https://freesound.org/people/M-RED/), bajo [Creative Commons 3.0](https://creativecommons.org/licenses/by/3.0/).

#### Aplicaciones
- Visual Studio 2017 Community: refiérase a [su EULA](https://visualstudio.microsoft.com/license-terms/mlt553321/).
- MetroFramework: bajo la [licencia de MetroFramework](https://github.com/dennismagno/metroframework-modern-ui/blob/master/LICENSE.md).
- Ecogames (a excepción de sus dependencias externas): bajo la [licencia del MIT](LICENSE).