using System;
using System.Collections.Generic;

namespace DeliveryRestaurantes
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantesRegiao regLondrina = new RestaurantesRegiao("Londrina");

            Restaurante r1 = new Restaurante("Comida Mineirinha", "Rua Belém", "123456");
            Produto p1 = new Produto("PF de feijoada", "500g de pura feijoada", 15f);
            Produto p2 = new Produto("Marmita Média", "Marmita de 400g variada", 12.50f);
            r1.cardapio.adicionarProduto(p1);
            r1.cardapio.adicionarProduto(p2);
            regLondrina.adicionarRestaurante(r1);

            Restaurante r2 = new Restaurante("Comida Japonesa", "Rua Amapá", "23456789");
            Produto p3 = new Produto("Temaki", "Temaki de salmão", 12f);
            Produto p4 = new Produto("Sushi", "12 peças de sushi variados", 15.50f);
            r2.cardapio.adicionarProduto(p3);
            r2.cardapio.adicionarProduto(p4);
            regLondrina.adicionarRestaurante(r2);

            regLondrina.removerRestaurante(r1);
            regLondrina.mostrarRestaurantes();
            r2.mostrarCardapio();

            RestaurantesRegiao regMaringa = new RestaurantesRegiao("Maringá");
            Restaurante r3 = new Restaurante("Resturante Canção", "Av Colombo", "444444");
            Produto p5 = new Produto("Baião de 2", "Arroz com feijão e temperos", 13.50f);
            Produto p6 = new Produto("Ovo cozido", "Ovos de codorna", 6.50f);
            r3.cardapio.adicionarProduto(p5);
            r3.cardapio.adicionarProduto(p6);
            regMaringa.adicionarRestaurante(r3);

            r3.removerProduto(p6);

            regMaringa.mostrarRestaurantes();
            r3.mostrarCardapio();

            Pedido pedido1 = new Pedido("Diego");
            pedido1.adicionarProduto(p1);
            pedido1.adicionarProduto(p2);
            pedido1.entregar();
            pedido1.MostrarPedido();
            r3.adicionarPedido(pedido1);
            r3.criarPedido("Joao", new Produto[]{p5});
            r2.criarPedido("Dhayvison", new Produto[] { p3, p4 });
            r2.criarPedido("Matheus", new Produto[] { p3 });
            r2.criarPedido("Raul", new Produto[] { p4 });
            r3.MostrarPedidos(Restaurante.TipoPedido.NaoEntregue);
            r3.MostrarPedidos(Restaurante.TipoPedido.Entregue);
            r3.MostrarPedidos(Restaurante.TipoPedido.Todos);
            r2.MostrarPedidos(Restaurante.TipoPedido.NaoEntregue);
            r2.MostrarPedidos(Restaurante.TipoPedido.Entregue);
            r2.MostrarPedidos(Restaurante.TipoPedido.Todos);


            RestaurantesRegiao regCambe = new RestaurantesRegiao("Cambé");

            Restaurante r4 = new Restaurante("Resturante Nativo", "Av. Rio Tibagi, 105", "43556555/1004");
            Produto p7 = new Produto("Típica feijoada", "Arroz, feijoada, mandioca frita e carne", 18.50f);
            Produto p8 = new Produto("Café reforçado", "Café expresso ou americano, sanduiche com presunto, queijo e ovos", 6.00f);
            r4.cardapio.adicionarProduto(p7);
            r4.cardapio.adicionarProduto(p8);
            regCambe.adicionarRestaurante(r4);

            regCambe.mostrarRestaurantes();
            r4.mostrarCardapio();

            Restaurante r5 = new Restaurante("Cambé & Café", "Av. Rio Tibagi, 143", "43544554/1004");
            Produto p9 = new Produto("Expresso", "Café preto", 1.00f);
            Produto p10 = new Produto("Americano", "Café preto porém mais fraco", 1.00f);
            Produto p11 = new Produto("Macchiato", "Café com Chantily", 1.60f);
            Produto p12 = new Produto("Double", "Café preto em dose dupla", 2.00f);
            Produto p13 = new Produto("Cappucchino", "Café, leite e chantily++", 3.00f);
            Produto p14 = new Produto("Latte", "Café, leite++, chantily ", 3.00f);


            r5.cardapio.adicionarProduto(p9);
            r5.cardapio.adicionarProduto(p10);
            r5.cardapio.adicionarProduto(p11);
            r5.cardapio.adicionarProduto(p12);
            r5.cardapio.adicionarProduto(p13);
            r5.cardapio.adicionarProduto(p14);

            regCambe.adicionarRestaurante(r5);

            regCambe.mostrarRestaurantes();
            r5.mostrarCardapio();
        }
    }
}
