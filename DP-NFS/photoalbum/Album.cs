using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.photoalbum {
    internal class Album : AlbumElement {
        private List<AlbumElement> albumElements;

        public Album() {
            albumElements = new List<AlbumElement>(); 
        }

        public void Add(AlbumElement albumElement) {
            albumElements.Add(albumElement);
        }

        public string GetText() {
            throw new NotImplementedException();
        }

        // Peut contenir des photos, des commentaires et d'autres albums
    }
}
