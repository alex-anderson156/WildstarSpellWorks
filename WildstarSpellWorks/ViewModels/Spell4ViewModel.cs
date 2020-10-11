using System;
using System.Collections.Generic;
using System.Text;
using WildstarSpellWorks.Data.Models;

namespace WildstarSpellWorks.ViewModels
{
    public class Spell4ViewModel: DataContextBase
    {
        private Spell4 _Spell;

        public Spell4 Spell { get => _Spell; }

        public string DisplayText
        {
            get { return $"{_Spell.ID} - {_Spell.description}"; }
        }

        public string WrappedInformation
        {
            get { return $@"ID:     {_Spell.ID}
Name:   {_Spell.description }
Tier:   {_Spell.tierIndex}

Duration:           {_Spell.spellDuration}
CastTime:           {_Spell.castTime}ms
Tooltip-CastTime:   {_Spell.tooltipCastTime}ms
           
Range:      {_Spell.targetMinRange} - {_Spell.targetMaxRange}
V-Range:    {_Spell.targetVerticalRange}

Channel Initial Delay:  {_Spell.channelInitialDelay}
Channel Max Time:       {_Spell.channelMaxTime}
Channel Pulse Time:     {_Spell.channelPulseTime}

            "; }
        }

        public Spell4ViewModel(Spell4 spell)
        {
            this._Spell = spell;
        }

    }
}
