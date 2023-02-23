Feature: Valoración de pistas

    Valoración del estado y uso de las pistas por el usuario

    Background: El usuario ya tiene una cuenta registrada y ha iniciado sesión en la aplicación
    Scenario: Un usuario ha usado una pista y quiere dar su retroalimentación con respecto a esta
    Given Un usuario ha usado un pista
    When Desea que el resto de usuarios sepan sobre las condiciones de esta
    Then El usuario seleccionará la pista de la cual quiere dar su retroalimentación
    And El usuario seleccionará una determinada puntuación de entre 0 a 5 estrellas hacia la pista
    And El usuario comentará positiva o negativamente acerca de su experiencia.