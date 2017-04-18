﻿using System;

namespace ATM.Drivers
{
    [FlagsAttribute]
    public enum PrinterStatus
    {
        PRINTER_STATUS_BUSY = 0x00000200,
        PRINTER_STATUS_DOOR_OPEN = 0x00400000,
        PRINTER_STATUS_ERROR = 0x00000002,
        PRINTER_STATUS_INITIALIZING = 0x00008000,
        PRINTER_STATUS_IO_ACTIVE = 0x00000100,
        PRINTER_STATUS_MANUAL_FEED = 0x00000020,
        PRINTER_STATUS_NO_TONER = 0x00040000,
        PRINTER_STATUS_NOT_AVAILABLE = 0x00001000,
        PRINTER_STATUS_OFFLINE = 0x00000080,
        PRINTER_STATUS_OUT_OF_MEMORY = 0x00200000,
        PRINTER_STATUS_OUTPUT_BIN_FULL = 0x00000800,
        PRINTER_STATUS_PAGE_PUNT = 0x00080000,
        PRINTER_STATUS_PAPER_JAM = 0x00000008,
        PRINTER_STATUS_PAPER_OUT = 0x00000010,
        PRINTER_STATUS_PAPER_PROBLEM = 0x00000040,
        PRINTER_STATUS_PAUSED = 0x00000001,
        PRINTER_STATUS_PENDING_DELETION = 0x00000004,
        PRINTER_STATUS_PRINTING = 0x00000400,
        PRINTER_STATUS_PROCESSING = 0x00004000,
        PRINTER_STATUS_TONER_LOW = 0x00020000,
        PRINTER_STATUS_USER_INTERVENTION = 0x00100000,
        PRINTER_STATUS_WAITING = 0x20000000,
        PRINTER_STATUS_WARMING_UP = 0x00010000
    }

}
