Aplicativo para inventário de produtos com código de barras. Executa em coletores de dados Windows CE ou Mobile.

Este projeto foi desenvolvido para auxiliar no processo de inventário de produtos identificados com código de barras. Para executá-lo é necessário um coletor de dados Windows CE ou Windows Mobile.

O funcionamento do projeto é muito simples:
Crie uma planilha (CSV) com a lista de produtos do seu estoque, e carregue-a no coletor de dados
Execute o aplicativo e comece a ler o código dos produtos em estoque. Para cada código lido o programa acrescenta uma marca no produto correspondente na planilha CSV. Caso o produto não exista na planilha, o seu código é marcado em outra lista.
Ao final do processo transfira para o PC as duas planilhas CSV. Uma delas é a planilha que você carregou no coletor, porém com uma coluna adicional que apresentará uma marcação nos produtos que foram lidos. A outra planilha contém apenas os códigos de barras lidos e que não foram encontrados na primeita planilha.

Projeto originalmente desenvolvido por: Promtec - Bobinas e Etiquetas Adesivas.
