Projeto Loja-de-Roupas
==============

Principíos de Design SOLID
------

### SRP - Single Responsibility Principle

O projeto contém classes que representam esse princípio de responsabilidade única, como por exemplo a classe Pessoa sendo abstrata, classes que representam apenas uma entidade, como a classe Endereco, que foi abstraída de Loja, Cliente e Vendedor ou mesmo as classes que representam o pagamento e a entrega separadas das classes Venda e VendaOnline.

### OCP - Open/Closed Principle

Ao criar interfaces para a entrega e o pagamento, garantiu-se que fosse possível estender as funcionalidades, criando novas formas de pagamento ou entrega, mas evitando que fosse necessário alterar o código existente para comportar as adições.

### DIP Dependency Inversion Principle

Ao implementar a persistência, foi necessário implementar uma interface para evitar que o programa seja dependente da classe que escreve no disco, ou seja, uma classe de baixo nível. Fazendo isso, o programa é dependente apenas da interface, ou seja, uma abstração.

#### Integrantes:

- Gabriel Pizzani Palhares
- Guilherme Lima Bernardes
- Henrique Miossi de Araújo
