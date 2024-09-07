#nullable enable

using MonoMod.Cil;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Terraria.ModLoader;

namespace LunarVeilChinesePack.Systems;

public class ForceLocalizeSystem : ModSystem {
    #region Localize
    /// <summary>
    /// <br/>替换一个方法中的字符串
    /// <br/>只能在加载阶段使用
    /// <br/>如果不想用反射, 可以使用<see cref="LocalizeByTypeName"/>
    /// <br/>或 <see cref="LocalizeByTypeFullName"/>
    /// <br/>注意如果此方法有多个重载 (即多个重名的方法), 则上述两个无法使用 (只能用这个)
    /// </summary>
    /// <param name="methodInfo">此方法, 由反射得到</param>
    /// <param name="localizations">需要替换的字符串, 键为替换前, 值为替换后</param>
    public static void Localize(MethodInfo methodInfo, Dictionary<string, string> localizations) {
        MonoModHooks.Modify(methodInfo, il => {
            ILCursor cursor = new(il);
            string? str = null;
            while (cursor.TryGotoNext(i => i.MatchLdstr(out str))) {
                if (str != null && cursor.Next != null && localizations.TryGetValue(str, out var value)) {
                    cursor.Next.Operand = value;
                }
            }
        });
    }
    /// <summary>
    /// <br/>替换一个方法中的字符串
    /// <br/>只能在加载阶段使用
    /// </summary>
    /// <param name="typeName">包含此方法的类型的名字</param>
    /// <param name="methodName">此方法名</param>
    /// <param name="localizations">需要替换的字符串, 键为替换前, 值为替换后</param>
    public static void LocalizeByTypeName(string typeName, string methodName, Dictionary<string, string> localizations) {
        if (!TypeHelper.StellaTypeByName.TryGetValue(typeName, out Type? type)) {
            return;
        }
        try {
            var methodInfo = type.GetMethod(methodName, BFALL);
            if (methodInfo == null) {
                return;
            }
            Localize(methodInfo, localizations);
        }
        catch { }
    }
    /// <summary>
    /// <br/>替换一个方法中的字符串
    /// <br/>只能在加载阶段使用
    /// </summary>
    /// <param name="typeFullName">
    /// <br/>包含此方法的类型的全名
    /// <br/>包含命名空间, 由 '.' 分隔
    /// <br/>例: LunarVeilChinesePack.Systems.ForceLocalizeSystem
    /// <br/>如果是内嵌类型, 则用 '+' 连接
    /// <br/>例: LunarVeilChinesePack.Systems.ForceLocalizeSystem+TypeHelper
    /// </param>
    /// <param name="methodName">此方法名</param>
    /// <param name="localizations">需要替换的字符串, 键为替换前, 值为替换后</param>
    public static void LocalizeByTypeFullName(string typeFullName, string methodName, Dictionary<string, string> localizations) {
        if (!TypeHelper.StellaTypeByFullName.TryGetValue(typeFullName, out Type? type)) {
            return;
        }
        try {
            var methodInfo = type.GetMethod(methodName, BFALL);
            if (methodInfo == null) {
                return;
            }
            Localize(methodInfo, localizations);
        }
        catch { }
    }
    
