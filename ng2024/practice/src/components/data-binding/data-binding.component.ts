import { Component, Input, Output } from '@angular/core';

@Component({
  selector: 'app-data-binding',
  standalone: true,
  imports: [],
  templateUrl: './data-binding.component.html',
  styleUrl: './data-binding.component.css'
})
export class DataBindingComponent {
  @Input() size=0;//input requre code 
  //@Output() =0;

  Inc(){
     // this.resize(1);
  }
  Dec(){

  }

}
