Feature: Notificaciones Usuario Instructores

    Notificaciones que reciben los usuarios por parte de sus instructores

    Background: El usuario está asociado con uno o más instructores
    Scenario: El instructor envía una notificación al usuario por que ha faltado al entrenamiento
    Given Un usuario ha faltado a una sesión de entrenamiento con su instructor
    When El instructor desea notificar al usuario de su falta
    Then El instructor enviará una notificación al usuario de que ha faltado y lo ha decepcionado

    Scenario: El instructor envía una notificación de aliento al usuario por su buen entrenamiento
    Given Un usuario se ha esforzado mucho en su entranmiento
    When El instructor desea enviar una notificación al usuario de su esfuerzo
    Then El instructor enviará una notificación al usuario de que esta orgulloso de el

    Scenario: El instructor envía una notificación al usuario de que no podrá asistir a la sesión de entrenamiento
    Given Un instructior no podrá asistir al entrenamiento programado con el usuario
    When El instructor desea enviar una notificación al usuario de que no podrá asistir
    Then El instructor enviará una notificación al usuario de que no asistirá a la sesión