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

        private ICommand _ApplyFiltersCommand;
        /// <summary>
        /// Gets or sets the 
        /// </summary>
        public ICommand ApplyFiltersCommand
        {
            get { return _ApplyFiltersCommand; }
            set { _ApplyFiltersCommand = value; }
        }


        public SpellSearchDataContext(IApplyFiltersAndSearch filterContext)
        {
            this._IFilterContext = filterContext;

            this.ApplyFiltersCommand = new Command(this.ApplyFilters);
        }

         

        private void ApplyFilters()
        {
            _IFilterContext.ApplyFilters(this._IDToFilter);
        }
    }
}
