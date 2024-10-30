import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { User } from '../../models/user';

@Component({
  selector: 'app-templateform',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './templateform.component.html',
  styleUrl: './templateform.component.css'
  
})
export class TemplateformComponent {
  user: User = new User('','','','',false);
  hello="meee";

onSubmit(form: any) {
  if(form.valid){
    this.user.email=form.value.email;
    this.user.password=form.value.password;
    this.user.username=form.value.username;
    this.user.role=form.value.role;
  }
  console.log(this.hello);

console.log(this.user);

}


}
