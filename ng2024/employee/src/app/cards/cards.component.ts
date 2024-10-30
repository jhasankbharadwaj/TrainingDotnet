import { Component } from '@angular/core';
import { Employee } from '../../Model/employee';
import {DatePipe} from '@angular/common'
@Component({
  selector: 'app-cards',
  standalone: true,
  imports: [DatePipe],
  templateUrl: './cards.component.html',
  styleUrl: './cards.component.css',
})
export class CardsComponent {
[x: string]: any;
  
  emplist: Employee[]=[
    {
      id:1234,

  name:"jhasank",
  gender:"male",
  email:"jb@1234.com",
  phoneNumber:123455,
  contactPreference:"hello",
  dateOfBirth: new Date(2/4),
  department:"support",
  isActive:true,
  photoPath:"emp1.jpg"
    },
    {
      id:1234,

  name:"jhasank",
  gender:"male",
  email:"jb@1234.com",
  phoneNumber:123455,
  contactPreference:"hello",
  dateOfBirth: new Date("2/4/2024"),
  department:"support",
  isActive:true,
  photoPath:"emp1.jpg"}
  ,
  {
    id:1234,

name:"jhasank",
gender:"male",
email:"jb@1234.com",
phoneNumber:123455,
contactPreference:"hello",
dateOfBirth: new Date(2/4),
department:"support",
isActive:true,
photoPath:"emp1.jpg"}
  ]
  

}
