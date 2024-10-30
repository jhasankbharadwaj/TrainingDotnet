import { Component } from '@angular/core';
import { Waitinglist } from '../../../models/waitinglist';

@Component({
  selector: 'app-customerinfo',
  standalone: true,
  imports: [],
  templateUrl: './customerinfo.component.html',
  styleUrl: './customerinfo.component.css'
})

export class CustomerinfoComponent {
[x: string]: any;
wlist:Waitinglist[]=[
  {
     Name:"MARK2",
      Price:4,
      WP:6,
  },
  {
    Name:"MARK4",
     Price:5,
     WP:8,
 },
 {
  Name:"MARK1",
   Price:1,
   WP:26,
}
]

}
