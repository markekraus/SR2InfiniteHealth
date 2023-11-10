using HarmonyLib;
using Il2Cpp;
using Il2CppMonomiPark.SlimeRancher.DataModel;

namespace InfiniteHealth
{
    [HarmonyPatch(typeof(PlayerModel), nameof(PlayerModel.LoseHealth))]
    internal class PlayerStateDamagePatch : Entry
    {
        public static bool Prefix(float health, PlayerState __instance) => false;
    }
}