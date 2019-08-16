using BlazorTodoMVC.Models;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTodoMVC.Services
{
	public class StorageService
	{
		private readonly IJSRuntime jSRuntime;

		public StorageService(IJSRuntime jSRuntime)
		{
			this.jSRuntime = jSRuntime;
		}
		public Task<IEnumerable<TodoItem>> GetTodosFromStorage()
		{
			return jSRuntime.InvokeAsync<IEnumerable<TodoItem>>("getTodos");
		}

		public Task PersistTodos(IEnumerable<TodoItem> todos)
		{
			return jSRuntime.InvokeAsync<object>("persistTodos", todos);
		}

	}
}
