using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTodoMVC.Models
{
	public class TodoItem
	{
		public string Text { get; set; } = "";
		public bool Completed { get; set; } = false;
		public bool Editing { get; set; } = false;
	}
}
