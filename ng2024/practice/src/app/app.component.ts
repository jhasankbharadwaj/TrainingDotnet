import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TemplateformComponent } from "../components/templateform/templateform.component";
import { DataBindingComponent } from "../components/data-binding/data-binding.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, TemplateformComponent, DataBindingComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  Data=10;
  title = 'practice';
}
