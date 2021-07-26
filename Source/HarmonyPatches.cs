using HarmonyLib;
using RimWorld;
using Verse;
using System.Reflection;

namespace NoComfortNoAteWithoutTable
{
    [StaticConstructorOnStartup]
    public class HarmonyPatches
    {
        static HarmonyPatches()
        {
            var harmony = new Harmony("llunak.NoComfortNoAteWithoutTable");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
