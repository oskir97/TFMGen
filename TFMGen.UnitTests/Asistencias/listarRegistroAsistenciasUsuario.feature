Feature: Lista de Registro de asistencias del usuario

    Lista las asistencia y/o falta del usuario mediante un reporte

    Background: El usuario una o más sesiones de entrenamiento con su instructor
    Scenario: El usuario desea obtener información de su asistencia
    Given Un usuario quiere obtener información de su registro de asistencia con un determinado instructor
    When El usuario selecciona un rango de fechas
    Then La aplicación listará el registro de asistencia de un usuario.
    And La aplicación ofrecerá generar un reporte con esta información.