

namespace SharpLib.MicroInput.Keyboard
{
    /// <summary>
    /// Contains constants representing HID keyboard scan codes as extracted from Teensydruino keylayouts.h
    /// keylayouts.h contents was processed in notepad using the following regular expressions:
    ///    - Find: .*#define\s+(.+?)\s+(\(.+\))
    ///    - Replace: public const ushort \1 = \2;
    ///    
    /// Those scan codes will match keys on american english keyboards I believe.
    /// However, depending of your actual keyboard layout and application, actioning them may not have the expected result.
    /// 
    /// </summary>
    public class Key
    {
        public const ushort A = (4 | 0xF000);
        public const ushort B = (5 | 0xF000);
        public const ushort C = (6 | 0xF000);
        public const ushort D = (7 | 0xF000);
        public const ushort E = (8 | 0xF000);
        public const ushort F = (9 | 0xF000);
        public const ushort G = (10 | 0xF000);
        public const ushort H = (11 | 0xF000);
        public const ushort I = (12 | 0xF000);
        public const ushort J = (13 | 0xF000);
        public const ushort K = (14 | 0xF000);
        public const ushort L = (15 | 0xF000);
        public const ushort M = (16 | 0xF000);
        public const ushort N = (17 | 0xF000);
        public const ushort O = (18 | 0xF000);
        public const ushort P = (19 | 0xF000);
        public const ushort Q = (20 | 0xF000);
        public const ushort R = (21 | 0xF000);
        public const ushort S = (22 | 0xF000);
        public const ushort T = (23 | 0xF000);
        public const ushort U = (24 | 0xF000);
        public const ushort V = (25 | 0xF000);
        public const ushort W = (26 | 0xF000);
        public const ushort X = (27 | 0xF000);
        public const ushort Y = (28 | 0xF000);
        public const ushort Z = (29 | 0xF000);
        public const ushort ALPHA_1 = (30 | 0xF000);
        public const ushort ALPHA_2 = (31 | 0xF000);
        public const ushort ALPHA_3 = (32 | 0xF000);
        public const ushort ALPHA_4 = (33 | 0xF000);
        public const ushort ALPHA_5 = (34 | 0xF000);
        public const ushort ALPHA_6 = (35 | 0xF000);
        public const ushort ALPHA_7 = (36 | 0xF000);
        public const ushort ALPHA_8 = (37 | 0xF000);
        public const ushort ALPHA_9 = (38 | 0xF000);
        public const ushort ALPHA_0 = (39 | 0xF000);
        public const ushort ENTER = (40 | 0xF000);
        public const ushort ESC = (41 | 0xF000);
        public const ushort BACKSPACE = (42 | 0xF000);
        public const ushort TAB = (43 | 0xF000);
        public const ushort SPACE = (44 | 0xF000);
        public const ushort MINUS = (45 | 0xF000);
        public const ushort EQUAL = (46 | 0xF000);
        public const ushort LEFT_BRACE = (47 | 0xF000);
        public const ushort RIGHT_BRACE = (48 | 0xF000);
        public const ushort BACKSLASH = (49 | 0xF000);
        public const ushort NON_US_NUM = (50 | 0xF000);
        public const ushort SEMICOLON = (51 | 0xF000);
        public const ushort QUOTE = (52 | 0xF000);
        public const ushort TILDE = (53 | 0xF000);
        public const ushort COMMA = (54 | 0xF000);
        public const ushort PERIOD = (55 | 0xF000);
        public const ushort SLASH = (56 | 0xF000);
        public const ushort CAPS_LOCK = (57 | 0xF000);
        public const ushort F1 = (58 | 0xF000);
        public const ushort F2 = (59 | 0xF000);
        public const ushort F3 = (60 | 0xF000);
        public const ushort F4 = (61 | 0xF000);
        public const ushort F5 = (62 | 0xF000);
        public const ushort F6 = (63 | 0xF000);
        public const ushort F7 = (64 | 0xF000);
        public const ushort F8 = (65 | 0xF000);
        public const ushort F9 = (66 | 0xF000);
        public const ushort F10 = (67 | 0xF000);
        public const ushort F11 = (68 | 0xF000);
        public const ushort F12 = (69 | 0xF000);
        public const ushort PRINTSCREEN = (70 | 0xF000);
        public const ushort SCROLL_LOCK = (71 | 0xF000);
        public const ushort PAUSE = (72 | 0xF000);
        public const ushort INSERT = (73 | 0xF000);
        public const ushort HOME = (74 | 0xF000);
        public const ushort PAGE_UP = (75 | 0xF000);
        public const ushort DELETE = (76 | 0xF000);
        public const ushort END = (77 | 0xF000);
        public const ushort PAGE_DOWN = (78 | 0xF000);
        public const ushort RIGHT = (79 | 0xF000);
        public const ushort LEFT = (80 | 0xF000);
        public const ushort DOWN = (81 | 0xF000);
        public const ushort UP = (82 | 0xF000);
        public const ushort NUM_LOCK = (83 | 0xF000);
        public const ushort NUM_SLASH = (84 | 0xF000);
        public const ushort NUM_ASTERIX = (85 | 0xF000);
        public const ushort NUM_MINUS = (86 | 0xF000);
        public const ushort NUM_PLUS = (87 | 0xF000);
        public const ushort NUM_ENTER = (88 | 0xF000);
        public const ushort NUM_1 = (89 | 0xF000);
        public const ushort NUM_2 = (90 | 0xF000);
        public const ushort NUM_3 = (91 | 0xF000);
        public const ushort NUM_4 = (92 | 0xF000);
        public const ushort NUM_5 = (93 | 0xF000);
        public const ushort NUM_6 = (94 | 0xF000);
        public const ushort NUM_7 = (95 | 0xF000);
        public const ushort NUM_8 = (96 | 0xF000);
        public const ushort NUM_9 = (97 | 0xF000);
        public const ushort NUM_0 = (98 | 0xF000);
        public const ushort NUM_PERIOD = (99 | 0xF000);
        public const ushort NON_US_BS = (100 | 0xF000);
        public const ushort MENU = (101 | 0xF000);
        public const ushort F13 = (104 | 0xF000);
        public const ushort F14 = (105 | 0xF000);
        public const ushort F15 = (106 | 0xF000);
        public const ushort F16 = (107 | 0xF000);
        public const ushort F17 = (108 | 0xF000);
        public const ushort F18 = (109 | 0xF000);
        public const ushort F19 = (110 | 0xF000);
        public const ushort F20 = (111 | 0xF000);
        public const ushort F21 = (112 | 0xF000);
        public const ushort F22 = (113 | 0xF000);
        public const ushort F23 = (114 | 0xF000);
        public const ushort F24 = (115 | 0xF000);
    }

