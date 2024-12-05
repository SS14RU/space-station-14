using Robust.Shared.Prototypes;

namespace Content.Shared.AWS.Skills;

[Prototype("skill")]
public sealed partial class SkillPrototype : IPrototype
{
    [IdDataField] public string ID { get; } = string.Empty;

    [ViewVariables(VVAccess.ReadWrite), DataField(required: true)]
    public ProtoId<SkillCategoryPrototype> Category = default!;

    [ViewVariables(VVAccess.ReadWrite), DataField(required: true)]
    public Dictionary<Enum, uint> Cost = new();   // Enum = SkillLevel

    [ViewVariables(VVAccess.ReadWrite), DataField]
    public List<Enum> Blocked = new();            // Enum = SkillLevel
}
