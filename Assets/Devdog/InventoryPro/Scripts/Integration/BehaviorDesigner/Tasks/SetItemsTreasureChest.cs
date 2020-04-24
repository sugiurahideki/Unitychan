#if BEHAVIOR_DESIGNER

using UnityEngine;
using Devdog.InventoryPro;

namespace BehaviorDesigner.Runtime.Tasks.InventorySystem
{
    [TaskCategory("InventorySystem")]
    [TaskDescription("Set items on a treasure chest, replaces the old items that were in the collection before it.")]
    [TaskIcon("Assets/Devdog/InventoryPro/Scripts/Integration/BehaviorDesigner/Editor/InventoryProIcon.png")]
    public class SetItemsTreasureChest : Action
    {
        public InventoryItemBase[] items;
        public LootableObject chest;

        public override TaskStatus OnUpdate()
        {
            if (chest == null) {
                return TaskStatus.Failure;
            }
            chest.items = items;
            return TaskStatus.Success;
        }

        public override void OnReset()
        {
            items = null;
            chest = null;
        }
    }
}

#endif