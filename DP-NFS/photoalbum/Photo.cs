using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.photoalbum {
    internal class Photo : AlbumElement {
        public string FileName { get; set; }

        public string Description { get; set; }

        public Photo(string fileName, string description) {
            FileName = fileName;
            Description = description;
        }

        public string GetText() {
            return this.FileName + " (" + this.Description + ")";
        }
    }
}
