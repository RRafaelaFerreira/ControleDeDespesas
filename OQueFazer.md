dotnet restore
(npm install)

**O que fazer para entregar o trabalho corretamente. 
Colocar com "OK" enorme na frente de cada parte para ver o que precisa fazer ainda ou não.** 


*****Parte das migrations:*****
1-Corrigir a classe Alimentação(corrigir de alimentação para Despesas);

2-Configurar a conexão com o banco de dados corretamente;

3-Fazer os passos de migration:
  3.1-   "dotnet ef migrations add CriarTabelaDeDespesas"
  3.2-Aplicar o migration no BD: "dotnet ef database update"
  3.3- Fazer uma alteração(adicionar mais alguma propriedade nova na classe)
    3.3.1-Usamos o mesmo comando(ex: "dotnet ef migrations add AdicionarDescricaoDaDespesa")
  3.4-Remover uma coluna da tabela usa-se "dotnet ef migrations remove".
    3.4.1-Esse comando remove a última migraion aplicada. 

4-Colocar a String de conexão no local certo
  4.1-No appsettings.json criamos o campo "SqlServer" para a propriedade Database;
  4.2-Tiramos do ApplicationDbContext o código relativo ao método OnConfiguring.
  4.3-Criamos o construtor da classe ApplicationDbContext;
  4.4-Criamos um arquivo para cada classe do projeto para que o Porgram.cs não fique grande(tlvz)

5-Manipulando dados no BD:
  5.1- "public record ProdutoRequest(string xxx, string xxx, string Descricao, etc)" Em um arquivo de nome DespesasRequest.cs(ou algo assim);
  5.2-Fazer o endpoint;





*****Parte da minimal API:*****
1- Criar as classes:
  1.1-classe Despesas;
  1.2- Criar o DespesasRepository;

2-Desenvolver os endpoints(não cria, edita ou exclui)
  2.1- app.MapGet("/despesas", ...);  //lista todas
       app.MapGet("/despesas/categoria/{categoria}, ...);  //filtrar por...
       app.MapGet("/despesas/data?inicio=...&fim=...", ...);  // Intervalo de datas
  2.2-Retorna em formato json(pelo navegador);

  ___FORMULÁRIO:___
  1-Campos apenas de busca e retorno de dados.






*****API USANDO CONTROLLER:*****
1-(CADASTRAR, LISTAR, ATUALIZAR E EXCLUIR)
  1.1-Create, Read, Update, Delete;
  1.2-Criar os endpoints Post/despesas; Get/despesas; get/despesas{id}; put/despesas/{id}; delete/despesas/{id};


  ___FORMULÁRIO:___
  1-Campos de CRUD;
  
