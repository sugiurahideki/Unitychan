#if BEHAVIOR_DESIGNER

using UnityEngine;
using Devdog.InventoryPro;

namespace BehaviorDesigner.Runtime.Tasks.InventorySystem
{
    [TaskCategory("InventorySystem")]
    [TaskDescription("Use a given item.")]
    [TaskIcon("Assets/Devdog/InventoryPro/Scripts/Integration/BehaviorDesigner/Editor/InventoryProIcon.png")]
    public class UseThisItem : Action
    {
        public override TaskStatus OnUpdate()
        {
            this.Owner.SendMessage("Use", SendMessageOptions.RequireReceiver);
            return TaskStatus.Success;
        }
    }
}

#endif