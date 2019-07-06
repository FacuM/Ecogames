[Español (internacional)](README.md)

Ecogames
========
Ecogames is a modern educative trivia-like game meant for economy-related activities.


Requirements
-------------

### Minimum specifications
- Processor: 1 core @ 613 MHz, x86 (32-bit), without PAE/NX support.
- RAM memory: 64 MB (**with a pagefile of 64 MB or more**), or 128 MB (**no pagefile required**).
- Operating system: Windows 98 SE (x86).
- Storage: 7 MB of free space.
- Software: .NET Framework 2.0.

### Recommended specifications
- Processor: 1 core @ 875 MHz, x86 (32-bit), with support for PAE/NX, or greater.
- RAM memory: 128 MB (**with a pagefile of 128 MB or more**), or 256 MB (**no pagefile required**), or more.
- Operating system: Windows 7 (x86), or newer.
- Storage: 10 MB or more of free space.
- Software: .NET Framework 3.5.

User interface
--------------
Once the applications is started, a welcome screen will show up containing basic information about what's going on internally.
<p align="center">
	<img src="https://i.imgur.com/AFimMhu.png" alt="Welcome screen" />
</p>

### Administration
During the first start, you'll be presented with the following form, on which you must register. This is done with the purpose of trying to prevent or, at least block users from logging into the administration area.
<p align="center">
	<img src="https://i.imgur.com/bOrmUxX.png" alt="First run" />
</p>

---

It's possible to create different activities, they're defined as follows: "**Crossword**", "**Hangman**", "**Open questions**" y "**Closed questions**".


Also, it'll be necessary to set a name for each and, optionally, a description.
<p align="center">
	<img src="https://i.imgur.com/J2dUSxT.png" alt="Administration interface" />
</p>

---

All of the activity types support deletion and modification.
<p align="center">
	<img src="https://i.imgur.com/B3WAgBs.png" alt="Deleting and modifying" />
</p>

---

This is how the crosswords' creation or modification form looks like.
<p align="center">
	<img src="https://i.imgur.com/ZEKg1rc.png" alt="Crossword" />
</p>

---

In the other hand, you can create the kind of "hangman" games in the following form.

Take in mind that you're free from enabling or desabling its functions as needed.
<p align="center">
	<img src="https://i.imgur.com/oWMw8Kd.png" alt="Hangman" />
</p>

---

The form that you can see below, will allow you to do an open question, that is, a question that doesn't contain any options and the development of the answer relies entirely on the participant.

Note that, as an optional experimental feature, you can check "**Verify automatically**" that, as the name suggests, allows the computer to try to evaluate the answer automatically. Being that it's impossible to determine whether an answer is right or wrong based off the answer saved in the system taken that the participant will be able to write whatever he/she wants at discretion, it'll require some processing time and might cause unexpected results.
<p align="center">
	<img src="https://i.imgur.com/x5nnVYv.png" alt="Hangman" />
</p>

---

It's possible to create closed questions too (with options).

In the following form you'll be presented, you must type in the question you want to do and, then, click "Next".
<p align="center">
	<img src="https://i.imgur.com/yIQiCua.png" alt="Closed question: adding the question" />
</p>

---

Once done, you'll be able to see the rest of the interface, on which you can add, delete and modify the options.
<p align="center">
	<img src="https://i.imgur.com/nf30vwd.png" alt="Closed question: adding options" />
</p>

---

##### Special keys
Once you're done with the initial configuration, in order to prevent unwanted access of the participants to the administration area, the only way of accessing it, will be using the following key combo:

`CTRL` + `S`

In the same way, if you feel like you need to remove all the activities, as a last resource, you can use the following combo:

`CTRL` + `ALT`

If you want to do it, keep pressing and, then, you'll notice that "**Delete**" will now be "**Delete all**", click it to do the operation. You'll be requested for confirmation.


Also, you can delete the data and restart the application easily if your version has `ENABLE_MASTER_RESET` defined and it's `True`, using the following combination:

`CTRL` + `ALT` + `M`

### User
The user has an interface that looks like the one you can see below.

Here, they'll be able of solving crosswords, play "hangman" games and answer open and closed questions.
<p align="center">
	<img src="https://i.imgur.com/wStEt3N.png" alt="Activities" />
</p>

---

The crosswords interface, generally, will look like this.
<p align="center">
	<img src="https://i.imgur.com/YMO3lIx.png" alt="Solving crossword" />
