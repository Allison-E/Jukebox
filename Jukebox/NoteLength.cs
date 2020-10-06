using System;

namespace Jukebox
{
    [Flags]
    public enum NoteLength
    {
        Semibreve = 1,
        Minim = 2,
        Crotchet = 4,
        Quaver = 8,
        Semiquaver = 16
    }
}
