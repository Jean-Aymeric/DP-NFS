﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.photoalbum {
    internal class Comment : AlbumElement {
        public string Text { get; set; }

        public Comment(string text) { 
            this.Text = text; 
        }
    }
}
