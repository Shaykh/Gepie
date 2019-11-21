using System.ComponentModel;

namespace Gepie.Data.Enumerations
{
    public enum StructureType : sbyte
    {
        [Description("Institution")]
        Institution = 1,
        [Description("Cabinet ministériel")]
        Ministere = 2,
        [Description("Direction")]
        Direction = 3,
        [Description("Service")]
        Service = 4,
    }
}