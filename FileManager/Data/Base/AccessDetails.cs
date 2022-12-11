﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SfFileService.FileManager.Base
{
    public class AccessDetails
    {

		public string Role { get; set; }
        public IEnumerable<AccessRule> AccessRules { get; set; }
    }

    public class AccessRule
    {
       public Permission Copy { get; set; }
        public Permission Download { get; set; }
        public Permission Write { get; set; }
        public string Path { get; set; } = string.Empty;
        public Permission Read { get; set; }
        public string Role { get; set; } = string.Empty;
        public Permission WriteContents { get; set; }
        public Permission Upload { get; set; }
        public bool IsFile { get; set; }
        public string Message { get; set; } = string.Empty;
    }
    public enum Permission
    {
        Allow,
        Deny
    }
}