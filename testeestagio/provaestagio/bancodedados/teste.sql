CREATE DATABASE IF NOT EXISTS biblioteca;
USE biblioteca;
CREATE TABLE IF NOT EXISTS livros (
    id_livros  int AUTO_INCREMENT PRIMARY KEY,
    titulo VARCHAR(255) NOT NULL,
    autor VARCHAR(255) NOT NULL,
    ano_publicacao datetime
);


