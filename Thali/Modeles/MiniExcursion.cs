using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thali.Modeles
{
    public class MiniExcursion
    {
        #region attributs 
        private int _numMiniExcursion;
        private string _libelleMiniExcursion;
        private int _nombrePlaces;
        private List<Etapes> _lesEtapes;
        public static ObservableCollection<MiniExcursion> CollClasse = new ObservableCollection<MiniExcursion>();
        #endregion

        #region constructeurs
        public MiniExcursion(int numMiniExcursion, string libelleMiniExcursion, int nombrePlaces)
        {
            _numMiniExcursion = numMiniExcursion;
            _libelleMiniExcursion = libelleMiniExcursion;
            _nombrePlaces = nombrePlaces;
            _lesEtapes = new List<Etapes>();
            CollClasse.Add(this);
        }
        #endregion

        #region Getters-Setters
        public int GetNumMiniExcursion()
        {
            return _numMiniExcursion;
        }
        public string GetLibelleMiniExcursion()
        {
            return _libelleMiniExcursion;
        }
        public int GetNombrePlaces()
        {
            return _nombrePlaces;
        }
        public List<Etapes> GetLesEtapes()
        {
            return _lesEtapes;
        }
        public void SetLibelleMiniExcursion(string param)
        {
            _libelleMiniExcursion = param;
        }
        public void SetNombrePlaces(int param)
        {
            _nombrePlaces = param;
        }
        public void SetLesEtapes(List<Etapes> param)
        {
            _lesEtapes = param;
        }
        #endregion
        #region Methodes
        public bool ajouteEtape(int unNumeroEtape,string uneDescription,DateTime uneDureePrevue)
        {
            bool resultat = false;
            foreach(Etapes monEtape in this.GetLesEtapes()) 
            { 
                if(monEtape.GetNumEtape().Equals(unNumeroEtape))
                {
                    return resultat;
                }
            }
            // Je recupere ma collection d'objets Etapes
            // Je cree une nouvelle etape
            // je l'ajoute à la collection
            this.GetLesEtapes().Add(new Etapes(unNumeroEtape, uneDescription, uneDureePrevue));
            return true;
          
        }
        public double donneDureePrevue()
        {
            double resultat = 0;

            foreach(Etapes monEtape in this.GetLesEtapes()) 
            {
                TimeSpan t = monEtape.GetDureePrevue().TimeOfDay;
                resultat = t.TotalMinutes;
            
            }

            return resultat;
        }
        #endregion
    }
}
