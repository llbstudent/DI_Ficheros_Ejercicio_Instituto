# DI_Ficheros_Ejercicio_Instituto
DESARROLLO DE INTERAFACES 

EJERCICIO CON FICHEROS  En el siguiente ejercicio vamos a desarrollar una aplicación con ventanas que permita almacenar en un fichero los datos para 
Alumnos, Profesores y Asignaturas.  
Dicha aplicación tendrá un formulario inicial a modo de menú que nos permitirá abrir o mostrar los formularios desde los que introduciremos los datos.  
El   formulario   inicial   será   un   menú,   (podéis   darle   el   formato   que   queráis),   donde aparecerán las siguientes opciones: 
Alumno, Profesor, Asignatura, Salir.  

----------
Cuando pulsemos la opción Alumno, nos aparecerá formulario para que introduzcamos la siguiente información:  
• DNI 
• Nombre 
• Fecha Nacimiento (podéis utilizar un DateTimePicker, o cajas de texto, lo que mejor se adapte al diseño del formulario) 
• Dirección 
• Teléfono  

Este formulario también tendrá dos botones:  
• Guardar: cuando pulsemos el botón tendremos que guardar los datos introducidos en el formulario en un archivo llamado Alumnos.txt. Por tratarse de un archivo de texto, utilizaremos un streamwriter, para escribir la información. Para separar los campos del formulario utilizaremos un carácter especial (¿,-,*). 
Construiremos una línea de texto (string) que será la concatenación de los campos separados por el carácter especial. Una vez construida dicha línea la escribiremos en el fichero. Al introducir   el   carácter   especial   buscamos   también   que   posteriormente   cuando realicemos la lectura, dicho carácter nos ayudará a separar unos campos de otros. 

• Limpiar: limpiará todos los campos del formulario.  

--------
Cuando pulsemos la opción Profesor, nos aparecerá formulario para que introduzcamos la siguiente información:  
• DNI 
• Nombre 
• Dirección 
• Teléfono 
• Estudios (qué ha estudiado ese profesor: Filología Inglesa, Matemáticas, Ingeniería Informática,…) 

Este formulario también tendrá dos botones: 
• Guardar: cuando pulsemos el botón tendremos que guardar los datos introducidos en el formulario en un archivo llamado Profesores.txt. 
Por tratarse de un archivo de texto, utilizaremos un streamwriter, para escribir la información. Para separar los campos del formulario utilizaremos un carácter especial (¿,-,*). Construiremos una línea de texto (string) que será la concatenación de los campos separados por el carácter especial. Una vez construida dicha línea la escribiremos en el fichero. Al introducir   el   carácter   especial   buscamos   también   que   posteriormente   cuando realicemos la lectura, dicho carácter nos ayudará a separar unos campos de otros. 

• Limpiar: limpiará todos los campos del formulario.  

-------------
Cuando   pulsemos   la   opción  Asignatura,   nos   aparecerá   formulario   para   que introduzcamos la siguiente información:  
• ID 
• Nombre 
• Departamento (será un ComboBox para seleccionar Lengua, Inglés, Matemáticas, …) 
• Horas semanales  

Este formulario también tendrá dos botones:  
• Guardar: cuando pulsemos el botón tendremos que guardar los datos introducidos en el formulario en un archivo llamado Asignaturas.txt. Por tratarse de un archivo de texto, utilizaremos un streamwriter, para escribir la información. Para separar los campos del formulario utilizaremos un carácter especial (¿,-,*). Construiremos una línea de texto (string) que será la concatenación de los campos separados por el carácter especial. Una vez construida dicha línea la escribiremos en el fichero. Al introducir   el   carácter   especial   buscamos   también   que   posteriormente   cuando realicemos la lectura, dicho carácter nos ayudará a separar unos campos de otros. 

• Limpiar: limpiará todos los campos del formulario.  Además la aplicación me permitirá realizar consultas. Mostraremos un formulario, donde el campo identificativo de cada item se muestre en un combobox(DNI en el caso de Alumno y Profesor, e ID en el caso de Asignatura) y así podré seleccionar para ver el resto de información. NOTA: Debéis prestar atención a la apertura y cierre de ficheros. Ya que si no controláis correctamente esto puede no permitir almacenar nueva información porque el fichero se haya quedado abierto anteriormente. También es importante que indiquéis el modo de apertura de fichero ( se recomienda Append) ya que se trata de ir añadiendo nuevos registros cada vez que seleccionemos Guardar.  

