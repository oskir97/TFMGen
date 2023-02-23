Feature: Inscribirse a un partido
 
    El usuario quiere inscribirse a un partido de padel
 
    Scenario: El usuario quiere buscar un partido de pádel en su localidad
    Given El usuario busca un partido de padel disponible en su localidad
    When Selecciona el deporte
    And la ubicación donde lo quiere jugar
    Then Se le muestran los partidos disponibles
 
    Scenario: El usuario quiere inscribirse en un partido y tiene la sesión iniciada
    Given El usuario elige uno de los partidos disponibles en el deporte y ubicación seleccionados
    When Le da a inscribirse
    Then Se le muestra la opción de pago
 
    Scenario: El usuario quiere inscribirse en un partido sin la sesión iniciada
    Given El usuario elige uno de los partidos disponibles en el deporte y ubicación seleccionados
    But No tiene la sesión iniciada
    When Le da a inscribirse
    Then Se muestra la opción de rellenar un formulario obligatorio con sus datos básicos (nombre, apellidos, email y teléfono)
    And la opción de registrarse
    And la opción de iniciar sesión
 
    Scenario: El usuario quiere seleccionar un partido que está completo
    Given El usuario elige uno de los partidos disponibles en el deporte y ubicación seleccionados
    But El partido al que quiere inscribirse está completo
    When Intenta seleccionar ese partido
    Then El sistema no muestra los partidos completos
    And el usuario no puede inscribirse
 
    Scenario: El usuario realiza el pago
    Given El usuario realiza el pago introduciendo sus datos de tarjeta
    When Pulsa realizar el pago
    Then El sistema realiza la transacción
    And inscribe al usuario en el partido
    And le envía una notificación con los datos del partido incluyendo la hora y ubicación de este
 
    Scenario: El usuario realiza el pago pero se equivoca en algún dato
    Given El usuario realiza el pago introduciendo sus datos de tarjeta
    But se equivoca en el código de verificación de la tarjeta
    When Pulsa realizar el pago
    Then El sistema le informa que los datos no son correctos
 
    Scenario: El usuario intenta inscribirse cuando otro usuario ya se ha inscrito previamente
    Given El usuario se decide a inscribirse en el partido
    But tarda más de 5 minutos en intentar completar la inscripción
    When Intenta realizar el pago
    Then El sistema lanza un mensaje de error informando de que ha ocurrido un error