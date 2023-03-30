using System;

namespace Memento {
	public class CodeMemento {
        public String Text { get; }

        public CodeMemento(String text) {
			this.Text = text;
		}
	}
}
