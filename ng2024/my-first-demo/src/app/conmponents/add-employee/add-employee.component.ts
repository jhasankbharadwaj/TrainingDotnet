import { Component } from '@angular/core';

@Component({
  selector: 'app-add-employee',
  standalone: true,
  imports: [],
  templateUrl: './add-employee.component.html',
  styleUrl: './add-employee.component.css'
})
export class AddEmployeeComponent {
  fullname:string="jhasank bharadwaj";
  id:number=238393;
 // marks:array={1,2,3,5};
 date:Date=new Date();
 

}
