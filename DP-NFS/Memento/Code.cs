using System;

namespace Memento {
	public class Code {
        public String Text { get; set; }

        public Code(String text) {
			this.Text = text;
		}
		public void AddFirst(String text) {
			this.Text = text + this.Text;
		}
		public void AddLast(String text) {
			this.Text += text;
		}
		public void Erase() {
			this.Text = "";
		}
		public void CropLeft(int length) {
			this.Text = this.Text.Substring(0, length);
		}
		public void CropRight(int length) {
			this.Text = this.Text.Substring(this.Text.Length - length, length);
		}
		public CodeMemento Save() {
			return new CodeMemento(this.Text);
		}
		public void Restore(CodeMemento memento) {
			this.Text = memento.Text;
		}
	}
}
