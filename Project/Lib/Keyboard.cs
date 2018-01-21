﻿

namespace SharpLib.MicroInput
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
    public class Keyboard
    {
        public const ushort MODIFIERKEY_CTRL = (0x01 | 0xE000);
        public const ushort MODIFIERKEY_SHIFT = (0x02 | 0xE000);
        public const ushort MODIFIERKEY_ALT = (0x04 | 0xE000);
        public const ushort MODIFIERKEY_GUI = (0x08 | 0xE000);
        public const ushort MODIFIERKEY_LEFT_CTRL = (0x01 | 0xE000);
        public const ushort MODIFIERKEY_LEFT_SHIFT = (0x02 | 0xE000);
        public const ushort MODIFIERKEY_LEFT_ALT = (0x04 | 0xE000);
        public const ushort MODIFIERKEY_LEFT_GUI = (0x08 | 0xE000);
        public const ushort MODIFIERKEY_RIGHT_CTRL = (0x10 | 0xE000);
        public const ushort MODIFIERKEY_RIGHT_SHIFT = (0x20 | 0xE000);
        public const ushort MODIFIERKEY_RIGHT_ALT = (0x40 | 0xE000);
        public const ushort MODIFIERKEY_RIGHT_GUI = (0x80 | 0xE000);

        public const ushort KEY_SYSTEM_POWER_DOWN = (0x81 | 0xE200);
        public const ushort KEY_SYSTEM_SLEEP = (0x82 | 0xE200);
        public const ushort KEY_SYSTEM_WAKE_UP = (0x83 | 0xE200);

        public const ushort KEY_MEDIA_PLAY = (0xB0 | 0xE400);
        public const ushort KEY_MEDIA_PAUSE = (0xB1 | 0xE400);
        public const ushort KEY_MEDIA_RECORD = (0xB2 | 0xE400);
        public const ushort KEY_MEDIA_FAST_FORWARD = (0xB3 | 0xE400);
        public const ushort KEY_MEDIA_REWIND = (0xB4 | 0xE400);
        public const ushort KEY_MEDIA_NEXT_TRACK = (0xB5 | 0xE400);
        public const ushort KEY_MEDIA_PREV_TRACK = (0xB6 | 0xE400);
        public const ushort KEY_MEDIA_STOP = (0xB7 | 0xE400);
        public const ushort KEY_MEDIA_EJECT = (0xB8 | 0xE400);
        public const ushort KEY_MEDIA_RANDOM_PLAY = (0xB0 | 0xE400);
        public const ushort KEY_MEDIA_PLAY_PAUSE = (0xCD | 0xE400);
        public const ushort KEY_MEDIA_PLAY_SKIP = (0xCE | 0xE400);
        public const ushort KEY_MEDIA_MUTE = (0xE2 | 0xE400);
        public const ushort KEY_MEDIA_VOLUME_INC = (0xE9 | 0xE400);
        public const ushort KEY_MEDIA_VOLUME_DEC = (0xEA | 0xE400);

        public const ushort KEY_A = (4 | 0xF000);
        public const ushort KEY_B = (5 | 0xF000);
        public const ushort KEY_C = (6 | 0xF000);
        public const ushort KEY_D = (7 | 0xF000);
        public const ushort KEY_E = (8 | 0xF000);
        public const ushort KEY_F = (9 | 0xF000);
        public const ushort KEY_G = (10 | 0xF000);
        public const ushort KEY_H = (11 | 0xF000);
        public const ushort KEY_I = (12 | 0xF000);
        public const ushort KEY_J = (13 | 0xF000);
        public const ushort KEY_K = (14 | 0xF000);
        public const ushort KEY_L = (15 | 0xF000);
        public const ushort KEY_M = (16 | 0xF000);
        public const ushort KEY_N = (17 | 0xF000);
        public const ushort KEY_O = (18 | 0xF000);
        public const ushort KEY_P = (19 | 0xF000);
        public const ushort KEY_Q = (20 | 0xF000);
        public const ushort KEY_R = (21 | 0xF000);
        public const ushort KEY_S = (22 | 0xF000);
        public const ushort KEY_T = (23 | 0xF000);
        public const ushort KEY_U = (24 | 0xF000);
        public const ushort KEY_V = (25 | 0xF000);
        public const ushort KEY_W = (26 | 0xF000);
        public const ushort KEY_X = (27 | 0xF000);
        public const ushort KEY_Y = (28 | 0xF000);
        public const ushort KEY_Z = (29 | 0xF000);
        public const ushort KEY_1 = (30 | 0xF000);
        public const ushort KEY_2 = (31 | 0xF000);
        public const ushort KEY_3 = (32 | 0xF000);
        public const ushort KEY_4 = (33 | 0xF000);
        public const ushort KEY_5 = (34 | 0xF000);
        public const ushort KEY_6 = (35 | 0xF000);
        public const ushort KEY_7 = (36 | 0xF000);
        public const ushort KEY_8 = (37 | 0xF000);
        public const ushort KEY_9 = (38 | 0xF000);
        public const ushort KEY_0 = (39 | 0xF000);
        public const ushort KEY_ENTER = (40 | 0xF000);
        public const ushort KEY_ESC = (41 | 0xF000);
        public const ushort KEY_BACKSPACE = (42 | 0xF000);
        public const ushort KEY_TAB = (43 | 0xF000);
        public const ushort KEY_SPACE = (44 | 0xF000);
        public const ushort KEY_MINUS = (45 | 0xF000);
        public const ushort KEY_EQUAL = (46 | 0xF000);
        public const ushort KEY_LEFT_BRACE = (47 | 0xF000);
        public const ushort KEY_RIGHT_BRACE = (48 | 0xF000);
        public const ushort KEY_BACKSLASH = (49 | 0xF000);
        public const ushort KEY_NON_US_NUM = (50 | 0xF000);
        public const ushort KEY_SEMICOLON = (51 | 0xF000);
        public const ushort KEY_QUOTE = (52 | 0xF000);
        public const ushort KEY_TILDE = (53 | 0xF000);
        public const ushort KEY_COMMA = (54 | 0xF000);
        public const ushort KEY_PERIOD = (55 | 0xF000);
        public const ushort KEY_SLASH = (56 | 0xF000);
        public const ushort KEY_CAPS_LOCK = (57 | 0xF000);
        public const ushort KEY_F1 = (58 | 0xF000);
        public const ushort KEY_F2 = (59 | 0xF000);
        public const ushort KEY_F3 = (60 | 0xF000);
        public const ushort KEY_F4 = (61 | 0xF000);
        public const ushort KEY_F5 = (62 | 0xF000);
        public const ushort KEY_F6 = (63 | 0xF000);
        public const ushort KEY_F7 = (64 | 0xF000);
        public const ushort KEY_F8 = (65 | 0xF000);
        public const ushort KEY_F9 = (66 | 0xF000);
        public const ushort KEY_F10 = (67 | 0xF000);
        public const ushort KEY_F11 = (68 | 0xF000);
        public const ushort KEY_F12 = (69 | 0xF000);
        public const ushort KEY_PRINTSCREEN = (70 | 0xF000);
        public const ushort KEY_SCROLL_LOCK = (71 | 0xF000);
        public const ushort KEY_PAUSE = (72 | 0xF000);
        public const ushort KEY_INSERT = (73 | 0xF000);
        public const ushort KEY_HOME = (74 | 0xF000);
        public const ushort KEY_PAGE_UP = (75 | 0xF000);
        public const ushort KEY_DELETE = (76 | 0xF000);
        public const ushort KEY_END = (77 | 0xF000);
        public const ushort KEY_PAGE_DOWN = (78 | 0xF000);
        public const ushort KEY_RIGHT = (79 | 0xF000);
        public const ushort KEY_LEFT = (80 | 0xF000);
        public const ushort KEY_DOWN = (81 | 0xF000);
        public const ushort KEY_UP = (82 | 0xF000);
        public const ushort KEY_NUM_LOCK = (83 | 0xF000);
        public const ushort KEYPAD_SLASH = (84 | 0xF000);
        public const ushort KEYPAD_ASTERIX = (85 | 0xF000);
        public const ushort KEYPAD_MINUS = (86 | 0xF000);
        public const ushort KEYPAD_PLUS = (87 | 0xF000);
        public const ushort KEYPAD_ENTER = (88 | 0xF000);
        public const ushort KEYPAD_1 = (89 | 0xF000);
        public const ushort KEYPAD_2 = (90 | 0xF000);
        public const ushort KEYPAD_3 = (91 | 0xF000);
        public const ushort KEYPAD_4 = (92 | 0xF000);
        public const ushort KEYPAD_5 = (93 | 0xF000);
        public const ushort KEYPAD_6 = (94 | 0xF000);
        public const ushort KEYPAD_7 = (95 | 0xF000);
        public const ushort KEYPAD_8 = (96 | 0xF000);
        public const ushort KEYPAD_9 = (97 | 0xF000);
        public const ushort KEYPAD_0 = (98 | 0xF000);
        public const ushort KEYPAD_PERIOD = (99 | 0xF000);
        public const ushort KEY_NON_US_BS = (100 | 0xF000);
        public const ushort KEY_MENU = (101 | 0xF000);
        public const ushort KEY_F13 = (104 | 0xF000);
        public const ushort KEY_F14 = (105 | 0xF000);
        public const ushort KEY_F15 = (106 | 0xF000);
        public const ushort KEY_F16 = (107 | 0xF000);
        public const ushort KEY_F17 = (108 | 0xF000);
        public const ushort KEY_F18 = (109 | 0xF000);
        public const ushort KEY_F19 = (110 | 0xF000);
        public const ushort KEY_F20 = (111 | 0xF000);
        public const ushort KEY_F21 = (112 | 0xF000);
        public const ushort KEY_F22 = (113 | 0xF000);
        public const ushort KEY_F23 = (114 | 0xF000);
        public const ushort KEY_F24 = (115 | 0xF000);


    }
}