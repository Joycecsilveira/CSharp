using System;
using static SuperMercado;


EstoqueDeProdutos estoque = new EstoqueDeProdutos();
estoque.nome = "Biscoitos";
estoque.fabricante = "ABC Biscoitos";
estoque.codigo_barras = "124528751";
estoque.valor_uitario = 4;
estoque.valor_compra = 2;
estoque.quantidade_estoque = 3;

Console.WriteLine("A quantidade de biscoitos em estoque é de  = " + estoque.quantidadeEmEstoque);
