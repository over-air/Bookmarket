using System.Collections.Generic;

namespace Models.Model
{
    public class Institute
    {
        public int Id { get; set; }

        /// <summary>
        /// 学院名称
        /// </summary>
        public string Name { get; set; }

        public virtual ICollection<Major> Majors { get; set; } 

    }
}
