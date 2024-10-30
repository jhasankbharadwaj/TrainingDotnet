import { HttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { Component, inject } from '@angular/core';
import { StudentService } from '../../service/student.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-add-student',
  standalone: true,
  imports: [ CommonModule, FormsModule],
  templateUrl: './add-student.component.html',
  styleUrls: ['./add-student.component.css']
})
export class AddStudentComponent {

  student: any = { 
    "studentId": 0, 
    "studentName": "", 
    "studentGrade": "", 
    "studentRollNo": "", 
    "isActive": true, 
    "createdDate": "", 
    "modifiedDate": ""
  };
  
  studentService = inject(StudentService);
  http = inject(HttpClient);

  onSubmit() {
    this.http.post("https://localhost:7088/api/TblStudents", this.student).subscribe((res: any) => {
      debugger;
      if (res.studentId >= 0) {
        alert("Student Record Created!");
      } else {
        alert("Some Problem in Student Creation");
      }
    });
  }
}
