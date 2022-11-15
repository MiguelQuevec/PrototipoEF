create database PrototipoEF090110509;
use PrototipoEF090110509;

create table tbl_cliente(
pk_id_cliente int not null primary key,
Nombre_cliente varchar(50),
Email_cliente varchar(50),
Direccion_cliente varchar(50),
Telefono_cliente varchar(10)
);

create table tbl_producto(
pk_id_producto int not null primary key,
Nombre_producto varchar(50),
Descripcion_producto varchar(50),
Precio_producto int
);

create table tbl_existencia(
pk_id_existencia int not null primary key,
fk_id_producto int not null,
existencia_producto int,
foreign key (fk_id_producto) references tbl_producto (pk_id_producto)
);

create table tbl_factura(
pk_id_factura int not null primary key,
fk_id_cliente int not null,
fk_id_producto int not null,
Total_factura int,
foreign key (fk_id_producto) references tbl_producto (pk_id_producto),
foreign key (fk_id_cliente) references tbl_cliente (pk_id_cliente)
);