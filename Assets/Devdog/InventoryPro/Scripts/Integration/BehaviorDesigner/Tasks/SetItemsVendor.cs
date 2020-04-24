#if BEHAVIOR_DESIGNER

using UnityEngine;
using Devdog.InventoryPro;

namespace BehaviorDesigner.Runtime.Tasks.InventorySystem
{
    [TaskCategory("InventorySystem")]
    [TaskDescription("Set items for a vendor, replaces the old items that were in the collection before it.")]
    [TaskIcon("Assets/Devdog/InventoryPro/Scripts/Integration/BehaviorDesigner/Editor/InventoryProIcon.png")]
    public class SetItemsVendor : Action
    {
        public InventoryItemBase[] items;
        public VendorTrigger vendor;

        public override TaskStatus OnUpdate()
        {
            if (vendor == null) {
                return TaskStatus.Failure;
            }

            vendor.items = items;
            return TaskStatus.Success;
        }

        public override void OnReset()
        {
            items = null;
            vendor = null;
        }
    }
}

#endif