    public class Modifier
    {
        public const ushort CTRL = (0x01 | 0xE000);
        public const ushort SHIFT = (0x02 | 0xE000);
        public const ushort ALT = (0x04 | 0xE000);
        public const ushort GUI = (0x08 | 0xE000);
        public const ushort LEFT_CTRL = (0x01 | 0xE000);
        public const ushort LEFT_SHIFT = (0x02 | 0xE000);
        public const ushort LEFT_ALT = (0x04 | 0xE000);
        public const ushort LEFT_GUI = (0x08 | 0xE000);
        public const ushort RIGHT_CTRL = (0x10 | 0xE000);
        public const ushort RIGHT_SHIFT = (0x20 | 0xE000);
        public const ushort RIGHT_ALT = (0x40 | 0xE000);
        public const ushort RIGHT_GUI = (0x80 | 0xE000);
    }

    public class System
    {
        public const ushort POWER_DOWN = (0x81 | 0xE200);
        public const ushort SLEEP = (0x82 | 0xE200);
        public const ushort WAKE_UP = (0x83 | 0xE200);
    }

    public class Media
    {
        public const ushort PLAY = (0xB0 | 0xE400);
        public const ushort PAUSE = (0xB1 | 0xE400);
        public const ushort RECORD = (0xB2 | 0xE400);
        public const ushort FAST_FORWARD = (0xB3 | 0xE400);
        public const ushort REWIND = (0xB4 | 0xE400);
        public const ushort NEXT_TRACK = (0xB5 | 0xE400);
        public const ushort PREV_TRACK = (0xB6 | 0xE400);
        public const ushort STOP = (0xB7 | 0xE400);
        public const ushort EJECT = (0xB8 | 0xE400);
        public const ushort RANDOM_PLAY = (0xB0 | 0xE400);
        public const ushort PLAY_PAUSE = (0xCD | 0xE400);
        public const ushort PLAY_SKIP = (0xCE | 0xE400);
        public const ushort MUTE = (0xE2 | 0xE400);
        public const ushort VOLUME_INC = (0xE9 | 0xE400);
        public const ushort VOLUME_DEC = (0xEA | 0xE400);
    }

}