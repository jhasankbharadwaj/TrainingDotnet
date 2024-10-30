import { Component } from '@angular/core';
import { Product } from '../../models/product';
import { CommonModule } from '@angular/common';
import { CustomerinfoComponent } from "./waitingperiod/customerinfo.component";
interface Section {
  name: string;
  products: Product[];
}

@Component({
  selector: 'app-menu',
  standalone: true,
  imports: [CommonModule, CustomerinfoComponent],
  templateUrl: './menu.component.html',
  styleUrl: './menu.component.css'
})


export class MenuComponent {
  sections:Section[]=[{
    name :"FastMoving",
  products:[{
  Id:12345,
  Image:"https://imgd.aeplcdn.com/664x374/n/cw/ec/178535/c-class-exterior-right-front-three-quarter.jpeg?isig=0&q=80",
  Name:"benz",
  Model:"benz123",
  Price:1234
},
{
  Id:12346,
  Image:"https://imgd.aeplcdn.com/664x374/n/cw/ec/178535/c-class-exterior-right-front-three-quarter.jpeg?isig=0&q=80",
  Name:"benz",
  Model:"benz1234",
  Price:1234
},

{
  Id:12346,
  Image:"https://imgd.aeplcdn.com/664x374/n/cw/ec/178535/c-class-exterior-right-front-three-quarter.jpeg?isig=0&q=80",
  Name:"benz",
  Model:"benz1234",
  Price:1234
}
]}]
}
