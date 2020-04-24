#if BEHAVIOR_DESIGNER

using UnityEngine;
using Devdog.InventoryPro;

namespace BehaviorDesigner.Runtime.Tasks.InventorySystem
{
    [TaskCategory("InventorySystem")]
    [TaskDescription("Show a notice message")]
    [TaskIcon("Assets/Devdog/InventoryPro/Scripts/Integration/BehaviorDesigner/Editor/InventoryProIcon.png")]
    public class UIShowNoticeMessage : Action
    {
        public SharedString title;
        public SharedString message;
        public SharedColor color;
        public NoticeDuration duration = NoticeDuration.Medium;
        public InventoryItemBase item;

        public override TaskStatus OnUpdate()
        {
            var m = new InventoryNoticeMessage(title.Value, message.Value, duration, color.Value);

            if (item != null)
                m.Show(item.name, item.description);
            else
                m.Show();

            return TaskStatus.Success;
        }

        public override void OnReset()
        {
            title = "";
            message = "";
            color = Color.black;
            duration = NoticeDuration.Medium;
            item = null;
        }
    }
}

#endif