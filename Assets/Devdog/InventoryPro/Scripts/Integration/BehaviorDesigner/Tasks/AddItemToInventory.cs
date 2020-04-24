#if BEHAVIOR_DESIGNER

using UnityEngine;
using Devdog.InventoryPro;

namespace BehaviorDesigner.Runtime.Tasks.InventorySystem
{
    [TaskCategory("InventorySystem")]
    [TaskDescription("Adds an item in the inventory, and if you have multiple inventories it will select the best inventory for the item.")]
    [TaskIcon("Assets/Devdog/InventoryPro/Scripts/Integration/BehaviorDesigner/Editor/InventoryProIcon.png")]
    public class AddItemToInventory : Action
    {
        public InventoryItemBase item;
        public SharedInt amount = 1;

        public override TaskStatus OnUpdate()
        {
            if (item == null) {
                return TaskStatus.Failure;
            }
            item.currentStackSize = (uint)amount.Value;
            InventoryManager.AddItem(item);
            return TaskStatus.Success;
        }

        public override void OnReset()
        {
            item = null;
            amount = 1;
        }
    }
}

#endif