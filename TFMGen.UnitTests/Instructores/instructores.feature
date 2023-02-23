Feature: Instructores
 
    El usuario administrador quiere gestionar Instructores de la entidad
 
    Background: El usuario con la sesión iniciada se sitúa en el área de instructores
 
    Scenario: El usuario quiere crear un nuevo instructor
    Given El usuario le da a crear nuevo instructor
    When Rellena los datos relativos a un nuevo instructor (nombre, apellidos, email, contraseña, correo, dirección, ciudad, provincia, teléfono y fecha de nacimiento)
    And pulsa el botón Aceptar
    Then Se guarda el instructor de forma correcta
    And se muestra el nuevo instructor junto con todos los instructores
 
    Scenario: El usuario quiere añadir un nuevo instructor con permisos de instructor
    Given El usuario quiere crear un nuevo instructor
    But No dispone de permisos de administrador
    When busca la opción de crear un nuevo instructor
    Then No la encuentra
 
    Scenario: El usuario añade un nuevo instructor sin nombre de teléfono
    Given El usuario le da a crear nuevo instructor
    But No dispone del número de teléfono
    When Rellena los datos relativos a un nuevo instructor (apellidos, email, contraseña, correo, dirección, ciudad, provincia, teléfono y fecha de nacimiento) excepto el nombre
    And pulsa el botón Aceptar
    Then Se le marca en rojo que el campo nombre no está vacío y es obligatorio
    And no se guarda el nuevo instructor
 
    Scenario: El usuario modifica el campo email de un instructor
    Given El usuario le da a editar a un instructor
    When Modifica el campo email
    And pulsa el botón Aceptar
    Then Se modifica el valor de email del instructor
    And se muestran todos los instructores con el campo actualizado
 
    Scenario: El usuario elimina un instructor
    Given El usuario elimina un instructor
    When pulsa el botón Aceptar en el mensaje de advertencia de ¿Quiere eliminar el instructor?
    Then Se elimina el instructor
    And se muestran todos los instructores de la entidad excepto el eliminado