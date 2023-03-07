Feature: Reservar pista
 
    El usuario quiere reservar una pista
 
    Background: El usuario ha seleccionado la pista 3A de padel del polideportivo de Alicante
 
    Scenario: El usuario quiere seleccionar una hora con la sesión iniciada
    Given El usuario quiere seleccionar de 10:00 a 12:00 la pista 3A
    When Selecciona el intervalo de tiempo
    Then Se muestra la opción de realizar pago
 
    Scenario: El usuario quiere seleccionar una hora sin la sesión iniciada
    Given El usuario quiere seleccionar de 10:00 a 12:00 la pista 3A
    But No tiene la sesión iniciada
    When Selecciona el intervalo de tiempo
    Then Se muestra la opción de rellenar un formulario obligatorio con sus datos básicos (nombre, apellidos, email y teléfono)
    And la opción de registrarse
    And la opción de iniciar sesión
 
    Scenario: El usuario quiere seleccionar una hora que ya está ocupada
    Given El usuario quiere seleccionar de 10:00 a 12:00 la pista 3A
    But Está ya ocupada
    When Intenta seleccionar el intervalo de tiempo
    Then El sistema no le deja mostrando ese intervalo deshabilitado
 
    Scenario: El usuario realiza el pago
    Given El usuario realiza el pago introduciendo sus datos de tarjeta
    When Pulsa realizar el pago
    Then El sistema realiza la transacción
    And reserva ese intervalo de tiempo
    And le envía una notificación con los datos de la reserva al usuario
 
    Scenario: El usuario realiza el pago pero se equivoca en algún dato
    Given El usuario realiza el pago introduciendo sus datos de tarjeta
    But se equivoca en el código de verificación de la tarjeta
    When Pulsa realizar el pago
    Then El sistema le informa que los datos no son correctos
 
    Scenario: El usuario intenta pagar cuando otro usuario ya ha reservado en esa hora
    Given El usuario se decide a pagar la reserva
    But tarda más de 5 minutos en intentar completar la reserva
    When Intenta realizar el pago
    Then El sistema lanza un mensaje de error informando de que ya no está disponible esa pista