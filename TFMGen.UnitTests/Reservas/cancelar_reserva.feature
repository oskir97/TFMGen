Feature: Cancelar reserva
 
    El usuario quiere cancelar la reserva
 
    Background: La entidad en la que se ha realizado la reserva tiene la opción de cancelar la reserva habilitada
 
    Scenario: El usuario quiere cancelar la reserva
    Given El usuario se sitúa en la reserva
    When Le da a cancelar
    Then Se cancela la reserva
    And se envía una notificación informando de la cancelación
    And se devuelve el dinero
 
    Scenario: El usuario quiere cancelar la reserva 1 hora antes de producirse
    Given El usuario se sitúa en la reserva
    But ha superado el umbral máximo de permiso de cancelaciones (4 horas)
    When Le da a cancelar
    Then Le sale un mensaje de error informando de que no es posible cancelar la reserva