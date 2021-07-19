create database unalm;
use unalm;

CREATE TABLE `cursos` (
  `id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `codigo` char(6) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nombre` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `creditos` int NOT NULL,
  `horas_teoria` int NOT NULL,
  `horas_practica` int NOT NULL,
  `sumilla` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `bandeja_mensajes` (
  `id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `nombres` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `apellidos` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `telefono` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `comentarios` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO `unalm`.`cursos`(`codigo`,`nombre`,`creditos`,`horas_teoria`,`horas_practica`,`created_at`,`updated_at`,`sumilla`)
VALUES ('CC1023','Matemática Básica',3,2,4,now(),now(),'El curso de Matemática Básica está destinado a los alumnos que inician sus estudios superiores en las carreras de Ciencias e Ingeniería con el proposito de homogenizar y profundizar sus conocimientos de matemáticas los cuales serán utilizados en los cursos posteriores.');
INSERT INTO `unalm`.`cursos`(`codigo`,`nombre`,`creditos`,`horas_teoria`,`horas_practica`,`created_at`,`updated_at`,`sumilla`)
VALUES ('EP1018','Lengua',3,2,2,now(),now(),'Esta asignatura pretende que el estudiante sea consciente de la importancia del estudio del lenguaje humano, oral y escrito así como de las manifestaciones de la comunicación e información en la sociedad, caracterizadas _mucha veces_ por la complejidad que proviene de la producción y recepción de textos y discursos.');
INSERT INTO `unalm`.`cursos`(`codigo`,`nombre`,`creditos`,`horas_teoria`,`horas_practica`,`created_at`,`updated_at`,`sumilla`)
VALUES ('EP1004','Economía General',4,3,2,now(),now(),'El curso se orienta a desarrollar en los alumnos contenidos para entender la economía como instrumento fundamental que le permita identificar conceptos, y procesos de la realidad económica, aplicados a la problemática de nuestro país.');
INSERT INTO `unalm`.`cursos`(`codigo`,`nombre`,`creditos`,`horas_teoria`,`horas_practica`,`created_at`,`updated_at`,`sumilla`)
VALUES ('CC3090','Electrónica Experimental',2,1,2,now(),now(),'El curso de Electrónica Experimental permitirá al alumno la posibilidad de manipular y conocer el funcionamiento de ciertos equipos factibles para diversas aplicaciones en meteorología');
INSERT INTO `unalm`.`cursos`(`codigo`,`nombre`,`creditos`,`horas_teoria`,`horas_practica`,`created_at`,`updated_at`,`sumilla`)
VALUES ('CC2051','Cálculo Integral',3,2,4,now(),now(),'Esta asignatura tiene la finalidad de proporcionar métodos y técnicas de cálculo integral de funciones en una variable, desarrollando principalmente la integral definida y sus aplicaciones en el campo de las ciencias e ingeniería, creando así en el estudiante una mayor capacidad de análisis en los problemas prácticos y contribuyendo de esta manera a su formación integral.');
INSERT INTO `unalm`.`cursos`(`codigo`,`nombre`,`creditos`,`horas_teoria`,`horas_practica`,`created_at`,`updated_at`,`sumilla`)
VALUES ('CC1020','Química Orgánica',3,2,4,now(),now(),'La Química Orgánica estudia los compuestos que tienen átomos de carbono en su composición y que son más del 90% de todas las moléculas conocidas por el ser humano. En el curso se estudiarán los aspectos básicos de estos compuestos, como su estructura, propiedades y principales aplicaciones.');
INSERT INTO `unalm`.`cursos`(`codigo`,`nombre`,`creditos`,`horas_teoria`,`horas_practica`,`created_at`,`updated_at`,`sumilla`)
VALUES ('EP2046','Perú en el Contexto Internacional',2,1,2,now(),now(),'Se buscará que el estudiante profundice sus conocimientos de la realidad peruana situada dentro del contexto internacional, utilizando los avances de las ciencias sociales y la información de los organismos e investigadores nacionales e internacionales con el fin de que se ubique dentro de su nuevo rol de ciudadano del país, América Latina y el mundo.');