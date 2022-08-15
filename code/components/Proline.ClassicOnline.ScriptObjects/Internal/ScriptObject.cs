﻿using Proline.ClassicOnline.CScriptObjs.Data;
using System.Collections.Generic;

namespace Proline.ClassicOnline.CScriptObjs.Internal
{
    public class ScriptObject
    {
        public int Handle { get; set; }
        public List<ScriptObjectData> Data { get; set; }
        public int State { get; internal set; }
    }
}
