﻿using SOD.Common.BepInEx.Configuration;

namespace SOD.RelationsPlus
{
    public interface IPluginBindings : IDecayModifierBindings, ISeenModifierBindings, IKnowModifierBindings, ILikeModifierBindings
    { }

    public interface IDecayModifierBindings
    {
        [Binding(60, "After how many in-game minutes is the decay check executed each time?", "Modifiers.Decay.DecayTimeMinutesCheck")]
        int DecayTimeMinutesCheck { get; set; }

        [Binding(-0.005f, "How much does 'Know' decay automatically? (cannot decay past certain stages of 'Know')", "Modifiers.Decay.DecayKnowAmount")]
        float DecayKnowAmount { get; set; }
    }

    public interface ISeenModifierBindings
    {
        [Binding(15, "How often a check is executed per citizen in in-game minutes if they see the player.", "Modifiers.Seen.SeenTimeMinutesCheck")]
        int SeenTimeMinutesCheck { get; set; }
    }

    public interface IKnowModifierBindings
    {
        [Binding(0.015f, "How much the \"Know\" property changes for the citizen and player when seen passing by on the street.", "Modifiers.Know.SeenOnStreetModifier")]
        float SeenOnStreetModifier { get; set; }

        [Binding(0.025f, "How much the \"Know\" property changes for the citizen and player when seen at their workplace.", "Modifiers.Know.SeenAtWorkplaceModifier")]
        float SeenAtWorkplaceModifier { get; set; }

        [Binding(0.045f, "How much the \"Know\" property changes for the citizen and player when seen inside their home.", "Modifiers.Know.SeenInHome")]
        float SeenInHomeModifier { get; set; }

        [Binding(0.035f, "How much the \"Know\" property changes for the citizen and player when seen inside their home's building/apartement.", "Modifiers.Know.SeenInHomeBuilding")]
        float SeenInHomeBuildingModifier { get; set; }
    }

    public interface ILikeModifierBindings
    {
        [Binding(-0.05f, "How much the \"Like\" property changes for the citizen and player when seen trespassing.", "Modifiers.Like.SeenTrespassingModifier")]
        float SeenTrespassingModifier { get; set; }
    }
}
