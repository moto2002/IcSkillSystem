﻿using System;
using CabinIcarus.IcSkillSystem.Runtime.Buffs;
using CabinIcarus.IcSkillSystem.Runtime.Buffs.Entitys;
using UnityEngine;

namespace CabinIcarus.IcSkillSystem.Expansion.Builtin.Component
{
    public class BuffEntityLinkComponent : MonoBehaviour
    {
        [NonSerialized] 
        public IBuffManager<IIcSkSEntity> EntityManager;
        [NonSerialized] 
        public IIcSkSEntity IcSkSEntity;

        public void Init(IBuffManager<IIcSkSEntity> entityManager, IIcSkSEntity icSkSEntity)
        {
            EntityManager = entityManager;
            Link(icSkSEntity);
        }

        public void Link(IIcSkSEntity icSkSEntity)
        {
            this.IcSkSEntity = icSkSEntity;
        }
    }
}