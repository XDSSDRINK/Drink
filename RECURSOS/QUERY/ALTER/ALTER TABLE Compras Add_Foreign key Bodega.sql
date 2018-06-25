
alter table compras 
Add Bodega int
Go
alter table compras
add foreign key(Bodega) references Bodega(ID)