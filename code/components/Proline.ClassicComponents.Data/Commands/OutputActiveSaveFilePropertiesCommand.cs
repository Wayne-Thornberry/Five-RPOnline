﻿using Newtonsoft.Json;
using Proline.ClassicOnline.CDataStream.Internal;

using Proline.Resource.Framework;
using Console = Proline.Resource.Console;

namespace Proline.ClassicOnline.CDataStream.Commands
{
    public class OutputActiveSaveFilePropertiesCommand : ResourceCommand
    {
        public OutputActiveSaveFilePropertiesCommand() : base("OutputActiveSaveFileProperties")
        {
        }

        protected override void OnCommandExecute(params object[] args)
        {
            var sm = DataFileManager.GetInstance();
            var saveFile = sm.ActiveFile;
            foreach (var item in saveFile.Properties.Keys)
            {
                Console.WriteLine(JsonConvert.SerializeObject(saveFile.Properties));
            }
        }
    }
}