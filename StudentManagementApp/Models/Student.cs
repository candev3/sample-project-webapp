using System.ComponentModel.DataAnnotations;

namespace StudentManagementApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "กรุณาระบุชื่อ")]
        [Display(Name = "ชื่อ")]
        public string FirstName { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "กรุณาระบุนามสกุล")]
        [Display(Name = "นามสกุล")]
        public string LastName { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "กรุณาระบุอีเมล")]
        [EmailAddress(ErrorMessage = "รูปแบบอีเมลไม่ถูกต้อง")]
        [Display(Name = "อีเมล")]
        public string Email { get; set; } = string.Empty;
        
        [Range(15, 100, ErrorMessage = "อายุต้องอยู่ระหว่าง 15-100 ปี")]
        [Display(Name = "อายุ")]
        public int Age { get; set; }
        
        [Display(Name = "สาขาวิชา")]
        public string Major { get; set; } = string.Empty;
        
        [Display(Name = "วันที่ลงทะเบียน")]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; } = DateTime.Now;
        
        // Property สำหรับแสดงชื่อเต็ม
        [Display(Name = "ชื่อเต็ม")]
        public string FullName => $"{FirstName} {LastName}";
    }
}
