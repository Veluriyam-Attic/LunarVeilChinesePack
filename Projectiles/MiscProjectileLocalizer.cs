namespace LunarVeilChinesePack.Projectiles;

internal class MiscProjectileLocalizer : ModSystem {
    public override void Load() {
        #region AuroreanStarbomber
        ForceLocalizeSystem.LocalizeByTypeName("AuroreanStarbomber", "SpawnStarBomber", new() {
            { "STARBOMBER crashes down!", "填入汉化文本" },
        });
        #endregion
        #region BloodLampProjectileModifications
        ForceLocalizeSystem.LocalizeByTypeName("BloodLampProjectileModifications", "OnHitNPC", new() {
            { "This NPC has been hit with a modified projectile ", "填入汉化文本" },
            { " times.", "填入汉化文本" },
        });
        #endregion
        #region ProjectileModifications
        ForceLocalizeSystem.LocalizeByTypeName("ProjectileModifications", "OnHitNPC", new() {
            { "This NPC has been hit with a modified projectile ", "填入汉化文本" },
            { " times.", "填入汉化文本" },
        });
        #endregion
        #region IgniterStart
        ForceLocalizeSystem.LocalizeByTypeName("IgniterStart", "OnHitNPC", new() {
            { "STRIKE!!", "填入汉化文本" },
            { "MAGIC!", "填入汉化文本" },
        });
        #endregion
    }
}
