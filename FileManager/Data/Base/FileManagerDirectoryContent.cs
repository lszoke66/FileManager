using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;

namespace SfFileService.FileManager.Base
{
    public class FileManagerDirectoryContent
    {
        public string Path { get; set; } = string.Empty;

        public string Action { get; set; } = string.Empty;

        public string NewName { get; set; } = string.Empty;
         
		 public string[] Names { get; set; }

        public string Name { get; set; } = string.Empty;

        public long Size { get; set; }

        public string PreviousName { get; set; } = string.Empty;

        public DateTime DateModified { get; set; }

        public DateTime DateCreated { get; set; }

        public bool HasChild { get; set; }

        public bool IsFile { get; set; }

        public string Type { get; set; } = string.Empty;

        public string Id { get; set; } = string.Empty;

        public string FilterPath { get; set; } = string.Empty;

        public string FilterId { get; set; } = string.Empty;
		
		public string ParentId { get; set; } = string.Empty;

        public string TargetPath { get; set; } = string.Empty;

        public string[] RenameFiles { get; set; }

#if EJ2_DNX
             public IList<System.Web.HttpPostedFileBase> UploadFiles { get; set; }
#else

        public IList<IFormFile> UploadFiles { get; set; }
#endif

        public bool CaseSensitive { get; set; }


        public string SearchString { get; set; } = string.Empty;

        public bool ShowHiddenItems { get; set; }

        public FileManagerDirectoryContent[] Data { get; set; }

        public FileManagerDirectoryContent TargetData { get; set; }

        public AccessPermission Permission { get; set; }
    }
}