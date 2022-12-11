using System;
using System.Collections.Generic;
using System.Linq;

namespace SfFileService.FileManager.Base
{
    public class ErrorDetails
    {
		public string Code { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;

        public IEnumerable<string> FileExists { get; set; }

    }
}