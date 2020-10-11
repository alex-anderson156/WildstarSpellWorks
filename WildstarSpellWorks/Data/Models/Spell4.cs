using System;
using System.Collections.Generic;
using System.Text;
using WildstarSpellWorks.Data.Parsers;

namespace WildstarSpellWorks.Data.Models
{
    public class Spell4
    {
        public int ID { get; set; }
        public string description { get; set; }
        public int spell4BaseIdBaseSpell { get; set; }
        public int tierIndex { get; set; }
        public int ravelInstanceId { get; set; }
        public int castTime { get; set; }
        public long spellDuration { get; set; }
        public int spellCoolDown { get; set; }
        public decimal targetMinRange { get; set; }
        public decimal targetMaxRange { get; set; }
        public int targetVerticalRange { get; set; }
        public int casterInnateRequirement0 { get; set; }
        public int casterInnateRequirement1 { get; set; }
        public int casterInnateRequirementValue0 { get; set; }
        public int casterInnateRequirementValue1 { get; set; }
        public int casterInnateRequirementEval0 { get; set; }
        public int casterInnateRequirementEval1 { get; set; }
        public int targetBeginInnateRequirement { get; set; }
        public int targetBeginInnateRequirementValue { get; set; }
        public int targetBeginInnateRequirementEval { get; set; }
        public int innateCostType0 { get; set; }
        public int innateCostType1 { get; set; }
        public int innateCost0 { get; set; }
        public int innateCost1 { get; set; }
        public int innateCostEMMId0 { get; set; }
        public int innateCostEMMId1 { get; set; }
        public int channelInitialDelay { get; set; }
        public long channelMaxTime { get; set; }
        public int channelPulseTime { get; set; }
        public int localizedTextIdActionBarTooltip { get; set; }
        public int stackPriority { get; set; }
        public int spell4VisualGroupId { get; set; }
        public int spell4IdCastEvent00 { get; set; }
        public int spell4IdCastEvent01 { get; set; }
        public int spell4IdCastEvent02 { get; set; }
        public int spell4IdCastEvent03 { get; set; }
        public int spell4ReagentId00 { get; set; }
        public int spell4ReagentId01 { get; set; }
        public int spell4ReagentId02 { get; set; }
        public int spell4RunnerId00 { get; set; }
        public int spell4RunnerId01 { get; set; }
        public int runnerTargetTypeEnum00 { get; set; }
        public int runnerTargetTypeEnum01 { get; set; }
        public int prerequisiteIdRunner00 { get; set; }
        public int prerequisiteIdRunner01 { get; set; }
        public int abilityChargeCount { get; set; }
        public int abilityRechargeTime { get; set; }
        public int abilityRechargeCount { get; set; }
        public int thresholdTime { get; set; }
        public int abilityPointCost { get; set; }
        public int trainingCost { get; set; }
        public int spellChannelFlags { get; set; }
        public int ignoreFollowTimeMs { get; set; }
        public int spell4IdMechanicAlternateSpell { get; set; }
        public int spell4IdPetSwitch { get; set; }
        public int spell4TagId00 { get; set; }
        public int spell4TagId01 { get; set; }
        public int spell4TagId02 { get; set; }
        public int spell4TagId03 { get; set; }
        public int spell4TagId04 { get; set; }
        public int localizedTextIdCasterIconSpellText { get; set; }
        public int localizedTextIdPrimaryTargetIconSpellText { get; set; }
        public int localizedTextIdSecondaryTargetIconSpellText { get; set; }
        public int localizedTextIdLASTier { get; set; }
        public int localizedTextIdTooltipCastInfo { get; set; }
        public int localizedTextIdTooltipCostInfo { get; set; }
        public int tooltipCastTime { get; set; }
        public int spell4AoeTargetConstraintsId { get; set; }
        public int spell4ConditionsIdCaster { get; set; }
        public int spell4ConditionsIdTarget { get; set; }
        public int spell4CCConditionsIdCaster { get; set; }
        public int spell4CCConditionsIdTarget { get; set; }
        public int spellCoolDownIdGlobal { get; set; }
        public int spellCoolDownId00 { get; set; }
        public int spellCoolDownId01 { get; set; }
        public int spellCoolDownId02 { get; set; }
        public int spell4GroupListId { get; set; }
        public int missileSpeed { get; set; }
        public int minMissileSpeed { get; set; }
        public int spell4ClientMissileId00 { get; set; }
        public int spell4ClientMissileId01 { get; set; }
        public int spell4ClientMissileId02 { get; set; }
        public int spell4ClientMissileId03 { get; set; }
        public int spell4ClientMissileId04 { get; set; }
        public int spell4ClientMissileId05 { get; set; }
        public int globalCooldownEnum { get; set; }
        public long propertyFlags { get; set; }
        public int uiFlags { get; set; }
        public int spell4StackGroupId { get; set; }
        public int prerequisiteIdCasterCast { get; set; }
        public int prerequisiteIdTargetCast { get; set; }
        public int prerequisiteIdCasterPersistence { get; set; }
        public int prerequisiteIdTargetPersistence { get; set; }
        public int castEventConditionEnum00 { get; set; }
        public int castEventConditionEnum01 { get; set; }
        public int castEventConditionEnum02 { get; set; }
        public int castEventConditionEnum03 { get; set; }
        public int castEventTargetFlags00 { get; set; }
        public int castEventTargetFlags01 { get; set; }
        public int castEventTargetFlags02 { get; set; }
        public int castEventTargetFlags03 { get; set; }
        public int spellCastStealthChange { get; set; }
        public int prerequisiteIdAoeTarget { get; set; }
        public int prerequisiteIdAoePreferredTarget { get; set; }
    } 
}
