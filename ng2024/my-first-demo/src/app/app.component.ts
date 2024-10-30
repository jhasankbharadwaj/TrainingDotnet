import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { AddEmployeeComponent } from './conmponents/add-employee/add-employee.component';
import { ModebuindingComponent } from './conmponents/modebuinding/modebuinding.component';
import { DataBindingComponent } from './conmponents/data-binding/data-binding.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,AddEmployeeComponent,ModebuindingComponent,DataBindingComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'my-first-demo';
}
