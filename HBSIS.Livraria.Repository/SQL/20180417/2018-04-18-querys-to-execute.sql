Create Table Livro(
    Id				int not null identity(1,1),    
	Titulo     		varchar(255) not null,
	DataPublicacao	datetime not null,
	Autor	     	varchar(255) not null,
	Editora			varchar(255) not null,
	Criacao	    	datetime not null,
    Atualizacao     datetime not null,	
    CONSTRAINT Pk_Livro_Id Primary Key (Id)
)

--Inserção Dados
Insert Into Livro Values('LivroTesteListagem', '2017-03-15', 'NomeAutor1', 'NomeEditora1', getdate(), getdate())