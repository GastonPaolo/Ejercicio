# Alquiler de Bicicletas
# README #
Documento para poner en marcha la Aplicacion RentBicycle

### Repositorio RentBicycle  ###

* Quick summary
* Version 0.1

### Como levantar la Aplicacion? ###
* Necesita Framework Instalado 4.6.1
IDE utilizado VISUAL Studio 2015
* Configuration
No posee Configuracion alguna se corren Los test y una Aplicacion de Consola en caso de querer
* Dependencies
Las Dependecias todas son bajadas de Nuget
* Database configuration
No Posee para simplificar la app
* Como Correr los Test
Simplemente darle run a los test de la app y correran
* Deployment instructions
Esta Aplicacion no se va Deployar en ningun Ambiente.

### Contribution guidelines ###
* Cada metodo Creado debe Tener su Test Correspondiente
* Desarrollar con metodologia TTD 

### Explicacion Breve ###
La aplicacion posee 4 clases principales Rental, Price, Discounts, TimeRent.

* Clase Price establece los Precios (para no crear una base de datos)
* Clase TimeRent: Se encarga de estableser que tiempo ingreso el usuario si fue Semana, Hora o Dia. Segun lo que ingresa establece el precio.
* Clase Discounts: Se encarga de Identificar el Descuento Si es Familiar o Ninguno.
* Clase Rental: Es la clase que se encarga llama a las demas para segun los datos ingresados aplicar el Descuento y establecer el precio.

