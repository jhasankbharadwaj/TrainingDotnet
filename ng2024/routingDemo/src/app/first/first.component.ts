import { Component } from '@angular/core';
import { Child1Component } from './child1/child1.component';
import { KidComponent } from './kid/kid.component';
import { RouterOutlet,RouterLink, RouterLinkActive } from '@angular/router';

@Component({
  selector: 'app-first',
  standalone: true,
  imports: [RouterOutlet,RouterLink,RouterLinkActive,Child1Component,KidComponent],
  templateUrl: './first.component.html',
  styleUrl: './first.component.css'
})
export class FirstComponent {

}
