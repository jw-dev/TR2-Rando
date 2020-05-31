﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TRLevelReader;
using TRLevelReader.Model;

namespace TRLevelReaderUnitTests
{
    [TestClass]
    public class TR2Level_UnitTests
    {
        private static readonly uint TR2VersionHeader = 0x0000002D;

        [TestMethod]
        public void GreatWall_ReadTest()
        {
            TR2LevelReader reader = new TR2LevelReader();

            TR2Level lvl = reader.ReadLevel("wall.tr2");

            #region Expected Palettes
            TRColour[] ExpectedPalette8 = new TRColour[]
            {
                new TRColour { Red = 0x3F, Green = 0x00, Blue = 0x3F },
                 new TRColour {  Red = 0x05, Green = 0x04, Blue = 0x01 },
                 new TRColour {  Red = 0x13, Green = 0x18, Blue = 0x18 },
                 new TRColour {  Red = 0x11, Green = 0x11, Blue = 0x0E},
                 new TRColour {  Red = 0x19, Green = 0x1D, Blue = 0x13},
                 new TRColour {  Red = 0x26, Green = 0x28, Blue = 0x27},
                 new TRColour {  Red = 0x20, Green = 0x25, Blue = 0x1B},
                 new TRColour {  Red = 0x09, Green = 0x09, Blue = 0x08},
                 new TRColour {  Red = 0x12, Green = 0x16, Blue = 0x17},
                 new TRColour {  Red = 0x1C, Green = 0x1F, Blue = 0x21},
                 new TRColour {  Red = 0x19, Green = 0x1C, Blue = 0x1E},
                 new TRColour {  Red = 0x14, Green = 0x16, Blue = 0x10},
                 new TRColour {  Red = 0x16, Green = 0x18, Blue = 0x1A},
                 new TRColour {  Red = 0x10, Green = 0x14, Blue = 0x15},
                 new TRColour {  Red = 0x0F, Green = 0x12, Blue = 0x12},
                 new TRColour {  Red = 0x0F, Green = 0x11, Blue = 0x0C},
                 new TRColour {  Red = 0x0D, Green = 0x0D, Blue = 0x0C},
                 new TRColour {  Red = 0x0D, Green = 0x0E, Blue = 0x09},
                 new TRColour {  Red = 0x19, Green = 0x19, Blue = 0x16},
                 new TRColour {  Red = 0x17, Green = 0x18, Blue = 0x13},
                 new TRColour {  Red = 0x21, Green = 0x26, Blue = 0x28},
                 new TRColour {  Red = 0x07, Green = 0x09, Blue = 0x09},
                 new TRColour {  Red = 0x0C, Green = 0x14, Blue = 0x16},
                 new TRColour {  Red = 0x18, Green = 0x1F, Blue = 0x20},
                 new TRColour {  Red = 0x1B, Green = 0x1C, Blue = 0x1F},
                 new TRColour {  Red = 0x21, Green = 0x22, Blue = 0x22},
                 new TRColour {  Red = 0x0C, Green = 0x10, Blue = 0x11},
                 new TRColour {  Red = 0x04, Green = 0x06, Blue = 0x07},
                 new TRColour {  Red = 0x2D, Green = 0x30, Blue = 0x2E},
                 new TRColour {  Red = 0x2F, Green = 0x33, Blue = 0x25},
                 new TRColour {  Red = 0x2B, Green = 0x2D, Blue = 0x2D},
                 new TRColour {  Red = 0x29, Green = 0x2B, Blue = 0x29},
                 new TRColour {  Red = 0x02, Green = 0x02, Blue = 0x02},
                 new TRColour {  Red = 0x06, Green = 0x07, Blue = 0x09},
                 new TRColour {  Red = 0x0A, Green = 0x0D, Blue = 0x0E},
                 new TRColour {  Red = 0x38, Green = 0x35, Blue = 0x1B},
                 new TRColour {  Red = 0x1B, Green = 0x22, Blue = 0x23},
                 new TRColour {  Red = 0x23, Green = 0x21, Blue = 0x1B},
                 new TRColour {  Red = 0x15, Green = 0x1B, Blue = 0x1C},
                 new TRColour {  Red = 0x0A, Green = 0x0B, Blue = 0x09},
                 new TRColour {  Red = 0x20, Green = 0x1E, Blue = 0x19},
                 new TRColour {  Red = 0x1E, Green = 0x21, Blue = 0x16},
                 new TRColour {  Red = 0x03, Green = 0x0B, Blue = 0x0A},
                 new TRColour {  Red = 0x14, Green = 0x14, Blue = 0x13},
                 new TRColour {  Red = 0x09, Green = 0x0B, Blue = 0x0B},
                 new TRColour {  Red = 0x04, Green = 0x05, Blue = 0x04},
                 new TRColour {  Red = 0x18, Green = 0x18, Blue = 0x0F},
                 new TRColour {  Red = 0x23, Green = 0x2B, Blue = 0x2A},
                 new TRColour {  Red = 0x1E, Green = 0x24, Blue = 0x24},
                 new TRColour {  Red = 0x26, Green = 0x28, Blue = 0x23},
                 new TRColour {  Red = 0x05, Green = 0x06, Blue = 0x06},
                 new TRColour {  Red = 0x1E, Green = 0x1C, Blue = 0x11},
                 new TRColour {  Red = 0x19, Green = 0x21, Blue = 0x0D},
                 new TRColour {  Red = 0x26, Green = 0x2C, Blue = 0x29},
                 new TRColour {  Red = 0x1C, Green = 0x1D, Blue = 0x19},
                 new TRColour {  Red = 0x0E, Green = 0x0B, Blue = 0x09},
                 new TRColour {  Red = 0x25, Green = 0x24, Blue = 0x20},
                 new TRColour {  Red = 0x22, Green = 0x23, Blue = 0x1E},
                 new TRColour {  Red = 0x10, Green = 0x10, Blue = 0x10},
                 new TRColour {  Red = 0x08, Green = 0x07, Blue = 0x08},
                 new TRColour {  Red = 0x15, Green = 0x17, Blue = 0x0A},
                 new TRColour {  Red = 0x27, Green = 0x2B, Blue = 0x1E},
                 new TRColour {  Red = 0x03, Green = 0x04, Blue = 0x04},
                 new TRColour {  Red = 0x0F, Green = 0x0F, Blue = 0x0D},
                 new TRColour {  Red = 0x04, Green = 0x06, Blue = 0x01},
                 new TRColour {  Red = 0x10, Green = 0x1B, Blue = 0x0A},
                 new TRColour {  Red = 0x1C, Green = 0x22, Blue = 0x28},
                 new TRColour {  Red = 0x15, Green = 0x18, Blue = 0x04},
                 new TRColour {  Red = 0x0E, Green = 0x14, Blue = 0x07},
                 new TRColour {  Red = 0x12, Green = 0x12, Blue = 0x10},
                 new TRColour {  Red = 0x06, Green = 0x0A, Blue = 0x03},
                 new TRColour {  Red = 0x0A, Green = 0x0C, Blue = 0x05},
                 new TRColour {  Red = 0x0E, Green = 0x10, Blue = 0x04},
                 new TRColour {  Red = 0x34, Green = 0x31, Blue = 0x2D},
                 new TRColour {  Red = 0x09, Green = 0x08, Blue = 0x05},
                 new TRColour {  Red = 0x06, Green = 0x07, Blue = 0x04},
                 new TRColour {  Red = 0x17, Green = 0x1D, Blue = 0x06},
                 new TRColour {  Red = 0x1B, Green = 0x19, Blue = 0x18},
                 new TRColour {  Red = 0x29, Green = 0x2F, Blue = 0x23},
                 new TRColour {  Red = 0x2E, Green = 0x2E, Blue = 0x28},
                 new TRColour {  Red = 0x08, Green = 0x06, Blue = 0x03},
                 new TRColour {  Red = 0x0D, Green = 0x0A, Blue = 0x06},
                 new TRColour {  Red = 0x10, Green = 0x0D, Blue = 0x06},
                 new TRColour {  Red = 0x16, Green = 0x17, Blue = 0x16},
                 new TRColour {  Red = 0x21, Green = 0x22, Blue = 0x11},
                 new TRColour {  Red = 0x25, Green = 0x28, Blue = 0x18},
                 new TRColour {  Red = 0x22, Green = 0x24, Blue = 0x25},
                 new TRColour {  Red = 0x1E, Green = 0x24, Blue = 0x0B},
                 new TRColour {  Red = 0x14, Green = 0x14, Blue = 0x08},
                 new TRColour {  Red = 0x0F, Green = 0x14, Blue = 0x02},
                 new TRColour {  Red = 0x17, Green = 0x14, Blue = 0x0D},
                 new TRColour {  Red = 0x22, Green = 0x1E, Blue = 0x14},
                 new TRColour {  Red = 0x13, Green = 0x20, Blue = 0x0C},
                 new TRColour {  Red = 0x30, Green = 0x2B, Blue = 0x21},
                 new TRColour {  Red = 0x39, Green = 0x3A, Blue = 0x2B},
                 new TRColour {  Red = 0x07, Green = 0x09, Blue = 0x01},
                 new TRColour {  Red = 0x0B, Green = 0x0E, Blue = 0x01},
                 new TRColour {  Red = 0x15, Green = 0x11, Blue = 0x0B},
                 new TRColour {  Red = 0x33, Green = 0x35, Blue = 0x2E},
                 new TRColour {  Red = 0x2C, Green = 0x32, Blue = 0x1D},
                 new TRColour {  Red = 0x00, Green = 0x09, Blue = 0x04},
                 new TRColour {  Red = 0x0F, Green = 0x0A, Blue = 0x01},
                 new TRColour {  Red = 0x26, Green = 0x2A, Blue = 0x0E},
                 new TRColour {  Red = 0x0A, Green = 0x05, Blue = 0x02},
                 new TRColour {  Red = 0x09, Green = 0x1C, Blue = 0x02},
                 new TRColour {  Red = 0x01, Green = 0x10, Blue = 0x00},
                 new TRColour {  Red = 0x07, Green = 0x10, Blue = 0x07},
                 new TRColour {  Red = 0x1B, Green = 0x1C, Blue = 0x03},
                 new TRColour {  Red = 0x18, Green = 0x34, Blue = 0x11},
                 new TRColour {  Red = 0x19, Green = 0x0B, Blue = 0x0B},
                 new TRColour {  Red = 0x3A, Green = 0x37, Blue = 0x03},
                 new TRColour {  Red = 0x0C, Green = 0x02, Blue = 0x01},
                 new TRColour {  Red = 0x22, Green = 0x1A, Blue = 0x0E},
                 new TRColour {  Red = 0x09, Green = 0x01, Blue = 0x00},
                 new TRColour {  Red = 0x0E, Green = 0x08, Blue = 0x04},
                 new TRColour {  Red = 0x10, Green = 0x02, Blue = 0x01},
                 new TRColour {  Red = 0x16, Green = 0x08, Blue = 0x03},
                 new TRColour {  Red = 0x17, Green = 0x00, Blue = 0x00},
                 new TRColour {  Red = 0x15, Green = 0x06, Blue = 0x07},
                 new TRColour {  Red = 0x13, Green = 0x06, Blue = 0x00},
                 new TRColour {  Red = 0x1D, Green = 0x00, Blue = 0x00},
                 new TRColour {  Red = 0x1A, Green = 0x07, Blue = 0x01},
                 new TRColour {  Red = 0x14, Green = 0x0E, Blue = 0x01},
                 new TRColour {  Red = 0x19, Green = 0x10, Blue = 0x06},
                 new TRColour {  Red = 0x2A, Green = 0x1D, Blue = 0x0E},
                 new TRColour {  Red = 0x1E, Green = 0x17, Blue = 0x0A},
                 new TRColour {  Red = 0x25, Green = 0x1A, Blue = 0x0A},
                 new TRColour {  Red = 0x1E, Green = 0x13, Blue = 0x03},
                 new TRColour {  Red = 0x24, Green = 0x0A, Blue = 0x0A},
                 new TRColour {  Red = 0x1E, Green = 0x05, Blue = 0x07},
                 new TRColour {  Red = 0x30, Green = 0x1F, Blue = 0x03},
                 new TRColour {  Red = 0x34, Green = 0x22, Blue = 0x10},
                 new TRColour {  Red = 0x22, Green = 0x14, Blue = 0x08},
                 new TRColour {  Red = 0x3B, Green = 0x26, Blue = 0x12},
                 new TRColour {  Red = 0x25, Green = 0x05, Blue = 0x04},
                 new TRColour {  Red = 0x05, Green = 0x1B, Blue = 0x09},
                 new TRColour {  Red = 0x0C, Green = 0x2C, Blue = 0x19},
                 new TRColour {  Red = 0x0F, Green = 0x36, Blue = 0x21},
                 new TRColour {  Red = 0x17, Green = 0x3E, Blue = 0x26},
                 new TRColour {  Red = 0x04, Green = 0x24, Blue = 0x12},
                 new TRColour {  Red = 0x04, Green = 0x16, Blue = 0x01},
                 new TRColour {  Red = 0x07, Green = 0x15, Blue = 0x09},
                 new TRColour {  Red = 0x2B, Green = 0x32, Blue = 0x32},
                 new TRColour {  Red = 0x3B, Green = 0x3D, Blue = 0x3D},
                 new TRColour {  Red = 0x20, Green = 0x2F, Blue = 0x16},
                 new TRColour {  Red = 0x1B, Green = 0x29, Blue = 0x12},
                 new TRColour {  Red = 0x02, Green = 0x04, Blue = 0x00},
                 new TRColour {  Red = 0x03, Green = 0x07, Blue = 0x0A},
                 new TRColour {  Red = 0x05, Green = 0x07, Blue = 0x12},
                 new TRColour {  Red = 0x01, Green = 0x02, Blue = 0x07},
                 new TRColour {  Red = 0x3A, Green = 0x1B, Blue = 0x01},
                 new TRColour {  Red = 0x36, Green = 0x26, Blue = 0x02},
                 new TRColour {  Red = 0x2C, Green = 0x30, Blue = 0x11},
                 new TRColour {  Red = 0x3A, Green = 0x3B, Blue = 0x15},
                 new TRColour {  Red = 0x3C, Green = 0x3D, Blue = 0x23},
                 new TRColour {  Red = 0x3A, Green = 0x39, Blue = 0x37},
                 new TRColour {  Red = 0x32, Green = 0x38, Blue = 0x2A},
                 new TRColour {  Red = 0x34, Green = 0x38, Blue = 0x36},
                 new TRColour {  Red = 0x19, Green = 0x1C, Blue = 0x17},
                 new TRColour {  Red = 0x32, Green = 0x36, Blue = 0x14},
                 new TRColour {  Red = 0x3C, Green = 0x3C, Blue = 0x36},
                 new TRColour {  Red = 0x38, Green = 0x36, Blue = 0x31},
                 new TRColour {  Red = 0x15, Green = 0x14, Blue = 0x02},
                 new TRColour {  Red = 0x28, Green = 0x26, Blue = 0x21},
                 new TRColour {  Red = 0x21, Green = 0x23, Blue = 0x07},
                 new TRColour {  Red = 0x22, Green = 0x26, Blue = 0x22},
                 new TRColour {  Red = 0x1F, Green = 0x20, Blue = 0x1E},
                 new TRColour {  Red = 0x33, Green = 0x34, Blue = 0x34},
                 new TRColour {  Red = 0x1D, Green = 0x15, Blue = 0x0F},
                 new TRColour {  Red = 0x34, Green = 0x35, Blue = 0x22},
                 new TRColour {  Red = 0x31, Green = 0x2E, Blue = 0x29},
                 new TRColour {  Red = 0x2C, Green = 0x1F, Blue = 0x12},
                 new TRColour {  Red = 0x2B, Green = 0x2A, Blue = 0x25},
                 new TRColour {  Red = 0x1C, Green = 0x14, Blue = 0x0A},
                 new TRColour {  Red = 0x30, Green = 0x24, Blue = 0x1E},
                 new TRColour {  Red = 0x2C, Green = 0x2B, Blue = 0x17},
                 new TRColour {  Red = 0x38, Green = 0x28, Blue = 0x18},
                 new TRColour {  Red = 0x1D, Green = 0x1F, Blue = 0x1C},
                 new TRColour {  Red = 0x33, Green = 0x3A, Blue = 0x3C},
                 new TRColour {  Red = 0x15, Green = 0x15, Blue = 0x15},
                 new TRColour {  Red = 0x13, Green = 0x13, Blue = 0x12},
                 new TRColour {  Red = 0x13, Green = 0x0C, Blue = 0x07},
                 new TRColour {  Red = 0x3F, Green = 0x3F, Blue = 0x3F},
                 new TRColour {  Red = 0x15, Green = 0x0F, Blue = 0x09},
                 new TRColour {  Red = 0x3B, Green = 0x2C, Blue = 0x1B},
                 new TRColour {  Red = 0x0B, Green = 0x0C, Blue = 0x0B},
                 new TRColour {  Red = 0x35, Green = 0x27, Blue = 0x16},
                 new TRColour {  Red = 0x00, Green = 0x00, Blue = 0x02},
                 new TRColour {  Red = 0x0A, Green = 0x0B, Blue = 0x0F},
                 new TRColour {  Red = 0x08, Green = 0x08, Blue = 0x0B},
                 new TRColour {  Red = 0x04, Green = 0x03, Blue = 0x0C},
                 new TRColour {  Red = 0x00, Green = 0x00, Blue = 0x00},
                 new TRColour {  Red = 0x31, Green = 0x24, Blue = 0x15},
                 new TRColour {  Red = 0x00, Green = 0x02, Blue = 0x03},
                 new TRColour {  Red = 0x02, Green = 0x02, Blue = 0x03},
                 new TRColour {  Red = 0x0C, Green = 0x0E, Blue = 0x0F},
                 new TRColour {  Red = 0x0A, Green = 0x0A, Blue = 0x0A},
                 new TRColour {  Red = 0x07, Green = 0x08, Blue = 0x07},
                 new TRColour {  Red = 0x38, Green = 0x12, Blue = 0x01},
                 new TRColour {  Red = 0x24, Green = 0x0D, Blue = 0x02},
                 new TRColour {  Red = 0x2D, Green = 0x0D, Blue = 0x01},
                 new TRColour {  Red = 0x3C, Green = 0x19, Blue = 0x08},
                 new TRColour {  Red = 0x3D, Green = 0x11, Blue = 0x01},
                 new TRColour {  Red = 0x33, Green = 0x0E, Blue = 0x00},
                 new TRColour {  Red = 0x03, Green = 0x01, Blue = 0x00},
                 new TRColour {  Red = 0x31, Green = 0x16, Blue = 0x04},
                 new TRColour {  Red = 0x2F, Green = 0x34, Blue = 0x33},
                 new TRColour {  Red = 0x2E, Green = 0x13, Blue = 0x0C},
                 new TRColour {  Red = 0x06, Green = 0x01, Blue = 0x01},
                 new TRColour {  Red = 0x37, Green = 0x19, Blue = 0x0E},
                 new TRColour {  Red = 0x0E, Green = 0x0F, Blue = 0x10},
                 new TRColour {  Red = 0x27, Green = 0x2E, Blue = 0x2F},
                 new TRColour {  Red = 0x2D, Green = 0x36, Blue = 0x3A},
                 new TRColour {  Red = 0x30, Green = 0x02, Blue = 0x04},
                 new TRColour {  Red = 0x2C, Green = 0x09, Blue = 0x06},
                 new TRColour {  Red = 0x26, Green = 0x00, Blue = 0x00},
                 new TRColour {  Red = 0x06, Green = 0x2A, Blue = 0x28},
                 new TRColour {  Red = 0x03, Green = 0x03, Blue = 0x02},
                 new TRColour {  Red = 0x0A, Green = 0x1A, Blue = 0x1F},
                 new TRColour {  Red = 0x27, Green = 0x30, Blue = 0x37},
                 new TRColour {  Red = 0x33, Green = 0x0F, Blue = 0x1A},
                 new TRColour {  Red = 0x3B, Green = 0x2B, Blue = 0x03},
                 new TRColour {  Red = 0x08, Green = 0x0A, Blue = 0x17},
                 new TRColour {  Red = 0x01, Green = 0x00, Blue = 0x00},
                 new TRColour {  Red = 0x3D, Green = 0x09, Blue = 0x09},
                 new TRColour {  Red = 0x39, Green = 0x03, Blue = 0x04},
                 new TRColour {  Red = 0x3D, Green = 0x3C, Blue = 0x0C},
                 new TRColour {  Red = 0x2C, Green = 0x36, Blue = 0x0B},
                 new TRColour {  Red = 0x23, Green = 0x28, Blue = 0x2E},
                 new TRColour {  Red = 0x17, Green = 0x00, Blue = 0x17},
                 new TRColour {  Red = 0x3B, Green = 0x03, Blue = 0x2C},
                 new TRColour {  Red = 0x03, Green = 0x3E, Blue = 0x1D},
                 new TRColour {  Red = 0x03, Green = 0x05, Blue = 0x36},
                 new TRColour {  Red = 0x02, Green = 0x3C, Blue = 0x31},
                 new TRColour {  Red = 0x05, Green = 0x05, Blue = 0x2B},
                 new TRColour {  Red = 0x06, Green = 0x3A, Blue = 0x07},
                 new TRColour {  Red = 0x02, Green = 0x30, Blue = 0x03},
                 new TRColour {  Red = 0x0A, Green = 0x00, Blue = 0x0A},
                 new TRColour {  Red = 0x17, Green = 0x03, Blue = 0x25},
                 new TRColour {  Red = 0x04, Green = 0x32, Blue = 0x1C},
                 new TRColour {  Red = 0x0C, Green = 0x29, Blue = 0x01},
                 new TRColour {  Red = 0x30, Green = 0x07, Blue = 0x32},
                 new TRColour {  Red = 0x1E, Green = 0x11, Blue = 0x33},
                 new TRColour {  Red = 0x1B, Green = 0x0A, Blue = 0x2B},
                 new TRColour {  Red = 0x22, Green = 0x00, Blue = 0x22},
                 new TRColour {  Red = 0x3B, Green = 0x03, Blue = 0x17},
                 new TRColour {  Red = 0x0D, Green = 0x08, Blue = 0x1D},
                 new TRColour {  Red = 0x3C, Green = 0x01, Blue = 0x3C},
                 new TRColour {  Red = 0x07, Green = 0x04, Blue = 0x3D},
                 new TRColour {  Red = 0x01, Green = 0x3D, Blue = 0x3C},
                 new TRColour {  Red = 0x02, Green = 0x2F, Blue = 0x1D},
                 new TRColour {  Red = 0x05, Green = 0x39, Blue = 0x23},
                 new TRColour {  Red = 0x18, Green = 0x3A, Blue = 0x2F},
                 new TRColour {  Red = 0x0C, Green = 0x0C, Blue = 0x38},
                 new TRColour {  Red = 0x11, Green = 0x37, Blue = 0x02},
                 new TRColour {  Red = 0x16, Green = 0x13, Blue = 0x28}
            };

            TRColour4[] ExpectedPalette16 = new TRColour4[]
            {
                new TRColour4 {  Red = 0x18, Green = 0x08, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x60, Green = 0x28, Blue = 0x08, Unused = 0x00},
                 new TRColour4 {  Red = 0xC8, Green = 0x88, Blue = 0x50, Unused = 0x00},
                 new TRColour4 {  Red = 0xD0, Green = 0xA0, Blue = 0x60, Unused = 0x00},
                 new TRColour4 {  Red = 0xC0, Green = 0xD8, Blue = 0xE0, Unused = 0x00},
                 new TRColour4 {  Red = 0x80, Green = 0x78, Blue = 0x80, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x48, Green = 0x50, Blue = 0x48, Unused = 0x00},
                 new TRColour4 {  Red = 0x98, Green = 0xB0, Blue = 0xA8, Unused = 0x00},
                 new TRColour4 {  Red = 0xF0, Green = 0x98, Blue = 0x18, Unused = 0x00},
                 new TRColour4 {  Red = 0x88, Green = 0x70, Blue = 0x38, Unused = 0x00},
                 new TRColour4 {  Red = 0xB8, Green = 0xB8, Blue = 0x88, Unused = 0x00},
                 new TRColour4 {  Red = 0xA0, Green = 0x28, Blue = 0x18, Unused = 0x00},
                 new TRColour4 {  Red = 0x68, Green = 0x78, Blue = 0x78, Unused = 0x00},
                 new TRColour4 {  Red = 0x78, Green = 0x60, Blue = 0x28, Unused = 0x00},
                 new TRColour4 {  Red = 0xA0, Green = 0x68, Blue = 0x70, Unused = 0x00},
                 new TRColour4 {  Red = 0xF0, Green = 0xC8, Blue = 0x70, Unused = 0x00},
                 new TRColour4 {  Red = 0x98, Green = 0x68, Blue = 0x60, Unused = 0x00},
                 new TRColour4 {  Red = 0x40, Green = 0x28, Blue = 0x08, Unused = 0x00},
                 new TRColour4 {  Red = 0x50, Green = 0x38, Blue = 0x08, Unused = 0x00},
                 new TRColour4 {  Red = 0xD0, Green = 0xB0, Blue = 0x60, Unused = 0x00},
                 new TRColour4 {  Red = 0x58, Green = 0x68, Blue = 0x58, Unused = 0x00},
                 new TRColour4 {  Red = 0x60, Green = 0x70, Blue = 0x60, Unused = 0x00},
                 new TRColour4 {  Red = 0x30, Green = 0x30, Blue = 0x30, Unused = 0x00},
                 new TRColour4 {  Red = 0x40, Green = 0x40, Blue = 0x40, Unused = 0x00},
                 new TRColour4 {  Red = 0x70, Green = 0x80, Blue = 0x70, Unused = 0x00},
                 new TRColour4 {  Red = 0xE0, Green = 0xE0, Blue = 0xE0, Unused = 0x00},
                 new TRColour4 {  Red = 0x58, Green = 0x60, Blue = 0x58, Unused = 0x00},
                 new TRColour4 {  Red = 0xC0, Green = 0xE0, Blue = 0xF8, Unused = 0x00},
                 new TRColour4 {  Red = 0x08, Green = 0x08, Blue = 0x08, Unused = 0x00},
                 new TRColour4 {  Red = 0xC8, Green = 0xC8, Blue = 0xB0, Unused = 0x00},
                 new TRColour4 {  Red = 0xE0, Green = 0xD8, Blue = 0xC0, Unused = 0x00},
                 new TRColour4 {  Red = 0x98, Green = 0x90, Blue = 0xA0, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
                 new TRColour4 {  Red = 0x00, Green = 0x00, Blue = 0x00, Unused = 0x00},
            };
            #endregion

            //Version
            Assert.AreEqual(TR2VersionHeader, lvl.Version);

            //Palettes
            for (int i = 0; i < 256; i++)
            {
                Assert.AreEqual(ExpectedPalette8[i].Red, lvl.Palette[i].Red);
                Assert.AreEqual(ExpectedPalette8[i].Green, lvl.Palette[i].Green);
                Assert.AreEqual(ExpectedPalette8[i].Blue, lvl.Palette[i].Blue);

                Assert.AreEqual(ExpectedPalette16[i].Red, lvl.Palette16[i].Red);
                Assert.AreEqual(ExpectedPalette16[i].Green, lvl.Palette16[i].Green);
                Assert.AreEqual(ExpectedPalette16[i].Blue, lvl.Palette16[i].Blue);
            }

            //Images/Textures - ToDo actual content of them against expected.
            Assert.AreEqual((uint)11, lvl.NumImages);

            //Rooms
            Assert.AreEqual((ushort)84, lvl.NumRooms);
        }

        [TestMethod]
        public void Venice_ReadTest()
        {
            TR2LevelReader reader = new TR2LevelReader();

            TR2Level lvl = reader.ReadLevel("boat.tr2");

            Assert.AreEqual((uint)133, lvl.NumEntities);
        }

        [TestMethod]
        public void Bartoli_ReadTest()
        {
            TR2LevelReader reader = new TR2LevelReader();

            TR2Level lvl = reader.ReadLevel("venice.tr2");

            Assert.AreEqual((uint)134, lvl.NumEntities);
        }

        [TestMethod]
        public void Opera_ReadTest()
        {
            TR2LevelReader reader = new TR2LevelReader();

            TR2Level lvl = reader.ReadLevel("opera.tr2");

            Assert.AreEqual((uint)216, lvl.NumEntities);
        }

        [TestMethod]
        public void Rig_ReadTest()
        {
            TR2LevelReader reader = new TR2LevelReader();

            TR2Level lvl = reader.ReadLevel("rig.tr2");

            Assert.AreEqual((uint)112, lvl.NumEntities);
        }

        [TestMethod]
        public void DA_ReadTest()
        {
            TR2LevelReader reader = new TR2LevelReader();

            TR2Level lvl = reader.ReadLevel("platform.tr2");

            Assert.AreEqual((uint)131, lvl.NumEntities);
        }

        [TestMethod]
        public void Fathoms_ReadTest()
        {
            TR2LevelReader reader = new TR2LevelReader();

            TR2Level lvl = reader.ReadLevel("unwater.tr2");

            Assert.AreEqual((uint)69, lvl.NumEntities);
        }

        [TestMethod]
        public void Doria_ReadTest()
        {
            TR2LevelReader reader = new TR2LevelReader();

            TR2Level lvl = reader.ReadLevel("keel.tr2");

            Assert.AreEqual((uint)199, lvl.NumEntities);
        }

        [TestMethod]
        public void LQ_ReadTest()
        {
            TR2LevelReader reader = new TR2LevelReader();

            TR2Level lvl = reader.ReadLevel("living.tr2");

            Assert.AreEqual((uint)92, lvl.NumEntities);
        }

        [TestMethod]
        public void Deck_ReadTest()
        {
            TR2LevelReader reader = new TR2LevelReader();

            TR2Level lvl = reader.ReadLevel("deck.tr2");

            Assert.AreEqual((uint)105, lvl.NumEntities);
        }

        [TestMethod]
        public void Tibet_ReadTest()
        {
            TR2LevelReader reader = new TR2LevelReader();

            TR2Level lvl = reader.ReadLevel("skidoo.tr2");

            Assert.AreEqual((uint)108, lvl.NumEntities);
        }

        [TestMethod]
        public void BKang_ReadTest()
        {
            TR2LevelReader reader = new TR2LevelReader();

            TR2Level lvl = reader.ReadLevel("monastry.tr2");

            Assert.AreEqual((uint)217, lvl.NumEntities);
        }

        [TestMethod]
        public void Talion_ReadTest()
        {
            TR2LevelReader reader = new TR2LevelReader();

            TR2Level lvl = reader.ReadLevel("catacomb.tr2");

            Assert.AreEqual((uint)170, lvl.NumEntities);
        }

        [TestMethod]
        public void IcePalace_ReadTest()
        {
            TR2LevelReader reader = new TR2LevelReader();

            TR2Level lvl = reader.ReadLevel("icecave.tr2");

            Assert.AreEqual((uint)158, lvl.NumEntities);
        }

        [TestMethod]
        public void Xian_ReadTest()
        {
            TR2LevelReader reader = new TR2LevelReader();

            TR2Level lvl = reader.ReadLevel("emprtomb.tr2");

            Assert.AreEqual((uint)240, lvl.NumEntities);
        }

        [TestMethod]
        public void Floating_ReadTest()
        {
            TR2LevelReader reader = new TR2LevelReader();

            TR2Level lvl = reader.ReadLevel("floating.tr2");

            Assert.AreEqual((uint)141, lvl.NumEntities);
        }

        [TestMethod]
        public void Lair_ReadTest()
        {
            TR2LevelReader reader = new TR2LevelReader();

            TR2Level lvl = reader.ReadLevel("xian.tr2");

            Assert.AreEqual((uint)66, lvl.NumEntities);
        }

        [TestMethod]
        public void HSH_ReadTest()
        {
            TR2LevelReader reader = new TR2LevelReader();

            TR2Level lvl = reader.ReadLevel("house.tr2");

            Assert.AreEqual((uint)108, lvl.NumEntities);
        }

        [TestMethod]
        public void TR3_ReadTest()
        {
            TR2LevelReader reader = new TR2LevelReader();
            Assert.ThrowsException<NotImplementedException>(() => reader.ReadLevel("jungle.tr2"));
        }

        [TestMethod]
        public void Other_ReadTest()
        {
            TR2LevelReader reader = new TR2LevelReader();
            Assert.ThrowsException<NotImplementedException>(() => reader.ReadLevel("joby5.trc"));
        }
    }
}
