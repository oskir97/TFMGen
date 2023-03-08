Feature: Seleccionar pista
 
    El usuario quiere seleccionar una pista
 
    Background: El usuario ha seleccionado como deporte Padel
 
    Scenario: El usuario quiere ver las pistas de la ciudad de Alicante
    Given El usuario quiere que se le muestren las pistas de Alicante
    When Selecciona Alicante en la lista de ubicaciones
    Then Se muestran todas las instalaciones que se hayan creado en la ciudad de Alicante
 
    Scenario: El usuario quiere que la aplicación le detecte su ubicación con la ubicación activada
    Given El usuario quiere que se le detecte la ubicación de forma automática
    When Selecciona esta opción
    Then Se le muestran todas las instalaciones cerca de él
 
    Scenario: El usuario quiere que la aplicación le detecte su ubicación sin la ubicación activada
    Given El usuario quiere que se le detecte la ubicación de forma automática
    But No tiene la ubicación activada
    When Selecciona esta opción
    Then Se le muestra un mensaje de que no tiene la ubicación activada
 
    Scenario: El usuario quiere consultar las pistas del polideportivo de Alicante
    Given El usuario ha seleccionado la ubicación de Alicante
    When Elige el polideportivo de Alicante
    Then Se le muestran las pistas disponibles
 
    Scenario: El usuario quiere seleccionar una pista
    Given El usuario ha seleccionado las instalaciones de pádel del polideportivo de Alicante
    When Elige la pista 3A
    Then Se muestran los horarios disponibles e información relativa a ella