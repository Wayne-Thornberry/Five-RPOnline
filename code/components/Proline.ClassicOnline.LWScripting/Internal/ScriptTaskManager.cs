﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proline.ClassicOnline.CCoreSystem.Internal
{

    internal class ScriptTaskManager
    {
        private static ScriptTaskManager _instance;

        public static ScriptTaskManager GetInstance()
        {
            if (_instance == null)
                _instance = new ScriptTaskManager();
            return _instance;
        }

        internal IEnumerable<Task> GetAllScriptInstanceTasks()
        {
            var sm = ListOfLiveScripts.GetInstance();
            return sm.Select(e => e.ExecutionTask);
        }
    }
}
