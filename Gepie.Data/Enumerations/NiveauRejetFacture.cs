using System.ComponentModel;

namespace Gepie.Data.Enumerations
{
    public enum NiveauRejetFacture : sbyte
    {
        [Description("Contrôleur Budgétaire")]
        ControleurBudgetaire = 1,
        [Description("Agent Comptable")]
        AgentComptable = 2
    }
}