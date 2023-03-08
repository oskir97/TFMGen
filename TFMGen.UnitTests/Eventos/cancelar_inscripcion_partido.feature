Feature: Cancelar inscripción a un partido
 
    El usuario quiere cancelar su inscripción a un partido
 
    Background: La entidad en la que se ha realizado la reserva tiene la opción de cancelar inscripciones y partidos
 
    Scenario: El usuario quiere cancelar su inscripción a un partido siendo el número de usuario mayor a 1
    Given El usuario se sitúa en el partido
    When Le da a cancelar inscripción
    Then Se cancela la inscripción
    And se envía una notificación informando de la cancelación
    And se devuelve el dinero
 
    Scenario: El usuario quiere cancelar su inscripción a un partido siendo el número de usuario igual a 1
    Given El usuario se sitúa en el partido
    When Le da a cancelar inscripción
    Then Se cancela la inscripción
    And se elimina el partido
    And se envía una notificación informando de la cancelación
    And se devuelve el dinero
 
    Scenario: El usuario quiere cancelar el partido 1 hora antes de producirse
    Given El usuario se sitúa en el partido
    But ha superado el umbral máximo de permiso de cancelaciones (4 horas)
    When Le da a cancelar
    Then Le sale un mensaje de error informando de que no es posible cancelar la reserva