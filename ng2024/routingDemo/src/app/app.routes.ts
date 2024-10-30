import { Routes } from '@angular/router';
import { FirstComponent } from './first/first.component';
import { SecondComponent } from './second/second.component';
import { ThirdComponent } from './third/third.component';
import { ErrorpageComponent } from './errorpage/errorpage.component';
import { Child1Component } from './first/child1/child1.component';
import { KidComponent } from './first/kid/kid.component';
import { AppComponent } from './app.component';

export const routes: Routes = [
   // {path:''===componet:AppComponent},
   // {path:'',redirectTo:"/first-component",pathMatch:'full'},//default root >> custum default.
    {path:"first-component", component:FirstComponent,
    children:[
       {path:'',redirectTo:"child1",pathMatch: 'full'},
        {path:"child1", component:Child1Component,},
        {path:"kid",component:KidComponent}

    ]},
    {path:"second-component",component:SecondComponent},
    //{path:'**',component:ErrorpageComponent}//redirectionto
    
];
