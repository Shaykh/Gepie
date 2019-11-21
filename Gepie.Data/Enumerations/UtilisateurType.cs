using System.ComponentModel;

namespace Gepie.Data.Enumerations
{
    public enum UtilisateurType : sbyte
    {
        [Description("Agent de la DE")]
        AgentDE = 1,
        [Description("Agent de la DAF")]
        AgentDAF = 2,
        [Description("Administrateur")]
        Administrateur = 9,
        [Description("SuperAdministrateur")]
        SuperAdministrateur = 10,
    }
}