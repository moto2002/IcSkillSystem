using System;
using UnityEngine;
using XNode;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/Project/UseSkillNodeNodeSingleFrame Value")]
    public partial class UseSkillNodeNodeSingleFrameValueNode:ValueNode
    {
        [SerializeField]
        private CabinIcarus.IcSkillSystem.Runtime.xNode_NPBehave_Node.SkillSystems.UseSkillNodeNodeSingleFrame _value;

        public override Type ValueType { get; } = typeof(CabinIcarus.IcSkillSystem.Runtime.xNode_NPBehave_Node.SkillSystems.UseSkillNodeNodeSingleFrame);
        
        protected override object GetOutValue()
        {
            return _value;
        }
    }
}