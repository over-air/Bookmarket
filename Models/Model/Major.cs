namespace Models.Model
{
    /// <summary>
    /// 专业
    /// </summary>
    public class Major
    {
        public int ID { get; set; }

        /// <summary>
        /// 专业名称
        /// </summary>
        public string Name { get; set; }

        public int InstituteId { get; set; }
        public virtual Institute Institute { get; set; }

    }
}
