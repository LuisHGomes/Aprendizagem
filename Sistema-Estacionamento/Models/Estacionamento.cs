using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Sistema_Estacionamento.Models
{
    public class Estacionamento
    {
        private float comprimentoVaga;
        private float larguraVaga;
        private int idVaga;

        public float getcomprimento()
        {
            return comprimentoVaga;
        }
        public void setcomprimento(float comprimentoVaga)
        {
            comprimentoVaga = comprimentoVaga;
        }
        public float getLargura()
        {
            return larguraVaga;
        }
        public void setLargura(float larguraVaga)
        {
            larguraVaga = larguraVaga;
        }
        public int getId()
        {
            return idVaga;
        }
        public void setId(int idVaga)
        {
            idVaga = idVaga;
        }

        static int completarIdenti()
        {
            Random rnd = new Random();
            return rnd.Next(1, 1000);
        }


        public static void adicionarVaga(float comprimentoVaga, float larguraVaga, int idVaga)
        {
            Estacionamento estacionamento1 = new Estacionamento();

            int i = 0;
            Console.WriteLine("Digite o comprimenro e a largura da vaga");
            comprimentoVaga = float.Parse(Console.ReadLine());
            larguraVaga = float.Parse(Console.ReadLine());

            idVaga = completarIdenti();

            Console.WriteLine($"O comprimento da vaga é de {comprimentoVaga} e sua largura é de {larguraVaga}" +
            "Digite 1 para alterar ou 2 para prosseguir");
            menuAdicao(0);

            void menuAdicao(int i)
            {
                i = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    adicionarVaga(0, 0, 0);
                }
                else if (i == 2)
                {
                    estacionamento1.setcomprimento(comprimentoVaga);
                    estacionamento1.setLargura(larguraVaga);
                    estacionamento1.setId(idVaga);
                    SalvarVagas();
                }
                else
                {
                    Console.WriteLine("Por favor , escolha entre a opção 1 ou 2");
                    menuAdicao(0);
                }
            }

            void SalvarVagas()
            {
                float comprimento = estacionamento1.getcomprimento();
                float largura = estacionamento1.getLargura();
                int idVaga = estacionamento1.getId();
                bool status = false;

                string dadosVaga = modificar(idVaga, largura, comprimento, status);
                BancoDados.AddListagem(dadosVaga);
            }
            string modificar(int idv, float larg, float comp, bool status)
            {

                return $"{idv},{larg},{comp}{status}";
            }
        }

        public static void DeletarVaga()
        {
            Estacionamento estacionamento1 = new Estacionamento();

            Console.WriteLine("Digite o ID da vaga que deseja excluir:");
            int idVagaEcluir = int.Parse(Console.ReadLine());

        }

    }
}