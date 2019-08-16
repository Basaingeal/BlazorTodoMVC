(function (window) {
  'use strict';

  window.persistTodos = (todos) => {
    window.localStorage.setItem('todos', JSON.stringify(todos));
  }

  window.getTodos = () => {
    const todosString = window.localStorage.getItem('todos') || '[]'
    return JSON.parse(todosString)
  }

})(window);
