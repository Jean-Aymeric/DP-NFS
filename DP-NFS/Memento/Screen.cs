using System;
using System.Collections.Generic;

namespace Memento {
	enum Command {
		Erase, AddFirst, AddLast, CropLeft, CropRight, Undo, Display, Nop, Exit, History
	}

	public class Screen {
        public Code Code { get; set; }
        public Stack<CodeMemento> History { get; set; }
		private Boolean Running { get; set; }

        public Screen() {
			this.Code = new Code("");
			this.History = new Stack<CodeMemento>();
		}

		public void Display() {
			Console.WriteLine(this.Code.Text);
		}

		public void DisplayHistory() {
			int i = 0;
			Console.WriteLine(i-- + " : " + this.Code.Text);
			foreach (CodeMemento memento in this.History) {
				Console.WriteLine(i-- + " : " + memento.Text);
			}
		}

		public void Go() {
			this.Running = true;
			while(this.Running) {
				this.Prompt();
            }
        }

		private void Save() {
			this.History.Push(this.Code.Save());
		}

		private void Restore() {
			this.Code.Restore(this.History.Pop());
        }

		public void Prompt() {
			Console.Write(">> ");
			String line = Console.ReadLine();
			String[] stringCommands =  line.Split(' ');
			switch (StringToCommand(stringCommands[0])) {
				case Command.Erase:
					this.Save();
					this.Code.Erase();
					break;
				case Command.AddFirst:
					this.Save();
					this.Code.AddFirst(stringCommands[1]);
					break;
				case Command.AddLast:
					this.Save();
					this.Code.AddLast(stringCommands[1]);
					break;
				case Command.CropLeft:
					this.Save();
					this.Code.CropLeft(int.Parse(stringCommands[1]));
					break;
				case Command.CropRight:
					this.Save();
					this.Code.CropRight(int.Parse(stringCommands[1]));
					break;
				case Command.Undo:
					this.Restore();
					break;
				case Command.Exit:
					this.Running = false;
					break;
				case Command.Display:
					this.Display();
					break;
				case Command.History:
					this.DisplayHistory();
					break;
				default:
					break;
			}
		}

		private static Command StringToCommand(String stringCommand) {
			if (stringCommand.Equals("erase")) {
				return Command.Erase;
			}
			if (stringCommand.Equals("addfirst")) {
				return Command.AddFirst;
			}
			if (stringCommand.Equals("addlast")) {
				return Command.AddLast;
			}
			if (stringCommand.Equals("cropleft")) {
				return Command.CropLeft;
			}
			if (stringCommand.Equals("cropright")) {
				return Command.CropRight;
			}
			if (stringCommand.Equals("undo")) {
				return Command.Undo;
			}
			if (stringCommand.Equals("display")) {
				return Command.Display;
			}
			if (stringCommand.Equals("history")) {
				return Command.History;
			}
			if (stringCommand.Equals("exit")) {
				return Command.Exit;
			}

			return Command.Nop;
        }
	}
}
