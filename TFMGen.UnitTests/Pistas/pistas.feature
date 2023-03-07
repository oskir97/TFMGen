Feature: Gestión de pistas
 
    El usuario administrador quiere gestionar las pistas de una instalación deportiva de la entidad
 
    Scenario: El usuario con la sesión iniciada en el panel quiere crear una nueva pista en una instalación
    Given El usuario accede al área de instalaciones deportivas
    And selecciona una instalación deportiva
    And se sitúa en la pestaña de pistas
    And le da a crear pista
    When Rellena los datos relativos a una nueva pista (nombre, ubicación, estado, horario, aforo máximo)
    And pulsa el botón Aceptar
    Then Se guarda la pista de forma correcta
    And se muestra la nueva pista junto a todas las demás en la instalación deportiva
 
    Scenario: El usuario con la sesión iniciada en el panel quiere crear una nueva pista en una instalación sin nombre
    Given El usuario accede al área de instalaciones deportivas
    And selecciona una instalación deportiva
    And se sitúa en la pestaña de pistas
    And le da a crear pista
    But No conoce el nombre de la nueva pista
    When Rellena los datos relativos a una nueva pista (ubicación, estado, horario, aforo máximo) excepto el nombre
    And pulsa el botón Aceptar
    Then Se le marca en rojo que el campo Nombre no está vacío y es obligatorio
    And no se guarda la nueva pista en la instalación
 
    Scenario: El usuario con la sesión iniciada modifica el campo ubicación de una pista
    Given El usuario accede al área de instalaciones deportivas
    And selecciona una instalación deportiva
    And se sitúa en la pestaña de pistas
    And le da a editar una pista
    When Modifica el campo ubicación
    And pulsa el botón Aceptar
    Then Se modifica el valor de ubicación de la pista
    And se muestran todas las pistas con el campo actualizado
 
    Scenario: El usuario con la sesión iniciada elimina una pista
    Given El usuario accede al área de instalaciones deportivas
    And selecciona una instalación deportiva
    And se sitúa en la pestaña de pistas
    When Elimina una pista
    And pulsa el botón Aceptar en el mensaje de advertencia de ¿Quiere eliminar la pista?
    Then Se elimina la pista seleccionada
    And se muestran todas las pistas excepto la eliminada