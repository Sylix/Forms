using System.Collections.Generic;

namespace Forms.Data
{
    public class Escalacao
    {
        public static IEnumerable<Jogador> Get()
        {
            var escalacao = new[]
            {
                new Jogador()
                {
                    Numero = 1,
                    Nome = "Valdir Peres",
                    Posicao = "Goleiro"
                },
                new Jogador()
                {
                    Numero = 2,
                    Nome = "Leandro ",
                    Posicao = "Lateral-Direito"
                },
                new Jogador()
                {
                    Numero = 3,
                    Nome = "Oscar",
                    Posicao = "Zagueiro"
                },
                new Jogador()
                {
                    Numero = 4,
                    Nome = "Luizinho",
                    Posicao = "Zagueiro"
                },
                new Jogador()
                {
                    Numero = 5,
                    Nome = "Toninho Cerezzo",
                    Posicao = "Volante"
                },
                new Jogador()
                {
                    Numero = 6,
                    Nome = "Junior",
                    Posicao = "Lateral-Esquerdo"
                },
                new Jogador()
                {
                    Numero = 7,
                    Nome = "Paulo Isidoro",
                    Posicao = "Meia"
                },
                new Jogador()
                {
                    Numero = 8,
                    Nome = "Socrates",
                    Posicao = "Meia"
                },
                new Jogador()
                {
                    Numero = 9,
                    Nome = "Serginho Chulapa",
                    Posicao = "Atacante"
                },
                new Jogador()
                {
                    Numero = 10,
                    Nome = "Zico",
                    Posicao = "Meia"
                },
                new Jogador()
                {
                    Numero = 11,
                    Nome = "Éder",
                    Posicao = "Atacante"
                }
            };

            return escalacao;
        }
    }
}