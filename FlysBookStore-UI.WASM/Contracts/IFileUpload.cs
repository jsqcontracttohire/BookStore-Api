using BlazorInputFile;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FlysBookStore_UI.WASM.Contracts
{
    public interface IFileUpload
    {
        //public Task UploadFile(Stream msFile, string picName);

        public Task UploadFile(IFileListEntry file, string picName);

        public void UploadFile(IFileListEntry file, MemoryStream msFile, string picName);

        public void RemoveFile(string picName);
    }
}
