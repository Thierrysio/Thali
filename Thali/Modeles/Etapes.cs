using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thali.Modeles
{
    public class Etapes
    {
        #region attributs 
        private int _numEtape;
        private string _description;
        private DateTime _dureePrevue;
        public static ObservableCollection<Etapes> CollClasse = new ObservableCollection<Etapes>();
        #endregion

        #region constructeurs
        public Etapes(int numEtape, string description, DateTime dureePrevue)
        {
            _numEtape = numEtape;
            _description = description;
            _dureePrevue = dureePrevue;
            CollClasse.Add(this);
        }
        #endregion

        #region Getters-Setters
        public int GetNumEtape()
        {
            return _numEtape;
        }
        public string GetDescription()
        {
            return _description;
        }
        public DateTime GetDureePrevue()
        {
            return _dureePrevue;
        }
        public void SetDescription(string param)
        {
            _description = param;
        }
        public void SetDureePrevue(DateTime param)
        {
            _dureePrevue = param;
        }
        #endregion
        #region Methodes
        #endregion
    }
}
