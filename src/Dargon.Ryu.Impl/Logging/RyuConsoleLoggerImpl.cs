﻿using System;

namespace Dargon.Ryu.Logging {
   public class RyuConsoleLoggerImpl : IRyuLogger {
      public void LoadedAssemblyFromPath(string path) {
         Console.WriteLine("Loaded Assembly from path: " + path);
      }
   }
}
