using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho___PIM
{
    //são classificadas como legumes são os frutos, as raízes, os caules e os tubérculos.
    //as verdura são tipos de plantas em forma de folhas e fruta que são comestíveis.

    internal class Plant_Produção
    {
        private string data;
        private int frutas;
        private int verduras;
        private int legumes;
        

        public Plant_Produção(string data, int frutas, int verduras, int legumes)
        {
            this.data = data; 
            this.frutas = frutas;
            this.verduras = verduras;
            this.legumes = legumes;            
        }
        public void plant_ProdInfo()
        {
            Console.WriteLine("Produção total do dia: {0}", data);
            Console.WriteLine("Frutas plantadas: {0}", frutas);
            Console.WriteLine("Verduras plantadas: {0}", verduras);
            Console.WriteLine("Legumes plantados: {0}", legumes);
        }

        public void plant_maça(int qtd)
        {
            int maça = qtd;
            Console.WriteLine("\nDas {0} frutas:\n{1} Maça(s) plantada(s).", frutas, maça);
        }
        public void plant_morango(int qtd)
        {
            int morango = qtd;
            Console.WriteLine("{0} Morango(s) plantado(s).",morango);
        }
        public void plant_uva(int qtd)
        {
            int uva= qtd;
            Console.WriteLine("{0} Uvas(s) plantada(s).", uva);
        }
        public void plant_alface(int qtd)
        {
            int alface= qtd;
            Console.WriteLine("\nDas {0} verduras:\n{1} Alface(s) plantada(s).",verduras,alface);
        }
        public void plant_rucula(int qtd)
        {
            int rucula = qtd;            
            Console.WriteLine("{0} Rucula(s) plantada(s).", rucula);
        }
        public void plant_brocolis(int qtd)
        {
            int brocolis = qtd;            
            Console.WriteLine("{0} Brócolis(s) plantado(s).", brocolis);
        }
        public void plant_ervilha(int qtd)
        {
            int ervilha = qtd;
            Console.WriteLine("\nDos {0} legumes plantados:\n{1} Ervilha(s) plantada(s).",legumes, ervilha);
        }
        public void plant_abobora(int qtd)
        {
            int abobora = qtd;
            Console.WriteLine("{0} Abóbora(s) plantada(s).", abobora);
        }
        public void plant_pimentao(int qtd)
        {
            int pimentao= qtd;
            Console.WriteLine("{0} Pimentão(ões) plantado(s).", pimentao);
        }
    }

    public class Colhe_Produção
    {
        private int col_f, col_v, col_l;
        private int est_basef;
        private int est_basev;
        private int est_basel;

        public Colhe_Produção(int col_f, int col_v, int col_l)
        {
            this.col_f = col_f;
            this.col_v = col_v;
            this.col_l = col_l;
        }   

        public  void setEst_f(int est_basef)
        {
            this.est_basef = est_basef;
        }
        public void setEst_v(int est_basev)
        {
            this.est_basev = est_basev;
        }

        public void setEst_l(int est_basel)
        {
            this.est_basel = est_basel;
        }
        
        public void estoq_Produção()
        {
            Console.WriteLine("Estoque de frutas: {0}", est_basef);
            Console.WriteLine("Estoque de verduras: {0}", est_basev);
            Console.WriteLine("Estoque de legumes: {0}", est_basel);
            Console.WriteLine();            
        }
        public void vender_estf(int qtd)
        {
            if(qtd == 0)
            {
                
            }
            else
            {
                est_basef -= qtd;
                if (est_basef >= 0)
                {
                    Console.WriteLine("Foram vendidas {0} caixas de frutas.", qtd);
                }
                else { Console.WriteLine("Venda negada, pois a quantidade de caixas de fruta no estoque é menor que o pedido"); }
            }            
        }

        public void vender_estv(int qtd)
        {
            if(qtd == 0)
            {

            }
            else
            {
                est_basev -= qtd;
                if (est_basev >= 0) { Console.WriteLine("Foram vendidas {0} caixas de verduras.", qtd); }
                else { Console.WriteLine("Venda negada, pois a quantidade de caixas de verduras no estoque é menor que o pedido"); }
            }
        }

        public void vender_estl(int qtd)
        {
            if (qtd == 0)
            {

            }
            else
            {
                est_basel -= qtd;
                if (est_basel >= 0) { Console.WriteLine("Foram vendidas {0} caixas de legumes.", qtd); }
                else { Console.WriteLine("Venda negada, pois a quantidade de caixas de legumes no estoque é menor que o pedido"); }
            }
        }

        public void colhe_ProdInfo()
        {
            Console.WriteLine("Total de frutas colhidas: {0}",col_f);
            Console.WriteLine("Total de verduras colhidas: {0}",col_v);
            Console.WriteLine("Total de legumes colhidas: {0}",col_l);
        }
        public void estoque_Colheita()
        {
            int est_f = est_basef;
            est_f += col_f;
            Console.WriteLine("Estoque fruta após colheita: {0}", est_f);
            int est_v = est_basev;
            est_v += col_v;
            Console.WriteLine("Estoque verduras após colheita: {0}", est_v);
            int est_l = est_basel;
            est_l += col_l;
            Console.WriteLine("Estoque legumes após colheita: {0}", est_l);
            Console.WriteLine();
        }
    }/*public class Relatorio
    {
        private int frutas;
        private int verduras;
        private int legumes;
        

        public Relatorio(int frutas, int verduras, int legumes)
        {
            this.frutas = frutas;
            this.verduras = verduras;
            this.legumes = legumes;
        }*/    
}

