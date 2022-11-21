using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thali.Modeles
{
    public class PlanningJournee
    {
        #region attributs 
        private List<MiniExcursionPlanifiee> _lesMiniExcursionPlanifiee;
        private DateTime _date;
        public static ObservableCollection<PlanningJournee> CollClasse = new ObservableCollection<PlanningJournee>();
        #endregion

        #region constructeurs
        public PlanningJournee(DateTime date)
        {
            _lesMiniExcursionPlanifiee = new List<MiniExcursionPlanifiee>();
            _date = date;
            CollClasse.Add(this);
        }
        #endregion

        #region Getters-Setters
        public List<MiniExcursionPlanifiee> GetLesMiniExcursionPlanifiee()
        {
            return _lesMiniExcursionPlanifiee;
        }
        public DateTime GetDate()
        {
            return _date;
        }
        public void SetDate(DateTime param)
        {
            _date = param;
        }
        #endregion
        #region Methodes
        #endregion
    }
}