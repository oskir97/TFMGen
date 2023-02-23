Feature: Notificaciones Usuario Instalaciones Deportivas

    Notificaciones que reciben los usuarios por parte de las Instalaciones Deportivas

    Background: El usuario ha realizado una reserva de una pista previamente
    Scenario: La pista reservada por el usuario de repente no está disponible
    Given Un usuario ha realizado la reserva de una pista de determinada instalación deportiva
    When La pista de la instalación de repente ha entrado en mantenimiento
    Then La instalación deportiva enviará al usuario una notifiación de que la pista actualmente se podrá usar

    Scenario: Se requiere enviar una notificación en caso de que la instalación cuente con una nueva pista 
    Given Una instalación deportiva ha abierto una nueva pista
    When Se desea dar a conocer a usuarios afiliados (hayan usado una pista de esta instalación) sobre la nueva pista
    Then La instalación deportiva enviará al usuario una notifiación de que existe una nueva pista
    And La instalación deportiva enviará al usuario dentro de la notifiación un enlace a ver la nueva pista

    Scenario: Se requiere enviar una notificación en caso de se cambien los horarios de una pista 
    Given Una instalación deportiva ha cambiado el horario de alguna de sus pistas
    When Quieren dar a conocer a sus usuarios sobre este cambio de horario
    Then La instalación notificará al usuario de que se ha cambiado el horario de determinada pista