using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows.Markup;

namespace WildstarSpellWorks.ViewModels
{
    public class SpellSearchDataContext : DataContextBase
    {
        private IApplyFiltersAndSearch _IFilterContext;

        private int _IDToFilter;
        /// <summary>
        /// Gets or sets the Identifier of the Spell to Filter.
        /// </summary>
        public int IDToFilter
        {
            get { return _IDToFilter; }
            set {
                _IDToFilter = value;
                NotifyPropertyChanged();
            }
        }

        private string _DescriptionToFilter;
        /// <summary>
        /// Gets or sets the 
        /// </summary>
        public string DescriptionToFilter
        {
            get { return _DescriptionToFilter; }
            set { _DescriptionToFilter = value; }
        }
         
        private ICommand _ApplyFiltersCommand;
        /// <summary>
        /// Gets or sets the Apply Filters Command
        /// </summary>
        public ICommand ApplyFiltersCommand
        {
            get { return _ApplyFiltersCommand; }
            set { _ApplyFiltersCommand = value; }
        }

        private ICommand _ClearFiltersCommand;
        /// <summary>
        /// Gets or sets the Clear Filters Command
        /// </summary>
        public ICommand ClearFiltersCommand
        {
            get { return _ClearFiltersCommand; }
            set { _ClearFiltersCommand = value; }
        }


        public SpellSearchDataContext(IApplyFiltersAndSearch filterContext)
        {
            this._IFilterContext = filterContext;

            this.ApplyFiltersCommand = new Command(this.ApplyFilters);
            this.ClearFiltersCommand = new Command(this.ClearFilters);
        }

         

        private void ApplyFilters()
        {
            _IFilterContext.ApplyFilters(this._IDToFilter, this._DescriptionToFilter);
        }

        private void ClearFilters()
        {
            this.IDToFilter = 0;
            this.DescriptionToFilter = string.Empty;
            _IFilterContext.ClearFilters();
        }
    }
}
