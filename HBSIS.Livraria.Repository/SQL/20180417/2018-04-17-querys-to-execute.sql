--Criação Tabelas
Create Table Estado(
    Id				int not null identity(1,1),
    Nome     		varchar(255) not null,
	Iniciais		varchar(255) not null,
	Criacao	    	datetime not null,
    Atualizacao     datetime not null,
    CONSTRAINT Pk_Estado_Id Primary Key (Id)    
)

Create Table Cidade(
    Id				int not null identity(1,1),    
	Nome     		varchar(255) not null,
	EstadoId		int not null,
	Criacao	    	datetime not null,
    Atualizacao     datetime not null,	
    CONSTRAINT Pk_Cidade_Id Primary Key (Id),
    CONSTRAINT Fk_Cidade_EstadoId Foreign Key (EstadoId) References Estado(Id)
)

Create Table Editora(
    Id				int not null identity(1,1),    
	Nome     		varchar(255) not null,
	Endereco     	varchar(255) not null,
	CidadeId		int not null,
	Criacao	    	datetime not null,
    Atualizacao     datetime not null,	
    CONSTRAINT Pk_Editora_Id Primary Key (Id),
    CONSTRAINT Fk_Editora_CidadeId Foreign Key (CidadeId) References Cidade(Id)
)

Create Table Autor(
    Id				int not null identity(1,1),    
	Nome     		varchar(255) not null,
	Idade	     	int not null,
	Criacao	    	datetime not null,
    Atualizacao     datetime not null,	
    CONSTRAINT Pk_Autor_Id Primary Key (Id)
)

Create Table Livro(
    Id				int not null identity(1,1),    
	Titulo     		varchar(255) not null,
	Valor     		varchar(255) not null,
	DataPublicacao	datetime not null,
	AutorId	     	int not null,
	EditoraId		int not null,
	Criacao	    	datetime not null,
    Atualizacao     datetime not null,	
    CONSTRAINT Pk_Livro_Id Primary Key (Id),
	CONSTRAINT Fk_Livro_AutorId Foreign Key (AutorId) References Autor(Id),
	CONSTRAINT Fk_Livro_EditoraId Foreign Key (EditoraId) References Editora(Id)
)

--Inserção Dados
Insert Into Estado Values('São Paulo', 'SP', getdate(), getdate())
Insert Into Estado Values('Santa Catarina', 'SC', getdate(), getdate())

Insert Into Cidade Values('Sorocaba', 1, getdate(), getdate())
Insert Into Cidade Values('Campinas', 1, getdate(), getdate())
Insert Into Cidade Values('Blumenau', 2, getdate(), getdate())

Insert Into Editora Values('Editora1', 'Endereco1', 1, getdate(), getdate())
Insert Into Editora Values('Editora2', 'Endereco2', 2, getdate(), getdate())
Insert Into Editora Values('Editora3', 'Endereco3', 3, getdate(), getdate())

Insert Into Autor Values('Autor1', 32, getdate(), getdate())
Insert Into Autor Values('Autor2', 56, getdate(), getdate())

Insert Into Autor Values('Autor1', 32, getdate(), getdate())
Insert Into Autor Values('Autor2', 56, getdate(), getdate())

Insert Into Livro Values('LivroTesteListagem', '29,90', '2017-03-15', 1, 2, getdate(), getdate())