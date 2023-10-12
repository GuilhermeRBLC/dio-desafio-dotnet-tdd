using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadora
{
    public class Calculadora
    {

        private List<string> historicoOperacoes;

        public Calculadora()
        {
            historicoOperacoes = new List<string>();
        }

        private void addHistorico(int val1, int val2, int res, string operacao) {
            historicoOperacoes.Add(String.Format("{0} {1} {2} = {3}", val1, operacao, val2, res));
            if(historicoOperacoes.Count > 3) {
                historicoOperacoes.RemoveRange(3, historicoOperacoes.Count - 3);
            }
        }
        
        public int somar(int val1, int val2) {
            int res = val1 + val2;
            addHistorico(val1, val2, res, "+");
            return res;
        }

        public int subtrair(int val1, int val2) {
            int res = val1 - val2;
            addHistorico(val1, val2, res, "-");
            return res;
        }

        public int multiplicar(int val1, int val2) {
            int res = val1 * val2;
            addHistorico(val1, val2, res, "*");
            return res;
        }

        public int dividir(int val1, int val2) {
            int res = val1 / val2;
            addHistorico(val1, val2, res, "/");
            return res;
        }

        public List<string> historico() {
            return historicoOperacoes;
        }

    }
}