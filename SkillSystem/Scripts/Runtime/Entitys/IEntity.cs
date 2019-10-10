//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年09月15日-19:04
//CabinIcarus.SkillSystem.Runtime

using System;

namespace CabinIcarus.IcSkillSystem.Runtime.Buffs.Entitys
{
    public interface IEntity
    {
    }
    
    public struct BuffEntity:IEquatable<BuffEntity>
    {
        public readonly int ID;

        public BuffEntity(int id)
        {
            ID = id;
        }
#if CSHARP_7_OR_LATER
        //todo 
#endif

        public bool Equals(BuffEntity other)
        {
            return ID == other.ID;
        }

        public override bool Equals(object obj)
        {
            return obj is BuffEntity other && Equals(other);
        }

        public override int GetHashCode()
        {
            return ID;
        }

        public static implicit operator int(BuffEntity entity)
        {
            return entity.ID;
        }
        
        public static implicit operator BuffEntity(int id)
        {
            return new BuffEntity(id);
        }
    }
}