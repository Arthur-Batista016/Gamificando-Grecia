CREATE DATABASE GreciaGames;
USE GreciaGames;
use master;
drop database GreciaGames
CREATE TABLE Personagens(
    PersonId INT NOT NULL PRIMARY KEY IDENTITY,
	PersonName VARCHAR(30) NOT NULL,
    PersonTexto VARCHAR(200) NOT NULL,
	PersonOpc1 VARCHAR(100) NOT NULL,
	PersonOpc2 VARCHAR(100) NOT NULL
);

CREATE TABLE Medidores(
    MedidorId INT NOT NULL PRIMARY KEY IDENTITY,
	PersonId INT NOT NULL,
	EstatisMantimentos INT,
	EstatisExercito INT ,
	EstatisConfianca INT,
	FOREIGN KEY(PersonId) REFERENCES Personagens(PersonId)
);

INSERT INTO Personagens VALUES('Agapetos', 'General, o caminho ser� longo, dever�amos seguir para o Oeste ou para o Noroeste.', 'Vamos, para o Oeste.', 'Continuem no Noroeste.');
INSERT INTO Personagens VALUES('Terreno Montanhoso', 'Chegamos em um terreno montanhoso, caminhos estreitos e �ngremes.', 'Contornar para um local mais seguro e mais longo.', 'Avan�ar cautelosamente. N�o temos tempo � perder!');
INSERT INTO Personagens VALUES('Tempestade', 'Nuvens escuras se acumulam, anunciando uma tempestade.', 'Economizaremos tempo prosseguindo na tempestade.', 'Abriguemos at� a tempestade passar.');
INSERT INTO Personagens VALUES('Eryx', 'O rio � frente est� transbordando devido �s chuvas recentes, o que faremos?', 'Usar madeiras para improvisar uma jangada e atravessar.', 'Esperar a �gua se acalmar para ultrapassar.');
INSERT INTO Personagens VALUES('Calista', 'General, avistei pelot�o inimigo pr�ximo ao nosso acampamento.', 'Escondam-se, esperemos at� irem embora.', 'Evitaremos confronto, contornem pelo caminho mais longo.');
INSERT INTO Personagens VALUES('Vilarejo abandonado', 'Avistamos um vilarejo, parece estar abandonado.', 'Explorem e procurem mais mantimentos.', 'Pode ser uma emboscada, continuem pelo caminho principal.');
INSERT INTO Personagens VALUES('Perseus', 'Chegamos numa floresta densa, com uma chance alta de conter armadilhas.', 'Separar as tropas para surpreend�-los.', 'Fiquem juntos, se eles aparecerem n�s os atacamos.');
INSERT INTO Personagens VALUES('Floresta armadilheira', 'Era uma armadilha! Estamos sendo atacados, o que faremos?', 'Vamos recuar. N�o h� tempo de levar tudo.', 'Reforcem as defesas imediatamente.');
INSERT INTO Personagens VALUES('Velho solit�rio', 'Encontramos um velho solit�rio pelo caminho, ele pediu um pouco de nossos mantimentos.', 'Negar a entrega de suprimentos.', 'Entregar um pouco de mantimento para ele.');
INSERT INTO Personagens VALUES('Marios', 'Avistamos exercito inimigo perto do Vale.', 'Evitaremos ataques at� o Desfiladeiro.', 'Eles n�o podem saber que estamos pr�ximos, ataque-os!');
INSERT INTO Personagens VALUES('Antonios', 'Nossos suprimentos est�o quase acabando.', 'Racionaremos suprimentos e faremos ca�adas perto do acampamento.', 'Buscaremos vilarejos pr�ximos para requisitar alimentos.');
INSERT INTO Personagens VALUES('Menelaus', 'General, estamos � muitos dias andando incansavelmente, precisamos de uma pausa.', 'Continuemos em frente, estamos quase chegando.', 'Vamos parar e descansar um pouco.');
INSERT INTO Personagens VALUES('Velho solit�rio', 'Reencontramos o velho solit�rio, e ele quer n�s retribuir.', 'Aceitar.', 'Negar.');
INSERT INTO Personagens VALUES('Desfiladeiro', 'Ap�s um longo percurso, chegamos ao Desfiladeiro, parece que os persas ainda n�o chegaram.', 'Mandar seus homens descansarem.', 'Se armar, h� uma possibilidade de ser uma emboscada.');
INSERT INTO Personagens VALUES('Mensageiro inimigo', 'Xerxes mandou mensageiros propondo a rendi��o do ex�rcito e entrega das armas.', 'Vem busc�-las!', 'N�s rendemos ao exercito...');
INSERT INTO Personagens VALUES('Gregorios', 'Os persas se aproximam. O que faremos, general?', 'Atacar agora.', 'Esperar um golpe mais decisivo.');
INSERT INTO Personagens VALUES('Alexios', 'O inimigo avan�a em forma��o.', 'Manter nossa forma��o defensiva.', 'Flanquear os inimigos.');
INSERT INTO Personagens VALUES('Arqueiros inimigos', 'Arqueiros est�o posicionados na colina.', 'Recuem para n�o sermos atingidos.', 'Procurem locais para se defenderem.');
INSERT INTO Personagens VALUES('Muitas baixas', 'Ocasionamos diversas baixas inimigas, devemos continuar nesse ritmo.', 'Continuar com for�a total.', 'Ir mais na defensiva.');
INSERT INTO Personagens VALUES('O fim da batalha', 'Estamos quase vencendo.', 'Finalizar todos os restantes.', 'Poupar os restantes.');
--                                                                                      Mantimentos Exercito Confian�a
INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (1, -15, 0, 10);
INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (1, -10, 0, 10);

INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (2, -15, 0, 15);
INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (2, -5, -15, -20);

INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (3, -20, -5, -5);
INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (3, 15, 0, 10);

INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (4, 15, 0, 10);
INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (4, -20, 0, 5);

INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (5, -5, 0, 10);
INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (5, -10, -5, -5);

INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (6, 25, -5, 10);
INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (6, -20, 0, -5);

INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (7, -10, -15, -20);
INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (7, -5, -10, -10);

INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (8, 15, -25, -15);
INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (8, 0, -10, 5);

INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (9, 0, 0, -25);
INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (9, -10, 0, 15);

INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (10, -5, 0, 5); 
INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (10, -5, -15, 10);  

INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (11, 20, -5, 10);
INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (11, 15, 0, 5);

INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (12, -5, -10, 5);
INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (12, -15, 0, 10);

INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (13, 20, 0, 5);
INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (13, 0, 0, 10);

INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (14, -15, 0, 10);
INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (14, -5, 0, 5);

INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (15, -5, -5, 10);
INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (15, 0, 0, -30);

INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (16, -5, -15, -5);
INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (16, -10, -5, -5);

INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (17, -5, -5, -5);
INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (17, -10, -10, -10);

INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (18, -10, -5, -5);
INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (18, -5, -15, -5);

INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (19, -15, -15, -10);
INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (19, -5, -10, -5);

INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (20, -5, -20, -15);
INSERT INTO Medidores (PersonId, EstatisMantimentos, EstatisExercito, EstatisConfianca) VALUES (20, -10, -15, -10);