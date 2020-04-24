#if BEHAVIOR_DESIGNER

using UnityEngine;
using Devdog.InventoryPro;

namespace BehaviorDesigner.Runtime.Tasks.InventorySystem
{
    [TaskCategory("InventorySystem")]
    [TaskDescription("Use a given item.")]
    [TaskIcon("Assets/Devdog/InventoryPro/Scripts/Integration/BehaviorDesigner/Editor/InventoryProIcon.png")]
    public class UseItem : Action
    {
        public InventoryItemBase item;

        public override TaskStatus OnUpdate()
        {
            if (item == null) {
                return TaskStatus.Failure;
            }
            item.Use();
            return TaskStatus.Success;
        }
        
        public override void OnReset()
        {
            item = null;
        }
    }
}

#endif