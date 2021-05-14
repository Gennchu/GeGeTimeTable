using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeGeTimeTable
{
    class Task
    {
      // Fields
        int priority = 0;
        string name = "Task";
        string description = "This task has no description.";
        DateTime startTime = new DateTime(1970, 1, 1, 0, 0, 0);
        DateTime endTime = new DateTime(1970, 1, 1, 0, 0, 0);
        Color taskColor = Color.Black;

        //  Constructors

        public Task(string description, DateTime startTime, DateTime endTime)
        {
            this.description = description;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public Task(int priority, string description, DateTime startTime, DateTime endTime) : this (description, startTime, endTime)
        {
            this.priority = priority;
        }

        public Task(int priority, string name, string description, DateTime startTime, DateTime endTime) : this (priority, description, startTime, endTime) 
        {
            this.name = name;
        }

        public Task(int priority, string name, string description, DateTime startTime, DateTime endTime, Color color) : this (priority, name, description, startTime, endTime)
        {
            this.taskColor = color;
        }


        // Properties
        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }
        public DateTime EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
        public Color TaskColor
        {
            get { return taskColor; }
            set { taskColor = value; }
        }




    }
}
