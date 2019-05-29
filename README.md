# FCamaraSuperdigital

- Desenvolvimento de uma API REST com ASP.NET Core 2.1
- Utilização de injeção de dependências.
- EntityFramework Core (InMemoryDatabase).
- Conceito de repositórios.
- Documentação com Swagger.
- Habilitado no Swagger a geração do uso de autorização.

# Itens Pendentes

- Geração de Token com JWT. (Necessário mais 2 horas)
- Falta de testes unitários. (Necessário mais 1 hora).

# 1) EXPLIQUE COM SUAS PALAVRAS O QUE É DOMAIN DRIVEN DESIGN E SUA IMPORTÂNCIA
# NA ESTRATÉGIA DE DESENVOLVIMENTO DE SOFTWARE.

O DDD é um conceito que por meio de algumas técnicas possibilita o desenvolvimento de aplicações tendo em foque a separação 
dos "módulos" em pequenos contextos bem definidos e assim criando uma delimitação clara entre eles. 

Como o foco do DDD está relacionado ao negócio/dominio, sua principal vantagem está no ganho de conhecimento que a equipe
de desenvolvimento adquire em relação ao negócio. Na minha opnião, a linguagem Ubiqua é a grande responsável por isso, pois
o código tende a representar de fato o negócio. Os contextos delimitados pregrados possibilitam a segragação do código e com isso 
funcionalidades menos acopladas o que consequentemente possibilita uma evolução mais rápida das funcionalidades já que algo
só muda quando o negócio muda, pois como dito anteriormente o código representa o negócio.

# 2) EXPLIQUE COM SUAS PALAVRAS O QUE É E COMO FUNCIONA UMA ARQUITETURA BASEADA
# EM MICROSERVICES. EXPLIQUE GANHOS COM ESTE MODELO E DESAFIOS EM SUA
# IMPLEMENTAÇÃO.

A arquitetura baseada em microserivços nada mais é do que a segragação de funcionalidades da aplicação em pequenos serviços.
Suas principais vantagens está no baixo acoplamento com demais funcionalidades do sistema, facilidade em evolução da mesma e 
escalabilidade, pois por exemplo a parada de um serviço não impacta dos demais como acontece nas arquiteturas monolíticas.
Na minha opnião o maior desafio está no controle transacional entre microserviços, por exemplo: Preciso cadastrar uma compra,
que por sua vez cadastra um pedido. RealizarPedido e FinalizarCompra podem ser serviços diferentes, no exemplo, vamos supor
que consigo realizar o pedido, porém a finalização da compra falha. Tenho dois bancos diferentes, precisarei sempre manter
os dois alinhados, falhou em um, preciso dar um delete no outro.

# 3) EXPLIQUE QUAL A DIFERENÇA ENTRE COMUNICAÇÃO SINCRONA E ASSINCRONA E QUAL O
# MELHOR CENÁRIO PARA UTILIZAR UMA OU OUTRA.

Comunicação sincrona quem realiza a chamada aguarda a resposta na mesma Thread. Assincrona realiza a chamada em umaThread
diferente e necessariamente não precisa esperar a resposta. Chamadas sincronas são ideaias para pequenos processos, já as assincronas
para processos mais demorados, que se fossem realizados de forma sincrona, obrigariam o travamento da Thread principal que estaria
aguardando o processamento.
