DROP TABLE IF EXISTS despesas, receitas, contas;

CREATE TABLE contas(
id INT PRIMARY KEY IDENTITY(1,1),
saldo DECIMAL(10,2),
tipo_conta VARCHAR(100),
instituicao_financeira VARCHAR(100)
);

CREATE TABLE receitas(
id INT PRIMARY KEY IDENTITY(1,1),
valor DECIMAL(10,2),
descricao TEXT,
data_recebimento DATE,
data_recebimento_esperado DATE,
tipo_receita VARCHAR(100),
id_conta INT,
FOREIGN KEY (id_conta) REFERENCES contas(id)
);

CREATE TABLE despesas(
id INT PRIMARY KEY IDENTITY(1,1),
valor DECIMAL(10,2),
data_pagamento DATE,
data_pagamento_esperado DATE,
tipo_despesa VARCHAR(100),
id_conta INT,
FOREIGN KEY (id_conta) REFERENCES contas(id)
);