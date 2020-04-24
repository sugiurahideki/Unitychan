#if BEHAVIOR_DESIGNER

using UnityEngine;
using Devdog.InventoryPro;

namespace BehaviorDesigner.Runtime.Tasks.InventorySystem
{
    [TaskCategory("InventorySystem")]
    [TaskDescription("Set items in a collection, replaces the old items that were in the collection before it.")]
    [TaskIcon("Assets/Devdog/InventoryPro/Scripts/Integration/BehaviorDesigner/Editor/InventoryProIcon.png")]
    public class SetItemsCollection : Action
    {
        public InventoryItemBase[] items;
        public ItemCollectionBase collection;

        public override TaskStatus OnUpdate()
        {
            if (collection == null) {
                return TaskStatus.Failure;
            }
            collection.SetItems(items, true);

            return TaskStatus.Success;
        }

        public override void OnReset()
        {
            items = null;
            collection = null;
        }
    }
}

#endif