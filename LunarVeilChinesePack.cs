using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace LunarVeilChinesePack
{
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
	public class LunarVeilChinesePack : Mod
	{
        public static string Tooltips_string(string old,string newst)
        {
            old = old.Replace(old,newst);
            return old;
        }
    }

}
