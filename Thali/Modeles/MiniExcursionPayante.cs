using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thali.Modeles
{
    public class MiniExcursionPayante : MiniExcursion
    {
        #region Attributs
        private int _tarif;
        #endregion
        #region Constructeurs
        public MiniExcursionPayante(int numMiniExcursion, string libelleMiniExcursion, int nombrePlaces, int tarif) : base(numMiniExcursion, libelleMiniExcursion, nombrePlaces)
        {
            _tarif = tarif;
        }
        #endregion
        #region Getters/Setters
        public int GetTarif()
        {
            return _tarif;
        }
        public void SetTarif(int param)
        {
            _tarif = param;
        }
        #endregion
    }
}
