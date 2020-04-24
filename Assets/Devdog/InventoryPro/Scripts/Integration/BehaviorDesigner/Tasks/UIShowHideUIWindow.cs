#if BEHAVIOR_DESIGNER

using UnityEngine;
using Devdog.General.UI;

namespace BehaviorDesigner.Runtime.Tasks.InventorySystem
{
    [TaskCategory("InventorySystem")]
    [TaskDescription("Show or hide a dialog")]
    [TaskIcon("Assets/Devdog/InventoryPro/Scripts/Integration/BehaviorDesigner/Editor/InventoryProIcon.png")]
    public class UIShowHideUIWindow : Action
    {
        public SharedBool show;
        public UIWindow window;

        public override TaskStatus OnUpdate()
        {
            if (window == null) {
                return TaskStatus.Failure;
            }
            if (show.Value)
                window.Show();
            else
                window.Hide();

            return TaskStatus.Success;
        }

        public override void OnReset()
        {
            show = false;
            window = null;
        }
    }
}

#endif