using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows.Markup;
using WildstarSpellWorks.Data.Models;

namespace WildstarSpellWorks.ViewModels
{
    public interface IApplyFiltersAndSearch
    {
        void ApplyFilters(int? id, string descriptionToFilter);

        void ClearFilters();
    }

    public class SpellDatabaseDataContext : DataContextBase, IApplyFiltersAndSearch
    {
        private Dictionary<int, Spell4> _SpellDictionary;

        private ObservableCollection<Spell4ViewModel> _SpellsForCurrentFilter; 
        /// <summary>
        /// 
        /// </summary>
        public ObservableCollection<Spell4ViewModel> SpellsForCurrentFilter
        {
            get { return _SpellsForCurrentFilter; }
            set { 
                _SpellsForCurrentFilter = value;
                NotifyPropertyChanged();
            }
        }

        private Spell4ViewModel _SelectedSpell; 
        /// <summary>
        /// 
        /// </summary>
        public Spell4ViewModel SelectedSpell
        {
            get { return _SelectedSpell; }
            set { 
                _SelectedSpell = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public SpellDatabaseDataContext()
        {
            
        }


        public void SetData(List<Spell4> data)
        {
            _SpellDictionary = new Dictionary<int, Spell4>();
            foreach (Spell4 datum in data)
            {
                _SpellDictionary.Add(datum.ID, datum);
            }

            ClearFilters();
        }


        public void ClearFilters()
        {
            SpellsForCurrentFilter = new ObservableCollection<Spell4ViewModel>(_SpellDictionary.Values.Select(s => new Spell4ViewModel(s)));
        }

        public void ApplyFilters(int? id, string descriptionToFilter)
        { 
            if (id != null && id > 0)
            {               
                _SpellDictionary.TryGetValue(id.Value, out Spell4 spell);

                if (spell != null) {
                    this.SpellsForCurrentFilter = new ObservableCollection<Spell4ViewModel>(new Spell4ViewModel[] { new Spell4ViewModel(spell) });
                    this.SelectedSpell = this.SpellsForCurrentFilter.First();
                }
            }
            else
            {
                this.ClearFilters();
            }

            if (!String.IsNullOrEmpty(descriptionToFilter))
            {
                this.SpellsForCurrentFilter = new ObservableCollection<Spell4ViewModel>(
                    this._SpellsForCurrentFilter.Where(s =>s.Spell.description.Contains(descriptionToFilter))
                );
            }
        }
    }
}
