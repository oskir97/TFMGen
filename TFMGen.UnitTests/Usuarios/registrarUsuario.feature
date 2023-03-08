Feature: Registro de usuario

    Registro de usuario en la aplicación (creación de cuenta)

    Background: El usuario a registrarse ya tiene una cuenta de correo electrónico

    Scenario: Un usuario desea registrarse en la aplicación con un correo electrónico
    Given Un usuario ingresa en la aplicación su correo electrónico
    When El correo electrónico ingresado es falso o inválido
    Then La aplicación valida que el correo ingresado exista

    Scenario: Un usuario desea registrarse en la aplicación con un correo electrónico falso o que no existe
    Given Un usuario ingresa en la aplicación su correo electrónico
    When El correo electrónico ingresado es falso o no existe
    Then La aplicación muestra el mensaje: correo electrónico no existe
    