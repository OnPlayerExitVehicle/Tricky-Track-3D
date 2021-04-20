using TrickyTrack.Base;
using System;
using System.Linq;
using TrickyTrack.Base.Utility;
using UnityEngine;

namespace TrickyTrack.Management
{
    
    public class GameManager: UpdateableScript
    {
        [SerializeField] private readonly BaseScript[] scriptArray = new BaseScript[0];
        public override void BaseAwake()
        {
            scriptArray.CallEvents((baseScript) => { baseScript.BaseAwake(); });
        }

        public override void BaseStart()
        {
            scriptArray.CallEvents((baseScript) => { baseScript.BaseStart(); });
        }

        public override void BaseFixedUpdate()
        {
            scriptArray.CallEvents<UpdateableScript>((updateableScript) => { updateableScript.BaseFixedUpdate(); });
        }

        public override void BaseUpdate()
        {
            scriptArray.CallEvents<UpdateableScript>((updateableScript) => { updateableScript.BaseUpdate(); });
        }

        public override void BaseLateUpdate()
        {
            scriptArray.CallEvents<UpdateableScript>((updateableScript) => { updateableScript.BaseLateUpdate(); });
        }
    }
}