DROP DATABASE IF EXISTS `konyvtar`;
CREATE DATABASE IF NOT EXISTS `konyvtar` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;
USE `konyvtar`;

CREATE TABLE vasarlok (
    vasarlo_id INT PRIMARY KEY,
    nev VARCHAR(100),
    email VARCHAR(100),
    telefonszam VARCHAR(20)
);

CREATE TABLE rendelesek (
    rendeles_id INT PRIMARY KEY,
    vasarlo_id INT,
    datum DATE,
    vegosszeg DECIMAL(10,2),
    FOREIGN KEY (vasarlo_id)
        REFERENCES vasarlok(vasarlo_id)
);

CREATE TABLE rendeles_tetelek (
    tetel_id INT PRIMARY KEY,
    rendeles_id INT,
    konyv_cim VARCHAR(200),
    darabszam INT,
    ar DECIMAL(10,2),
    FOREIGN KEY (rendeles_id)
        REFERENCES rendelesek(rendeles_id)
);