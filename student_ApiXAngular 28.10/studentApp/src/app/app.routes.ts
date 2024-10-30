import { Routes } from '@angular/router';
import { StudentListComponent } from './pages/student-list/student-list.component';
import { AddStudentComponent } from './pages/add-student/add-student.component';

export const routes: Routes = [
    {path:"student-list",component:StudentListComponent},
    {path:"add-student",component:AddStudentComponent}

];
