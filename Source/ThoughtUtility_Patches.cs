using HarmonyLib;
using RimWorld;
using Verse;

namespace NoComfortNoAteWithoutTable
{
    [HarmonyPatch(typeof(ThoughtUtility))]
    [HarmonyPatch(nameof(CanGetThought))]
    public static class ThoughtUtility_Patch
    {
        [HarmonyPrefix]
        public static bool CanGetThought(ref bool __result, Pawn pawn, ThoughtDef def, bool checkIfNullified)
        {
            // Pawns with Comfort:Ignored precept have pawn.needs.comfort == null.
            if(def == ThoughtDefOf.AteWithoutTable && pawn.needs != null && pawn.needs.comfort == null)
            {
                __result = false;
                return false;
            }
            return true; // execute the original version of the function
        }
    }
}
