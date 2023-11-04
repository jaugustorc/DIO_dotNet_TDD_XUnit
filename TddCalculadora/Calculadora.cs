using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCalculadora
{
    public class Calculadora
    {
        /// <summary>
        /// Historico das operações
        /// </summary>
        private List<string> _historico;
        /// <summary>
        /// data da criação da calculadora
        /// </summary>
        private string _data;
        
        /// <summary>
        /// Construtror
        /// </summary>
        public Calculadora(String data)
        {
            _historico = new List<string>();
            this._data = data;
        }
        
        //public
        #region public
        /// <summary>
        /// Metodo para somar
        /// </summary>
        /// <param name="num1">valor 1</param>
        /// <param name="num2">valor 2</param>
        /// <returns>valor da soma</returns>
        public int Somar(int num1,int num2)
        {
            int res = num1 + num2;
            _historico.Insert(0, "Res: " + res + this._data);
            return res;
        }
        /// <summary>
        /// Metodo para subtração
        /// </summary>
        /// <param name="num1">valor 1</param>
        /// <param name="num2">valor 2</param>
        /// <returns>valor da subtração</returns>
        public int Subtrair(int num1, int num2)
        {
            int res = num1 - num2;
            _historico.Insert(0, "Res: " + res + this._data);
            return res;
        }
        /// <summary>
        /// Metodo para multiplicar
        /// </summary>
        /// <param name="num1">valor 1</param>
        /// <param name="num2">valor 2</param>
        /// <returns>valor da multiplicação</returns>
        public int Multiplicar(int num1, int num2)
        {
            int res = num1 * num2;
            _historico.Insert(0, "Res: " + res +this._data);
            return res;
        }
        /// <summary>
        /// Metodo para dividir
        /// </summary>
        /// <param name="num1">valor 1</param>
        /// <param name="num2">valor 2</param>
        /// <returns>valor da divição</returns>
        public int Dividir(int num1, int num2)
        {
            int res = num1/ num2;
            _historico.Insert(0, "Res: " + res + this._data);
            return res;
        }
        /// <summary>
        /// Retorna o historico
        /// </summary>
        /// <returns></returns>
        public List<string> Historico()
        {
            //limpa a lista, deixando somente 3 operações
            _historico.RemoveRange(3, _historico.Count-3);
            
            return _historico;
        }
        #endregion

        

    }
}
