namespace Paraclete.Painting;

public partial class Font
{
#pragma warning disable SA1500 // Braces for multi-line statements should not share line
    private static readonly Font _fontDefinitionXS = new(
            Size.XS,
            ('0', ["0"]),
            ('1', ["1"]),
            ('2', ["2"]),
            ('3', ["3"]),
            ('4', ["4"]),
            ('5', ["5"]),
            ('6', ["6"]),
            ('7', ["7"]),
            ('8', ["8"]),
            ('9', ["9"]),
            (':', [":"]),
            ('.', ["."])
        );

    private static readonly Font _fontDefinitionS = new(
            Size.S,
            ('0', [" ▄  ",
                   "█ █ ",
                   "▀▄▀ "]),

            ('1', [" ▄  ",
                   "▀█  ",
                   "▄█▄ "]),

            ('2', [" ▄  ",
                   "▀ █ ",
                   "▄█▄ "]),

            ('3', ["▄▄  ",
                   " ▄▀ ",
                   "▄▄▀ "]),

            ('4', [" ▄▄ ",
                   "█▄█ ",
                   "  █ "]),

            ('5', ["▄▄▄ ",
                   "█▄  ",
                   "▄▄▀ "]),

            ('6', [" ▄▄ ",
                   "█▄  ",
                   "▀▄▀ "]),

            ('7', ["▄▄▄ ",
                   " ▄▀ ",
                   "█   "]),

            ('8', [" ▄  ",
                   "▀▄▀ ",
                   "▀▄▀ "]),

            ('9', [" ▄  ",
                   "▀▄█ ",
                   "▄▄▀ "]),

            (':', ["    ",
                   " ▀  ",
                   " ▀  "]),

            ('.', ["    ",
                   "    ",
                   " ▄  "])
        );

    private static readonly Font _fontDefinitionM = new(
            Size.M,
            ('0', [" ██  ",
                   "█  █ ",
                   "█  █ ",
                   "█  █ ",
                   " ██  "]),

            ('1', ["  █  ",
                   " ██  ",
                   "  █  ",
                   "  █  ",
                   " ███ "]),

            ('2', [" ██  ",
                   "█  █ ",
                   "  █  ",
                   " █   ",
                   "████ "]),

            ('3', [" ██  ",
                   "█  █ ",
                   "  █  ",
                   "█  █ ",
                   " ██  "]),

            ('4', ["  ██ ",
                   " █ █ ",
                   "█  █ ",
                   "████ ",
                   "   █ "]),

            ('5', ["████ ",
                   "█    ",
                   "███  ",
                   "   █ ",
                   "███  "]),

            ('6', [" ██  ",
                   "█    ",
                   "███  ",
                   "█  █ ",
                   " ██  "]),

            ('7', ["████ ",
                   "█  █ ",
                   "  █  ",
                   "  █  ",
                   "  █  "]),

            ('8', [" ██  ",
                   "█  █ ",
                   " ██  ",
                   "█  █ ",
                   " ██  "]),

            ('9', [" ██  ",
                   "█  █ ",
                   " ███ ",
                   "   █ ",
                   " ██  "]),

            (':', ["     ",
                   "  █  ",
                   "     ",
                   "  █  ",
                   "     "]),

            ('.', ["     ",
                   "     ",
                   "     ",
                   "     ",
                   "  █  "])
        );

    private static readonly Font _fontDefinitionL = new(
            Size.L,
            ('0', [" ████  ",
                   "██  ██ ",
                   "██  ██ ",
                   "██  ██ ",
                   "██  ██ ",
                   "██  ██ ",
                   " ████  "]),

            ('1', ["  ██   ",
                   " ███   ",
                   "  ██   ",
                   "  ██   ",
                   "  ██   ",
                   "  ██   ",
                   " ████  "]),

            ('2', [" ████  ",
                   "██  ██ ",
                   "    ██ ",
                   "  ███  ",
                   " ██    ",
                   "██  ██ ",
                   "██████ "]),

            ('3', [" ████  ",
                   "██  ██ ",
                   "    ██ ",
                   "  ███  ",
                   "    ██ ",
                   "██  ██ ",
                   " ████  "]),

            ('4', ["   ██  ",
                   "  ███  ",
                   " █ ██  ",
                   "█  ██  ",
                   "██████ ",
                   "   ██  ",
                   "  ████ "]),

            ('5', ["██████ ",
                   "██  ██ ",
                   "██     ",
                   "█████  ",
                   "    ██ ",
                   "██  ██ ",
                   " ████  "]),

            ('6', [" ████  ",
                   "██  ██ ",
                   "██     ",
                   "█████  ",
                   "██  ██ ",
                   "██  ██ ",
                   " ████  "]),

            ('7', ["██████ ",
                   "██  ██ ",
                   "    ██ ",
                   "   ██  ",
                   "  ██   ",
                   "  ██   ",
                   " ████  "]),

            ('8', [" ████  ",
                   "██  ██ ",
                   "██  ██ ",
                   " ████  ",
                   "██  ██ ",
                   "██  ██ ",
                   " ████  "]),

            ('9', [" ████  ",
                   "██  ██ ",
                   "██  ██ ",
                   " █████ ",
                   "    ██ ",
                   "██  ██ ",
                   " ████  "]),

            (':', ["       ",
                   "  ██   ",
                   "  ██   ",
                   "       ",
                   "  ██   ",
                   "  ██   ",
                   "       "]),

            ('.', ["       ",
                   "       ",
                   "       ",
                   "       ",
                   "       ",
                   "  ██   ",
                   "  ██   "])
        );
#pragma warning restore SA1500 // Braces for multi-line statements should not share line
}
