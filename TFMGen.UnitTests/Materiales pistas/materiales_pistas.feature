Feature: Materiales de pistas
 
    El usuario administrador quiere gestionar los materiales de una pista de una instalación deportiva de la entidad
 
    Background: El usuario con la sesión iniciada se sitúa en el área de instalaciones deportivas
    And selecciona una en concreto
    And se sitúa en una pista en concreto
    And se mueve a la pestaña Materiales
 
    Scenario: El usuario quiere crear un nuevo material
    Given El usuario le da a crear nuevo material
    When Rellena los datos relativos a un nuevo material (código, descripción, estado, precio, proveedor)
    And pulsa el botón Aceptar
    Then Se guarda el material de forma correcta
    And se muestra el nuevo material junto con todos los materiales de la pista
 
    Scenario: El usuario añade un nuevo material sin descripción
    Given El usuario le da a crear nuevo material
    But No quiere darle una descripción al material
    When Rellena los datos relativos a un nuevo material (código, estado, precio, proveedor) excepto la descripción
    And pulsa el botón Aceptar
    Then Se le marca en rojo que el campo descripción no está vacío y es obligatorio
    And no se guarda la nueva pista en la instalación
 
    Scenario: El usuario modifica el campo descripción de un material
    Given El usuario le da a editar a un material de la pista
    When Modifica el campo descripción
    And pulsa el botón Aceptar
    Then Se modifica el valor de descripción del material
    And se muestran todos los materiales con el campo actualizado
 
    Scenario: El usuario elimina un material
    Given El usuario elimina un material
    When pulsa el botón Aceptar en el mensaje de advertencia de ¿Quiere eliminar el material de la pista?
    Then Se elimina el material de la pista seleccionado
    And se muestran todos los materiales excepto el eliminado