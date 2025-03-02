CREATE DATABASE ReservasHotel;
USE ReservasHotel;
/*DROP DATABASE ReservasHotel;*/
CREATE TABLE IF NOT EXISTS Reserva(
	id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    cpf VARCHAR(11) NOT NULL UNIQUE,
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

CREATE TABLE IF NOT EXISTS Quarto(
    idQuarto INT PRIMARY KEY AUTO_INCREMENT,
    numero INT UNIQUE,
    tipo VARCHAR(50),
    precoDiaria DECIMAL NOT NULL,
    capacidade INT NOT NULL
);
CREATE TABLE IF NOT EXISTS Servico( 
    idServico INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(255) NOT NULL,
    descricao TEXT,
    preco DECIMAL NOT NULL
);

CREATE TABLE IF NOT EXISTS ReservaServico(
	idReservaServico INT PRIMARY KEY AUTO_INCREMENT,
    idReserva INT NOT NULL,
    idServico INT NOT NULL,
    quantidade INT NOT NULL,
    FOREIGN KEY (idReserva) REFERENCES Reserva(id),
    FOREIGN KEY (idServico) REFERENCES Servico(idServico)
);

CREATE TABLE IF NOT EXISTS Funcionario(
    idFuncionario INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(255) NOT NULL,
    cargo VARCHAR(100) NOT NULL,
    email VARCHAR(255),
    telefone VARCHAR(20) NOT NULL
);

CREATE TABLE IF NOT EXISTS Pagamento(
    idPagamento INT PRIMARY KEY AUTO_INCREMENT,
    idReserva INT NOT NULL,
    dataPagamento DATE,
    valor DECIMAL NOT NULL,
    FOREIGN KEY (idReserva) REFERENCES Reserva(id)
);

CREATE TABLE IF NOT EXISTS Avaliacao(
    idAvaliacao INT PRIMARY KEY AUTO_INCREMENT,
    idReserva INT NOT NULL,
    nota INT NOT NULL,
    comentario TEXT,
    dataAvaliacao DATE NOT NULL,
    FOREIGN KEY (idReserva) REFERENCES Reserva(id)
);

CREATE TABLE IF NOT EXISTS ItemConsumido(
    idItemConsumido INT PRIMARY KEY AUTO_INCREMENT,
    idReserva INT NOT NULL,
    nomeItem VARCHAR(255) NOT NULL,
    quantidade INT NOT NULL,
    precoUnitario DECIMAL NOT NULL,
    FOREIGN KEY (idReserva) REFERENCES Reserva(id)
);