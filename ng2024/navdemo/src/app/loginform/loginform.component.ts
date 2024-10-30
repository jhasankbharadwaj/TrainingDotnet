import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule, NgModel } from '@angular/forms';
import { Login } from '../../models/login';


@Component({
  selector: 'app-loginform',
  standalone: true,
  imports: [CommonModule,FormsModule],
  templateUrl: './loginform.component.html',
  styleUrl: './loginform.component.css'
})
export class LoginformComponent {

model=new Login("","","","",false);
  onSubmit(data:any){
    console.log(data.value);
  }


}
