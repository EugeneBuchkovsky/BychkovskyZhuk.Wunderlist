using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wunderlist.DataAccess.Interfaces.EF;
using Wunderlist.DataAccess.Interfaces.Entities;
using Wunderlist.DataAccess.Interfaces.Interfaces;
using System.Data.Entity;

namespace Wunderlist.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private WunderlistContext db;

        private UserRepository _userRepository;
        private TaskListRepository _taskListRepository;
        private TodoItemRepository _todoItemRepository;
        private SubscriberRepository _subscriberRepository;
        private SubtaskRepository _subtaskRepository;
        private TaskFileRepository _taskFileRepository;
        private CommentRepository _commentRepository;

        public UnitOfWork (WunderlistContext context)
        {
            this.db = context;
        }

        public IRepository<Comment> Comments
        {
            get
            {
                if (_commentRepository == null)
                    _commentRepository = new CommentRepository(db);
                return _commentRepository;
            }
        }

        public IRepository<Subscriber> Subscribers
        {
            get
            {
                if (_subscriberRepository == null)
                    _subscriberRepository = new SubscriberRepository(db);
                return _subscriberRepository;
            }
        }

        public IRepository<Subtask> Subtasks
        {
            get
            {
                if (_subtaskRepository == null)
                    _subtaskRepository = new SubtaskRepository(db);
                return _subtaskRepository;
            }
        }

        public IRepository<TaskFile> TaskFiles
        {
            get
            {
                if (_taskFileRepository == null)
                    _taskFileRepository = new TaskFileRepository(db);
                return _taskFileRepository;
            }
        }

        public IRepository<TaskList> TaskLists
        {
            get
            {
                if (_taskListRepository == null)
                    _taskListRepository = new TaskListRepository(db);
                return _taskListRepository;
            }
        }

        public IRepository<TodoItem> TodoItems
        {
            get
            {
                if (_todoItemRepository == null)
                    _todoItemRepository = new TodoItemRepository(db);
                return _todoItemRepository;
            }
        }

        public IRepository<User> Users
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(db);
                return _userRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
