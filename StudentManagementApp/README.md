# ระบบจัดการนักเรียน (Student Management System)

โปรเจ็คตัวอย่างสำหรับเรียนรู้ ASP.NET Core 8 MVC สำหรับผู้เริ่มต้น

## คุณสมบัติของระบบ

- ✨ **เพิ่มนักเรียน** - เพิ่มข้อมูลนักเรียนใหม่เข้าสู่ระบบ
- 📝 **แก้ไขข้อมูล** - อัปเดตข้อมูลนักเรียนที่มีอยู่
- 👁️ **ดูรายละเอียด** - ดูข้อมูลนักเรียนแบบละเอียด
- 🗑️ **ลบข้อมูล** - ลบข้อมูลนักเรียนออกจากระบบ
- 📱 **Responsive Design** - รองรับการใช้งานบนอุปกรณ์ทุกขนาด

## เทคโนโลยีที่ใช้

- **Framework**: ASP.NET Core 8 MVC
- **UI Framework**: Bootstrap 5
- **Icons**: Font Awesome 6
- **Language**: C#
- **Storage**: In-Memory (สำหรับการเรียนรู้)

## โครงสร้างโปรเจ็ค

```
StudentManagementApp/
├── Controllers/
│   ├── HomeController.cs        # Controller หลัก
│   └── StudentsController.cs    # Controller สำหรับจัดการนักเรียน
├── Models/
│   └── Student.cs              # Model ข้อมูลนักเรียน
├── Services/
│   └── StudentService.cs       # Service สำหรับจัดการข้อมูล
├── Views/
│   ├── Home/
│   │   └── Index.cshtml        # หน้าแรก
│   ├── Students/
│   │   ├── Index.cshtml        # รายการนักเรียน
│   │   ├── Create.cshtml       # เพิ่มนักเรียน
│   │   ├── Edit.cshtml         # แก้ไขนักเรียน
│   │   ├── Details.cshtml      # รายละเอียดนักเรียน
│   │   └── Delete.cshtml       # ลบนักเรียน
│   └── Shared/
│       └── _Layout.cshtml      # Layout หลัก
└── wwwroot/
    └── css/
        └── site.css           # CSS เพิ่มเติม
```

## วิธีการรันโปรเจ็ค

### ข้อกำหนดเบื้องต้น
- .NET 8 SDK หรือใหม่กว่า

### คำสั่งสำหรับรันโปรเจ็ค

1. **คลิก Ctrl+Shift+P** แล้วพิมพ์ "Tasks: Run Task"
2. เลือก "Run Student Management App"

หรือใช้คำสั่งใน Terminal:

```bash
cd StudentManagementApp
dotnet run
```

3. เปิดเบราว์เซอร์ไปที่ `https://localhost:5001` หรือ `http://localhost:5000`

## การใช้งาน

### หน้าหลัก
- แสดงข้อมูลเบื้องต้นเกี่ยวกับระบบ
- มีปุ่มลัดสำหรับเข้าสู่ระบบจัดการนักเรียน

### จัดการนักเรียน
1. **ดูรายการ**: ไปที่เมนู "จัดการนักเรียน"
2. **เพิ่มใหม่**: คลิกปุ่ม "เพิ่มนักเรียนใหม่"
3. **แก้ไข**: คลิกไอคอนแก้ไขในรายการ
4. **ดูรายละเอียด**: คลิกไอคอนดูในรายการ
5. **ลบ**: คลิกไอคอนลบในรายการ

## คุณสมบัติสำหรับการเรียนรู้

### 1. MVC Pattern
- **Model**: `Student.cs` - โครงสร้างข้อมูล
- **View**: ไฟล์ `.cshtml` - ส่วนแสดงผล
- **Controller**: `StudentsController.cs` - ตัวควบคุม

### 2. Dependency Injection
- ใช้ `IStudentService` และ `StudentService`
- ลงทะเบียนใน `Program.cs`

### 3. Data Validation
- ใช้ Data Annotations
- Client-side และ Server-side validation

### 4. Routing
- Conventional routing
- ASP.NET Core MVC routing

### 5. Razor Views
- Layout และ Partial Views
- Razor syntax
- Tag Helpers

## สำหรับผู้สอน

โปรเจ็คนี้เหมาะสำหรับสอนหัวข้อ:

1. **พื้นฐาน MVC**
   - การทำงานของ Model-View-Controller
   - Routing และ Action Methods

2. **การจัดการข้อมูล**
   - CRUD Operations
   - Data Validation
   - Service Pattern

3. **Front-end**
   - Razor Views
   - Bootstrap Framework
   - Responsive Design

4. **Best Practices**
   - Dependency Injection
   - Separation of Concerns
   - Clean Code

## การขยายผลงาน

สำหรับนักเรียนที่ต้องการพัฒนาต่อ:

1. **เพิ่ม Database**
   - เชื่อมต่อกับ SQL Server/SQLite
   - ใช้ Entity Framework Core

2. **เพิ่มความปลอดภัย**
   - Authentication & Authorization
   - Data Protection

3. **API**
   - สร้าง Web API
   - การใช้งาน Ajax

4. **Advanced Features**
   - Search และ Pagination
   - File Upload
   - Reporting

## License

โปรเจ็คนี้ใช้สำหรับการศึกษาเท่านั้น
