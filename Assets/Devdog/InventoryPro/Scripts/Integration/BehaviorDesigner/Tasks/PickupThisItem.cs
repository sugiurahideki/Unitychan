#if BEHAVIOR_DESIGNER

using UnityEngine;
using Devdog.InventoryPro;

namespace BehaviorDesigner.Runtime.Tasks.InventorySystem
{
    [TaskCategory("InventorySystem")]
    [TaskDescription("Loots this item.")]
    [TaskIcon("Assets/Devdog/InventoryPro/Scripts/Integration/BehaviorDesigner/Editor/InventoryProIcon.png")]
    public class PickupThisItem : Action
    {
        protected InventoryItemBase item;

        public override TaskStatus OnUpdate()
        {
            item.PickupItem();
            return TaskStatus.Success;
        }

        public override void OnAwake()
        {
            base.OnAwake();

            item = this.Owner.GetComponent<InventoryItemBase>();
        }
    }
}

#endif