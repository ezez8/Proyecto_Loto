select monto_pagado, MONTO_APUESTA
from tb_ticket A, tb_usuario B
where A.id_usuario = B.id_usuario and B.id_usuario = 1 and A.fecha_hora = "2018-10-10";

select monto_pagado, MONTO_APUESTA
from tb_ticket T, tb_usuario U, 
where T.id_usuario = U.id_usuario
and I.id_item = US.id_item
and U.id_usuario = 1 
and T.fecha_hora >= "2017-10-10";

select *
from tb_usuario;

select *
from tb_usuario_sorteo_item;

select *
from tb_ticket;

select *
from tb_juego;

select *
from tb_dominio;

insert into tb_dominio (id_dominio,nombre,numeroidentificacion,estatus,direccion,telefono,banqueo,porcentaje) 
values (8,'Anthony','28143369',1,'caracas','4241668983',3,8.5);

insert into tb_dominio (id_dominio,nombre,numeroidentificacion,estatus,direccion,telefono,banqueo,porcentaje) 
values (5,'Gabriel','27150750',2,'caracas','4241363707',3,8.5);

update tb_dominio set estatus = 4
where nombre = 'Anthony';

delete from tb_dominio;

insert into tb_juego (id_juego,id_tipojuego,nombre,estatus,
factorpago,tiempocierre) values (1,1,"Bingo",1,2,5);

insert into tb_juego (id_juego,id_tipojuego,nombre,estatus,
factorpago,tiempocierre) values (2,1,"Ruleta",1,2,5);

insert into tb_tipojuego (id_tipojuego,descripcion,pagina,estatus) values (1,"Numeros","www.bingo.com",1);

insert into tb_ticket (id_ticket,id_usuario,serial,fecha_hora,estatus,monto_pagado,fecha_hora_pago,monto_apuesta) 
values (3,1,"5124879","2018-10-10",1,0,null,5000.00);

insert into tb_ticket (id_ticket,id_usuario,serial,fecha_hora,estatus,monto_pagado,fecha_hora_pago,monto_apuesta) 
values (6,1,"8745156","2018-01-03",1,500,null,50.00);

select monto_pagado 
from tb_ticket 
where fecha_hora >= current_date() and id_usuario = 1;

select monto_pagado, MONTO_APUESTA
from tb_ticket A, tb_usuario B
where A.id_usuario = B.id_usuario and B.id_usuario = 1 and A.fecha_hora >= "2018-10-10";

/       insert item              /

insert into tb_item (id_item,id_juego,nombre,valor,cupo,monto,estatus) values (1,1,'uno','a',3,1000.00,1);

insert into tb_item (id_item,id_juego,nombre,valor,cupo,monto,estatus) values (2,1,'dos','a',3,1000.00,1);

insert into tb_item (id_item,id_juego,nombre,valor,cupo,monto,estatus) values (3,1,'tres','a',3,1000.00,1);


insert into tb_item (id_item,id_juego,nombre,valor,cupo,monto,estatus) values (4,2,'unorojo','a',3,1000.00,1);

insert into tb_item (id_item,id_juego,nombre,valor,cupo,monto,estatus) values (5,2,'dosrojo','a',3,1000.00,1);

insert into tb_item (id_item,id_juego,nombre,valor,cupo,monto,estatus) values (6,2,'unonegro','a',3,1000.00,1);

insert into tb_item (id_item,id_juego,nombre,valor,cupo,monto,estatus) values (7,2,'dosnegro','a',3,1000.00,1);

/       insert sorteo              /

insert into tb_sorteo (id_sorteo,ID_JUEGO,hora,estatus) values (1,1,"05:00:00",1);

insert into tb_sorteo (id_sorteo,ID_JUEGO,hora,estatus) values (2,1,"05:00:00",1);

insert into tb_sorteo (id_sorteo,ID_JUEGO,hora,estatus) values (3,1,"05:00:00",1);

insert into tb_sorteo (id_sorteo,ID_JUEGO,hora,estatus) values (4,1,"05:00:00",1);

insert into tb_sorteo (id_sorteo,ID_JUEGO,hora,estatus) values (5,1,"05:00:00",1);

insert into tb_sorteo (id_sorteo,ID_JUEGO,hora,estatus) values (6,2,"05:00:00",1);

select *
from tb_sorteo;

delete from tb_sorteo 
where id_sorteo = 6;

select *
from tb_item;

/		insert usuario_sorteo_item		/

select *
from tb_usuario_sorteo_item;

insert into tb_usuario_sorteo_item (id_usuariosorteoitem,id_sorteo,id_item,id_usuario,cupo_max,monto_max,estatus,
cupo_disponible,monto_disponible) values (1,1,3,1,5,100000,1,2,100000);

insert into tb_usuario_sorteo_item (id_usuariosorteoitem,id_sorteo,id_item,id_usuario,cupo_max,monto_max,estatus,
cupo_disponible,monto_disponible) values (2,2,1,1,5,100000,1,2,100000);

insert into tb_usuario_sorteo_item (id_usuariosorteoitem,id_sorteo,id_item,id_usuario,cupo_max,monto_max,estatus,
cupo_disponible,monto_disponible) values (3,3,3,1,5,100000,1,2,100000);

insert into tb_usuario_sorteo_item (id_usuariosorteoitem,id_sorteo,id_item,id_usuario,cupo_max,monto_max,estatus,
cupo_disponible,monto_disponible) values (4,4,3,1,5,100000,1,2,100000);

insert into tb_usuario_sorteo_item (id_usuariosorteoitem,id_sorteo,id_item,id_usuario,cupo_max,monto_max,estatus,
cupo_disponible,monto_disponible) values (5,5,3,1,5,100000,1,2,100000);

insert into tb_usuario_sorteo_item (id_usuariosorteoitem,id_sorteo,id_item,id_usuario,cupo_max,monto_max,estatus,
cupo_disponible,monto_disponible) values (6,6,2,1,5,100000,1,2,100000);

///////////////////////////////////////////////////////////////////////////

insert into tb_comision (id_comision,id_usuario,COMISIONVENTA,COMISIONPARTICIPACION,
FECHAINICIO,FECHAFIN,ESTATUS) values (1,1,20,null,"2018-10-1","2019-02-1",1);

update tb_comision set fechafin = "2018-11-01"
where id_usuario = 1;

insert into tb_comision (id_comision,id_usuario,COMISIONVENTA,COMISIONPARTICIPACION,
FECHAINICIO,FECHAFIN,ESTATUS) values (2,1,30,null,"2018-11-2",current_date(),1);

insert into tb_ticket (id_ticket,id_usuario,serial,fecha_hora,estatus,monto_pagado,fecha_hora_pago,monto_apuesta) 
values (4,1,"7425135","2019-01-03",1,10000,null,10.00);

insert into tb_ticket (id_ticket,id_usuario,serial,fecha_hora,estatus,monto_pagado,fecha_hora_pago,monto_apuesta) 
values (5,1,"7425135","2019-01-03",1,0,null,20000.00);

select MONTO_PAGADO, MONTO_APUESTA, COMISIONVENTA, COMISIONPARTICIPACION
from tb_usuario A, tb_ticket B, tb_comision C
where A.id_usuario = B.id_usuario
and A.id_usuario = C.id_usuario
and B.fecha_hora <= C.fechafin
and B.fecha_hora >= C.fechainicio
and A.id_usuario = 1;

select * 
from tb_comision;

update tb_comision 
set comisionparticipacion = 10
where id_usuario = 1;