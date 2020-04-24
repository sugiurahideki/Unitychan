#if BEHAVIOR_DESIGNER

using UnityEngine;
using Devdog.InventoryPro;

namespace BehaviorDesigner.Runtime.Tasks.InventorySystem
{
    [TaskCategory("InventorySystem")]
    [TaskDescription("Sells all of the items to the vender.")]
    [TaskIcon("Assets/Devdog/InventoryPro/Scripts/Integration/BehaviorDesigner/Editor/InventoryProIcon.png")]
    public class SellItemsToVender : Action
    {
        public VendorTrigger vendor;

        public override TaskStatus OnUpdate()
        {
            if (vendor == null) {
                return TaskStatus.Failure;
            }
            var collections = InventoryManager.GetLootToCollections();
            for (int i = 0; i < collections.Length; ++i) {
                var items = collections[i].items;
                for (int j = items.Length - 1; j > -1; --j) {
                    if (items[j].item == null) {
                        continue;
                    }
                    vendor.SellItemToVendorNow(items[j].item, items[j].item.currentStackSize);
                }
            }
            return TaskStatus.Success;
        }

        public override void OnReset()
        {
            vendor = null;
        }
    }
}

#endif