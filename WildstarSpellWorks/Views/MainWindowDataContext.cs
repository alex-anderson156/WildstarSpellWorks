using CsvHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Input;
using WildstarSpellWorks.Data.Models;
using WildstarSpellWorks.Data.Parsers;
using WildstarSpellWorks.ViewModels; 

namespace WildstarSpellWorks
{
    public class MainWindowDataContext: DataContextBase
    {
        #region Properties

        private SpellSearchDataContext _SpellSearchDataContext;  
        public SpellSearchDataContext SpellSearchDataContext
        {
            get { return _SpellSearchDataContext; }
            set { _SpellSearchDataContext = value;
                this.NotifyPropertyChanged();
            }
        }

        private SpellDatabaseDataContext _SpellDatabaseDataContext = new SpellDatabaseDataContext();
        public SpellDatabaseDataContext SpellDatabaseDataContext
        {
            get { return _SpellDatabaseDataContext; }
            set
            {
                _SpellDatabaseDataContext = value;
                this.NotifyPropertyChanged();
            }
        }

        #endregion

        #region Commands    

        private ICommand _ReadDataCommand; 
        public ICommand ReadDataCommand
        {
            get { return _ReadDataCommand; }
            set { _ReadDataCommand = value; }
        }

        private ICommand _CloseApplicationCommand; 
        public ICommand CloseApplicationCommand
        {
            get { return _CloseApplicationCommand; }
            set { _CloseApplicationCommand = value; }
        }
         
        #endregion
         
        public MainWindowDataContext()
        {
            this._ReadDataCommand = new Command(this.ReadData);
            this._CloseApplicationCommand = new Command(this.CloseApplication);
        }

        #region Public Methods

        #endregion

        #region Protected Methods

        #endregion

        #region Private Methods

        private void ReadData()
        {
            const string folderPath = @"H:\Projects\Games\NexusForever\raw\tbl";

            // READ FROM Spell4.csv
            using(CSVParser<Spell4> s4p = new CSVParser<Spell4>(folderPath + @"\spell4.csv"))
            {
                this.SpellDatabaseDataContext.SetData(s4p.Parse());
                this.SpellSearchDataContext = new SpellSearchDataContext(SpellDatabaseDataContext);
            }

            // Create a new SpellDatabaseDataContext(data);

            // Create the SearchDataContext(SpellDatabaseDataContext)
        }
         
        private void CloseApplication()
        {
            Application.Current.Shutdown();
        }

        #endregion
    }
}
