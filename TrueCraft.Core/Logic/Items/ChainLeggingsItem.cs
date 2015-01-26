using System;
using TrueCraft.API.Logic;
using TrueCraft.API;

namespace TrueCraft.Core.Logic.Items
{
    public class ChainLeggingsItem : ArmourItem
    {
        public static readonly short ItemID = 0x130;

        public override short ID { get { return 0x130; } }

        public override ArmourMaterial Material { get { return ArmourMaterial.Chain; } }

        public override short BaseDurability { get { return 92; } }

        public override float BaseArmour { get { return 3; } }

        public override string DisplayName { get { return "Chain Leggings"; } }
    }
}