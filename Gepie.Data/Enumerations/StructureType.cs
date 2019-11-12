using System.ComponentModel;

namespace Gepie.Data.Enumerations
{
    [DisplayName("Type de Structure")]
    public enum StructureType : sbyte
    {
        [Description("Service")]
        Service = 1,
        [Description("Direction")]
        Direction = 2,
        [Description("Cabinet ministériel")]
        Ministere = 3,
        [Description("Institution")]
        Institution = 4,
        // Todo Verify enumeration
    }
}