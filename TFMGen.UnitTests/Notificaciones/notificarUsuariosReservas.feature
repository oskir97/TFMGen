Feature: Notificaciones Usuario Reservas

    Notificaciones que reciben los usuarios cuando han realizado una reserva

    Background: El usuario ha seleccionado la pista y el horario a reservar
    Scenario: El usuario desea ver una notificación de que su reserva ha sido realizada
    Given Un usuario ha realizado la reserva de una pista en un determinado horario
    When La reserva ha finalizado con éxito
    Then La instalación deportiva enviará al usuario una notificación con información de su reserva