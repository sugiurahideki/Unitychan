#if BEHAVIOR_DESIGNER

using UnityEngine;
using Devdog.InventoryPro;

namespace BehaviorDesigner.Runtime.Tasks.InventorySystem
{
    [TaskCategory("InventorySystem")]
    [TaskDescription("Use a given item.")]
    [TaskIcon("Assets/Devdog/InventoryPro/Scripts/Integration/BehaviorDesigner/Editor/InventoryProIcon.png")]
    public class OpenCloseTreasureChest : Action
    {
        public LootableObject chest;
        public SharedBool open;

        public override TaskStatus OnUpdate()
        {
            if (chest == null) {
                return TaskStatus.Failure;
            }

            if (open.Value)
                chest.trigger.Use();
            else
                chest.trigger.UnUse();

            return TaskStatus.Success;
        }
        
        public override void OnReset()
        {
            chest = null;
            open = false;
        }
    }
}

#endif