#if BEHAVIOR_DESIGNER

using UnityEngine;
using Devdog.InventoryPro;

namespace BehaviorDesigner.Runtime.Tasks.InventorySystem
{
    [TaskCategory("InventorySystem")]
    [TaskDescription("Adds all of the items from a treasure chest.")]
    [TaskIcon("Assets/Devdog/InventoryPro/Scripts/Integration/BehaviorDesigner/Editor/InventoryProIcon.png")]
    public class AddItemsFromThreasureChest : Action
    {
        public LootableObject chest;

        public override TaskStatus OnUpdate()
        {
            if (chest == null) {
                return TaskStatus.Failure;
            }

            for (int i = chest.items.Length - 1; i > -1; --i) {
                InventoryManager.AddItem(chest.items[i]);
                chest.items[i] = null;
            }

            return TaskStatus.Success;
        }
        
        public override void OnReset()
        {
            chest = null;
        }
    }
}

#endif