</p>

---

While the one for the "hangman" games, like this.
<p align="center">
	<img src="https://i.imgur.com/CepvBdx.png" alt="Solving hangman" />
</p>

---

The open questions, like this.
<p align="center">
	<img src="https://i.imgur.com/54dNKsl.png" alt="Solving open question" />
</p>

---

And, at last, the closed questions, in this way.
<p align="center">
	<img src="https://i.imgur.com/zSBdJ4Y.png" alt="Solving closed question" />
</p>

Technical specifications
------------------------

### Statistics

    Project: Ecogames
    Configuration: Debug
    Scope: Project
    Maintainability Index: 64
    Cyclomatic Complexity: 750
    Depth of Inheritance: 9
    Class Coupling: 118
    Lines of Code: 3,069

According to the results of the analysis driven by the IDE in which the project was made, it's got a maintainability index of 64 points, a great result.

> For more information, head to the [official Microsoft docuemntation](https://docs.microsoft.com/en-us/visualstudio/code-quality/code-metrics-values?view=vs-2019).

### Code structure

Most part of the re-used code, can be found in the global module (`General.vb`), it includes procedures and functions that serve as helpers for the rest of the classes.

Along the code of the classes, there are implicit categories that determine how are the code lines separated visually inside the same parent block.

An example can be seen below.
<p align="center">
	<img src="https://i.imgur.com/xB8ufuh.png" alt="Code blocks" />
</p>

---

Also, as a long-term optimization measurement, and to prevent leaks of internal data, the debugging symbols won't be compiled in final releases.
<p align="center">
	<img src="https://i.imgur.com/tH62uh4.png" alt="Símbolos de depuración" />
</p>

### Optional parameters

Clarification: the following constants shall be understood as defined and with a `True` value.

`DEBUG` - Enables the debugging symbols and posts messages to the console output.
 - `DEBUG_CLEAN` - Wipes the system data each time the application is started.
   - `KEEP_LANG` - Won't wipe the language selection during the cleanup.

`ENABLE_MASTER_RESET` - Allows issuing  `CTRL` + `ALT` + `M` to run a quick manual wipe.

### Dependencies

#### Runtime
The dependencies required on runtime are included in a dynamic way inside of the public distributable package.

- [MetroFramework](https://github.com/dennismagno/metroframework-modern-ui)

#### Compilation
- Visual Studio 2017 Community (or newer)
- NuGet
- [MetroFramework](https://github.com/dennismagno/metroframework-modern-ui)

### Resources

#### Visual
- [Welcome screen background image](https://pixabay.com/es/illustrations/analytics-análisis-de-datos-gráfico-2158454/) by [Nikin (at Pixabay)](https://pixabay.com/es/users/nikin-253338/), under the [Pixabay license](https://pixabay.com/es/service/license/).
- [Pinpoint interface icons](https://www.iconfinder.com/iconsets/pinpoint-interface) by [PINPOINT.WORLD (at Iconfinder)](https://www.iconfinder.com/pinpointworld), under [Creative Commons 3.0](https://creativecommons.org/licenses/by/3.0/).
- [Crossword resolution activities icon](https://www.publicdomainpictures.net/en/view-image.php?image=261720&picture=crossword-puzzle-background) by [Linnaea Mallette (at PublicDomainPictures)](https://www.publicdomainpictures.net/en/browse-author.php?a=18382), under [CC0 Public Domain](https://creativecommons.org/publicdomain/zero/1.0/).

#### Audio
- [Pack: SFX for games/apps](https://freesound.org/people/rhodesmas/packs/17958/) by [Andy Rhode (rhodesmas at freesound)](https://freesound.org/people/rhodesmas/), under [Creative Commons 3.0](https://creativecommons.org/licenses/by/3.0/).
- [Pack: Real and Generated](https://freesound.org/people/M-RED/packs/2470/) by [M-RED (M-RED en freesound)](https://freesound.org/people/M-RED/), under [Creative Commons 3.0](https://creativecommons.org/licenses/by/3.0/).

#### Applications
- Visual Studio 2017 Community: refer to [their EULA](https://visualstudio.microsoft.com/license-terms/mlt553321/).
- MetroFramework: under the [MetroFramework license](https://github.com/dennismagno/metroframework-modern-ui/blob/master/LICENSE.md).
- Ecogames (with exception of its external dependencies): under the [MIT license](LICENSE).
