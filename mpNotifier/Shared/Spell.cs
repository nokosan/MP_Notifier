using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpNotifier.Shared
{
    public enum AID:uint
    {
        None = 0,
        Sprint = 3,

        // single target GCDs
        Blizzard1 = 142, // L1, 2.5s cast, range 25, single-target 0/0, targets=hostile
        Fire1 = 141, // L2, 2.5s cast, range 25, single-target 0/0, targets=hostile
        Thunder1 = 144, // L6, 2.5s cast, range 25, single-target 0/0, targets=hostile
        Scathe = 156, // L15, instant, range 25, single-target 0/0, targets=hostile
        Blizzard3 = 154, // L35, 3.5s cast, range 25, single-target 0/0, targets=hostile
        Fire3 = 152, // L35, 3.5s cast, range 25, single-target 0/0, targets=hostile
        Thunder3 = 153, // L45, 2.5s cast, range 25, single-target 0/0, targets=hostile
        Blizzard4 = 3576, // L58, 2.5s cast, range 25, single-target 0/0, targets=hostile, animLock=???
        Fire4 = 3577, // L60, 2.8s cast, range 25, single-target 0/0, targets=hostile, animLock=???
        Foul = 7422, // L70, 2.5s cast, range 25, AOE circle 5/0, targets=hostile, animLock=???
        Despair = 16505, // L72, 3.0s cast, range 25, single-target 0/0, targets=hostile, animLock=???
        Xenoglossy = 16507, // L80, instant, range 25, single-target 0/0, targets=hostile, animLock=???
        Paradox = 25797, // L90, 2.5s cast, range 25, single-target 0/0, targets=hostile, animLock=???

        // aoe GCDs
        Blizzard2 = 25793, // L12, 3.0s cast, range 25, AOE circle 5/0, targets=hostile
        Fire2 = 147, // L18, 3.0s cast, range 25, AOE circle 5/0, targets=hostile
        Thunder2 = 7447, // L26, 2.5s cast, range 25, AOE circle 5/0, targets=hostile
        Freeze = 159, // L40, 2.8s cast, range 25, AOE circle 5/0, targets=hostile
        Flare = 162, // L50, 4.0s cast, range 25, AOE circle 5/0, targets=hostile
        Thunder4 = 7420, // L64, 2.5s cast, range 25, AOE circle 5/0, targets=hostile, animLock=???
        HighBlizzard2 = 25795, // L82, 3.0s cast, range 25, AOE circle 5/0, targets=hostile, animLock=???
        HighFire2 = 25794, // L82, 3.0s cast, range 25, AOE circle 5/0, targets=hostile, animLock=???

        // oGCDs
        Transpose = 149, // L4, instant, 5.0s CD (group 0), range 0, single-target 0/0, targets=self
        Sharpcast = 3574, // L54, instant, 60.0s CD (group 19), range 0, single-target 0/0, targets=self, animLock=???

        // offsensive CDs
        Swiftcast = 7561, // L18, instant, 60.0s CD (group 42), range 0, single-target 0/0, targets=self
        Manafont = 158, // L30, instant, 180.0s CD (group 23), range 0, single-target 0/0, targets=self
        LeyLines = 3573, // L52, instant, 120.0s CD (group 14), range 0, Ground circle 3/0, targets=area, animLock=???
        Triplecast = 7421, // L66, instant, 60.0s CD (group 9) (2 charges), range 0, single-target 0/0, targets=self, animLock=???
        Amplifier = 25796, // L86, instant, 120.0s CD (group 20), range 0, single-target 0/0, targets=self, animLock=???
        LucidDreaming = 7562, // L14, instant, 60.0s CD (group 41), range 0, single-target 0/0, targets=self

        // defensive CDs
        Addle = 7560, // L8, instant, 90.0s CD (group 40), range 25, single-target 0/0, targets=hostile
        Manaward = 157, // L30, instant, 120.0s CD (group 21), range 0, single-target 0/0, targets=self
        Surecast = 7559, // L44, instant, 120.0s CD (group 43), range 0, single-target 0/0, targets=self

        // misc
        AetherialManipulation = 155, // L50, instant, 10.0s CD (group 4), range 25, single-target 0/0, targets=party, animLock=???
        BetweenTheLines = 7419, // L62, instant, 3.0s CD (group 1), range 25, Ground circle 0/0, targets=area, animLock=???
        UmbralSoul = 16506, // L76, instant, range 0, single-target 0/0, targets=self, animLock=???
        Sleep = 25880, // L10, 2.5s cast, range 30, AOE circle 5/0, targets=hostile
    }
}
