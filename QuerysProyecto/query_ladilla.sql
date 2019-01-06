select tb_ticket.MONTO_PAGADO, tb_ticket.MONTO_APUESTA
from tb_usuario_sorteo_item, tb_item, tb_juego, tb_usuario, tb_ticket
where tb_juego.ID_JUEGO = tb_item.ID_JUEGO
and tb_ticket.ID_USUARIO = tb_usuario.ID_USUARIO
and tb_usuario.ID_USUARIO =  tb_usuario_sorteo_item.ID_USUARIO
and tb_usuario_sorteo_item.ID_ITEM = tb_item.ID_ITEM
and tb_usuario.ID_USUARIO = 2
and tb_ticket.FECHA_HORA >= "1998-05-10"
and tb_juego.ID_JUEGO = 2;