    /// <summary>
    /// <br/>替换一个方法中的字符串
    /// <br/>只能在加载阶段使用
    /// <br/>如果不想用反射, 可以使用<see cref="LocalizeInOrderByTypeName"/>
    /// <br/>或 <see cref="LocalizeInOrderByTypeName"/>
    /// <br/>注意如果此方法有多个重载 (即多个重名的方法), 则上述两个无法使用 (只能用这个)
    /// </summary>
    /// <param name="methodInfo">此方法, 由反射得到</param>
    /// <param name="localizations">需要替换的字符串, 需按顺序装有 (替换前, 替换后) 的值</param>
    public static void LocalizeInOrder(MethodInfo methodInfo, List<(string Key, string Value)> localizations) {
        if (localizations.Count == 0) {
            return;
        }
        MonoModHooks.Modify(methodInfo, il => {
            ILCursor cursor = new(il);
            string? str = null;
            int i = 0;
            while (cursor.TryGotoNext(i => i.MatchLdstr(out str))) {
                if (str == null || cursor.Next == null || localizations[i].Key != str) {
                    continue;
                }
                cursor.Next.Operand = localizations[i].Value;
                i += 1;
                if (localizations.Count <= i) {
                    return;
                }
            }
        });
    }
    /// <summary>
    /// <br/>替换一个方法中的字符串
    /// <br/>只能在加载阶段使用
    /// </summary>
    /// <param name="typeName">包含此方法的类型的名字</param>
    /// <param name="methodName">此方法名</param>
    /// <param name="localizations">需要替换的字符串, 需按顺序装有 (替换前, 替换后) 的值</param>
    public static void LocalizeInOrderByTypeName(string typeName, string methodName, List<(string Key, string Value)> localizations) {
        if (!TypeHelper.StellaTypeByName.TryGetValue(typeName, out Type? type)) {
            return;
        }
        try {
            var methodInfo = type.GetMethod(methodName, BFALL);
            if (methodInfo == null) {
                return;
            }
            LocalizeInOrder(methodInfo, localizations);
        }
        catch { }
    }
    /// <summary>
    /// <br/>替换一个方法中的字符串
    /// <br/>只能在加载阶段使用
    /// </summary>
    /// <param name="typeFullName">
    /// <br/>包含此方法的类型的全名
    /// <br/>包含命名空间, 由 '.' 分隔
    /// <br/>例: LunarVeilChinesePack.Systems.ForceLocalizeSystem
    /// <br/>如果是内嵌类型, 则用 '+' 连接
    /// <br/>例: LunarVeilChinesePack.Systems.ForceLocalizeSystem+TypeHelper
    /// </param>
    /// <param name="methodName">此方法名</param>
    /// <param name="localizations">需要替换的字符串, 需按顺序装有 (替换前, 替换后) 的值</param>
    public static void LocalizeInOrderByTypeFullName(string typeFullName, string methodName, List<(string Key, string Value)> localizations) {
        if (!TypeHelper.StellaTypeByFullName.TryGetValue(typeFullName, out Type? type)) {
            return;
        }
        try {
            var methodInfo = type.GetMethod(methodName, BFALL);
            if (methodInfo == null) {
                return;
            }
            LocalizeInOrder(methodInfo, localizations);
        }
        catch { }
    }
    #endregion

    public override void PostSetupRecipes() {
        TypeHelper.Clear();
    }
    private const BindingFlags BFALL = BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
    public static class TypeHelper {
        private static Assembly? stellaAssembly;
        public static Assembly StellaAssembly {
            get {
                if (stellaAssembly == null) {
                    Initialize();
                }
                return stellaAssembly;
            }
        }
        private static Dictionary<string, Type>? stellaTypeByName;
        public static Dictionary<string, Type> StellaTypeByName {
            get {
                if (stellaTypeByName == null) {
                    Initialize();
                }
                return stellaTypeByName;
            }
        }
        private static Dictionary<string, Type>? stellaTypeByFullName;
        public static Dictionary<string, Type> StellaTypeByFullName {
            get {
                if (stellaTypeByFullName == null) {
                    Initialize();
                }
                return stellaTypeByFullName;
            }
        }
        private static bool initialized;
        [MemberNotNull(nameof(stellaAssembly), nameof(stellaTypeByName), nameof(stellaTypeByFullName))]
        private static void Initialize() {
            if (cleared) {
                throw new Exception("在完成后初始化!");
            }
            if (initialized) {
                throw new Exception("重复初始化!");
            }
            initialized = true;
            stellaAssembly = ModLoader.GetMod("Stellamod").GetType().Assembly;
            stellaTypeByName = [];
            stellaTypeByFullName = [];
            foreach (var type in stellaAssembly.GetTypes()) {
                stellaTypeByName.TryAdd(type.Name, type);
                if (type.FullName != null) {
                    stellaTypeByFullName.TryAdd(type.FullName, type);
                }
            }
        }
        private static bool cleared;
        public static void Clear() {
            cleared = true;
            initialized = false;
            stellaAssembly = null;
            stellaTypeByName = null;
            stellaTypeByFullName = null;
        }

    }
}

public static class ListAddExtensions {
    public static void Add<T1, T2>(this List<(T1, T2)> self, T1 t1, T2 t2) => self.Add((t1, t2));
}
