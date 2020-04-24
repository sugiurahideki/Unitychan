#if BEHAVIOR_DESIGNER

using UnityEngine;
using Devdog.InventoryPro;

namespace BehaviorDesigner.Runtime.Tasks.InventorySystem
{
    [TaskCategory("InventorySystem")]
    [TaskDescription("Generate a bunch of items that can be stored in a collection.")]
    [TaskIcon("Assets/Devdog/InventoryPro/Scripts/Integration/BehaviorDesigner/Editor/InventoryProIcon.png")]
    public class GenerateItems : Action
    {
        public SharedInt minAmount, maxAmount;
        
        public InventoryItemBase[] items;

        protected IItemGenerator generator;

        public override void OnAwake()
        {
            base.OnAwake();

            generator = new BasicItemGenerator();
        }


        public override TaskStatus OnUpdate()
        {
            generator.SetItems(ItemManager.database.items);
            generator.Generate(minAmount.Value, maxAmount.Value);

            return TaskStatus.Success;
        }

        public override void OnReset()
        {
            minAmount = 0;
            maxAmount = 0;
            items = null;
        }
    }
}

#endif