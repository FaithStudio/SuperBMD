﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperBMD.Materials;
using GameFormatReader.Common;

namespace SuperBMD.Materials.IO
{
    public static class ColorChannelIO
    {
        public static List<ChannelControl> Load(EndianBinaryReader reader, int offset, int size)
        {
            List<ChannelControl> controls = new List<ChannelControl>();
            int count = size / 8;

            for (int i = 0; i < count; i++)
                controls.Add(new ChannelControl(reader));

            return controls;
        }
    }
}
