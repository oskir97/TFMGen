Feature: Registro de asistencia del usuario

    Registro de asistencia de un usuario por parte de un instructor

    Background: El usuario está asociado con uno o más instructores
    Scenario: El instructor registra que el usuario ha faltado al entrenamiento
    Given Un usuario ha faltado a una sesión de entrenamiento con su instructor
    When El instructor desea reigstrar que el usuario ha faltado
    Then El instructor registrará la falta del usuario a una determianda sesión de entrenamiento, registrando fecha y hora.

    Scenario: El instructor registra que el usuario ha asistido al entrenamiento
    Given Un usuario ha asistido a su sesión de entrenamiento con su instructor
    When El instructor desea reigstrar que el usuario ha asistido
    Then El instructor registrará la asistencia del usuario a una determianda sesión de entrenamiento, registrando fecha y hora.