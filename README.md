# InnovaHack
Repositorio del proyecto para el Hackaton

Propuesta de solución

# Rastreo de GPS paralas camionetas policiales (Similar a aplicación DiDi), con zonas de rastreo con mayor demanda delicitva. 

![image](https://user-images.githubusercontent.com/86864682/127743010-4abfb2cb-2f4f-4d2e-9af0-b55c41a2e1b0.png)


### Problemática
 Muchas veces somos víctimas de un acto en el cual es necesario que intervengan los cuerpos policiales, la situación aquí es que no lo hacen de manera inmediata ya que se encuentran atendiendo una situación diferente o simplemente la patrulla más cercana no llegó y se tuvo que esperar a la que llegará primero; misma que muchas veces nos lleva desde perder nuestras pertenencias por un robo o la muerte por una pelea que se salió de control .

Actualmente no se tiene un conocimiento total de la ubicación de una patrulla las 24 horas, la mayoria de estos vehiculos utilizan su comunicación por radio para reportar su zona; tampoco no se tiene un análisis completo de cuáles son las zonas en las que se debería incrementar la vigilancia por cierto número de avisos por parte de las personas que llaman al 911. Para finalizar no se conoce el estado de una patrulla al momento de hacer un reporte ciudadano, y no se sabe si ignora el llamado o no.


### Función de la Aplicación
  
Nuestra aplicación tiene la función de conocer en tiempo real la ubicación exacta de las patrullas policiales y en cuanto se tenga una emergencia esta pueda acudir al lugar más rápido. De la obtención de estos datos se crea una base de datos de las zonas con más riesgo y que necesitan mayor vigilancia lo cual puede ayudar a reducir considerablemente los delitos y aumentar la protección de la ciudadanía.
 
Con estos datos habrá un mayor control de los oficiales y a los lugares en los cuales acudieron. Sistema de monitoreo de 24 horas por patrulla, para conocer la ubicación de cada unidad y que hace en cada momento, de tal forma para garantizar el trabajo de una patrulla de seguridad. 
 
Una operadora atenderá el llamado, posteriormente mandará un reporte que se reflejará en la ubicación asignada como un punto de denuncia y a partir de ahí, se generará un reporte de las unidades que se encuentren en un radio de 5 km (ejemplo) al punto de ubicación y se verá cuáles atendieron el llamado y cuáles no, en caso de atender, confirmaron la denuncia o desmentir la misma, para mandarlo al proceso de datos de predicción de posible zona de riesgo, en caso de no atender el llamado, se abre un expediente de motivos; teniendo el caso de que se hace una denuncia y una patrulla no atiende el llamado, se abrirá un reporte en donde los miembros de la patrulla tienen que justificar el porqué no se atendió el llamado o cuál era su situación en ese momento.
 
En el caso de atender el llamado, confirmar la denuncia. Si la denuncia es confirmada, mandar esos datos para que sean procesados. Una vez los datos hayan sido procesados, se elegirán zonas de posible riesgo para que las patrullas hagan rondas de vigilancia en esas locaciones, la ventaja es que esos datos serán confirmados en tiempo real.
En caso de atender el llamado y que no sea confirmada la denuncia, se abrirá un reporte, pero los datos no serán procesados.

![Image of Services](https://github.com/Rene-Cruz/InnovaHack/blob/main/img/diagrama.jpg)

### Costos sin la nube

| Gastos totales por inseguridad | Dinero | PIB |
| ------------------------------ | ------ | --- |
| Gasto por años  | $282.1 mil millones de pesos | 1.53%|
| Gastos por persona | $6,931.00 | 22,3 MILLONES VICTIMAS EN TODO EL AÑO |
| POR CADA 100 MIL HABITANTES | TASA INCIDENCIAS 100 MIL H | - |
| TASA DE 24,849 VÍCTIMAS | 33,65 CASOS | - |


### Costos con la nube

#### Costos TCO 3 años
Costos lineales


![TCO image](https://github.com/Rene-Cruz/InnovaHack/blob/main/img/diagramaTCO.jpg)

Grafica pastel de servicios


![TCO graphic](https://github.com/Rene-Cruz/InnovaHack/blob/main/img/graficaPastel.jpg)

En un total, se está ahorrando la cantidad $23775008.88

#### Precio Total por mes
| Description | Estimated monthly cost |
|-----------|--------------|
| Block Blob Storage, General Purpose V2, LRS Redundancy, Hot Access Tier, 1,000 GB Capacity - Pay as you go, 100,000 Write operations, 100,000 List and Create Container Operations, 100,000 Read operations, 100,000 Archive High Priority Read, 1 Other operations. 1,000 GB Data Retrieval, 1,000 GB Archive High Priority Retrieval, 1,000 GB Data Write | $410.18 |
| S0 tier: 10,000 transactions | $211.00 |
| Consumption tier, 128 MB memory, 100 milliseconds execution time, 10,000 executions/mo | $0.00 |
| Basic Tier; 1 B2 (2 Core(s), 3.5 GB RAM, 10 GB Storage) x 730 Hours; Windows OS | $2,310.45 |
| Single Database, vCore, RA-GRS Backup Storage, General Purpose, Provisioned, Gen 5, Local Redundancy, 1 - 8 vCore instance(s) x 730 Hours, 32 GB Storage, 0 GB Backup Storage | $22,601.27 |
| Consumption tier, 128 MB memory, 100 milliseconds execution time, 9,999 executions/mo | $0.00 |
| Standard Tier, Free: 500 devices, 8,000 msgs/day, $0.00/mo, 0 IoT Hub Units | $0.00 |
| ExpressRoute, Metered, Standard, 50 Mbps Circuit X 1 | $1,160.50 |
| 1,000,000 Standard API calls, 1 VM(s) monitored and 1 metric(s) monitored per VM, 1 Log Alert(s) at 5 Minutes Frequency, 1,000 emails, 1,000 push notifications, 100,000 web hooks | $33.76 |
| 1 D3 v2 (4 Core(s), 14 GB RAM) x 730 Hours, Pay as you go | $3,527.29 |
| East US (Virtual Network 1): 100 GB Outbound Data Transfer; East US (Virtual Network 2): 100 GB Outbound Data Transfer | $84.40 |
| Total | $30,338.85 | 

# SLA 

Cálculo del SLA y disponibilidad en un año

![sla image](https://github.com/Rene-Cruz/InnovaHack/blob/main/img/sla.jpg)


#### Tik Tok
(https://vm.tiktok.com/ZMdcK9Hhg/)

# Opiniones del Hackaton

## José Armando Díaz
El trabajar dentro del Hackathon es una experiencia completamente nueva para mí, ya que no me había tocado participar en un evento de tal magnitud; la adrenalina es una de las principales cosas que se sienten porque conoces a nuevas personas y hay que vasar todo en el conocimiento previo. No se necesita como tal una carrera porque entre todos hacemos un gran aporte.
Con el apoyo de los Sherpa aclaramos ideas y pudimos trabajar de la mejor manera, aunque se gane o se pierda el conocimiento siempre estará presente, es lo que me enorgullece; gracias a todo esto lo podre compartir con más y más personas para que crezca el interés de seguir aprendiendo.

![image](https://user-images.githubusercontent.com/86864682/127774219-b3306cfe-a228-47f1-bbce-63c6c7eb9eee.png)


## Julio Abraham Alonso

A lo largo de este recorrido correspondiente al Hack hemos aprendido de todo, desde la integración de un equipo multidisciplinario hasta ser capaces de diseñar y crear una solución a un problema que aqueja da la sociedad actual. Realmente ha sido una muy grata experiencia el poder convivir con otras personas y explotar mis habilidades recientemente adquiridas en el curso. A pesar de que no me especializo en el tema de la nube o la informática.

## René Francisco Cruz González
Me gustó bastante el evento, creo que fue algo difícil y eso ayudó a reforzar los temas que se habían estudiado anteriormente. De igual manera las dinámicas fueron excelentes, así como la buena vibra que los sherpas nos daban. Cabe decir que fue un proceso muy educativo y divertido a la vez.

![rambo](https://github.com/Rene-Cruz/InnovaHack/blob/main/img/rambolike.jpg)

