using System;

namespace Memento {
	public class Code {
        public String Text { get; set; }

        public Code(ref String text) {
			throw new System.NotImplementedException("Not implemented");
		}
		public void AddFirst(ref String text) {
			throw new System.NotImplementedException("Not implemented");
		}
		public void AddLast(ref String text) {
			throw new System.NotImplementedException("Not implemented");
		}
		public void Erase() {
			throw new System.NotImplementedException("Not implemented");
		}
		public void CropLeft(ref int length) {
			throw new System.NotImplementedException("Not implemented");
		}
		public void CropRight(ref int length) {
			throw new System.NotImplementedException("Not implemented");
		}
		public CodeMemento Save() {
			throw new System.NotImplementedException("Not implemented");
		}
		public void Restore(ref CodeMemento memento) {
			throw new System.NotImplementedException("Not implemented");
		}

	}

}
