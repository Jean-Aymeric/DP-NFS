using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.treeNode {
    class TreeNode<E> {
        public List<TreeNode<E>> Children = new();
        public int Count { get => this.Children.Count; }
        public E Element { get; set; }

        public TreeNode(E element) {
            this.Element = element;
        }

        public TreeNode<E> AddChild(E element) {
            TreeNode<E> child = new(element);
            Children.Add(child);
            return child;
        }

        public TreeNode<E> AddChild(TreeNode<E> treeElement) {
            TreeNode<E> child = treeElement;
            Children.Add(child);
            return child;
        }

        public override string ToString() {
            String returnedString = "" + this.Element;
            if (this.Children.Count > 0) {
                returnedString += "(";
                foreach (TreeNode<E> child in this.Children) {
                    returnedString += child + ",";
                }
                returnedString = returnedString[0..(returnedString.Length - 2)] + ")";
            }
            return returnedString;
        }
    }
}
