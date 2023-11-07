namespace Project.Model
{
    #region 
    public class CourseDataModel
    {
        /// <summary>
        /// 課程ID
        /// </summary>
        public string CourseID { get; set; }
        /// <summary>
        /// 課程名稱
        /// </summary>
        public string CourseTitle { get; set; }
        /// <summary>
        /// 課程簡介
        /// </summary>
        public string CourseIntroduction { get; set; }
        /// <summary>
        /// 授課講師
        /// </summary>
        public string ProfessorName { get; set; }
        /// <summary>
        /// 星期幾
        /// </summary>
        public string Week { get; set; }
        /// <summary>
        /// HHmm-HHmm
        /// </summary>
        public string Time { get; set; }
        /// <summary>
        /// 必修科系
        /// </summary>
        public string RequiredSubjects { get; set; }
    }
    #endregion
}