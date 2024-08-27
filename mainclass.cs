using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MelonLoader;
using HarmonyLib;
namespace KillBind
{
    public class mainclass :MelonMod
    {
        public override void OnUpdate()
        {
            if(GameObject.Find("Player") != null && Input.GetKeyDown(KeyCode.K))
            {
                PlayerHealthManagement phmscript = GameObject.Find("Player").GetComponent<PlayerHealthManagement>();
                phmscript.TakeDamage(phmscript.MyHealth * 6f);
            }
        }
    }
}
