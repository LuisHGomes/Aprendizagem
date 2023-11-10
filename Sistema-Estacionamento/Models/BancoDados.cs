using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Estacionamento.Models
{
    public class BancoDados
    {
        private static List<string> arrayVagas = new List<string>();
        public static void AddListagem(string dadosVaga){
            arrayVagas.Add(dadosVaga);
        }

        public static List<string> OrdenarVaga(){
            return vagasOrdenadas;
        }
    }
}