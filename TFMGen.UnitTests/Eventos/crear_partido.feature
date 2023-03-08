Feature: Creación de un partido
 
    El usuario quiere crear un partido de padel
 
    Scenario: El usuario quiere crear un partido de pádel con la sesión iniciada
    Given El usuario accede al área de partidos
    When Le da a crear partido
    Then Se le muestra la opción de seleccionar un deporte
 
    Scenario: El usuario con la sesión iniciada quiere seleccionar una hora
    Given El usuario quiere seleccionar la hora del partido de padel (22:00)
    And le ha dado a crear un nuevo partido
    And ha seleccionado padel
    When Selecciona su ubicación
    And la pista 4B del polideportivo de Alicante
    Then Selecciona la hora 22:00
 
    Scenario: El usuario con la sesión iniciada quiere seleccionar una hora no disponible
    Given El usuario quiere seleccionar la hora del partido de padel (22:00)
    And le ha dado a crear un nuevo partido
    And ha seleccionado padel
    But Esa hora ya ha sido reservada por otro usuario
    When Selecciona su ubicación
    And la pista 4B del polideportivo de Alicante
    Then El sistema no le permite seleccionar las 22:00 deshabilitando esa hora
 
    Scenario: El usuario con la sesión iniciada quiere realizar el pago del partido
    Given El usuario quiere realizar el pago del partido que ha creado
    And ha seleccionado el deporte
    And ha seleccionado la ubicación
    And ha seleccionado la pista
    And ha seleccionado la hora
    When Realiza el pago
    Then Se crea el partido
    And se añade un jugador a este
    And se realiza la reserva
    And se notifica al usuario con los datos del partido
 
    Scenario: El usuario quiere crear un partido de padel sin la sesión iniciada
    Given El usuario quiere crear un partido de padel
    When Accede al área de partidos
    Then No la encuentra, debido a que tiene que iniciar sesión
    And sólo le permite inscribirse a un partido