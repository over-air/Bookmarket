using System.Collections.Generic;

namespace ViewModels
{
    public class Institute
    {
        public int Id { get; set; }

        /// <summary>
        /// 学院名称
        /// </summary>
        public string Name { get; set; }

        public ICollection<Major> Majors { get; set; } 

    }
}
