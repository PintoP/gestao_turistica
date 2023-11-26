using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace gestao
{
    internal class Reservas
    {
        #region atributos
        private ArrayList reservas;
        #endregion

        #region contrutor
        public Reservas() 
        { 
            reservas= new ArrayList();
        }
        #endregion

        #region propriedades

        #endregion

        #region overrides

        #endregion
        
        #region metodos

        public bool mostra_resevas(DataGrid grid, )
        {

            return true;
        }

        //funções com ficheiros
        public bool Grava_reservas(string fn)
        {
            Stream s = File.Open(fn, FileMode.Create);
            //testar se ficheiro...
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, reservas);
            s.Close();
            return true;
        }

        public bool carrega_reservas(string fn)
        {
            Stream s = File.Open(fn, FileMode.Open);
            //testar se ficheiro...
            BinaryFormatter b = new BinaryFormatter();
            reservas = (ArrayList)b.Deserialize(s);
            s.Close();
            return true;
        }
        #endregion
    }
}
