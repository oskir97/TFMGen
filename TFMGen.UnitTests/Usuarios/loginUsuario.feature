Feature: Login de usuario

    Login de usuario en la aplicación (inicio de sesión)

    Background: El usuario ya tiene una cuenta registrada (creada)
    Scenario: Un usuario a olvidado su contraseña de la cuenta
    Given Un usuario desea iniciar sesión en la apliación
    When La contraseña ingresada es incorrecta
    And Ha ingresado la contraseña incorrecta mas de 4 veces
    Then La aplicación muestra una pantalla para la recuperación de la contraseña

    Background: La aplicación muestra una pantalla para la recuperación de la contraseña
    Scenario: Un usuario desea recuperar la contraseña de su cuenta
    Given Un usuario ha olvidado la contraseña de su cuenta
    When Esta cuenta tiene un correo electrónico existente
    Then La aplicación manda por correo una contraseña temporal