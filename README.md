# College
Simulación de web para inscripción de alumnos de una universidad con ASP .NET C#, con conexión a base de datos SQL Server.

En la base de datos el usuario tiene dos posibles roles, (estudiante y administrador) y a la hora de loguearse lo hacen los dos con la misma información,
pero la web redirecciona al usuario a la pagina correspondiente en funcion del rol que tiene asignado en la base de datos. Ademas no permite el acceso a una ruta
determinada si el usuario no tiene el rol correspondiente.

La seccion del estudiante hasta el momento tiene un listado de las materias disponibles y cada una al seleccionarla muestra en pantalla la informacion del dia, horario,
profesor y cupo disponible del curso.
