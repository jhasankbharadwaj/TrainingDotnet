import { Routes } from '@angular/router';
import { MenuComponent } from './menu/menu.component';
import { OrderComponent } from './order/order.component';
import { RefundsComponent } from './refunds/refunds.component';
import { ContactComponent } from './contact/contact.component';
import { LoginformComponent } from './loginform/loginform.component';

export const routes: Routes = [
    {path:'',redirectTo:'/loginform',pathMatch:'full'},
    {path:"menu",component:MenuComponent},
    {path:"loginform",component:LoginformComponent},
    {path:"order",component:OrderComponent},
    {path:"refunds",component:RefundsComponent},
    {path:"contact",component:ContactComponent},

];
