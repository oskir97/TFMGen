Feature: Gestión de instalaciones deportiva
 
    El usuario administrador quiere gestionar las instalaciones deportiva de la entidad
 
    Scenario: El usuario con la sesión iniciada en el panel quiere crear una nueva instalación
    Given El usuario accede al área de instalaciones deportivas
    When Rellena los datos relativos a una nueva instalación deportiva (nombre, teléfono, dirección, ciudad, provincia, estado y ubicación)
    And pulsa el botón Aceptar
    Then Se guarda la instalación de forma correcta
    And se muestra la nueva instalación junto a todas las demás
 
    Scenario: El usuario con la sesión iniciada en el panel quiere crear una nueva instalación sin nombre
    Given El usuario accede al área de instalaciones deportivas
    But No conoce el nombre de la nueva instalación deportiva
    When Rellena los datos relativos a una nueva instalación deportiva (teléfono, dirección, ciudad, provincia, estado y ubicación) excepto el nombre
    And pulsa el botón Aceptar
    Then Se le marca en rojo que el campo Nombre no está vacío y es obligatorio
    And no se guarda la nueva instalación
 
    Scenario: El usuario con la sesión iniciada modifica el campo teléfono de una instalación deportiva
    Given El usuario accede al área de instalaciones deportivas
    When Modifica el campo teléfono
    And pulsa el botón Aceptar
    Then Se modifica el valor del télefono de la instalación deportiva
    And se muestran todas las instalaciones deportivas con el campo actualizado
 
    Scenario: El usuario con la sesión iniciada elimina una instalación deportiva
    Given El usuario accede al área de instalaciones deportivas
    When Elimina una instalación deportiva
    And pulsa el botón Aceptar en el mensaje de advertencia de ¿Quiere eliminar la instalación deportiva?
    Then Se elimina la instalación seleccionada
    And se muestran todas las instalaciones deportivas excepto la eliminada