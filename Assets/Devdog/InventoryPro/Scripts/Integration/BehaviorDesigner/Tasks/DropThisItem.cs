#if BEHAVIOR_DESIGNER

using Devdog.General;
using UnityEngine;
using Devdog.InventoryPro;

namespace BehaviorDesigner.Runtime.Tasks.InventorySystem
{
    [TaskCategory(InventoryPro.ProductName)]
    [TaskDescription("Use a given item.")]
    [TaskIcon("Assets/Devdog/InventoryPro/Scripts/Integration/BehaviorDesigner/Editor/InventoryProIcon.png")]
    public class DropThisItem : Action
    {
        protected InventoryItemBase item;

        public override void OnAwake()
        {
            base.OnAwake();

            item = this.Owner.GetComponent<InventoryItemBase>();
        }

        public override TaskStatus OnUpdate()
        {
            item.itemCollection[item.index].TriggerDrop();
            return TaskStatus.Success;
        }
    }
}

#endif