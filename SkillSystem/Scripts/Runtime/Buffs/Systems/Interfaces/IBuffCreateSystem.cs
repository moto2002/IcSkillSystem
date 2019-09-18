//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年09月14日-19:03
//CabinIcarus.SkillSystem.Runtime

using Cabin_Icarus.SkillSystem.Scripts.Runtime.Buffs.Entitys;
using CabinIcarus.SkillSystem.Runtime.Buffs.Components;
using CabinIcarus.SkillSystem.Scripts.Runtime.Buffs.Com;

namespace CabinIcarus.SkillSystem.Runtime.Buffs.Systems.Interfaces
{
    /// <summary>
    /// buff 创建系统
    /// </summary>
    public interface IBuffCreateSystem:IBuffSystem,IBuffFilter
    {
        void Create(IEntity entity,IBuffDataComponent buff);
    }
}