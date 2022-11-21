using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Thali.Modeles
{
    public class MiniExcursionPlanifiee
    {
        #region attributs 
        private DateTime _heureDepart;
        private int _nombreInscrits;
        private MiniExcursion _laMiniExcursion;
        public static ObservableCollection<MiniExcursionPlanifiee> CollClasse = new ObservableCollection<MiniExcursionPlanifiee>();
        #endregion

        #region constructeurs
        public MiniExcursionPlanifiee(DateTime heureDepart, int nombreInscrits, MiniExcursion laMiniExcursion)
        {
            _heureDepart = heureDepart;
            _nombreInscrits = nombreInscrits;
            _laMiniExcursion = laMiniExcursion;
            CollClasse.Add(this);
        }
        #endregion

        #region Getters-Setters
        public DateTime GetHeureDepart()
        {
            return _heureDepart;
        }
        public int GetNombreInscrits()
        {
            return _nombreInscrits;
        }
        public MiniExcursion GetLaMiniExcursion()
        {
            return _laMiniExcursion;
        }
        public void SetNombreInscrits(int param)
        {
            _nombreInscrits = param;
        }
        public void SetLaMiniExcursion(MiniExcursion param)
        {
            _laMiniExcursion = param;
        }
        #endregion
        #region Methodes
        public bool estComplete()
        {
            bool resultat = false;

            //if(this._nombreInscrits == this.GetLaMiniExcursion().GetNombrePlaces())
            if (this.GetNombreInscrits().Equals(this.GetLaMiniExcursion().GetNombrePlaces()))
            {
                return true;
            }

            return resultat;
        }
        #endregion
    }
}
