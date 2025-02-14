CREATE DATABASE ReservasHotel;
USE ReservasHotel;

CREATE TABLE IF NOT EXISTS Reserva(
	id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    cpf VARCHAR(11) NOT NULL,
    email VARCHAR(150),
    telefone VARCHAR(12) NOT NULL,
    dtCheckin DATE NOT NULL,
    dtCheckout DATE NOT NULL,
    hospedes INT NOT NULL,
    prefQuarto TEXT,
    tpQuarto VARCHAR(10) NOT NULL,
    formaPag VARCHAR(15) NOT NULL
);

SELECT * FROM Reserva;